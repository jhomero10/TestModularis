
namespace ModularisTest.Interface
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    public interface ILogDestinationAcction
    {
        string saveLogDestination(ILogDataDTO logData, LogDestinationsType logDestinationsType);
    }
}
