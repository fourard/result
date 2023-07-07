namespace Fourard.Result.Tests
{
    public class ResultExtensionsMappingTests
    {
        public record Error(string Message)
        {
        }

        [Test]
        public void TestMapSuccessTypeOfSuccessResult()
        {
            var result = new Success<int, string>(1);
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string, string>>());
        }

        [Test]
        public void TestMapSuccessTypeOfFailureResult()
        {
            var result = new Failure<int, string>("ERROR");
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string, string>>());
        }

        [Test]
        public void TestMapSuccessTypeOfUnhandledResult()
        {
            var result = new Unhandled<int, string>(new Exception());
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string, string>>());
        }

        [Test]
        public void TestMapSuccessTypeOfNullResult()
        {
            Result<int, string>? result = null;
            var mapped = result.Map(value => value.ToString());
            Assert.That(mapped, Is.Null);
        }

        [Test]
        public async Task TestMapSuccessTypeOfTaskResult()
        {
            var result = Task.FromResult<Result<int, string>?>(new Success<int, string>(1));
            var mapped = await result.Map(value => value.ToString());
            Assert.That(mapped, Is.InstanceOf<Result<string, string>>());
        }

        [Test]
        public void TestMapSuccessAndErrorTypesOfSuccessResult()
        {
            var result = new Success<int, string>(1);
            var mapped = result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.InstanceOf<Result<string, Error>>());
        }

        [Test]
        public void TestMapSuccessAndErrorTypesOfFailureResult()
        {
            var result = new Failure<int, string>("ERROR");
            var mapped = result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.InstanceOf<Result<string, Error>>());
        }

        [Test]
        public void TestMapSuccessAndErrorTypesOfUnhandledResult()
        {
            var result = new Unhandled<int, string>(new Exception());
            var mapped = result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.InstanceOf<Result<string, Error>>());
        }

        [Test]
        public void TestMapSuccessAndErrorTypesOfNullResult()
        {
            Result<int, string>? result = null;
            var mapped = result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.Null);
        }

        [Test]
        public async Task TestMapSuccessAndErrorTypeOfTaskResult()
        {
            var result = Task.FromResult<Result<int, string>?>(new Success<int, string>(1));
            var mapped = await result.Map(value => value.ToString(), error => new Error(error));
            Assert.That(mapped, Is.InstanceOf<Result<string, Error>>());
        }
    }
}