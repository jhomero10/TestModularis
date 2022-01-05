// ------------------------------------------------------------------------------------
// <copyright file="ConsoleBL.cs" company="JHT">
// Copyright (c) JHT. All rights reserved.
// </copyright>
// <author>Jaime Homero Trujillo Trujillo</author>
// ------------------------------------------------------------------------------------
namespace ModularisTest.LogDestinations
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    using ModularisTest.LogDestinations.Factory;
    using System;

    /// <summary>
    /// 
    /// </summary>
    internal class ConsoleBL : IFactoryLogDestinations
    {
        /// <summary>
        /// 
        /// </summary>
        public ILogDataDTO logData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ConsoleBL() { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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