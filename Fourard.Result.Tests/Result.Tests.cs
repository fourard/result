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

        [Test]
        public void TestShouldImplicitlyConvertFromExceptionToSuccessResult()
        {
            Result<Payload, Error> result = new Payload();
            Assert.That(result, Is.InstanceOf<Success<Payload, Error>>());
        }

        [Test]
        public void TestShouldImplicitlyConvertFromExceptionToFailureResult()
        {
            Result<Payload, Error> result = new Error();
            Assert.That(result, Is.InstanceOf<Failure<Payload, Error>>());
        }

        [Test]
        public void TestShouldImplicitlyConvertFromExceptionToUnhandledResult()
        {
            Result<Payload, Error> result = new Exception();
            Assert.That(result, Is.InstanceOf<Unhandled<Payload, Error>>());
        }
    }
}
