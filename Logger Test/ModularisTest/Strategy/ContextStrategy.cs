
namespace ModularisTest.Strategy
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    using ModularisTest.Interface;
    
    class ContextStrategy
    {
        private static ContextStrategy instance;

        private ContextStrategy() { }

        public static ContextStrategy GetInstance()
        {
            if (instance == null)
            {
                instance = new ContextStrategy();
            }
            return instance;
        }

        private ILogType oLogType;

        public string log(ILogDataDTO logData)
        {
            switch (logData.logType)
            {
                case (LogType.Error):
                    {
                        this.oLogType = new ErrorStrategy();
                    }
                    break;
                case (LogType.Message):
                    {
                        this.oLogType = new MessageStrategy();
                    }
                    break;
                case (LogType.Warning):
                    {
                        this.oLogType = new WarningStrategy();
                    }
                    break;
            }

            return this.oLogType.saveLog(logData);
        }
    }
}
