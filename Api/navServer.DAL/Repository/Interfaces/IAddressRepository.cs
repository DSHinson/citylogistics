using navServer.Models.dbo;

namespace navServer.DAL.Repository.Interfaces
{
    public interface IAddressRepository
    {
        public void AddAddress(Address address);
    }
}
