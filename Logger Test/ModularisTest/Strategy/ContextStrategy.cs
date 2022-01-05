// ------------------------------------------------------------------------------------
// <copyright file="ContextStrategy.cs" company="JHT">
// Copyright (c) JHT. All rights reserved.
// </copyright>
// <author>Jaime Homero Trujillo Trujillo</author>
// ------------------------------------------------------------------------------------
namespace ModularisTest.Strategy
{
    using ModularisTest.DTO;
    using ModularisTest.Enum;
    using ModularisTest.Interface;

    /// <summary>
    ///
    /// </summary>
    internal class ContextStrategy
    {
        /// <summary>
        ///
        /// </summary>
        private ILogType _oLogType;

        /// <summary>
        ///
        /// </summary>
        private static ContextStrategy instance;

        /// <summary>
        ///
        /// </summary>
        private ContextStrategy()
        { }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static ContextStrategy GetInstance()
        {
            if (instance == null)
            {
                instance = new ContextStrategy();
            }
            return instance;
        }


        public void SetEstrategy(ILogType oLogType)
        {
            this._oLogType = oLogType;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="logData"></param>
        /// <returns></returns>
        public string log(ILogDataDTO logData)
        {
            //switch (logData.logType)
            //{
            //    case (LogType.Error):
            //        {
            //            this._oLogType = new ErrorStrategy();
            //        }
            //        break;

            //    case (LogType.Message):
            //        {
            //            this._oLogType = new MessageStrategy();
            //        }
            //        break;

            //    case (LogType.Warning):
            //        {
            //            this._oLogType = new WarningStrategy();
            //        }
            //        break;
            //}

            return this._oLogType.saveLog(logData);
        }
    }
}