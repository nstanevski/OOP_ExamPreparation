using Logger.Interfaces;

namespace Logger
{
    public class Logger
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public IAppender Appender { get; private set; }

        public void Info(string msg)
        {
            this.Log(msg, ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg, ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg, ReportLevel.Error);
        }

        public void Critical(string msg)
        {
            this.Log(msg, ReportLevel.Critical);
        }

        public void Fatal(string msg)
        {
            this.Log(msg, ReportLevel.Fatal);
        }

        private void Log(string msg, ReportLevel levelMsg)
        {
            IFormatter formatter = this.Appender.Formatter;
            string formattedMsg = formatter.FormatMessage(msg, levelMsg);
            this.Appender.Append(formattedMsg);
        }
    }
}
