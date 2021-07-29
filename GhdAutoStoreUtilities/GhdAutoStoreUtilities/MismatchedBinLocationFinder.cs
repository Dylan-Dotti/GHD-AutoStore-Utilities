using System;

namespace GhdAutoStoreUtilities
{
    public static class MismatchedBinLocationFinder
    {
        public static MismatchedBinLocation[] GetMismatchedBins(
            SynqDataReader synqReader, AutoStoreDataReader asReader,
            bool sorted = false)
        {
            var bins = asReader.GetBins();
            foreach (AutoStoreBin bin in bins)
            {
                Console.WriteLine($"({bin.ID}, {bin.Mode})");
            }
            return null;
        }
    }
}
