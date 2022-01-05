
namespace ModularisTest.DTO
{
    using ModularisTest.Enum;

    public interface ILogDataDTO
    {
        string message { get; set; }
        LogType logType { get; set; }
    }
}