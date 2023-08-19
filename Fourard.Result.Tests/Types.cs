namespace Fourard.Result.Tests
{
    public class Value
    {
        public override bool Equals(object? obj) => true;
        public override int GetHashCode() => base.GetHashCode();
    }

    public class Value1 : Value
    {
    }
    public class Value2 : Value
    {
    }
    public class Value3 : Value
    {
    }
    public class Value4 : Value
    {
    }
    public class Value5 : Value
    {
    }
    public class Value6 : Value
    {
    }
    public class Value7 : Value
    {
    }
    public class Value8 : Value
    {
    }

    public class Error
    {
        public string? Message { get; set; }

        public Error() { }
        public Error(string message) { Message = message; }
    }

    public class Return
    {
    }
}