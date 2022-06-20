using System;
using GoogleMaps.LocationServices;
using navServer.BLL.Interfaces;
using navServer.Models.Core;


namespace navServer.BLL.Implementations
{
    public class GeoLocationsService : IGeoLocation
    {
        private readonly GoogleLocationService _locationService;
        public GeoLocationsService(string apiKey)
        {
            _ = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _locationService = new GoogleLocationService(apiKey);

        }
        public Coordinates AddressToCoordinates(Address address)
        {
            return (Coordinates)_locationService.GetLatLongFromAddress(address);
        }
    }
}
