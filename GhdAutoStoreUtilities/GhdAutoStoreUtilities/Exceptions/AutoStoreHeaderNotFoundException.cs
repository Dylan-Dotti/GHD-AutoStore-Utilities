
namespace GhdAutoStoreUtilities.Exceptions
{
    public class AutoStoreHeaderNotFoundException : HeaderNotFoundException
    {
        public AutoStoreHeaderNotFoundException(string headerName)
            : base("the AutoStore data file", headerName)
        { }
    }
}
