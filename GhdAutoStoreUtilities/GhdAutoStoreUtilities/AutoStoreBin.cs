
namespace GhdAutoStoreUtilities
{
    public class AutoStoreBin
    {
        public string ID { get; private set; }
        public string Mode { get; private set; }

        public AutoStoreBin(string id, string mode)
        {
            ID = id;
            Mode = mode;
        }
    }
}
