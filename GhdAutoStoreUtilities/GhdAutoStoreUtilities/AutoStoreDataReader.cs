using GhdAutoStoreUtilities.Exceptions;
using System;
using System.Linq;

namespace GhdAutoStoreUtilities
{
    public class AutoStoreDataReader
    {
        private readonly IGridFileReader reader;

        public AutoStoreDataReader(IGridFileReader reader)
        {
            this.reader = reader;
        }

        public AutoStoreBin[] GetBins(bool sortByID = false)
        {
            string[] headers = GetHeaders();
            int binHeaderIndex = GetHeaderIndex(headers, "Bin");
            int modeHeaderIndex = GetHeaderIndex(headers, "Mode");
            var binIDs = ProcessData(reader.GetColumnData(binHeaderIndex,
                skipFirstRow: true, includeEmpty: true));
            var modes = ProcessData(reader.GetColumnData(modeHeaderIndex,
                skipFirstRow: true, includeEmpty: true));
            var bins = Enumerable.Range(0, binIDs.Length)
                .Select(i => new AutoStoreBin(binIDs[i], modes[i]))
                .Where(bin => !string.IsNullOrWhiteSpace(bin.ID));
            return (sortByID ? bins.OrderBy(b => b.ID) : bins).ToArray();
        }

        public string[] GetBinIDs(bool sorted = false)
        {
            var binIDs = GetBins().Select(b => b.ID);
            return (sorted ? binIDs.OrderBy(s => s) : binIDs).ToArray();
        }

        private string[] GetHeaders()
        {
            return reader.GetRowData(0, includeEmpty: true)
                .Select(s => ProcessData(s))
                .ToArray();
        }

        private int GetHeaderIndex(string[] headers, string header)
        {
            int headerIndex = Array.IndexOf(headers, header);
            if (headerIndex == -1) throw new AutoStoreHeaderNotFoundException(header);
            return headerIndex;
        }

        private string[] ProcessData(params string[] data)
        {
            return data.Select(s => ProcessData(s)).ToArray();
        }

        private string ProcessData(string data)
        {
            return data.Replace("\"", "").Replace(" ", "");
        }
    }
}
