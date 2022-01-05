
namespace ModularisTest.Strategy
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    using ModularisTest.Interface;
    class Context
    {
        private ILogType oLogType;

        public void log(ILogDataDTO logData)
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

            this.oLogType.saveLog(logData);
        }
    }
}
