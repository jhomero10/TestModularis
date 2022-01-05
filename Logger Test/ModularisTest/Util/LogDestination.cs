namespace ModularisTest.Util
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    using ModularisTest.Interface;
    using ModularisTest.LogDestinations.Factory;

    public class LogDestination : ILogDestinationAcction
    {
        public LogDestination()
        { }

        public string saveLogDestination(ILogDataDTO logData, LogDestinationsType logDestinationsType)
        {
            FactoryLogDestinations factoryLogDestinations = new FactoryLogDestinations(logDestinationsType);
            IFactoryLogDestinations factory = factoryLogDestinations.createFactory(logData);
            factory.logData = logData;
            return factory.saveLog();
        }
    }
}