
namespace GhdAutoStoreUtilities
{
    public class SynqTU
    {
        public string ID { get; private set; }
        public string Location { get; private set; }

        public SynqTU(string id, string location)
        {
            ID = id;
            Location = location;
        }
    }
}
