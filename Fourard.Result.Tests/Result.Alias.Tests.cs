namespace Fourard.Result.Tests
{
    public class ResultAliasTests
    {
        [Test]
        public void TestMultipleValuesResultShouldBeInstanceOfTupleResultOf2Values()
        {
            Result<int, int, string> result = (1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesResultShouldBeInstanceOfTupleResultOf3Values()
        {
            Result<int, int, int, string> result = (1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesResultShouldBeInstanceOfTupleResultOf4Values()
        {
            Result<int, int, int, int, string> result = (1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesResultShouldBeInstanceOfTupleResultOf5Values()
        {
            Result<int, int, int, int, int, string> result = (1, 1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesResultShouldBeInstanceOfTupleResultOf6Values()
        {
            Result<int, int, int, int, int, int, string> result = (1, 1, 1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesResultShouldBeInstanceOfTupleResultOf7Values()
        {
            Result<int, int, int, int, int, int, int, string> result = (1, 1, 1, 1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int, int), string>>());
        }

        [Test]
        public void TestMultipleValuesResultShouldBeInstanceOfTupleResultOf8Values()
        {
            Result<int, int, int, int, int, int, int, int, string> result = (1, 1, 1, 1, 1, 1, 1, 1);
            Assert.That(result, Is.InstanceOf<Result<(int, int, int, int, int, int, int, int), string>>());
        }
    }
}
