using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using navServer.DAL.Commands.Interface;
using navServer.DAL.Repository.Implementations;
using navServer.DAL.Repository.Interfaces;
using navServer.Models.dbo;

namespace navServer.DAL.Repository
{
    public class AddressRepository: BaseRepository , IAddressRepository
    {
        private readonly ICommands _command;
        public AddressRepository(IConfiguration configuration, ICommands commandText) : base(configuration)
        {
            _command = commandText;

        }
        public void AddAddress(Address address)
        {
            _ = WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_command.usp_SaveAddress, address, commandType: CommandType.StoredProcedure);
            });
        }
    }
}
