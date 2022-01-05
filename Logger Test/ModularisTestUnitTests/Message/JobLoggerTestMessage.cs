namespace ModularisTestUnitTests.Message
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModularisTest;
    using ModularisTest.BO;
    using ModularisTest.Enum;
    using ModularisTest.Resources;
    using ModularisTest.Strategy;

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
            string result = jobLogger.LogMessage(logData, new MessageStrategy());

            //Assert
            Assert.AreEqual(ResourcesGeneral.StrategyMessage, result);
        }
    }
}