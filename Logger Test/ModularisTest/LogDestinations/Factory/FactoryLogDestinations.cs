namespace ModularisTest.LogDestinations.Factory
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;

    public class FactoryLogDestinations
    {
        private LogDestinationsType _factoryType;

        public FactoryLogDestinations(LogDestinationsType factoryType)
        {
            this._factoryType = factoryType;
        }

        public IFactoryLogDestinations createFactory(ILogDataDTO logData)
        {
            switch (_factoryType)
            {
                case LogDestinationsType.Console:
                    return new ConsoleBL();
                case LogDestinationsType.DatBase:
                    return new DataBaseBL();
                case LogDestinationsType.File:
                    return new FileBL();
                default:
                    return null;
            }
        }
    }
}