using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using navServer.Models.dbo;
using navServer.DAL.Commands.Interface;

namespace navServer.DAL.Repository
{
    public class RoutesRepository:BaseRepository
    {
    private readonly ICommands _command;

    public RoutesRepository(IConfiguration configuration, ICommands commandText) : base(configuration)
    {
        _command = commandText;

    }

    public void AddRoute(Routes routes)
    {
        _ = WithConnection(async conn =>
        {
            await conn.ExecuteAsync(_command.usp_SaveRoute, routes, commandType: CommandType.StoredProcedure);
        });
    }
    }
}
