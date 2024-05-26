#pragma warning disable CS1998

using static Fourard.Result.Commands;

namespace Fourard.Result.Tests
{
    public partial class CommandsTests
    {
        [TestCase(typeof(Value))]
        public void TestExecShouldReturnSuccessResult(Type TValue)
        {
            var result = Exec<Value>(() => new Value());

            Assert.That(result, Is.AssignableFrom<Success<Value>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestExecShouldReturnSuccessResult(Type TValue, Type TError)
        {
            var result = Exec<Value, Error>(() => new Value());

            Assert.That(result, Is.AssignableFrom<Success<Value, Error>>());
        }

        [TestCase(typeof(Value))]
        public async Task TestExecAsyncShouldReturnSuccessResult(Type TValue)
        {
            var result = await Exec<Value>(async () => new Value());

            Assert.That(result, Is.AssignableFrom<Success<Value>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestExecAsyncShouldReturnSuccessResult(Type TValue, Type TError)
        {
            var result = await Exec<Value, Error>(async () => new Value());

            Assert.That(result, Is.AssignableFrom<Success<Value, Error>>());
        }

        [TestCase(typeof(Value))]
        public void TestExecShouldReturnUnhandledResultWhenExceptionIsThrown(Type TValue)
        {
            var error = true;

            var result = Exec<Value>(() =>
            {
                if (error) throw new Exception();
                return new Value();
            });

            Assert.That(result, Is.AssignableFrom<Unhandled<Value>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public void TestExecShouldReturnUnhandledResultWhenExceptionIsThrown(Type TValue, Type TError)
        {
            var error = true;

            var result = Exec<Value, Error>(() =>
            {
                if (error) throw new Exception();
                return new Value();
            });

            Assert.That(result, Is.AssignableFrom<Unhandled<Value, Error>>());
        }

        [TestCase(typeof(Value))]
        public async Task TestExecAsyncShouldReturnUnhandledResultWhenExceptionIsThrown(Type TValue)
        {
            var error = true;

            var result = await Exec<Value>(async () =>
            {
                if (error) throw new Exception();
                return new Value();
            });

            Assert.That(result, Is.AssignableFrom<Unhandled<Value>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestExecAsyncShouldReturnUnhandledResultWhenExceptionIsThrown(Type TValue, Type TError)
        {
            var error = true;

            var result = await Exec<Value, Error>(async () =>
            {
                if (error) throw new Exception();
                return new Value();
            });

            Assert.That(result, Is.AssignableFrom<Unhandled<Value, Error>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestExecShouldReturnFailureResult(Type TValue, Type TError)
        {
            var result = Exec<Value, Error>(() => new Error());

            Assert.That(result, Is.AssignableFrom<Failure<Value, Error>>());
        }

        [TestCase(typeof(Value), typeof(Error))]
        public async Task TestExecAsyncShouldReturnFailureResult(Type TValue, Type TError)
        {
            var result = await Exec<Value, Error>(async () => new Error());

            Assert.That(result, Is.AssignableFrom<Failure<Value, Error>>());
        }
    }
}
