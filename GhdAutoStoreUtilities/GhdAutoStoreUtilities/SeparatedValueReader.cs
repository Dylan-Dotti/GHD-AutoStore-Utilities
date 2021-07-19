using System.IO;
using System.Linq;

namespace GhdAutoStoreUtilities
{
    public class SeparatedValueReader : IGridFileReader
    {
        private readonly string[][] fileData;

        public SeparatedValueReader(string filePath, char separator)
        {
            string[] fileLines = File.ReadAllLines(filePath);
            fileData = fileLines
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => s.Split(separator))
                .ToArray();
        }

        public void Dispose() { }

        public string GetCellData(int rowIndex, int colIndex)
        {
            return fileData[rowIndex][colIndex];
        }

        public string[] GetColumnData(int colIndex,
            bool skipFirstRow = false, bool includeEmpty = false)
        {
            return fileData.Skip(skipFirstRow ? 1 : 0)
                .Select(row => row[colIndex])
                .Where(s => includeEmpty || !string.IsNullOrWhiteSpace(s))
                .ToArray();
        }

        public string[] GetRowData(int rowIndex,
            bool skipFirstCol = false, bool includeEmpty = false)
        {
            return fileData[rowIndex]
                .Where(s => includeEmpty || !string.IsNullOrWhiteSpace(s))
                .ToArray();
        }
    }
}
