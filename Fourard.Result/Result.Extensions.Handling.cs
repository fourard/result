namespace Fourard.Result
{
    public static partial class ResultExtensions
    {
        public static TReturn? Handle<TValue, TReturn>(this Result<TValue>? result, Func<TValue, TReturn> success, Action<Exception>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue> s: return success(s.Value);
                case Unhandled<TValue> u: unhandled?.Invoke(u.Exception); break;
            };

            return default;
        }

        public static TReturn? Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return success(s.Value);
                case Failure<TValue, TError> f: failure?.Invoke(f.Error); break;
                case Unhandled<TValue, TError> u: unhandled?.Invoke(u.Exception); break;
            };

            return default;
        }

        public static TReturn? Handle<TValue, TReturn>(this Result<TValue>? result, Action<TValue> success, Func<Exception, TReturn> unhandled)
        {
            switch (result)
            {
                case Success<TValue> s: success(s.Value); break;
                case Unhandled<TValue> u: return unhandled(u.Exception);
            };

            return default;
        }

        public static TReturn? Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Action<TValue> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            switch (result)
            {
                case Success<TValue, TError> s: success(s.Value); break;
                case Failure<TValue, TError> f: failure(f.Error); break;
                case Unhandled<TValue, TError> u: return unhandled(u.Exception);
            };

            return default;
        }

        public static TReturn? Handle<TValue, TReturn>(this Result<TValue>? result, Func<TValue, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            switch (result)
            {
                case Success<TValue> s: return success(s.Value);
                case Unhandled<TValue> u: return unhandled(u.Exception);
            };

            return default;
        }

        public static TReturn? Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return success(s.Value);
                case Failure<TValue, TError> f: failure(f.Error); break;
                case Unhandled<TValue, TError> u: return unhandled(u.Exception);
            };

            return default;
        }

        public static TReturn? Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return success(s.Value);
                case Failure<TValue, TError> f: return failure(f.Error);
                case Unhandled<TValue, TError> u: return unhandled(u.Exception);
            };

            return default;
        }

        public static TReturn? Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Action<TValue> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: success(s.Value); break;
                case Failure<TValue, TError> f: return failure(f.Error);
                case Unhandled<TValue, TError> u: unhandled?.Invoke(u.Exception); break;
            };

            return default;
        }

        public static TReturn? Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return success(s.Value);
                case Failure<TValue, TError> f: return failure(f.Error);
                case Unhandled<TValue, TError> u: unhandled?.Invoke(u.Exception); break;
            };

            return default;
        }

        public static TReturn? Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Action<TValue> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            switch (result)
            {
                case Success<TValue, TError> s: success(s.Value); break;
                case Failure<TValue, TError> f: return failure(f.Error);
                case Unhandled<TValue, TError> u: return unhandled(u.Exception);
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

        public static async Task<TReturn?> Handle<TValue, TReturn>(this Result<TValue>? result, Func<TValue, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue> s: return await success(s.Value);
                case Unhandled<TValue> u: if (unhandled != null) await unhandled(u.Exception); break;
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return await success(s.Value);
                case Failure<TValue, TError> f: if (failure != null) await failure(f.Error); break;
                case Unhandled<TValue, TError> u: if (unhandled != null) await unhandled(u.Exception); break;
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TReturn>(this Result<TValue>? result, Func<TValue, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            switch (result)
            {
                case Success<TValue> s: await success(s.Value); break;
                case Unhandled<TValue> u: return await unhandled(u.Exception);
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            switch (result)
            {
                case Success<TValue, TError> s: await success(s.Value); break;
                case Failure<TValue, TError> f: await failure(f.Error); break;
                case Unhandled<TValue, TError> u: return await unhandled(u.Exception);
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TReturn>(this Result<TValue>? result, Func<TValue, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            switch (result)
            {
                case Success<TValue> s: return await success(s.Value);
                case Unhandled<TValue> u: return await unhandled(u.Exception);
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return await success(s.Value);
                case Failure<TValue, TError> f: await failure(f.Error); break;
                case Unhandled<TValue, TError> u: return await unhandled(u.Exception);
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return await success(s.Value);
                case Failure<TValue, TError> f: return await failure(f.Error);
                case Unhandled<TValue, TError> u: return await unhandled(u.Exception);
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: await success(s.Value); break;
                case Failure<TValue, TError> f: return await failure(f.Error);
                case Unhandled<TValue, TError> u: if (unhandled != null) await unhandled(u.Exception); break;
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            switch (result)
            {
                case Success<TValue, TError> s: return await success(s.Value);
                case Failure<TValue, TError> f: return await failure(f.Error);
                case Unhandled<TValue, TError> u: if (unhandled != null) await unhandled(u.Exception); break;
            };

            return default;
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Result<TValue, TError>? result, Func<TValue, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            switch (result)
            {
                case Success<TValue, TError> s: await success(s.Value); break;
                case Failure<TValue, TError> f: return await failure(f.Error);
                case Unhandled<TValue, TError> u: return await unhandled(u.Exception);
            };

            return default;
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

        public static async Task<TReturn?> Handle<TValue, TReturn>(this Task<Result<TValue>?> result, Func<TValue, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Task<Result<TValue, TError>?> result, Func<TValue, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TReturn>(this Task<Result<TValue>?> result, Func<TValue, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Task<Result<TValue, TError>?> result, Func<TValue, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TReturn>(this Task<Result<TValue>?> result, Func<TValue, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Task<Result<TValue, TError>?> result, Func<TValue, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Task<Result<TValue, TError>?> result, Func<TValue, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Task<Result<TValue, TError>?> result, Func<TValue, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Task<Result<TValue, TError>?> result, Func<TValue, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue, TError, TReturn>(this Task<Result<TValue, TError>?> result, Func<TValue, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue>(this Task<Result<TValue>?> result, Func<TValue, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue, TError>(this Task<Result<TValue, TError>?> result, Func<TValue, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }
    }
}