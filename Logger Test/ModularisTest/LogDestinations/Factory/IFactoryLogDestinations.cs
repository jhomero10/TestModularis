using ModularisTest.DTO;

namespace ModularisTest.LogDestinations.Factory
{
    public interface IFactoryLogDestinations
    {
        ILogDataDTO logData { get; set; }

        string saveLog();
    }
}