using navServer.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace navServer.BLL.Interfaces
{
    public interface IGeoLocation
    {
        public Coordinates AddressToCoordinates(Address address);
    }
}
