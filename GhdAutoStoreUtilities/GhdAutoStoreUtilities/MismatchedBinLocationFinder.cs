using System;
using System.Collections.Generic;
using System.Linq;

namespace GhdAutoStoreUtilities
{
    public static class MismatchedBinLocationFinder
    {
        public static MismatchedBinLocation[] GetMismatchedBins(
            SynqDataReader synqReader, AutoStoreDataReader asReader,
            bool sorted = false)
        {
            var tus = synqReader.GetTUs();
            var bins = asReader.GetBins();
            var matchingIDs = tus
                .Where(tu => bins.Any(bin => bin.ID == tu.ID))
                .Select(tu => tu.ID);
            var mismatchedBinLocations = new List<MismatchedBinLocation>();
            foreach (string id in matchingIDs)
            {
                var synqLocation = tus.First(tu => tu.ID == id).Location;
                var asLocation = bins.First(bin => bin.ID == id).Mode;
                if (GetSynqLocationCategory(synqLocation) != GetASLocationCategory(asLocation))
                {
                    mismatchedBinLocations.Add(
                        new MismatchedBinLocation(id, synqLocation, asLocation));
                }
            }
            return mismatchedBinLocations.ToArray();
        }

        private static BinLocationCategory GetSynqLocationCategory(string location)
        {
            location = location.ToUpper();
            // can't use switch here due to needing to match generalized patterns
            if (location.Contains("GRID") || location.Contains("TRANSIT"))
            {
                return BinLocationCategory.Grid;
            }
            if (location.Contains("PORT"))
            {
                return BinLocationCategory.Port;
            }
            throw new ArgumentException("Unsupported Synq location: " + location);
        }

        private static BinLocationCategory GetASLocationCategory(string location)
        {
            location = location.ToUpper();
            switch (location)
            {
                case "GRID":
                case "PREPARED":
                case "FORECAST":
                case "BLOCKED":
                    return BinLocationCategory.Grid;
                case "TO GRID":
                case "TOGRID":
                case "TO_GRID":
                case "CLOSED":
                case "PORT":
                case "OPEN":
                    return BinLocationCategory.Port;
                case "TRANSIT":
                    return BinLocationCategory.Grid;
                case "OUTSIDE":
                    return BinLocationCategory.Outside;
                default:
                    throw new ArgumentException("Unsupported AS location: " + location);
            }
        }
    }
}
