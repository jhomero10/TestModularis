using ModularisTest.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Interface
{
    public interface ILogType
    {
        string saveLog(ILogDataDTO logData );
    }
}
