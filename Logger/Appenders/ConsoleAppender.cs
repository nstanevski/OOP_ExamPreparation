using System;
using Logger.Interfaces;

namespace Logger.Appenders
{
    public class ConsoleAppender:Appender
    {
        
        public override void Append(string msg)
        {
            if (msg == null)
            {
                throw new ArgumentNullException("msg");
            }
            Console.WriteLine(msg);
            
        }

        public ConsoleAppender(IFormatter formatter) 
            : base(formatter)
        {
        }
    }
}
