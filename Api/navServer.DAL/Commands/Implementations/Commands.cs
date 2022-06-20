using navServer.DAL.Commands.Interface;

namespace navServer.DAL.Commands.Implementations
{
    public class Commands : ICommands
    {
        //give the command name the same as the proc name in DB
        public string usp_SaveRoute => nameof(usp_SaveRoute);

        public string usp_SaveAddress => nameof(usp_SaveAddress);
    }
}
