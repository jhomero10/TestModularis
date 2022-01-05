// ------------------------------------------------------------------------------------
// <copyright file="JobLogger.cs" company="JHT">
// Copyright (c) JHT. All rights reserved.
// </copyright>
// <author>Jaime Homero Trujillo Trujillo</author>
// ------------------------------------------------------------------------------------
namespace ModularisTest
{
    using ModularisTest.DTO;
    using ModularisTest.Exceptions;
    using ModularisTest.Interface;
    using ModularisTest.Strategy;
    using System;
    using System.Configuration;

    /// <summary>
    /// 
    /// </summary>
    public class JobLogger
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
        private static bool _initialized;

        /// <summary>
        /// 
        /// </summary>
        private static JobLogger instance;

        /// <summary>
        /// 
        /// </summary>
        private JobLogger()
        {
            _initialized = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static JobLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new JobLogger();
            }
            return instance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logData"></param>
        /// <returns></returns>
        public string LogMessage(ILogDataDTO logData, ILogType oLogTyp)
        {
            if (!_initialized) throw new JobLoggerNotInitializedException();

            if (!_logToConsole && !_logToFile)
            {
                throw new Exception("Invalid configuration");
            }

            ContextStrategy contextStrategy = ContextStrategy.GetInstance();
            contextStrategy.SetEstrategy(oLogTyp);
            return contextStrategy.log(logData);
        }       
    }
}