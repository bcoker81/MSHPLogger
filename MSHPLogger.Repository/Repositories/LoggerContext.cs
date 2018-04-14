using MSHPLogger.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSHPLogger.Repository.Repositories
{
    public class LoggerContext : DbContext
    {

        public LoggerContext() : base("ErrorLogs")
        {

        }

        public virtual DbSet<LogEntry> LogEntries { get; set; }
    }
}
