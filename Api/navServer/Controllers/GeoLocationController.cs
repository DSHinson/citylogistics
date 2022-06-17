using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using navServer.BLL.Interfaces;
using navServer.Models.Core;

namespace navServer.API.Controllers
{
    [Route("")]
    public class GeoLocationController : Controller
    {
        private readonly IGeoLocation _geoLocationService;
        private readonly ILogger<GeoLocationController> _logger;
        public GeoLocationController(IGeoLocation geoLocationService, ILogger<GeoLocationController>logger)
        {
            _geoLocationService = geoLocationService ?? throw new ArgumentNullException(nameof(geoLocationService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        [Route("GetCoordinatesForAddress")]
        public Coordinates GetCoordinatesForAddress(Address _address)
        {
            _logger.LogInformation("handled request");
            return _geoLocationService.AddressToCoordinates(_address);
        }
    }
}
