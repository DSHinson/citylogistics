using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace navServer.DAL.Commands.Interface
{
    public interface ICommands
    {
        string usp_SaveRoute { get; }
        string usp_SaveAddress { get; }
    }
}
