using System;
using System.Linq;

namespace GhdAutoStoreUtilities
{
    public static class MissingBinFinder
    {
        public static string[] GetMissingBins(
            SynqDataReader synqReader, AutoStoreDataReader asReader,
            bool sorted = false)
        {
            string[] synqIDs = synqReader.GetTUIDs(sorted);
            string[] asIDs = asReader.GetBinIDs(sorted);
            var missingIDs = synqIDs.Where(id => !asIDs.Contains(id));
            return (sorted ? missingIDs.OrderBy(s => s) : missingIDs).ToArray();
        }
    }
}
