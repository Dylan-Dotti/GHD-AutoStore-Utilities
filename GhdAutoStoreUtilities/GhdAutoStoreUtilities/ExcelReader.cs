using System;
using System.Linq;
using ClosedXML.Excel;

namespace GhdAutoStoreUtilities
{
    public class ExcelReader : IGridFileReader
    {
        private readonly XLWorkbook workbook;
        private readonly IXLWorksheet worksheet;

        public ExcelReader(string path)
        {
            workbook = new XLWorkbook(path);
            worksheet = workbook.Worksheets.First();
        }

        public void Dispose()
        {
            workbook.Dispose();
        }

        public string GetCellData(int rowIndex, int colIndex)
        {
            return worksheet.Cell(rowIndex + 1, colIndex + 1).GetString();
        }

        public string[] GetRowData(int rowIndex,
            bool skipFirstCol = false, bool includeEmpty = false)
        {
            string[] rowData = worksheet.Row(rowIndex + 1)
                .Cells(skipFirstCol ? 2 : 1, worksheet.ColumnCount())
                .Select(c => c.GetString()).ToArray();
            return FilterVector(rowData, includeEmpty);
        }

        public string[] GetColumnData(int colIndex,
            bool skipFirstRow = false, bool includeEmpty = false)
        {
            string[] columnData = worksheet.Column(colIndex + 1)
                .Cells(skipFirstRow ? 2 : 1, worksheet.RowCount())
                .Select(c => c.GetString()).ToArray();
            return FilterVector(columnData, includeEmpty);
        }

        private string[] FilterVector(string[] vector, bool includeEmpty)
        {
            // get all cells up to the last filled cell, filter empty cells if necessary
            string lastFilled = vector.LastOrDefault(s => !string.IsNullOrWhiteSpace(s));
            if (string.IsNullOrWhiteSpace(lastFilled)) return new string[] { };
            int lastIndex = Array.LastIndexOf(vector, lastFilled);
            var filtered = vector.Take(lastIndex + 1)
                .Where(s => includeEmpty || !string.IsNullOrWhiteSpace(s))
                .ToArray();
            return filtered;
        }
    }
}
