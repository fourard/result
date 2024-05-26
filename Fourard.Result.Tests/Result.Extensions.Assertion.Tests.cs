namespace Fourard.Result.Tests
{
    public partial class ExecuteTests
    {
        [TestCase(typeof(Value))]
        public void TestIsSuccessShouldReturnTrueWhenSuccessResult(Type TValue)
        {
            Result<Value> result = new Success<Value>(new Value());

            Assert.Multiple(() =>
            {
                Assert.That(result.IsSuccess(out var value), Is.True);
                Assert.That(value, Is.InstanceOf<Value>());
            });
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestIsSuccessShouldReturnTrueWhenSuccessResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Success<Value, Error>(new Value());

            Assert.Multiple(() =>
            {
                Assert.That(result.IsSuccess(out var value), Is.True);
                Assert.That(value, Is.InstanceOf<Value>());
            });
        }

        [TestCase(typeof(Value))]
        public void TestIsSuccessShouldReturnFalseWhenOtherResult(Type TValue)
        {
            Result<Value> result = new Unhandled<Value>(new Exception());

            Assert.Multiple(() =>
            {
                Assert.That(result.IsSuccess(out var value), Is.False);
                Assert.That(value, Is.Null);
            });
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestIsSuccessShouldReturnFalseWhenOtherResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Failure<Value, Error>(new Error());

            Assert.Multiple(() =>
            {
                Assert.That(result.IsSuccess(out var value), Is.False);
                Assert.That(value, Is.Null);
            });
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestIsFailureShouldReturnTrueWhenFailureResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Failure<Value, Error>(new Error());

            Assert.Multiple(() =>
            {
                Assert.That(result.IsFailure(out var error), Is.True);
                Assert.That(error, Is.InstanceOf<Error>());
            });
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestIsFailureShouldReturnFalseWhenOtherResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Success<Value, Error>(new Value());

            Assert.Multiple(() =>
            {
                Assert.That(result.IsFailure(out var error), Is.False);
                Assert.That(error, Is.Null);
            });
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestIsUnhandledShouldReturnTrueWhenUnhandledResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Unhandled<Value, Error>(new Exception());

            Assert.Multiple(() =>
            {
                Assert.That(result.IsUnhandled(out var exception), Is.True);
                Assert.That(exception, Is.InstanceOf<Exception>());
            });
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestIsUnhandledShouldReturnFalseWhenOtherResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Success<Value, Error>(new Value());

            Assert.Multiple(() =>
            {
                Assert.That(result.IsUnhandled(out var exception), Is.False);
                Assert.That(exception, Is.Null);
            });
        }
    }
}
