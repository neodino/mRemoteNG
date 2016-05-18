﻿using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Repository;
#if !PORTABLE
using System;
#endif
using System.IO;
using System.Windows.Forms;

namespace mRemoteNG.App
{
    public class Logger
    {
        private static Logger _logger = null;
        private ILog _log;

        public static ILog GetSingletonInstance()
        {
            if (_logger == null)
                _logger = new Logger();
            return _logger._log;
        }

        private Logger()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            XmlConfigurator.Configure();
            string logFile = BuildLogFilePath();

            ILoggerRepository repository = LogManager.GetRepository();
            IAppender[] appenders = repository.GetAppenders();
            
            FileAppender fileAppender = default(FileAppender);
            foreach (IAppender appender in appenders)
            {
                fileAppender = appender as FileAppender;
                if (!(fileAppender == null || fileAppender.Name != "LogFileAppender"))
                {
                    fileAppender.File = logFile;
                    fileAppender.ActivateOptions();
                }
            }
            _log = LogManager.GetLogger("Logger");
        }

        private static string BuildLogFilePath()
        {
            string logFilePath = "";
#if !PORTABLE
			logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);
#else
            logFilePath = Application.StartupPath;
#endif
            string logFileName = Path.ChangeExtension(Application.ProductName, ".log");
            string logFile = Path.Combine(logFilePath, logFileName);
            return logFile;
        }
    }
}