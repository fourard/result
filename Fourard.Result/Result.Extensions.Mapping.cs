#pragma warning disable CS8509

namespace Fourard.Result
{
    public static partial class ResultExtensions
    {
        public static Result<TNewValue> Map<TValue, TNewValue>(this Result<TValue>? result, Func<TValue, TNewValue> success)
        {
            return result switch
            {
                Success<TValue> s => success(s.Value),
                Unhandled<TValue> u => u.Exception,
            };
        }

        public static Result<TNewValue, TError> Map<TValue, TError, TNewValue>(this Result<TValue, TError>? result, Func<TValue, TNewValue> success)
        {
            return result switch
            {
                Success<TValue, TError> s => success(s.Value),
                Failure<TValue, TError> f => f.Error,
                Unhandled<TValue, TError> u => u.Exception,
            };
        }

        public static async Task<Result<TNewValue>> Map<TValue, TNewValue>(this Task<Result<TValue>?> result, Func<TValue, TNewValue> success)
        {
            return Map(await result, success);
        }

        public static async Task<Result<TNewValue, TError>> Map<TValue, TError, TNewValue>(this Task<Result<TValue, TError>?> result, Func<TValue, TNewValue> success)
        {
            return Map(await result, success);
        }

        public static Result<TNewValue, TNewError> Map<TValue, TError, TNewValue, TNewError>(this Result<TValue, TError>? result, Func<TValue, TNewValue> success, Func<TError, TNewError> failure)
        {
            return result switch
            {
                Success<TValue, TError> s => success(s.Value),
                Failure<TValue, TError> f => failure(f.Error),
                Unhandled<TValue, TError> u => u.Exception,
            };
        }

        public static async Task<Result<TNewValue, TNewError>> Map<TValue, TError, TNewValue, TNewError>(this Task<Result<TValue, TError>?> result, Func<TValue, TNewValue> success, Func<TError, TNewError> failure)
        {
            return Map(await result, success, failure);
        }
    }
}