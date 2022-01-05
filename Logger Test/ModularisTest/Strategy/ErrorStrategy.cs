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
    using ModularisTest.Util;
    using System;
    using System.Configuration;

    /// <summary>
    /// 
    /// </summary>
    public class ErrorStrategy : ILogType
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly bool _logToFile = bool.Parse(ConfigurationManager.AppSettings["LogToFile"]);

        /// <summary>
        /// 
        /// </summary>
        private static readonly bool _logToConsole = bool.Parse(ConfigurationManager.AppSettings["LogToConsole"]);

        /// <summary>
        /// 
        /// </summary>
        private readonly Lazy<ILogDestinationAcction> logDestination = new Lazy<ILogDestinationAcction>(()=> new LogDestination());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logData"></param>
        /// <returns></returns>
        public string saveLog(ILogDataDTO logData)
        {
            logData.message = ConfigurationManager.AppSettings["ErrorMessage"];

            if (_logToFile) logDestination.Value.saveLogDestination(logData, LogDestinationsType.File);
            if (_logToConsole) logDestination.Value.saveLogDestination(logData, LogDestinationsType.Console);

            return ResourcesGeneral.StrategyError;
        }
    }
}