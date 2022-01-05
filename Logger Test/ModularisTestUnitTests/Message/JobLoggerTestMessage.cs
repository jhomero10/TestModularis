namespace ModularisTestUnitTests.Message
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModularisTest;
    using ModularisTest.BO;
    using ModularisTest.Enum;
    using ModularisTest.Resources;

    [TestClass]
    public class JobLoggerTestMessage
    {
        [TestMethod]
        public void Test2()
        {
            //Arrange
            LogDataBO logData = new LogDataBO
            {
                logType = LogType.Message
            };
            JobLogger jobLogger = JobLogger.GetInstance();

            //Act
            string result = jobLogger.LogMessage(logData);

            //Assert
            Assert.AreEqual(ResourcesGeneral.StrategyMessage, result);
        }
    }
}