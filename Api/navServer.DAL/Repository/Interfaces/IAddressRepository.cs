using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using navServer.Models.dbo;

namespace navServer.DAL.Repository.Interfaces
{
    public interface IAddressRepository
    {
        public void AddAddress(Address address);
    }
}
