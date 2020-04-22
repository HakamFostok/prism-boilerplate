using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModule
{
    public class LogService : ILogService
    {
        public void LogError(string log)
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.Error(log);
        }
    }
}
