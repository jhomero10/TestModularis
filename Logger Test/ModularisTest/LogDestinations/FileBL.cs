namespace ModularisTest.LogDestinations
{
    using ModularisTest.DTO;
    using ModularisTest.LogDestinations.Factory;
    using System;
    using System.Configuration;
    using System.IO;

    internal class FileBL : IFactoryLogDestinations
    {
        public ILogDataDTO logData { get; set; }

        public FileBL()
        { }

        public string saveLog()
        {
            string l = string.Empty;

            var logFolder = ConfigurationManager.AppSettings["LogFileDirectory"];
            if (string.IsNullOrEmpty(logFolder)) logFolder = Environment.CurrentDirectory;
            var logFileName = "LogFile" + DateTime.Now.ToShortDateString().Replace("/", ".") + ".txt";
            var logFullFilePath = Path.Combine(logFolder, logFileName);

            if (File.Exists(logFullFilePath))
            {
                l = File.ReadAllText(logFullFilePath);
            }

            l = l + DateTime.Now.ToString() + $" {logData.logType}   " + logData.message + Environment.NewLine;

            if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder);

            System.IO.File.WriteAllText(logFullFilePath, l);

            return "save log in file";
        }
    }
}