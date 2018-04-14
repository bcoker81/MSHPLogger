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
            bool result = false;

            try
            {
                if (log != null)
                {
                    _db.LogEntries.Add(log);
                    _db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw;
            }
            return result;
        }
    }
}
