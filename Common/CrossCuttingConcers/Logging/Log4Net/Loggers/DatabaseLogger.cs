using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace Common.CrossCuttingConcers.Logging.Log4Net.Loggers
{
    public class DatabaseLogger:LoggerService
    {
        //public DatabaseLogger() : base(LogManager.GetLogger("DatabaseLogger"))
        // yukarıdaki gibi konfigurasyondan alınmalı...
        public DatabaseLogger(ILog log) : base(log)
        {
        }
    }
}
