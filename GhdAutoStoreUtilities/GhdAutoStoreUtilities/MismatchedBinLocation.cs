
namespace GhdAutoStoreUtilities
{
    public class MismatchedBinLocation
    {
        public string BinID { get; private set; }
        public string SynqLocation { get; private set; }
        public string ASLocation { get; private set; }

        public MismatchedBinLocation(
            string binID, string synqLocation, string asLocation)
        {
            BinID = binID;
            SynqLocation = synqLocation;
            ASLocation = asLocation;
        }
    }
}
