namespace ModularisTestUnitTests.Warning
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModularisTest;
    using ModularisTest.BO;
    using ModularisTest.Enum;
    using ModularisTest.Resources;
    using ModularisTest.Strategy;

    [TestClass]
    public class JobLoggerTestWarning
    {
        [TestMethod]
        public void Test3()
        {
            //Arrange
            LogDataBO logData = new LogDataBO
            {
                logType = LogType.Warning
            };
            JobLogger jobLogger = JobLogger.GetInstance();

            //Act
            string result = jobLogger.LogMessage(logData, new WarningStrategy());

            //Assert
            Assert.AreEqual(ResourcesGeneral.StrategyWarning, result);
        }
    }
}