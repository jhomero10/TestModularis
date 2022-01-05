// ------------------------------------------------------------------------------------
// <copyright file="FileBL.cs" company="JHT">
// Copyright (c) JHT. All rights reserved.
// </copyright>
// <author>Jaime Homero Trujillo Trujillo</author>
// ------------------------------------------------------------------------------------
namespace ModularisTest.LogDestinations
{
    using ModularisTest.DTO;
    using ModularisTest.LogDestinations.Factory;
    using System;
    using System.Configuration;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    internal class FileBL : IFactoryLogDestinations
    {
        /// <summary>
        /// 
        /// </summary>
        public ILogDataDTO logData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FileBL()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string saveLog()
        {
            string stringFileContent = string.Empty;

            string logFolder = ConfigurationManager.AppSettings["LogFileDirectory"];

            if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder);

            if (string.IsNullOrEmpty(logFolder)) logFolder = Environment.CurrentDirectory;

            string logFullFilePath = Path.Combine(logFolder, $"LogFile{DateTime.Now.ToShortDateString().Replace("/", ".")}.txt");

            if (File.Exists(logFullFilePath))
            {
                stringFileContent = File.ReadAllText(logFullFilePath);
            }

            stringFileContent = $"{stringFileContent}{DateTime.Now} - {logData.logType} - {logData.message} {Environment.NewLine}";

            File.WriteAllText(logFullFilePath, stringFileContent);

            return "save log in file";
        }
    }
}