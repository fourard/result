namespace Fourard.Result.Tests
{
    public class ResultTests
    {
        [TestCase(typeof(Value))]
        public void TestShouldImplicitlyConvertFromTValueToSuccessResult(Type TValue)
        {
            Result<Value> result = new Value();
            Assert.That(result, Is.InstanceOf<Success<Value>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestShouldImplicitlyConvertFromTValueToSuccessResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Value();
            Assert.That(result, Is.InstanceOf<Success<Value, Error>>());
        }

        [TestCase(typeof(Value))]
        public void TestShouldImplicitlyConvertFromErrorToFailureResult(Type TValue)
        {
            Result<Value, Error> result = new Error();
            Assert.That(result, Is.InstanceOf<Failure<Value, Error>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestShouldImplicitlyConvertFromErrorToFailureResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Error();
            Assert.That(result, Is.InstanceOf<Failure<Value, Error>>());
        }

        [TestCase(typeof(Value))]
        public void TestShouldImplicitlyConvertFromExceptionToUnhandledResult(Type TValue)
        {
            Result<Value> result = new Exception();
            Assert.That(result, Is.InstanceOf<Unhandled<Value>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestShouldImplicitlyConvertFromExceptionToUnhandledResult(Type TValue, Type TError)
        {
            Result<Value, Error> result = new Exception();
            Assert.That(result, Is.InstanceOf<Unhandled<Value, Error>>());
        }
    }
}
