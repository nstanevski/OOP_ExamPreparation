using System;
using Logger.Interfaces;

namespace Logger.Appenders
{
    public abstract class Appender:IAppender
    {
        //private string format;
        private IFormatter formatter;

        public abstract void Append(string msg);

        public Appender(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public IFormatter Formatter 
        {
            get { return this.formatter; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Format");
                }
                this.formatter = value;
            }
        }
    }
}
