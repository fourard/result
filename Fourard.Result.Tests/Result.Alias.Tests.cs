namespace Fourard.Result.Tests
{
    public class ResultAliasTests
    {
        [Test]
        public void TestMultipleValuesSuccessResultShouldBeInstanceOfTupleResultOf2Values()
        {
            Result<int, int, string> result = (1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesSuccessResultShouldBeInstanceOfTupleResultOf3Values()
        {
            Result<int, int, int, string> result = (1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesSuccessResultShouldBeInstanceOfTupleResultOf4Values()
        {
            Result<int, int, int, int, string> result = (1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesSuccessResultShouldBeInstanceOfTupleResultOf5Values()
        {
            Result<int, int, int, int, int, string> result = (1, 1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesSuccessResultShouldBeInstanceOfTupleResultOf6Values()
        {
            Result<int, int, int, int, int, int, string> result = (1, 1, 1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesSuccessResultShouldBeInstanceOfTupleResultOf7Values()
        {
            Result<int, int, int, int, int, int, int, string> result = (1, 1, 1, 1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesSuccessResultShouldBeInstanceOfTupleResultOf8Values()
        {
            Result<int, int, int, int, int, int, int, int, string> result = (1, 1, 1, 1, 1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesFailureResultShouldBeInstanceOfTupleResultOf2Values()
        {
            Result<int, int, string> result = "Result<int, int, string>";
            Assert.That(result, Is.InstanceOf<Result<(int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesFailureResultShouldBeInstanceOfTupleResultOf3Values()
        {
            Result<int, int, int, string> result = "Result<int, int, int, string>";
            Assert.That(result, Is.InstanceOf<Result<(int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesFailureResultShouldBeInstanceOfTupleResultOf4Values()
        {
            Result<int, int, int, int, string> result = "Result<int, int, int, int, string>";
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesFailureResultShouldBeInstanceOfTupleResultOf5Values()
        {
            Result<int, int, int, int, int, string> result = "Result<int, int, int, int, int, string>";
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesFailureResultShouldBeInstanceOfTupleResultOf6Values()
        {
            Result<int, int, int, int, int, int, string> result = "Result<int, int, int, int, int, int, string>";
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesFailureResultShouldBeInstanceOfTupleResultOf7Values()
        {
            Result<int, int, int, int, int, int, int, string> result = "Result<int, int, int, int, int, int, int, string>";
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesFailureResultShouldBeInstanceOfTupleResultOf8Values()
        {
            Result<int, int, int, int, int, int, int, int, string> result = "Result<int, int, int, int, int, int, int, int, string>";
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesUnhandledResultShouldBeInstanceOfTupleResultOf2Values()
        {
            Result<int, int, string> result = new Exception("Result<int, int, string>");
            Assert.That(result, Is.InstanceOf<Result<(int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesUnhandledResultShouldBeInstanceOfTupleResultOf3Values()
        {
            Result<int, int, int, string> result = new Exception("Result<int, int, int, string>");
            Assert.That(result, Is.InstanceOf<Result<(int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesUnhandledResultShouldBeInstanceOfTupleResultOf4Values()
        {
            Result<int, int, int, int, string> result = new Exception("Result<int, int, int, int, string>");
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesUnhandledResultShouldBeInstanceOfTupleResultOf5Values()
        {
            Result<int, int, int, int, int, string> result = new Exception("Result<int, int, int, int, int, string>");
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesUnhandledResultShouldBeInstanceOfTupleResultOf6Values()
        {
            Result<int, int, int, int, int, int, string> result = new Exception("Result<int, int, int, int, int, int, string>");
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesUnhandledResultShouldBeInstanceOfTupleResultOf7Values()
        {
            Result<int, int, int, int, int, int, int, string> result = new Exception("Result<int, int, int, int, int, int, int, string>");
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesUnhandledResultShouldBeInstanceOfTupleResultOf8Values()
        {
            Result<int, int, int, int, int, int, int, int, string> result = new Exception("Result<int, int, int, int, int, int, int, int, string>");
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int, int, int), string>>());
        }
    }
}
