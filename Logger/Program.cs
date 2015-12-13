using Logger.Appenders;
using Logger.Formatters;
using Logger.Interfaces;

namespace Logger
{
    class Program
    {
        static void Main()
        {
            IFormatter simipleFormatter = new XmlFormatter();
            //IAppender consoleAppender = new ConsoleAppender(simipleFormatter);
            
            var fileAppender = new FileAppender(simipleFormatter, "log2.txt");
            //Logger logger = new Logger(consoleAppender);
            Logger logger = new Logger(fileAppender);
            logger.Info("ala bala");
            logger.Fatal("Division by zero");
            fileAppender.Close();
        }
    }
}
