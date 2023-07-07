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

        [Test]
        public void TestGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess()
        {
            var payload = new Payload();

            var result = new Success<Payload, Error>(payload);

            var value = result.GetValueOrDefault();

            Assert.That(value, Is.EqualTo(payload));
        }

        [Test]
        public async Task TestAsyncGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess()
        {
            var payload = new Payload();

            var result = Task.FromResult<Result<Payload, Error>?>(new Success<Payload, Error>(payload));

            var value = await result.GetValueOrDefault();

            Assert.That(value, Is.EqualTo(payload));
        }

        [Test]
        public void TestGetValueOrDefaultShouldReturnNullWhenResultIsFailure()
        {
            var error = new Error();

            var result = new Failure<Payload, Error>(error);

            var value = result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [Test]
        public async Task TestAsyncGetValueOrDefaultShouldReturnNullWhenResultIsFailure()
        {
            var error = new Error();

            var result = Task.FromResult<Result<Payload, Error>?>(new Failure<Payload, Error>(error));

            var value = await result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [Test]
        public void TestGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled()
        {
            var exception = new Exception();

            var result = new Unhandled<Payload, Error>(exception);

            var value = result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [Test]
        public async Task TestAsyncGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled()
        {
            var exception = new Exception();

            var result = Task.FromResult<Result<Payload, Error>?>(new Unhandled<Payload, Error>(exception));

            var value = await result.GetValueOrDefault();

            Assert.That(value, Is.Null);
        }

        [Test]
        public void TestHandleShouldCallSuccessCallbackOnly()
        {
            var payload = new Payload();
            var result = new Success<Payload, Error>(payload);

            var (success, failure, unhandled) = CreateVoidCallbacks();
            result.Handle(success, failure, unhandled);

            success.Received().Invoke(payload);
            failure.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [Test]
        public async Task TestAsyncHandleShouldCallSuccessCallbackOnly()
        {
            var payload = new Payload();
            var result = new Success<Payload, Error>(payload);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks();
            await result.Handle(success, failure, unhandled);

            await success.Received().Invoke(payload);
            await failure.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [Test]
        public void TestHandleShouldCallFailureCallbackOnly()
        {
            var error = new Error();
            var result = new Failure<Payload, Error>(error);

            var (success, failure, unhandled) = CreateVoidCallbacks();
            result.Handle(success, failure, unhandled);

            success.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure.Received().Invoke(error);
            unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [Test]
        public async Task TestAsyncHandleShouldCallFailureCallbackOnly()
        {
            var error = new Error();
            var result = new Failure<Payload, Error>(error);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks();
            await result.Handle(success, failure, unhandled);

            await success.DidNotReceive().Invoke(Arg.Any<Payload>());
            await failure.Received().Invoke(error);
            await unhandled.DidNotReceive().Invoke(Arg.Any<Exception>());
        }

        [Test]
        public void TestHandleShouldCallUnhandledCallbackOnly()
        {
            var exception = new Exception();
            var result = new Unhandled<Payload, Error>(exception);

            var (success, failure, unhandled) = CreateVoidCallbacks();
            result.Handle(success, failure, unhandled);

            success.DidNotReceive().Invoke(Arg.Any<Payload>());
            failure.DidNotReceive().Invoke(Arg.Any<Error>());
            unhandled.Received().Invoke(exception);
        }

        [Test]
        public async Task TestAsyncHandleShouldCallUnhandledCallbackOnly()
        {
            var exception = new Exception();
            var result = new Unhandled<Payload, Error>(exception);

            var (success, failure, unhandled) = CreateAsyncVoidCallbacks();
            await result.Handle(success, failure, unhandled);

            await success.DidNotReceive().Invoke(Arg.Any<Payload>());
            await failure.DidNotReceive().Invoke(Arg.Any<Error>());
            await unhandled.Received().Invoke(exception);
        }

        [Test]
        public void TestStackedHandlesShouldCallSuccessCallbacksOnly()
        {
            var payload = new Payload();

            var result = new Success<Payload, Error>(payload);

            var (success1, failure1, unhandled1) = CreateResultCallbacks();
            var (success2, failure2, unhandled2) = CreateResultCallbacks();
            var (success3, failure3, unhandled3) = CreateVoidCallbacks();

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

        [Test]
        public async Task TestStackedAsyncHandlesShouldCallSuccessCallbacksOnly()
        {
            var payload = new Payload();

            var result = new Success<Payload, Error>(payload);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks();
            var (success3, failure3, unhandled3) = CreateAsyncVoidCallbacks();

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

        [Test]
        public void TestStackedHandlesShouldCallSuccess1Failure2AndIgnoreAllOthersCallbacks()
        {
            var payload = new Payload();
            var error = new Error();

            var result = new Success<Payload, Error>(payload);

            var (success1, failure1, unhandled1) = CreateResultCallbacks();
            var (success2, failure2, unhandled2) = CreateResultCallbacks();
            var (success3, failure3, unhandled3) = CreateResultCallbacks();

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

        [Test]
        public void TestStackedHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks()
        {
            var exception = new Exception();

            var result = new Unhandled<Payload, Error>(exception);

            var (success1, failure1, unhandled1) = CreateResultCallbacks();
            var (success2, failure2, unhandled2) = CreateResultCallbacks();
            var (success3, failure3, unhandled3) = CreateResultCallbacks();

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

        [Test]
        public async Task TestStackedAsyncHandlesShouldCallSuccess1Failure2AndIgnoreAllOthersCallbacks()
        {
            var payload = new Payload();
            var error = new Error();

            var result = new Success<Payload, Error>(payload);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks();
            var (success3, failure3, unhandled3) = CreateAsyncResultCallbacks();

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

        [Test]
        public async Task TestStackedAsyncHandlesShouldCallUnhandled1IgnoreAllOthersCallbacks()
        {
            var exception = new Exception();

            var result = new Unhandled<Payload, Error>(exception);

            var (success1, failure1, unhandled1) = CreateAsyncResultCallbacks();
            var (success2, failure2, unhandled2) = CreateAsyncResultCallbacks();
            var (success3, failure3, unhandled3) = CreateAsyncResultCallbacks();

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

        private static (Action<Payload>, Action<Error>, Action<Exception>) CreateVoidCallbacks()
        {
            var success = Substitute.For<Action<Payload>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            return (success, failure, unhandled);
        }

        private static (Func<Payload, Task>, Func<Error, Task>, Func<Exception, Task>) CreateAsyncVoidCallbacks()
        {
            var success = Substitute.For<Func<Payload, Task>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            return (success, failure, unhandled);
        }

        private static (Func<Payload, Result<Payload, Error>>, Action<Error>, Action<Exception>) CreateResultCallbacks()
        {
            var success = Substitute.For<Func<Payload, Result<Payload, Error>>>();
            var failure = Substitute.For<Action<Error>>();
            var unhandled = Substitute.For<Action<Exception>>();
            return (success, failure, unhandled);
        }

        private static (Func<Payload, Task<Result<Payload, Error>>>, Func<Error, Task>, Func<Exception, Task>) CreateAsyncResultCallbacks()
        {
            var success = Substitute.For<Func<Payload, Task<Result<Payload, Error>>>>();
            var failure = Substitute.For<Func<Error, Task>>();
            var unhandled = Substitute.For<Func<Exception, Task>>();
            return (success, failure, unhandled);
        }
    }
}
