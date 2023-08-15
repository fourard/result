namespace Fourard.Result
{
    public static partial class ResultExtensions
    {
        public static TAction? Handle<TValue1, TValue2, TAction>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, TAction> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2), unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TError, TAction>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TAction> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TAction>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, TAction> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TError, TAction>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TAction> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, TAction> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TAction> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TAction> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TAction> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TAction> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TAction> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TAction> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TAction> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TAction> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public static TAction? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TAction> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2>(this Result<(TValue1, TValue2)>? result, Action<TValue1, TValue2> success, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2), unhandled);
        }

        public static void Handle<TValue1, TValue2, TError>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3>(this Result<(TValue1, TValue2, TValue3)>? result, Action<TValue1, TValue2, TValue3> success, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TError>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TAction>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TError, TAction>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TAction>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TError, TAction>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TAction>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TAction>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TError, TAction>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TAction>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TError, TAction>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TAction>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public async static Task<TAction?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TAction>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TAction>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TError>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TError>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2), unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TError>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TError>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public async static Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }
    }
}