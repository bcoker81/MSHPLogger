using MSHPLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSHPLogger.Repository.Interfaces
{
    public interface ILogger
    {
        bool LogError(LogEntry log);
    }
}
