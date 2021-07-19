using GhdAutoStoreUtilities.Exceptions;
using System;
using System.Linq;

namespace GhdAutoStoreUtilities
{
    public class SynqDataReader
    {
        private readonly IGridFileReader reader;

        public SynqDataReader(IGridFileReader reader)
        {
            this.reader = reader;
        }

        public SynqTU[] GetTUs()
        {
            string[] headers = GetHeaders();
            int tuHeaderIndex = GetHeaderIndex(headers, "TU");
            int locationHeaderIndex;
            try
            {
                locationHeaderIndex = GetHeaderIndex(headers, "CURRENT_LOCATION");
            }
            catch (SynqHeaderNotFoundException)
            {
                try
                {
                    locationHeaderIndex = GetHeaderIndex(headers, "LOCATION");
                }
                catch (SynqHeaderNotFoundException)
                {
                    throw new SynqHeaderNotFoundException("CURRENT_LOCATION or LOCATION");
                }
            }
            var tuIDs = reader.GetColumnData(
                tuHeaderIndex, skipFirstRow: true, includeEmpty: true);
            var tuLocations = reader.GetColumnData(
                locationHeaderIndex, skipFirstRow: true, includeEmpty: true);
            SynqTU[] tus = Enumerable.Range(0, tuIDs.Length)
                .Select(i => new SynqTU(tuIDs[i], tuLocations[i]))
                .Where(bin => !string.IsNullOrWhiteSpace(bin.ID))
                .ToArray();
            return tus;
        }

        public string[] GetTUIDs(bool sorted = false)
        {
            string[] headers = GetHeaders();
            int tuHeaderIndex = GetHeaderIndex(headers, "TU");
            var tuIDs = reader.GetColumnData(tuHeaderIndex,
                skipFirstRow: true, includeEmpty: false)
                .Distinct();
            return (sorted ? tuIDs.OrderBy(s => s) : tuIDs).ToArray();
        }

        private string[] GetHeaders()
        {
            return reader.GetRowData(0, includeEmpty: true);
        }

        private int GetHeaderIndex(string[] headers, string header)
        {
            int headerIndex = Array.IndexOf(headers, header);
            if (headerIndex == -1) throw new SynqHeaderNotFoundException(header);
            return headerIndex;
        }
    }
}
