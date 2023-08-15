namespace Fourard.Result
{
    public abstract record Result<T>
    {
        public static implicit operator Result<T>(T value) => new Success<T>(value);
        public static implicit operator Result<T>(Exception exception) => new Unhandled<T>(exception);
    }

    public record Success<T>(T Value) : Result<T>
    {
    }

    public record Unhandled<T>(Exception Exception) : Result<T>
    {
    }

    public abstract record Result<TValue, TError>
    {
        public static implicit operator Result<TValue, TError>(TValue value) => new Success<TValue, TError>(value);
        public static implicit operator Result<TValue, TError>(TError error) => new Failure<TValue, TError>(error);
        public static implicit operator Result<TValue, TError>(Exception exception) => new Unhandled<TValue, TError>(exception);
    }

    public record Success<TValue, TError>(TValue Value) : Result<TValue, TError>
    {
    }

    public record Failure<TValue, TError>(TError Error) : Result<TValue, TError>
    {
    }

    public record Unhandled<TValue, TError>(Exception Exception) : Result<TValue, TError>
    {
    }
}