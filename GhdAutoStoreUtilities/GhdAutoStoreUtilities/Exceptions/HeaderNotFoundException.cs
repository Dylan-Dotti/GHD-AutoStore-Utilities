using System;

namespace GhdAutoStoreUtilities.Exceptions
{
    public abstract class HeaderNotFoundException: Exception
    {
        public HeaderNotFoundException(string fileName, string headerName)
            : base($"No column was found in {fileName} " +
                   $"which was marked with a header of \"{headerName}\".")
        { }
    }
}
