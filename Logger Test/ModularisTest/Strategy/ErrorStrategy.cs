
namespace ModularisTest.Strategy
{
    using ModularisTest.DTO;
    using ModularisTest.Interface;
    using System;

    public class ErrorStrategy : ILogType
    {
        public string saveLog(ILogDataDTO logData)
        {
            throw new NotImplementedException();


        }
    }
}
