using System;
using System.IO;
using Logger.Interfaces;

namespace Logger.Appenders
{
    public class FileAppender:Appender
    {
        public string FileName { get; set; }


        private StreamWriter writer;

        public FileAppender(IFormatter formatter, string fileName) 
            : base(formatter)
        {
            this.FileName = fileName;
            this.writer = new StreamWriter(this.FileName, true);            
        }

        public override void Append(string msg)
        {
            if (msg == null)
            {
                throw new ArgumentNullException("msg");
            }
            this.writer.WriteLine(msg);
            //Console.WriteLine(msg);
        }

        public void Close()
        {
            this.writer.Close();
        }

    }
}
