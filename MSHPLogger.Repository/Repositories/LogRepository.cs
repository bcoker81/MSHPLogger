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
        private LoggerContext _db;

        public LogRepository(LoggerContext db)
        {
            _db = db;
        }

        public LogRepository()
        {
            _db = new LoggerContext();
        }

        public bool LogError(LogEntry log)
        {
            throw new NotImplementedException();
        }
    }
}
