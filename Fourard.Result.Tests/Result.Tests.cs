namespace Fourard.Result.Tests
{
    public class ResultTests
    {
        public class Payload
        {
        }

        public class Error
        {
        }

        [TestCase(typeof(Payload))]
        public void TestShouldImplicitlyConvertFromPayloadToSuccessResult(Type TValue)
        {
            Result<Payload> result = new Payload();
            Assert.That(result, Is.InstanceOf<Success<Payload>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestShouldImplicitlyConvertFromPayloadToSuccessResult(Type TValue, Type TError)
        {
            Result<Payload, Error> result = new Payload();
            Assert.That(result, Is.InstanceOf<Success<Payload, Error>>());
        }

        [TestCase(typeof(Payload))]
        public void TestShouldImplicitlyConvertFromErrorToFailureResult(Type TValue)
        {
            Result<Payload, Error> result = new Error();
            Assert.That(result, Is.InstanceOf<Failure<Payload, Error>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestShouldImplicitlyConvertFromErrorToFailureResult(Type TValue, Type TError)
        {
            Result<Payload, Error> result = new Error();
            Assert.That(result, Is.InstanceOf<Failure<Payload, Error>>());
        }

        [TestCase(typeof(Payload))]
        public void TestShouldImplicitlyConvertFromExceptionToUnhandledResult(Type TValue)
        {
            Result<Payload> result = new Exception();
            Assert.That(result, Is.InstanceOf<Unhandled<Payload>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestShouldImplicitlyConvertFromExceptionToUnhandledResult(Type TValue, Type TError)
        {
            Result<Payload, Error> result = new Exception();
            Assert.That(result, Is.InstanceOf<Unhandled<Payload, Error>>());
        }
    }
}
