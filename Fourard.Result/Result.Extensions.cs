namespace Fourard.Result
{
    public static partial class ResultExtensions
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

        public static TAction? Handle<TValue, TAction>(this Result<TValue>? result, Func<TValue, TAction> success, Action<Exception>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue> s: return success(s.Value);
                case Unhandled<TValue> u: unhandled?.Invoke(u.Exception); break;
            };

            return default;
        }

        public static TAction? Handle<TValue, TError, TAction>(this Result<TValue, TError>? result, Func<TValue, TAction> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return success(s.Value);
                case Failure<TValue, TError> f: failure?.Invoke(f.Error); break;
                case Unhandled<TValue, TError> u: unhandled?.Invoke(u.Exception); break;
            };

            return default;
        }

        public static void Handle<TValue>(this Result<TValue>? result, Action<TValue>? success = null, Action<Exception>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue> s: success?.Invoke(s.Value); break;
                case Unhandled<TValue> u: unhandled?.Invoke(u.Exception); break;
            };
        }

        public static void Handle<TValue, TError>(this Result<TValue, TError>? result, Action<TValue>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: success?.Invoke(s.Value); break;
                case Failure<TValue, TError> f: failure?.Invoke(f.Error); break;
                case Unhandled<TValue, TError> u: unhandled?.Invoke(u.Exception); break;
            };
        }

        public static async Task<TAction?> Handle<TValue, TAction>(this Task<Result<TValue>?> result, Func<TValue, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TAction?> Handle<TValue, TError, TAction>(this Task<Result<TValue, TError>?> result, Func<TValue, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TAction?> Handle<TValue, TAction>(this Result<TValue>? result, Func<TValue, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue> s: return await success(s.Value);
                case Unhandled<TValue> u: if (unhandled != null) await unhandled(u.Exception); break;
            };

            return default;
        }

        public static async Task<TAction?> Handle<TValue, TError, TAction>(this Result<TValue, TError>? result, Func<TValue, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return await success(s.Value);
                case Failure<TValue, TError> f: if (failure != null) await failure(f.Error); break;
                case Unhandled<TValue, TError> u: if (unhandled != null) await unhandled(u.Exception); break;
            };

            return default;
        }

        public static async Task Handle<TValue>(this Task<Result<TValue>?> result, Func<TValue, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue, TError>(this Task<Result<TValue, TError>?> result, Func<TValue, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue>(this Result<TValue>? result, Func<TValue, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue> s: if (success != null) await success(s.Value); break;
                case Unhandled<TValue> u: if (unhandled != null) await unhandled(u.Exception); break;
            };
        }

        public static async Task Handle<TValue, TError>(this Result<TValue, TError>? result, Func<TValue, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: if (success != null) await success(s.Value); break;
                case Failure<TValue, TError> f: if (failure != null) await failure(f.Error); break;
                case Unhandled<TValue, TError> u: if (unhandled != null) await unhandled(u.Exception); break;
            };
        }
    }
}