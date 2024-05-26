namespace Fourard.Result.Tests
{
    public partial class ExtensionsTests
    {
        [Test]
        public void TestHandleDeconstruction1() // TReturn? Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, TReturn> success, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2)>(values);
            var success = Substitute.For<Func<Value1, Value2, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction2() // TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction3() // TReturn? Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Action<TValue1, TValue2> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2)>(values);
            var success = Substitute.For<Action<Value1, Value2>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction4() // TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Action<Value1, Value2>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction5() // TReturn? Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2)>(values);
            var success = Substitute.For<Func<Value1, Value2, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction6() // TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction7() // TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction8() // TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Action<Value1, Value2>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction9() // TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction10() // TReturn? Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Action<Value1, Value2>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction11() // void Handle<TValue1, TValue2>(this Result<(TValue1, TValue2)>? result, Action<TValue1, TValue2>? success = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2)>(values);
            var success = Substitute.For<Action<Value1, Value2>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction12() // void Handle<TValue1, TValue2, TError>(this Result<(TValue1, TValue2), TError>? result, Action<TValue1, TValue2>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Action<Value1, Value2>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public void TestHandleDeconstruction13() // TReturn? Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction14() // TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction15() // TReturn? Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Action<TValue1, TValue2, TValue3> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction16() // TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction17() // TReturn? Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction18() // TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction19() // TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction20() // TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction21() // TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction22() // TReturn? Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction23() // void Handle<TValue1, TValue2, TValue3>(this Result<(TValue1, TValue2, TValue3)>? result, Action<TValue1, TValue2, TValue3>? success = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction24() // void Handle<TValue1, TValue2, TValue3, TError>(this Result<(TValue1, TValue2, TValue3), TError>? result, Action<TValue1, TValue2, TValue3>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public void TestHandleDeconstruction25() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction26() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction27() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction28() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction29() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction30() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction31() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction32() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction33() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction34() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction35() // void Handle<TValue1, TValue2, TValue3, TValue4>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Action<TValue1, TValue2, TValue3, TValue4>? success = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction36() // void Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Action<TValue1, TValue2, TValue3, TValue4>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public void TestHandleDeconstruction37() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction38() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction39() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction40() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction41() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction42() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction43() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction44() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction45() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction46() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction47() // void Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5>? success = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction48() // void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public void TestHandleDeconstruction49() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction50() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction51() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction52() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction53() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction54() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction55() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction56() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction57() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction58() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction59() // void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>? success = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction60() // void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public void TestHandleDeconstruction61() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction62() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction63() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction64() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction65() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction66() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction67() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction68() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction69() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction70() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction71() // void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>? success = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction72() // void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public void TestHandleDeconstruction73() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction74() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction75() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction76() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction77() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction78() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Action<TError> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Return>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction79() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction80() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction81() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn> success, Func<TError, TReturn> failure, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Return>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction82() // TReturn? Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> success, Func<TError, TReturn> failure, Func<Exception, TReturn> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8>>();
            var failure = Substitute.For<Func<Error, Return>>();
            var unhandled = Substitute.For<Func<Exception, Return>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction83() // void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>? success = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public void TestHandleDeconstruction84() // void Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>? success = null, Action<TError>? failure = null, Action<Exception>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Action<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            result.Handle(success, failure, unhandled);
            success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction85() // async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2)>(values);
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction86() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction87() // async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2)>(values);
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction88() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction89() // async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2)>(values);
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction90() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction91() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction92() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction93() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction94() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction95() // async Task Handle<TValue1, TValue2>(this Result<(TValue1, TValue2)>? result, Func<TValue1, TValue2, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2)>(values);
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction96() // async Task Handle<TValue1, TValue2, TError>(this Result<(TValue1, TValue2), TError>? result, Func<TValue1, TValue2, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = new Success<(Value1, Value2), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction97() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction98() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction99() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction100() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction101() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction102() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction103() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction104() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction105() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction106() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction107() // async Task Handle<TValue1, TValue2, TValue3>(this Result<(TValue1, TValue2, TValue3)>? result, Func<TValue1, TValue2, TValue3, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction108() // async Task Handle<TValue1, TValue2, TValue3, TError>(this Result<(TValue1, TValue2, TValue3), TError>? result, Func<TValue1, TValue2, TValue3, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = new Success<(Value1, Value2, Value3), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction109() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction110() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction111() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction112() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction113() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction114() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction115() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction116() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction117() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction118() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction119() // async Task Handle<TValue1, TValue2, TValue3, TValue4>(this Result<(TValue1, TValue2, TValue3, TValue4)>? result, Func<TValue1, TValue2, TValue3, TValue4, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction120() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Result<(TValue1, TValue2, TValue3, TValue4), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = new Success<(Value1, Value2, Value3, Value4), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction121() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction122() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction123() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction124() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction125() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction126() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction127() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction128() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction129() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction130() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction131() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction132() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction133() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction134() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction135() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction136() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction137() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction138() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction139() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction140() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction141() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction142() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction143() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction144() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction145() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction146() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction147() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction148() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction149() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction150() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction151() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction152() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction153() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction154() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction155() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction156() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction157() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction158() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction159() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction160() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction161() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction162() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>? result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values);
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction163() // async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2)>>(new Success<(Value1, Value2)>(values));
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction164() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2), Error>>(new Success<(Value1, Value2), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction165() // async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2)>>(new Success<(Value1, Value2)>(values));
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction166() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2), Error>>(new Success<(Value1, Value2), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction167() // async Task<TReturn?> Handle<TValue1, TValue2, TReturn>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2)>>(new Success<(Value1, Value2)>(values));
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction168() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2), Error>>(new Success<(Value1, Value2), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction169() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2), Error>>(new Success<(Value1, Value2), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction170() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2), Error>>(new Success<(Value1, Value2), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction171() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2), Error>>(new Success<(Value1, Value2), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction172() // async Task<TReturn?> Handle<TValue1, TValue2, TError, TReturn>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2), Error>>(new Success<(Value1, Value2), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction173() // async Task Handle<TValue1, TValue2>(this Task<Result<(TValue1, TValue2)>?> result, Func<TValue1, TValue2, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2)>>(new Success<(Value1, Value2)>(values));
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction174() // async Task Handle<TValue1, TValue2, TError>(this Task<Result<(TValue1, TValue2), TError>?> result, Func<TValue1, TValue2, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2());
            var result = Task.FromResult<Result<(Value1, Value2), Error>>(new Success<(Value1, Value2), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2());
        }

        [Test]
        public async Task TestHandleDeconstruction175() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3)>>(new Success<(Value1, Value2, Value3)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction176() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3), Error>>(new Success<(Value1, Value2, Value3), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction177() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3)>>(new Success<(Value1, Value2, Value3)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction178() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3), Error>>(new Success<(Value1, Value2, Value3), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction179() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TReturn>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3)>>(new Success<(Value1, Value2, Value3)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction180() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3), Error>>(new Success<(Value1, Value2, Value3), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction181() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3), Error>>(new Success<(Value1, Value2, Value3), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction182() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3), Error>>(new Success<(Value1, Value2, Value3), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction183() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3), Error>>(new Success<(Value1, Value2, Value3), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction184() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3), Error>>(new Success<(Value1, Value2, Value3), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction185() // async Task Handle<TValue1, TValue2, TValue3>(this Task<Result<(TValue1, TValue2, TValue3)>?> result, Func<TValue1, TValue2, TValue3, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3)>>(new Success<(Value1, Value2, Value3)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction186() // async Task Handle<TValue1, TValue2, TValue3, TError>(this Task<Result<(TValue1, TValue2, TValue3), TError>?> result, Func<TValue1, TValue2, TValue3, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3());
            var result = Task.FromResult<Result<(Value1, Value2, Value3), Error>>(new Success<(Value1, Value2, Value3), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3());
        }

        [Test]
        public async Task TestHandleDeconstruction187() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4)>>(new Success<(Value1, Value2, Value3, Value4)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction188() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4), Error>>(new Success<(Value1, Value2, Value3, Value4), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction189() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4)>>(new Success<(Value1, Value2, Value3, Value4)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction190() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4), Error>>(new Success<(Value1, Value2, Value3, Value4), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction191() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4)>>(new Success<(Value1, Value2, Value3, Value4)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction192() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4), Error>>(new Success<(Value1, Value2, Value3, Value4), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction193() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4), Error>>(new Success<(Value1, Value2, Value3, Value4), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction194() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4), Error>>(new Success<(Value1, Value2, Value3, Value4), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction195() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4), Error>>(new Success<(Value1, Value2, Value3, Value4), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction196() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4), Error>>(new Success<(Value1, Value2, Value3, Value4), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction197() // async Task Handle<TValue1, TValue2, TValue3, TValue4>(this Task<Result<(TValue1, TValue2, TValue3, TValue4)>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4)>>(new Success<(Value1, Value2, Value3, Value4)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction198() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4), Error>>(new Success<(Value1, Value2, Value3, Value4), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4());
        }

        [Test]
        public async Task TestHandleDeconstruction199() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5)>>(new Success<(Value1, Value2, Value3, Value4, Value5)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction200() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction201() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5)>>(new Success<(Value1, Value2, Value3, Value4, Value5)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction202() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction203() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5)>>(new Success<(Value1, Value2, Value3, Value4, Value5)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction204() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction205() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction206() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction207() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction208() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction209() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5)>>(new Success<(Value1, Value2, Value3, Value4, Value5)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction210() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5());
        }

        [Test]
        public async Task TestHandleDeconstruction211() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction212() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction213() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction214() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction215() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction216() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction217() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction218() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction219() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction220() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6());
        }

        [Test]
        public async Task TestHandleDeconstruction221() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction222() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction223() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction224() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction225() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction226() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction227() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction228() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction229() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction230() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7());
        }

        [Test]
        public async Task TestHandleDeconstruction231() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction232() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction233() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction234() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction235() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction236() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction237() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TReturn>> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task<Return>>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction238() // async Task<TReturn?> Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError, TReturn>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> success, Func<TError, Task<TReturn>> failure, Func<Exception, Task<TReturn>> unhandled)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var failure = Substitute.For<Func<Error, Task<Return>>>();
            var unhandled = Substitute.For<Func<Exception, Task<Return>>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction239() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8)>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task>? success = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8)>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }

        [Test]
        public async Task TestHandleDeconstruction240() // async Task Handle<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TError>(this Task<Result<(TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8), TError>?> result, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task>? success = null, Func<TError, Task>? failure = null, Func<Exception, Task>? unhandled = null)
        {
            var values = (new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
            var result = Task.FromResult<Result<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>>(new Success<(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8), Error>(values));
            var success = Substitute.For<Func<Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            await result!.Handle(success, failure, unhandled);
            await success.Received().Invoke(new Value1(), new Value2(), new Value3(), new Value4(), new Value5(), new Value6(), new Value7(), new Value8());
        }
    }
}