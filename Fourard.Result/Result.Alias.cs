namespace Fourard.Result
{
    public abstract record Result<TValue1, TValue2, TError> : Result<(TValue1, TValue2), TError>
    {
        public static implicit operator Result<TValue1, TValue2, TError>((TValue1, TValue2) values) => new Success<TValue1, TValue2, TError>(values.Item1, values.Item2);
        public static implicit operator Result<TValue1, TValue2, TError>(TError error) => new Failure<TValue1, TValue2, TError>(error);
        public static implicit operator Result<TValue1, TValue2, TError>(Exception exception) => new Unhandled<TValue1, TValue2, TError>(exception);
    }

    public record Success<TValue1, TValue2, TError>(TValue1 Value1, TValue2 Value2) : Result<TValue1, TValue2, TError>
    {
    }

    public record Failure<TValue1, TValue2, TError>(TError Error) : Result<TValue1, TValue2, TError>
    {
    }

    public record Unhandled<TValue1, TValue2, TError>(Exception Exception) : Result<TValue1, TValue2, TError>
    {
    }

    public abstract record Result<TValue1, TValue2, TValue3, TError> : Result<(TValue1, TValue2, TValue3), TError>
    {
        public static implicit operator Result<TValue1, TValue2, TValue3, TError>((TValue1, TValue2, TValue3) values) => new Success<TValue1, TValue2, TValue3, TError>(values.Item1, values.Item2, values.Item3);
        public static implicit operator Result<TValue1, TValue2, TValue3, TError>(TError error) => new Failure<TValue1, TValue2, TValue3, TError>(error);
        public static implicit operator Result<TValue1, TValue2, TValue3, TError>(Exception exception) => new Unhandled<TValue1, TValue2, TValue3, TError>(exception);
    }

    public record Success<TValue1, TValue2, TValue3, TError>(TValue1 Value1, TValue2 Value2, TValue3 Value3) : Result<TValue1, TValue2, TValue3, TError>
    {
    }

    public record Failure<TValue1, TValue2, TValue3, TError>(TError Error) : Result<TValue1, TValue2, TValue3, TError>
    {
    }

    public record Unhandled<TValue1, TValue2, TValue3, TError>(Exception Exception) : Result<TValue1, TValue2, TValue3, TError>
    {
    }

    public abstract record Result<TValue1, TValue2, TValue3, TValue4, TError> : Result<(TValue1, TValue2, TValue3, TValue4), TError>
    {
        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TError>((TValue1, TValue2, TValue3, TValue4) values) =>
            new Success<TValue1, TValue2, TValue3, TValue4, TError>(values.Item1, values.Item2, values.Item3, values.Item4);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TError>(TError error) =>
            new Failure<TValue1, TValue2, TValue3, TValue4, TError>(error);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TError>(Exception exception) =>
            new Unhandled<TValue1, TValue2, TValue3, TValue4, TError>(exception);
    }

    public record Success<TValue1, TValue2, TValue3, TValue4, TError>(
        TValue1 Value1, TValue2 Value2, TValue3 Value3, TValue4 Value4)
        : Result<TValue1, TValue2, TValue3, TValue4, TError>
    {
    }

    public record Failure<TValue1, TValue2, TValue3, TValue4, TError>(TError Error)
        : Result<TValue1, TValue2, TValue3, TValue4, TError>
    {
    }

    public record Unhandled<TValue1, TValue2, TValue3, TValue4, TError>(Exception Exception)
        : Result<TValue1, TValue2, TValue3, TValue4, TError>
    {
    }

    public abstract record Result<TValue1, TValue2, TValue3, TValue4, TValue5, TError> : Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>
    {
        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TError>((TValue1, TValue2, TValue3, TValue4, TValue5) values) =>
            new Success<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(values.Item1, values.Item2, values.Item3, values.Item4, values.Item5);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(TError error) =>
            new Failure<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(error);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(Exception exception) =>
            new Unhandled<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(exception);
    }

    public record Success<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(
        TValue1 Value1, TValue2 Value2, TValue3 Value3, TValue4 Value4, TValue5 Value5)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TError>
    {
    }

    public record Failure<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(TError Error)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TError>
    {
    }

    public record Unhandled<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(Exception Exception)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TError>
    {
    }

    public abstract record Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError> : Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>
    {
        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>((TValue1, TValue2, TValue3, TValue4, TValue5, TValue6) values) =>
            new Success<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(values.Item1, values.Item2, values.Item3, values.Item4, values.Item5, values.Item6);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(TError error) =>
            new Failure<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(error);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(Exception exception) =>
            new Unhandled<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(exception);
    }

    public record Success<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(
        TValue1 Value1, TValue2 Value2, TValue3 Value3, TValue4 Value4, TValue5 Value5, TValue6 Value6)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>
    {
    }

    public record Failure<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(TError Error)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>
    {
    }

    public record Unhandled<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(Exception Exception)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>
    {
    }

    public abstract record Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError> : Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>
    {
        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>((TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7) values) =>
            new Success<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(values.Item1, values.Item2, values.Item3, values.Item4, values.Item5, values.Item6, values.Item7);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(TError error) =>
            new Failure<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(error);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(Exception exception) =>
            new Unhandled<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(exception);
    }

    public record Success<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(
        TValue1 Value1, TValue2 Value2, TValue3 Value3, TValue4 Value4, TValue5 Value5, TValue6 Value6, TValue7 Value7)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>
    {
    }

    public record Failure<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(TError Error)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>
    {
    }

    public record Unhandled<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(Exception Exception)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>
    {
    }

    public abstract record Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError> : Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>
    {
        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>((TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8) values) =>
            new Success<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(values.Item1, values.Item2, values.Item3, values.Item4, values.Item5, values.Item6, values.Item7, values.Item8);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(TError error) =>
            new Failure<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(error);

        public static implicit operator Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(Exception exception) =>
            new Unhandled<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(exception);
    }

    public record Success<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(
        TValue1 Value1, TValue2 Value2, TValue3 Value3, TValue4 Value4, TValue5 Value5, TValue6 Value6, TValue7 Value7, TValue8 Value8)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>
    {
    }

    public record Failure<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(TError Error)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>
    {
    }

    public record Unhandled<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(Exception Exception)
        : Result<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>
    {
    }
}