namespace Logger.Formatters
{
    public class SimpleFormatter : Formatter
    {
        public override string Format { get; set; } //TODO: validation

        public SimpleFormatter()
        {
            this.Format = "{0} {1} {2}";
        }

    }
}
