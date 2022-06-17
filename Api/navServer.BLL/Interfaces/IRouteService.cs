using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using navServer.Models.dbo;

namespace navServer.BLL.Interfaces
{
    public interface IRouteService
    {
        public void SaveRouteDetails(Address startAddress, Address endAddress);
    }
}
