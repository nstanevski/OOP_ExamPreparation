namespace Logger.Formatters
{
    public class XmlFormatter : Formatter
    {
        public override string Format { get; set; } //TODO: validation

        public XmlFormatter()
        {
            this.Format = "<date>\r\n{0}\r\n</date>\r\n<level>\r\n{1}\r\n</level>\r\n<message>\r\n{2}\r\n</message>\r\n";
        }
    }
}
