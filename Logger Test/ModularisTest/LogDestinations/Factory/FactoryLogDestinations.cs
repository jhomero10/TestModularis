// ------------------------------------------------------------------------------------
// <copyright file="FactoryLogDestinations.cs" company="JHT">
// Copyright (c) JHT. All rights reserved.
// </copyright>
// <author>Jaime Homero Trujillo Trujillo</author>
// ------------------------------------------------------------------------------------
namespace ModularisTest.LogDestinations.Factory
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;

    /// <summary>
    /// 
    /// </summary>
    public class FactoryLogDestinations
    {
        /// <summary>
        /// 
        /// </summary>
        private LogDestinationsType _factoryType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factoryType"></param>
        public FactoryLogDestinations(LogDestinationsType factoryType)
        {
            this._factoryType = factoryType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logData"></param>
        /// <returns></returns>
        public IFactoryLogDestinations createFactory(ILogDataDTO logData)
        {
            switch (_factoryType)
            {
                case LogDestinationsType.Console:
                    return new ConsoleBL();
                case LogDestinationsType.DatBase:
                    return new DataBaseBL();
                case LogDestinationsType.File:
                    return new FileBL();
                default:
                    return null;
            }
        }
    }
}