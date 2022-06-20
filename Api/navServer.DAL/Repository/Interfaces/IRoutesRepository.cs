using navServer.Models.dbo;

namespace navServer.DAL.Repository.Interfaces
{
    public interface IRoutesRepository
    {
        public void AddRoute(Routes routes);
    }
}
