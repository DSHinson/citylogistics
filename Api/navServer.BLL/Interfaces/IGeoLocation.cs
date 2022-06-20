using navServer.Models.Core;

namespace navServer.BLL.Interfaces
{
    public interface IGeoLocation
    {
        public Coordinates AddressToCoordinates(Address address);
    }
}
