using Core;
using NLog;

namespace SharedModule
{
    public class LogService : ILogService
    {
        public void LogError(string log)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error(log);
        }
    }
}
