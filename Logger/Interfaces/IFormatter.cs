namespace Logger.Interfaces
{
    public interface IFormatter
    {
        string FormatMessage(string msg, ReportLevel reportLevel); 
    }
}
