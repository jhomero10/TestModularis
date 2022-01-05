using ModularisTest.DTO;
using ModularisTest.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.BO
{
    public class LogDataBO : ILogDataDTO
    {
        public string message { get; set; }
        public LogType logType { get; set; }
    }
}
