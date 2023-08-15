namespace Fourard.Result.Tests
{
    public class ResultExtensionsMappingTests
    {
        public class Payload
        {
        }

        public record Error(string Message)
        {
        }

        [TestCase(typeof(Payload))]
        public void TestMapSuccessTypeOfSuccessResult(Type TValue)
        {
            var result = new Success<int>(1);
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestMapSuccessTypeOfSuccessResult(Type TValue, Type TError)
        {
            var result = new Success<int, string>(1);
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string, string>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestMapSuccessTypeOfFailureResult(Type TValue, Type TError)
        {
            var result = new Failure<int, string>("ERROR");
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string, string>>());
        }

        [TestCase(typeof(Payload))]
        public void TestMapSuccessTypeOfUnhandledResult(Type TValue)
        {
            var result = new Unhandled<int>(new Exception());
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestMapSuccessTypeOfUnhandledResult(Type TValue, Type TError)
        {
            var result = new Unhandled<int, string>(new Exception());
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string, string>>());
        }

        [TestCase(typeof(Payload))]
        public void TestMapSuccessTypeOfNullResult(Type TValue)
        {
            Result<int>? result = null;
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.Null);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestMapSuccessTypeOfNullResult(Type TValue, Type TError)
        {
            Result<int, string>? result = null;
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.Null);
        }

        [TestCase(typeof(Payload))]
        public async Task TestMapSuccessTypeOfTaskResult(Type TValue)
        {
            var result = Task.FromResult<Result<int>?>(new Success<int>(1));
            var mapped = await result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestMapSuccessTypeOfTaskResult(Type TValue, Type TError)
        {
            var result = Task.FromResult<Result<int, string>?>(new Success<int, string>(1));
            var mapped = await result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string, string>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestMapSuccessAndErrorTypesOfSuccessResult(Type TValue, Type TError)
        {
            var result = new Success<int, string>(1);
            var mapped = result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.InstanceOf<Result<string, Error>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestMapSuccessAndErrorTypesOfFailureResult(Type TValue, Type TError)
        {
            var result = new Failure<int, string>("ERROR");
            var mapped = result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.InstanceOf<Result<string, Error>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestMapSuccessAndErrorTypesOfUnhandledResult(Type TValue, Type TError)
        {
            var result = new Unhandled<int, string>(new Exception());
            var mapped = result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.InstanceOf<Result<string, Error>>());
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestMapSuccessAndErrorTypesOfNullResult(Type TValue, Type TError)
        {
            Result<int, string>? result = null;
            var mapped = result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.Null);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestMapSuccessAndErrorTypeOfTaskResult(Type TValue, Type TError)
        {
            var result = Task.FromResult<Result<int, string>?>(new Success<int, string>(1));
            var mapped = await result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.InstanceOf<Result<string, Error>>());
        }
    }
}