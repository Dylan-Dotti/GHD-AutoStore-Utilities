using System;

namespace GhdAutoStoreUtilities
{
    public interface IGridFileReader: IDisposable
    {
        string GetCellData(int rowIndex, int colIndex);
        string[] GetRowData(int rowIndex, bool skipFirstCol = false, bool includeEmpty = false);
        string[] GetColumnData(int colIndex, bool skipFirstRow = false, bool includeEmpty = false);
    }
}
