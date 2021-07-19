
namespace GhdAutoStoreUtilities.Exceptions
{
    public class SynqHeaderNotFoundException : HeaderNotFoundException
    {
        public SynqHeaderNotFoundException(string headerName)
            : base("the SynQ data file", headerName)
        { }
    }
}
