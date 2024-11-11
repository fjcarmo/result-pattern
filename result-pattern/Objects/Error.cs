namespace result_pattern.Objects
{
    public class Error(string code, string description)
    {
        public string Code { get; } = code;
        public string Description { get; } = description;
    }
}
