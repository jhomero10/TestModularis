namespace ModularisTestUnitTests.Warning
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModularisTest;
    using ModularisTest.BO;
    using ModularisTest.Enum;
    using ModularisTest.Resources;

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
            string result = jobLogger.LogMessage(logData);

            //Assert
            Assert.AreEqual(ResourcesGeneral.StrategyWarning, result);
        }
    }
}