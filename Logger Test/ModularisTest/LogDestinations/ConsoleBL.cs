
namespace ModularisTest.LogDestinations
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    using ModularisTest.LogDestinations.Factory;
    using System;

    internal class ConsoleBL : IFactoryLogDestinations
    {
        public ILogDataDTO logData { get; set; }

        public ConsoleBL() { }

        public string saveLog()
        {
            switch (logData.logType)
            {
                case LogType.Message:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogType.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now.ToString() + logData.message);

            return "save log in console";
        }
    }
}