using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleMaps.LocationServices;
using Microsoft.Extensions.Logging;
using navServer.BLL.Interfaces;
using navServer.Models.Core;


namespace navServer.BLL.Implementations
{
    public class GeoLocationsService : IGeoLocation
    {
        private string _apiKey;
        public GeoLocationsService(string apiKey)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }
        public Coordinates AddressToCoordinates(Address address)
        {
            
            var locationService = new GoogleLocationService(_apiKey);
            return (Coordinates)locationService.GetLatLongFromAddress(address);
        }
    }
}
