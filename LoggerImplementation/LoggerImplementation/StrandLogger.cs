using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerImplementation
{
    public sealed class StrandLogger : ILogger  //FileLogService
    {
        readonly ILog log;

        static StrandLogger()
        {
            var log4NetConfigDirectory = AppDomain.CurrentDomain.RelativeSearchPath ?? AppDomain.CurrentDomain.BaseDirectory;
            var log4NetConfigFilePath = Path.Combine(log4NetConfigDirectory, "logger.Config");
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(log4NetConfigFilePath));
        }

        public StrandLogger(Type logClass)
        {
            log = LogManager.GetLogger(logClass);
        }

        public void Debug(object message)
        {
            if(log.IsDebugEnabled)
            log.Debug(message);
        }

        public void Debug(object message, Exception ex)
        {
            if (log.IsDebugEnabled)
            log.Debug(message, ex);
        }

        public void Error(object message)
        {
            if(log.IsErrorEnabled)
            log.Error(message);
        }

        public void Error(object message, Exception ex)
        {
            if(log.IsErrorEnabled)
            log.Error(message, ex);
        }

        public void Fatal(object message)
        {
            if(log.IsFatalEnabled)
            log.Fatal(message);
        }

        public void Fatal(object message, Exception ex)
        {
            if(log.IsFatalEnabled)
            log.Fatal(message, ex);
        }

        public void Info(object message)
        {
            if(log.IsInfoEnabled)
            log.Info(message);
        }

        public void Info(object message, Exception ex)
        {
            if(log.IsInfoEnabled)
            log.Info(message, ex);
        }

        public void Warn(object message)
        {
            if(log.IsWarnEnabled)
            log.Warn(message);
        }

        public void Warn(object message, Exception ex)
        {
            if(log.IsWarnEnabled)
            log.Warn(message, ex);
        }
    }
}
