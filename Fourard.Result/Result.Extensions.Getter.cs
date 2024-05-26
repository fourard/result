namespace Fourard.Result
{
    public static partial class Extensions
    {
        public static TValue? GetValueOrDefault<TValue>(this Result<TValue>? result)
        {
            return result is Success<TValue> s ? s.Value : default;
        }

        public static TValue? GetValueOrDefault<TValue, TError>(this Result<TValue, TError>? result)
        {
            return result is Success<TValue, TError> s ? s.Value : default;
        }

        public static async Task<TValue?> GetValueOrDefault<TValue>(this Task<Result<TValue>?> result)
        {
            return GetValueOrDefault(await result);
        }

        public static async Task<TValue?> GetValueOrDefault<TValue, TError>(this Task<Result<TValue, TError>?> result)
        {
            return GetValueOrDefault(await result);
        }
    }
}