using System;
using NLog;

namespace ChickenAPI.Utils
{
    public class Logger
    {
        private ILogger _log { get; set; }

        private Logger(Type type)
        {
            _log = LogManager.GetLogger(type.ToString());
        }

        public static Logger GetLogger<TClass>() 
            where TClass : class
        {
            return new Logger(typeof(TClass));
        }

        public void Trace(string msg)
        {
            _log?.Trace(msg);
        }

        public void Debug(string msg)
        {
            _log?.Debug(msg);
        }

        public void Info(string msg)
        {
            _log?.Info(msg);
        }

        public void Warn(string msg)
        {
            _log?.Warn(msg);
        }

        public void Error(string msg, Exception ex)
        {
            _log?.Error(ex, msg);
        }

        public void Fatal(string msg, Exception ex)
        {
            _log?.Fatal(ex, msg);
        }
    }
}