using System;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace ChickenAPI.Utils
{
    public class Logger
    {
        private ILogger _log { get; }

        private const string DefaultLayout = "${date}: [${level}][${logger}] ${message}";

        private Logger(Type type)
        {
            _log = LogManager.GetLogger(type.ToString());
        }

        /// <summary>
        /// Initialize logger's configuration.
        /// Please refer to https://github.com/nlog/NLog/wiki/Layout-Renderers for custom layouts.
        /// </summary>
        /// <param name="consoleLayout"></param>
        /// <param name="fileLayout"></param>
        public static void Initialize(string consoleLayout = DefaultLayout, string fileLayout = DefaultLayout)
        {
            var config = new LoggingConfiguration();
            var consoleTarget = new ColoredConsoleTarget();
            var fileTarget = new FileTarget();

            consoleTarget.Layout = consoleLayout;

            fileTarget.Layout = fileLayout;
            fileTarget.FileName = "logs/" + DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss");

            config.AddTarget("console", consoleTarget);
            config.AddTarget("file", fileTarget);

            var rule1 = new LoggingRule("*", LogLevel.Debug, consoleTarget);
            config.LoggingRules.Add(rule1);

            var rule2 = new LoggingRule("*", LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(rule2);

            LogManager.Configuration = config;
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