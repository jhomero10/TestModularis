
namespace ModularisTest.LogDestinations
{
    using ModularisTest.DTO;
    using ModularisTest.LogDestinations.Factory;

    internal class DataBaseBL : IFactoryLogDestinations
    {
        public ILogDataDTO logData { get; set; }

        public DataBaseBL() { }

        public string saveLog()
        {
            ///TODO: iplement conetion database
            return "save log in Data Base";
        }
    }
}