namespace Fourard.Result.Tests
{
    public class ResultExtensionTests
    {
        public class Payload
        {
        }

        public class Error
        {
        }

        [TestCase(typeof(Payload))]
        public void TestGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess(Type TValue)
        {
            var payload = new Payload();

            var result = new Success<Payload>(payload);

            var value = result.GetValueOrDefault();

            Assert.That(value, Is.EqualTo(payload));
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess(Type TValue, Type TError)
        {
            var payload = new Payload();

            var result = new Success<Payload, Error>(payload);

            var value = result.GetValueOrDefault();

            Assert.That(value, Is.EqualTo(payload));
        }

        [TestCase(typeof(Payload))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess(Type TValue)
        {
            var payload = new Payload();

            var result = Task.FromResult<Result<Payload>?>(new Success<Payload>(payload));

            var value = await result.GetValueOrDefault();

            Assert.That(value, Is.EqualTo(payload));
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess(Type TValue, Type TError)
        {
            var payload = new Payload();

            var result = Task.FromResult<Result<Payload, Error>?>(new Success<Payload, Error>(payload));

            var value = await result.GetValueOrDefault();

            Assert.That(value, Is.EqualTo(payload));
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestGetValueOrDefaultShouldReturnNullWhenResultIsFailure(Type TValue, Type TError)
        {
            var error = new Error();

            var result = new Failure<Payload, Error>(error);

            var value = result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnNullWhenResultIsFailure(Type TValue, Type TError)
        {
            var error = new Error();

            var result = Task.FromResult<Result<Payload, Error>?>(new Failure<Payload, Error>(error));

            var value = await result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [TestCase(typeof(Payload))]
        public void TestGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled(Type TValue)
        {
            var exception = new Exception();

            var result = new Unhandled<Payload>(exception);

            var value = result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled(Type TValue, Type TError)
        {
            var exception = new Exception();

            var result = new Unhandled<Payload, Error>(exception);

            var value = result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [TestCase(typeof(Payload))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled(Type TValue)
        {
            var exception = new Exception();

            var result = Task.FromResult<Result<Payload>?>(new Unhandled<Payload>(exception));

            var value = await result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled(Type TValue, Type TError)
        {
            var exception = new Exception();

            var result = Task.FromResult<Result<Payload, Error>?>(new Unhandled<Payload, Error>(exception));

            var value = await result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [TestCase(typeof(Payload))]
        public void TestHandleShouldCallSuccessCallbackOnly(Type TValue)
        {
            var payload = new Payload();
            var result = new Success<Payload>(payload);

            var (success, unhandled) = CreateVoidCallbacks<Payload>();
            result.Handle(success, unhandled);

            success.Received().Invoke(payload);
            unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestHandleShouldCallSuccessCallbackOnly(Type TValue, Type TError)
        {
            var payload = new Payload();
            var result = new Success<Payload, Error>(payload);

            var (success, failure, unhandled) = CreateVoidCallbacks<Payload, Error>();
            result.Handle(success, failure, unhandled);

            success.Received().Invoke(payload);
            failure.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload))]
        public async Task TestAsyncHandleShouldCallSuccessCallbackOnly(Type TValue)
        {
            var payload = new Payload();
            var result = new Success<Payload>(payload);

            var (success, unhandled) = CreateAsyncVoidCallbacks<Payload>();
            await result.Handle(success, unhandled);

            await success.Received().Invoke(payload);
            await unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestAsyncHandleShouldCallSuccessCallbackOnly(Type TValue, Type TError)
        {
            var payload = new Payload();
            var result = new Success<Payload, Error>(payload);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks<Payload, Error>();
            await result.Handle(success, failure, unhandled);

            await success.Received().Invoke(payload);
            await failure.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestHandleShouldCallFailureCallbackOnly(Type TValue, Type TError)
        {
            var error = new Error();
            var result = new Failure<Payload, Error>(error);

            var (success, failure, unhandled) = CreateVoidCallbacks<Payload, Error>();
            result.Handle(success, failure, unhandled);

            success.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure.Received().Invoke(error);
            unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestAsyncHandleShouldCallFailureCallbackOnly(Type TValue, Type TError)
        {
            var error = new Error();
            var result = new Failure<Payload, Error>(error);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks<Payload, Error>();
            await result.Handle(success, failure, unhandled);

            await success.DidNotReceive().Invoke(Arg.Any<Payload>());
            await failure.Received().Invoke(error);
            await unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload))]
        public void TestHandleShouldCallUnhandledCallbackOnly(Type TValue)
        {
            var exception = new Exception();
            var result = new Unhandled<Payload>(exception);

            var (success, unhandled) = CreateVoidCallbacks<Payload>();
            result.Handle(success, unhandled);

            success.DidNotReceive().Invoke(Arg.Any<Payload>());
            unhandled.Received().Invoke(exception);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestHandleShouldCallUnhandledCallbackOnly(Type TValue, Type TError)
        {
            var exception = new Exception();
            var result = new Unhandled<Payload, Error>(exception);

            var (success, failure, unhandled) = CreateVoidCallbacks<Payload, Error>();
            result.Handle(success, failure, unhandled);

            success.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled.Received().Invoke(exception);
        }

        [TestCase(typeof(Payload))]
        public async Task TestAsyncHandleShouldCallUnhandledCallbackOnly(Type TValue)
        {
            var exception = new Exception();
            var result = new Unhandled<Payload>(exception);

            var (success, unhandled) = CreateAsyncVoidCallbacks<Payload>();
            await result.Handle(success, unhandled);

            await success.DidNotReceive().Invoke(Arg.Any<Payload>());
            await unhandled.Received().Invoke(exception);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestAsyncHandleShouldCallUnhandledCallbackOnly(Type TValue, Type TError)
        {
            var exception = new Exception();
            var result = new Unhandled<Payload, Error>(exception);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks<Payload, Error>();
            await result.Handle(success, failure, unhandled);

            await success.DidNotReceive().Invoke(Arg.Any<Payload>());
            await failure.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled.Received().Invoke(exception);
        }

        [TestCase(typeof(Payload))]
        public void TestStackedHandlesShouldCallSuccessCallbacksOnly(Type TValue)
        {
            var payload = new Payload();

            var result = new Success<Payload>(payload);

            var (success1, unhandled1) = CreateResultCallbacks<Payload>();
            var (success2, unhandled2) = CreateResultCallbacks<Payload>();
            var (success3, unhandled3) = CreateVoidCallbacks<Payload>();

            success1.Invoke(payload).Returns(new Success<Payload>(payload));
            success2.Invoke(payload).Returns(new Success<Payload>(payload));

            result
                .Handle(success1, unhandled1)
                .Handle(success2, unhandled2)
                .Handle(success3, unhandled3);

            success1.Received().Invoke(payload);
            unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            success2.Received().Invoke(payload);
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.Received().Invoke(payload);
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestStackedHandlesShouldCallSuccessCallbacksOnly(Type TValue, Type TError)
        {
            var payload = new Payload();

            var result = new Success<Payload, Error>(payload);

            var (success1, failure1, unhandled1) = CreateResultCallbacks<Payload, Error>();
            var (success2, failure2, unhandled2) = CreateResultCallbacks<Payload, Error>();
            var (success3, failure3, unhandled3) = CreateVoidCallbacks<Payload, Error>();

            success1.Invoke(payload).Returns(new Success<Payload, Error>(payload));
            success2.Invoke(payload).Returns(new Success<Payload, Error>(payload));

            result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            success1.Received().Invoke(payload);
            failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            success2.Received().Invoke(payload);
            failure2.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.Received().Invoke(payload);
            failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload))]
        public async Task TestStackedAsyncHandlesShouldCallSuccessCallbacksOnly(Type TValue)
        {
            var payload = new Payload();

            var result = new Success<Payload>(payload);

            var (success1, unhandled1) = CreateAsyncResultCallbacks<Payload>();
            var (success2, unhandled2) = CreateAsyncResultCallbacks<Payload>();
            var (success3, unhandled3) = CreateAsyncVoidCallbacks<Payload>();

            success1.Invoke(payload).Returns(new Success<Payload>(payload));
            success2.Invoke(payload).Returns(new Success<Payload>(payload));

            await result
                .Handle(success1, unhandled1)
                .Handle(success2, unhandled2)
                .Handle(success3, unhandled3);

            await success1.Received().Invoke(payload);
            await unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success2.Received().Invoke(payload);
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.Received().Invoke(payload);
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestStackedAsyncHandlesShouldCallSuccessCallbacksOnly(Type TValue, Type TError)
        {
            var payload = new Payload();

            var result = new Success<Payload, Error>(payload);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks<Payload, Error>();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks<Payload, Error>();
            var (success3, failure3, unhandled3) = CreateAsyncVoidCallbacks<Payload, Error>();

            success1.Invoke(payload).Returns(new Success<Payload, Error>(payload));
            success2.Invoke(payload).Returns(new Success<Payload, Error>(payload));

            await result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            await success1.Received().Invoke(payload);
            await failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success2.Received().Invoke(payload);
            await failure2.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.Received().Invoke(payload);
            await failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestStackedHandlesShouldCallSuccess1Failure2AndIgnoreAllOthersCallbacks(Type TValue, Type TError)
        {
            var payload = new Payload();
            var error = new Error();

            var result = new Success<Payload, Error>(payload);

            var (success1, failure1, unhandled1) = CreateResultCallbacks<Payload, Error>();
            var (success2, failure2, unhandled2) = CreateResultCallbacks<Payload, Error>();
            var (success3, failure3, unhandled3) = CreateResultCallbacks<Payload, Error>();

            success1.Invoke(payload).Returns(new Failure<Payload, Error>(error));

            result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            success1.Received().Invoke(payload);
            failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            success2.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure2.Received().Invoke(error);
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload))]
        public void TestStackedHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks(Type TValue)
        {
            var exception = new Exception();

            var result = new Unhandled<Payload>(exception);

            var (success1, unhandled1) = CreateResultCallbacks<Payload>();
            var (success2, unhandled2) = CreateResultCallbacks<Payload>();
            var (success3, unhandled3) = CreateResultCallbacks<Payload>();

            result
                .Handle(success1, unhandled1)
                .Handle(success2, unhandled2)
                .Handle(success3, unhandled3);

            success1.DidNotReceive().Invoke(Arg.Any<Payload>());
            unhandled1.Received().Invoke(exception);

            success2.DidNotReceive().Invoke(Arg.Any<Payload>());
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.DidNotReceive().Invoke(Arg.Any<Payload>());
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestStackedHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks(Type TValue, Type TError)
        {
            var exception = new Exception();

            var result = new Unhandled<Payload, Error>(exception);

            var (success1, failure1, unhandled1) = CreateResultCallbacks<Payload, Error>();
            var (success2, failure2, unhandled2) = CreateResultCallbacks<Payload, Error>();
            var (success3, failure3, unhandled3) = CreateResultCallbacks<Payload, Error>();

            result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            success1.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled1.Received().Invoke(exception);

            success2.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure2.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            success3.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestStackedAsyncHandlesShouldCallSuccess1Failure2AndIgnoreAllOthersCallbacks(Type TValue, Type TError)
        {
            var payload = new Payload();
            var error = new Error();

            var result = new Success<Payload, Error>(payload);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks<Payload, Error>();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks<Payload, Error>();
            var (success3, failure3, unhandled3) = CreateAsyncResultCallbacks<Payload, Error>();

            success1.Invoke(payload).Returns(new Failure<Payload, Error>(error));

            await result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            await success1.Received().Invoke(payload);
            await failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled1.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success2.DidNotReceive().Invoke(Arg.Any<Payload>());
            await failure2.Received().Invoke(error);
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.DidNotReceive().Invoke(Arg.Any<Payload>());
            await failure3.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload))]
        public async Task TestStackedAsyncHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks(Type TValue)
        {
            var exception = new Exception();

            var result = new Unhandled<Payload>(exception);

            var (success1, unhandled1) = CreateAsyncResultCallbacks<Payload>();
            var (success2, unhandled2) = CreateAsyncResultCallbacks<Payload>();
            var (success3, unhandled3) = CreateAsyncResultCallbacks<Payload>();

            await result
                .Handle(success1, unhandled1)
                .Handle(success2, unhandled2)
                .Handle(success3, unhandled3);

            await success1.DidNotReceive().Invoke(Arg.Any<Payload>());
            await unhandled1.Received().Invoke(exception);

            await success2.DidNotReceive().Invoke(Arg.Any<Payload>());
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.DidNotReceive().Invoke(Arg.Any<Payload>());
            await unhandled3.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestStackedAsyncHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks(Type TValue, Type TError)
        {
            var exception = new Exception();

            var result = new Unhandled<Payload, Error>(exception);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks<Payload, Error>();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks<Payload, Error>();
            var (success3, failure3, unhandled3) = CreateAsyncResultCallbacks<Payload, Error>();

            await result
                .Handle(success1, failure1, unhandled1)
                .Handle(success2, failure2, unhandled2)
                .Handle(success3, failure3, unhandled3);

            await success1.DidNotReceive().Invoke(Arg.Any<Payload>());
            await failure1.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled1.Received().Invoke(exception);

            await success2.DidNotReceive().Invoke(Arg.Any<Payload>());
            await failure2.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled2.DidNotReceive().Invoke(Arg.Any<Exception>());

            await success3.DidNotReceive().Invoke(Arg.Any<Payload>());
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
