namespace Fourard.Result
{
    public static partial class Extensions
    {
        public static bool IsSuccess<TValue>(this Result<TValue>? result, out TValue? value)
        {
            value = default;

            if (result is Success<TValue> success)
            {
                value = success.Value;
                return true;
            }

            return false;
        }

        public static bool IsSuccess<TValue, TError>(this Result<TValue, TError>? result, out TValue? value)
        {
            value = default;

            if (result is Success<TValue, TError> success)
            {
                value = success.Value;
                return true;
            }

            return false;
        }

        public static bool IsFailure<TValue, TError>(this Result<TValue, TError>? result, out TError? error)
        {
            error = default;

            if (result is Failure<TValue, TError> failure)
            {
                error = failure.Error;
                return true;
            }

            return false;
        }

        public static bool IsUnhandled<TValue>(this Result<TValue>? result, out Exception? exception)
        {
            exception = default;

            if (result is Unhandled<TValue> unhandled)
            {
                exception = unhandled.Exception;
                return true;
            }

            return false;
        }

        public static bool IsUnhandled<TValue, TError>(this Result<TValue, TError>? result, out Exception? exception)
        {
            exception = default;

            if (result is Unhandled<TValue, TError> unhandled)
            {
                exception = unhandled.Exception;
                return true;
            }

            return false;
        }
    }
}