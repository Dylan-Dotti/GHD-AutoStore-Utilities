using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhdAutoStoreUtilities.GUI
{
    public partial class TabbedMainForm2 : Form
    {
        private bool haveSearched = false;
        private BinAnalysisResults results = null;

        public TabbedMainForm2()
        {
            InitializeComponent();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            synqFileSelector.Enabled = false;
            asFileSelector.Enabled = false;
            analyzeButton.Enabled = false;
            results = null;
            haveSearched = false;
            BinAnalysisOperationForm operationForm = new BinAnalysisOperationForm(
                synqFileSelector.SelectedFileName,
                asFileSelector.SelectedFileName);
            if (operationForm.ShowDialog(this) == DialogResult.OK)
            {
                // update results
                results = operationForm.AnalysisResults;
                haveSearched = true;
                tabbedResultsControl1.Results = results;
            }
            synqFileSelector.Enabled = true;
            asFileSelector.Enabled = true;
            analyzeButton.Enabled = true;
        }

        private void UpdateAnalyzeButton()
        {
            analyzeButton.Enabled = !string.IsNullOrWhiteSpace(synqFileSelector.SelectedFileName) &&
                !string.IsNullOrWhiteSpace(asFileSelector.SelectedFileName);
        }

        private void synqFileSelector_SelectedFile(object sender, EventArgs e)
        {
            UpdateAnalyzeButton();
        }

        private void asFileSelector_SelectedFile(object sender, EventArgs e)
        {
            UpdateAnalyzeButton();
        }
    }
}
