using System;
using Logger.Interfaces;

namespace Logger.Formatters
{
    public abstract class Formatter:IFormatter
    {
        public abstract string Format { get; set; }


        public string FormatMessage(string msg, ReportLevel reportLevel)
        {
            DateTime dateTime = DateTime.Now;
            return string.Format(this.Format, dateTime, reportLevel, msg);
        }
    }
}
