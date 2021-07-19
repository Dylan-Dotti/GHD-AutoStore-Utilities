using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GhdAutoStoreUtilities.GUI
{
    public partial class MissingBinFinderControl : UserControl
    {
        private string[] results = new string[] { };
        private bool haveSearched = false;

        public MissingBinFinderControl()
        {
            InitializeComponent();
            maxLenInput.Value = Properties.Settings.Default.maxBinIDLength;
        }

        private void UpdateCompareButton()
        {
            compareButton.Enabled = !string.IsNullOrWhiteSpace(synqFileSelector.SelectedFileName) &&
                !string.IsNullOrWhiteSpace(asFileSelector.SelectedFileName);
        }

        private void ClearMaxLenInputEmptyValue()
        {
            decimal value = maxLenInput.Value;
            maxLenInput.Value = value == 1 ? 2 : 1;
            maxLenInput.Value = value;
        }

        private void UpdateResults()
        {
            string[] resultsFiltered = results
                .Where(s => s.Length <= decimal.ToInt32(maxLenInput.Value))
                .ToArray();
            missingBinsTextBox.Text = resultsFiltered.Length == 0 ?
                (haveSearched ? "No missing bins found" : "") :
                string.Join(Environment.NewLine, resultsFiltered);
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            synqFileSelector.Enabled = false;
            asFileSelector.Enabled = false;
            compareButton.Enabled = false;
            missingBinsTextBox.Text = "";
            results = new string[] { };
            haveSearched = false;
            MissingBinOperationForm operationForm = new MissingBinOperationForm(
                synqFileSelector.SelectedFileName, 
                asFileSelector.SelectedFileName);
            if (operationForm.ShowDialog(this) == DialogResult.OK)
            {
                Console.WriteLine("ok");
                results = operationForm.MissingBinsResult;
                haveSearched = true;
                UpdateResults();
            }
            synqFileSelector.Enabled = true;
            asFileSelector.Enabled = true;
            compareButton.Enabled = true;
        }

        private void maxLenInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateResults();
            Properties.Settings.Default.maxBinIDLength =
                decimal.ToInt32(maxLenInput.Value);
            Properties.Settings.Default.Save();
        }

        private void maxLenInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void maxLenInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                ClearMaxLenInputEmptyValue();
                maxLenInput.Select(maxLenInput.Value.ToString().Length, 0);
            }
        }

        private void maxLenInput_Leave(object sender, EventArgs e)
        {
            ClearMaxLenInputEmptyValue();
        }

        private void synqFileSelector_SelectedFile(object sender, EventArgs e)
        {
            UpdateCompareButton();
        }

        private void asFileSelector_SelectedFile(object sender, EventArgs e)
        {
            UpdateCompareButton();
        }
    }
}
