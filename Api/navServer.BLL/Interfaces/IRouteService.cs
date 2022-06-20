using navServer.Models.dbo;

namespace navServer.BLL.Interfaces
{
    public interface IRouteService
    {
        public void SaveRouteDetails(Address startAddress, Address endAddress);
    }
}
