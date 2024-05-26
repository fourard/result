namespace Fourard.Result.Tests
{
    public partial class ExtensionsTests
    {
        [TestCase(typeof(Value))]
        public void TestGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess(Type TValue)
        {
            var value = new Value();

            var result = new Success<Value>(value);

            var content = result.GetValueOrDefault();

            Assert.That(content, Is.EqualTo(value));
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess(Type TValue, Type TError)
        {
            var value = new Value();

            var result = new Success<Value, Error>(value);

            var content = result.GetValueOrDefault();

            Assert.That(content, Is.EqualTo(value));
        }

        [TestCase(typeof(Value))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess(Type TValue)
        {
            var value = new Value();

            var result = Task.FromResult<Result<Value>?>(new Success<Value>(value));

            var content = await result.GetValueOrDefault();

            Assert.That(content, Is.EqualTo(value));
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnCorrectValueWhenResultIsSuccess(Type TValue, Type TError)
        {
            var value = new Value();

            var result = Task.FromResult<Result<Value, Error>?>(new Success<Value, Error>(value));

            var content = await result.GetValueOrDefault();

            Assert.That(content, Is.EqualTo(value));
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestGetValueOrDefaultShouldReturnNullWhenResultIsFailure(Type TValue, Type TError)
        {
            var error = new Error();

            var result = new Failure<Value, Error>(error);

            var content = result.GetValueOrDefault();

            Assert.That(content, Is.Null);
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnNullWhenResultIsFailure(Type TValue, Type TError)
        {
            var error = new Error();

            var result = Task.FromResult<Result<Value, Error>?>(new Failure<Value, Error>(error));

            var content = await result.GetValueOrDefault();

            Assert.That(content, Is.Null);
        }

        [TestCase(typeof(Value))]
        public void TestGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled(Type TValue)
        {
            var exception = new Exception();

            var result = new Unhandled<Value>(exception);

            var content = result.GetValueOrDefault();

            Assert.That(content, Is.Null);
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled(Type TValue, Type TError)
        {
            var exception = new Exception();

            var result = new Unhandled<Value, Error>(exception);

            var content = result.GetValueOrDefault();

            Assert.That(content, Is.Null);
        }

        [TestCase(typeof(Value))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled(Type TValue)
        {
            var exception = new Exception();

            var result = Task.FromResult<Result<Value>?>(new Unhandled<Value>(exception));

            var content = await result.GetValueOrDefault();

            Assert.That(content, Is.Null);
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestAsyncGetValueOrDefaultShouldReturnNullWhenResultIsUnhandled(Type TValue, Type TError)
        {
            var exception = new Exception();

            var result = Task.FromResult<Result<Value, Error>?>(new Unhandled<Value, Error>(exception));

            var content = await result.GetValueOrDefault();

            Assert.That(content, Is.Null);
        }
    }
}
