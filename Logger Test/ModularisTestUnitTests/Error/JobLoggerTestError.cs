namespace ModularisTestUnitTests.Error
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModularisTest;
    using ModularisTest.BO;
    using ModularisTest.Enum;
    using ModularisTest.Resources;

    [TestClass]
    public class JobLoggerTestError
    {
        [TestMethod]
        public void Test1()
        {
            //Arrange
            LogDataBO logData = new LogDataBO
            {
                logType = LogType.Error
            };
            JobLogger jobLogger = JobLogger.GetInstance();

            //Act
            string result = jobLogger.LogMessage(logData);

            //Assert
            Assert.Equals(ResourcesGeneral.StrategyError, result);
        }
    }
}