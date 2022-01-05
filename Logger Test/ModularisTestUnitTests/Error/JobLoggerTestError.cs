namespace ModularisTestUnitTests.Error
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModularisTest;
    using ModularisTest.BO;
    using ModularisTest.Enum;
    using ModularisTest.Resources;
    using ModularisTest.Strategy;

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

            string result = jobLogger.LogMessage(logData, new ErrorStrategy());

            //Assert
            Assert.AreEqual(ResourcesGeneral.StrategyError, result);
        }
    }
}