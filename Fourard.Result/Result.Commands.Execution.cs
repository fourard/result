namespace Fourard.Result
{
    public static class Commands
    {
        public static Result<TValue> Exec<TValue>(Func<Result<TValue>> action)
        {
            try
            {
                return action();
            }
            catch (Exception exception)
            {
                return exception;
            }
        }

        public static async Task<Result<TValue>> Exec<TValue>(Func<Task<Result<TValue>>> action)
        {
            try
            {
                return await action();
            }
            catch (Exception exception)
            {
                return exception;
            }
        }

        public static Result<TValue, TError> Exec<TValue, TError>(Func<Result<TValue, TError>> action)
        {
            try
            {
                return action();
            }
            catch (Exception exception)
            {
                return exception;
            }
        }

        public static async Task<Result<TValue, TError>> Exec<TValue, TError>(Func<Task<Result<TValue, TError>>> action)
        {
            try
            {
                return await action();
            }
            catch (Exception exception)
            {
                return exception;
            }
        }
    }
}