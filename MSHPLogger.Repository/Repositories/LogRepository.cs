using MSHPLogger.Entities;
using MSHPLogger.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSHPLogger.Repository.Repositories
{
    public class LogRepository : ILogger
    {
        public bool LogError(LogEntry log)
        {
            throw new NotImplementedException();
        }
    }
}
