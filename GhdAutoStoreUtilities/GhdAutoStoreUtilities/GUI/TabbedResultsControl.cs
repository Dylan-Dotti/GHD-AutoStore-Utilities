using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GhdAutoStoreUtilities.GUI
{
    public partial class TabbedResultsControl : UserControl
    {
        private BinDataAnalysisResults results;

        public BinDataAnalysisResults Results
        {
            get => results;
            set => UpdateResults(value);
        }

        public TabbedResultsControl()
        {
            InitializeComponent();
        }

        private void UpdateResults(BinDataAnalysisResults newResults)
        {
            bool haveSearched = results != null;
            results = newResults;
            // update missing bins
            if (results.MissingBins != null)
            {
                string[] missingBinResults = results.MissingBins
                .Where(s => s.Length <= decimal.ToInt32(maxLenInput.Value))
                .ToArray();
                missingBinsTextBox.Text = missingBinResults.Length == 0 ?
                (haveSearched ? "No missing bins found" : "") :
                string.Join(Environment.NewLine, missingBinResults);
            }
            // update mismatched bins
            if (results.MismatchedBins != null)
            {
                // TODO
            }
        }
    }
}
