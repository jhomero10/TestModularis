// ------------------------------------------------------------------------------------
// <copyright file="LogDestination.cs" company="JHT">
// Copyright (c) JHT. All rights reserved.
// </copyright>
// <author>Jaime Homero Trujillo Trujillo</author>
// ------------------------------------------------------------------------------------
namespace ModularisTest.Util
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    using ModularisTest.Interface;
    using ModularisTest.LogDestinations.Factory;

    public class LogDestination : ILogDestinationAcction
    {
        /// <summary>
        /// 
        /// </summary>
        public LogDestination()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logData"></param>
        /// <param name="logDestinationsType"></param>
        /// <returns></returns>
        public string saveLogDestination(ILogDataDTO logData, LogDestinationsType logDestinationsType)
        {
            FactoryLogDestinations factoryLogDestinations = new FactoryLogDestinations(logDestinationsType);
            IFactoryLogDestinations factory = factoryLogDestinations.createFactory(logData);
            factory.logData = logData;
            return factory.saveLog();
        }
    }
}