// ------------------------------------------------------------------------------------
// <copyright file="ErrorStrategy.cs" company="JHT">
// Copyright (c) JHT. All rights reserved.
// </copyright>
// <author>Jaime Homero Trujillo Trujillo</author>
// ------------------------------------------------------------------------------------
namespace ModularisTest.Strategy
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    using ModularisTest.Interface;
    using ModularisTest.Resources;
    using System;
    using System.Configuration;

    public class ErrorStrategy : ILogType
    {
        private static readonly bool _logToFile = bool.Parse(ConfigurationManager.AppSettings["LogToFile"]);
        private static readonly bool _logToConsole = bool.Parse(ConfigurationManager.AppSettings["LogToConsole"]);

        private readonly Lazy<ILogDestinationAcction> logDestination;

        public string saveLog(ILogDataDTO logData)
        {
            logData.message = ConfigurationManager.AppSettings["ErrorMessage"];

            if (_logToFile) logDestination.Value.saveLogDestination(logData, LogDestinationsType.File);
            if (_logToConsole) logDestination.Value.saveLogDestination(logData, LogDestinationsType.Console);

            return ResourcesGeneral.StrategyError;
        }
    }
}