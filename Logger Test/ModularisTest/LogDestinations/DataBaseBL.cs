// ------------------------------------------------------------------------------------
// <copyright file="DataBaseBL.cs" company="JHT">
// Copyright (c) JHT. All rights reserved.
// </copyright>
// <author>Jaime Homero Trujillo Trujillo</author>
// ------------------------------------------------------------------------------------
namespace ModularisTest.LogDestinations
{
    using ModularisTest.DTO;
    using ModularisTest.LogDestinations.Factory;

    /// <summary>
    /// 
    /// </summary>
    internal class DataBaseBL : IFactoryLogDestinations
    {
        /// <summary>
        /// 
        /// </summary>
        public ILogDataDTO logData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DataBaseBL() { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string saveLog()
        {
            ///TODO: iplement conetion database
            return "save log in Data Base";
        }
    }
}