using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using navServer.BLL.Interfaces;
using navServer.DAL.Repository;
using navServer.DAL.Repository.Interfaces;
using navServer.Models.dbo;

namespace navServer.BLL.Implementations
{
    public class RouteService : IRouteService
    {
        private readonly IRoutesRepository _routesRepository;
        private readonly IAddressRepository _addressRepository;
        public RouteService(IRoutesRepository routesRepository, IAddressRepository addressRepository)
        {
            _routesRepository = routesRepository ?? throw new ArgumentNullException(nameof(routesRepository));
            _addressRepository = addressRepository ?? throw new ArgumentNullException(nameof(addressRepository));
        }
        public void SaveRouteDetails(Address startAddress, Address endAddress)
        {
            // save the address then save the route
            _addressRepository.AddAddress(startAddress);
            _addressRepository.AddAddress(endAddress);
            _routesRepository.AddRoute( new Routes()
            {
                //add pk from each address into route object and save
            });
        }
    }
}
