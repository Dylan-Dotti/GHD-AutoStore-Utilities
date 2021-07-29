using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhdAutoStoreUtilities
{
    public class BinAnalysisResults
    {
        public IEnumerable<string> MissingBins { get; private set; }
        public IEnumerable<MismatchedBinLocation> MismatchedBins { get; private set; }

        public BinAnalysisResults(
            IEnumerable<string> missingBins,
            IEnumerable<MismatchedBinLocation> mismatchedBinLocations)
        {
            MissingBins = missingBins?.ToList();
            MismatchedBins = mismatchedBinLocations?.ToList();
        }
    }
}
