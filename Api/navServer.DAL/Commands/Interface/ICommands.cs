namespace navServer.DAL.Commands.Interface
{
    public interface ICommands
    {
        string usp_SaveRoute { get; }
        string usp_SaveAddress { get; }
    }
}
