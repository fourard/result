namespace Fourard.Result.Tests
{
    public partial class ExtensionsTests
    {
        [TestCase(typeof(Value))]
        public void TestHandleShouldCallSuccessCallbackOnly(Type TValue)
        {
            var value = new Value();
            var result = new Success<Value>(value);

            var (success, unhandled) = CreateVoidCallbacks<Value>();
            result.Handle(success, unhandled);

            success.Received().Invoke(value);
            unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestHandleShouldCallSuccessCallbackOnly(Type TValue, Type TError)
        {
            var value = new Value();
            var result = new Success<Value, Error>(value);

            var (success, failure, unhandled) = CreateVoidCallbacks<Value, Error>();
            result.Handle(success, failure, unhandled);

            success.Received().Invoke(value);
            failure.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value))]
        public async Task TestAsyncHandleShouldCallSuccessCallbackOnly(Type TValue)
        {
            var value = new Value();
            var result = new Success<Value>(value);

            var (success, unhandled) = CreateAsyncVoidCallbacks<Value>();
            await result.Handle(success, unhandled);

            await success.Received().Invoke(value);
            await unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestAsyncHandleShouldCallSuccessCallbackOnly(Type TValue, Type TError)
        {
            var value = new Value();
            var result = new Success<Value, Error>(value);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks<Value, Error>();
            await result.Handle(success, failure, unhandled);

            await success.Received().Invoke(value);
            await failure.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestHandleShouldCallFailureCallbackOnly(Type TValue, Type TError)
        {
            var error = new Error();
            var result = new Failure<Value, Error>(error);

            var (success, failure, unhandled) = CreateVoidCallbacks<Value, Error>();
            result.Handle(success, failure, unhandled);

            success.DidNotReceive().Invoke(Arg.Any<Value>());
            failure.Received().Invoke(error);
            unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestAsyncHandleShouldCallFailureCallbackOnly(Type TValue, Type TError)
        {
            var error = new Error();
            var result = new Failure<Value, Error>(error);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks<Value, Error>();
            await result.Handle(success, failure, unhandled);

            await success.DidNotReceive().Invoke(Arg.Any<Value>());
            await failure.Received().Invoke(error);
            await unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value))]
        public void TestHandleShouldCallUnhandledCallbackOnly(Type TValue)
        {
            var exception = new Exception();
            var result = new Unhandled<Value>(exception);

            var (success, unhandled) = CreateVoidCallbacks<Value>();
            result.Handle(success, unhandled);

            success.DidNotReceive().Invoke(Arg.Any<Value>());
            unhandled.Received().Invoke(exception);
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestHandleShouldCallUnhandledCallbackOnly(Type TValue, Type TError)
        {
            var exception = new Exception();
            var result = new Unhandled<Value, Error>(exception);

            var (success, failure, unhandled) = CreateVoidCallbacks<Value, Error>();
            result.Handle(success, failure, unhandled);

            success.DidNotReceive().Invoke(Arg.Any<Value>());
            failure.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled.Received().Invoke(exception);
        }

        [TestCase(typeof(Value))]
        public async Task TestAsyncHandleShouldCallUnhandledCallbackOnly(Type TValue)
        {
            var exception = new Exception();
            var result = new Unhandled<Value>(exception);

            var (success, unhandled) = CreateAsyncVoidCallbacks<Value>();
            await result.Handle(success, unhandled);

            await success.DidNotReceive().Invoke(Arg.Any<Value>());
            await unhandled.Received().Invoke(exception);
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestAsyncHandleShouldCallUnhandledCallbackOnly(Type TValue, Type TError)
        {
            var exception = new Exception();
            var result = new Unhandled<Value, Error>(exception);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks<Value, Error>();
            await result.Handle(success, failure, unhandled);

            await success.DidNotReceive().Invoke(Arg.Any<Value>());
            await failure.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled.Received().Invoke(exception);
        }

        [TestCase(typeof(Value))]
        public void TestStackedHandlesShouldCallSuccessCallbacksOnly(Type TValue)
        {
            var value = new Value();

            var result = new Success<Value>(value);

            var (success1, unhandled1) = CreateResultCallbacks<Value>();
            var (success2, unhandled2) = CreateResultCallbacks<Value>();
            var (success3, unhandled3) = CreateVoidCallbacks<Value>();

            success1.Invoke(value).Returns(new Success<Value>(value));
            success2.Invoke(value).Returns(new Success<Value>(value));

            result
                .Handle(success1, unhandled1)
                .Handle(success2, unhandled2)
                .Handle(success3, unhandled3);

            success1.Received().Invoke(value);
            unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            success2.Received().Invoke(value);
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.Received().Invoke(value);
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestStackedHandlesShouldCallSuccessCallbacksOnly(Type TValue, Type TError)
        {
            var value = new Value();

            var result = new Success<Value, Error>(value);

            var (success1, failure1, unhandled1) = CreateResultCallbacks<Value, Error>();
            var (success2, failure2, unhandled2) = CreateResultCallbacks<Value, Error>();
            var (success3, failure3, unhandled3) = CreateVoidCallbacks<Value, Error>();

            success1.Invoke(value).Returns(new Success<Value, Error>(value));
            success2.Invoke(value).Returns(new Success<Value, Error>(value));

            result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            success1.Received().Invoke(value);
            failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            success2.Received().Invoke(value);
            failure2.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.Received().Invoke(value);
            failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value))]
        public async Task TestStackedAsyncHandlesShouldCallSuccessCallbacksOnly(Type TValue)
        {
            var value = new Value();

            var result = new Success<Value>(value);

            var (success1, unhandled1) = CreateAsyncResultCallbacks<Value>();
            var (success2, unhandled2) = CreateAsyncResultCallbacks<Value>();
            var (success3, unhandled3) = CreateAsyncVoidCallbacks<Value>();

            success1.Invoke(value).Returns(new Success<Value>(value));
            success2.Invoke(value).Returns(new Success<Value>(value));

            await result
                .Handle(success1, unhandled1)
                .Handle(success2, unhandled2)
                .Handle(success3, unhandled3);

            await success1.Received().Invoke(value);
            await unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success2.Received().Invoke(value);
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.Received().Invoke(value);
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestStackedAsyncHandlesShouldCallSuccessCallbacksOnly(Type TValue, Type TError)
        {
            var value = new Value();

            var result = new Success<Value, Error>(value);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks<Value, Error>();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks<Value, Error>();
            var (success3, failure3, unhandled3) = CreateAsyncVoidCallbacks<Value, Error>();

            success1.Invoke(value).Returns(new Success<Value, Error>(value));
            success2.Invoke(value).Returns(new Success<Value, Error>(value));

            await result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            await success1.Received().Invoke(value);
            await failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success2.Received().Invoke(value);
            await failure2.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.Received().Invoke(value);
            await failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestStackedHandlesShouldCallSuccess1Failure2AndIgnoreAllOthersCallbacks(Type TValue, Type TError)
        {
            var value = new Value();
            var error = new Error();

            var result = new Success<Value, Error>(value);

            var (success1, failure1, unhandled1) = CreateResultCallbacks<Value, Error>();
            var (success2, failure2, unhandled2) = CreateResultCallbacks<Value, Error>();
            var (success3, failure3, unhandled3) = CreateResultCallbacks<Value, Error>();

            success1.Invoke(value).Returns(new Failure<Value, Error>(error));

            result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            success1.Received().Invoke(value);
            failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            success2.DidNotReceive().Invoke(Arg.Any<Value>());
            failure2.Received().Invoke(error);
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.DidNotReceive().Invoke(Arg.Any<Value>());
            failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value))]
        public void TestStackedHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks(Type TValue)
        {
            var exception = new Exception();

            var result = new Unhandled<Value>(exception);

            var (success1, unhandled1) = CreateResultCallbacks<Value>();
            var (success2, unhandled2) = CreateResultCallbacks<Value>();
            var (success3, unhandled3) = CreateResultCallbacks<Value>();

            result
                .Handle(success1, unhandled1)
                .Handle(success2, unhandled2)
                .Handle(success3, unhandled3);

            success1.DidNotReceive().Invoke(Arg.Any<Value>());
            unhandled1.Received().Invoke(exception);

            success2.DidNotReceive().Invoke(Arg.Any<Value>());
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.DidNotReceive().Invoke(Arg.Any<Value>());
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestStackedHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks(Type TValue, Type TError)
        {
            var exception = new Exception();

            var result = new Unhandled<Value, Error>(exception);

            var (success1, failure1, unhandled1) = CreateResultCallbacks<Value, Error>();
            var (success2, failure2, unhandled2) = CreateResultCallbacks<Value, Error>();
            var (success3, failure3, unhandled3) = CreateResultCallbacks<Value, Error>();

            result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            success1.DidNotReceive().Invoke(Arg.Any<Value>());
            failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled1.Received().Invoke(exception);

            success2.DidNotReceive().Invoke(Arg.Any<Value>());
            failure2.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.DidNotReceive().Invoke(Arg.Any<Value>());
            failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestStackedAsyncHandlesShouldCallSuccess1Failure2AndIgnoreAllOthersCallbacks(Type TValue, Type TError)
        {
            var value = new Value();
            var error = new Error();

            var result = new Success<Value, Error>(value);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks<Value, Error>();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks<Value, Error>();
            var (success3, failure3, unhandled3) = CreateAsyncResultCallbacks<Value, Error>();

            success1.Invoke(value).Returns(new Failure<Value, Error>(error));

            await result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            await success1.Received().Invoke(value);
            await failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success2.DidNotReceive().Invoke(Arg.Any<Value>());
            await failure2.Received().Invoke(error);
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.DidNotReceive().Invoke(Arg.Any<Value>());
            await failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value))]
        public async Task TestStackedAsyncHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks(Type TValue)
        {
            var exception = new Exception();

            var result = new Unhandled<Value>(exception);

            var (success1, unhandled1) = CreateAsyncResultCallbacks<Value>();
            var (success2, unhandled2) = CreateAsyncResultCallbacks<Value>();
            var (success3, unhandled3) = CreateAsyncResultCallbacks<Value>();

            await result
                .Handle(success1, unhandled1)
                .Handle(success2, unhandled2)
                .Handle(success3, unhandled3);

            await success1.DidNotReceive().Invoke(Arg.Any<Value>());
            await unhandled1.Received().Invoke(exception);

            await success2.DidNotReceive().Invoke(Arg.Any<Value>());
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.DidNotReceive().Invoke(Arg.Any<Value>());
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestStackedAsyncHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks(Type TValue, Type TError)
        {
            var exception = new Exception();

            var result = new Unhandled<Value, Error>(exception);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks<Value, Error>();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks<Value, Error>();
            var (success3, failure3, unhandled3) = CreateAsyncResultCallbacks<Value, Error>();

            await result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            await success1.DidNotReceive().Invoke(Arg.Any<Value>());
            await failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled1.Received().Invoke(exception);

            await success2.DidNotReceive().Invoke(Arg.Any<Value>());
            await failure2.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.DidNotReceive().Invoke(Arg.Any<Value>());
            await failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        private static (Action<TValue>, Action<Exception>) CreateVoidCallbacks<TValue>()
        {
            var success = Substitute.For<Action<TValue>>();
            var unhandled = Substitute.For<Action<Exception>>();
            return (success, unhandled);
        }

        private static (Action<TValue>, Action<TError>, Action<Exception>) CreateVoidCallbacks<TValue, TError>()
        {
            var success = Substitute.For<Action<TValue>>();
            var failure = Substitute.For<Action<TError>>();
            var unhandled = Substitute.For<Action<Exception>>();
            return (success, failure, unhandled);
        }

        private static (Func<TValue, Task>, Func<Exception, Task>) CreateAsyncVoidCallbacks<TValue>()
        {
            var success = Substitute.For<Func<TValue, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            return (success, unhandled);
        }

        private static (Func<TValue, Task>, Func<TError, Task>, Func<Exception, Task>) CreateAsyncVoidCallbacks<TValue, TError>()
        {
            var success = Substitute.For<Func<TValue, Task>>();
            var failure = Substitute.For<Func<TError, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            return (success, failure, unhandled);
        }

        private static (Func<TValue, Result<TValue>>, Action<Exception>) CreateResultCallbacks<TValue>()
        {
            var success = Substitute.For<Func<TValue, Result<TValue>>>();
            var unhandled = Substitute.For<Action<Exception>>();
            return (success, unhandled);
        }

        private static (Func<TValue, Result<TValue, TError>>, Action<TError>, Action<Exception>) CreateResultCallbacks<TValue, TError>()
        {
            var success = Substitute.For<Func<TValue, Result<TValue, TError>>>();
            var failure = Substitute.For<Action<TError>>();
            var unhandled = Substitute.For<Action<Exception>>();
            return (success, failure, unhandled);
        }

        private static (Func<TValue, Task<Result<TValue>>>, Func<Exception, Task>) CreateAsyncResultCallbacks<TValue>()
        {
            var success = Substitute.For<Func<TValue, Task<Result<TValue>>>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            return (success, unhandled);
        }

        private static (Func<TValue, Task<Result<TValue, TError>>>, Func<TError, Task>, Func<Exception, Task>) CreateAsyncResultCallbacks<TValue, TError>()
        {
            var success = Substitute.For<Func<TValue, Task<Result<TValue, TError>>>>();
            var failure = Substitute.For<Func<TError, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            return (success, failure, unhandled);
        }
    }
}
