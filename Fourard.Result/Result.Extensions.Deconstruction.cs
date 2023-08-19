namespace Fourard.Result
{
    public static partial class ResultExtensions
    {
        public static TReturn? Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, TReturn> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Action<TValue1, TValue2> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2>(this Result<(TValue1, TValue2)>? result, Action<TValue1, TValue2>? success = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2), unhandled);
        }

        public static void Handle<TValue1, TValue2, TError>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Action<TValue1, TValue2, TValue3> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3>(this Result<(TValue1, TValue2, TValue3)>? result, Action<TValue1, TValue2, TValue3>? success = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TError>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Action<TValue1, TValue2, TValue3, TValue4>? success = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5>? success = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>? success = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>? success = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            return Handle(result, value => success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>? success = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public static void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            Handle(result, value => success?.Invoke(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2), failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2); }, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TError>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2); }, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3), failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3); }, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TError>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3); }, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4), failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4); }, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4); }, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5), failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5); }, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5); }, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6), failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6); }, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6); }, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7), failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7); }, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7); }, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(result, async value => await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8), failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8); }, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(result, async value => { if (success != null) await success(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Item8); }, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TError>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TError>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            return await Handle(await result, success, failure, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, unhandled);
        }

        public static async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            await Handle(await result, success, failure, unhandled);
        }
    }
}