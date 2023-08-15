namespace Fourard.Result.Tests
{
    public class ResultExtensionsDeconstructionTests
    {
        public class Payload
        {
        }

        public class Error
        {
        }

        [TestCase(typeof(Payload))]
        public void TestActionSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1);
            var result = new Success<(int, int)>(values);
            var success = Substitute.For<Action<int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestActionSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1);
            var result = new Success<(int, int), string>(values);
            var success = Substitute.For<Action<int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestActionSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int)>(values);
            var success = Substitute.For<Action<int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestActionSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestActionSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int)>(values);
            var success = Substitute.For<Action<int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestActionSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestActionSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int)>(values);
            var success = Substitute.For<Action<int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestActionSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestActionSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int)>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestActionSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestActionSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int)>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestActionSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestActionSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int)>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestActionSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestFuncSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1);
            var result = new Success<(int, int)>(values);
            var success = Substitute.For<Func<int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestFuncSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1);
            var result = new Success<(int, int), string>(values);
            var success = Substitute.For<Func<int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestFuncSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestFuncSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestFuncSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestFuncSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestFuncSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestFuncSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestFuncSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestFuncSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestFuncSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestFuncSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public void TestFuncSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public void TestFuncSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1);
            var result = new Success<(int, int)>(values);
            var success = Substitute.For<Func<int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1);
            var result = new Success<(int, int), string>(values);
            var success = Substitute.For<Func<int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1);
            var result = Task.FromResult<Result<(int, int)>?>(new Success<(int, int)>(values));
            var success = Substitute.For<Func<int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1);
            var result = Task.FromResult<Result<(int, int), string>?>(new Success<(int, int), string>(values));
            var success = Substitute.For<Func<int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int)>?>(new Success<(int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int), string>?>(new Success<(int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int)>?>(new Success<(int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int), string>?>(new Success<(int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int)>?>(new Success<(int, int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int), string>?>(new Success<(int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int)>?>(new Success<(int, int, int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int)>?>(new Success<(int, int, int, int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int, int)>?>(new Success<(int, int, int, int, int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1);
            var result = new Success<(int, int)>(values);
            var success = Substitute.For<Func<int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1);
            var result = new Success<(int, int), string>(values);
            var success = Substitute.For<Func<int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int)>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1);
            var result = Task.FromResult<Result<(int, int)>?>(new Success<(int, int)>(values));
            var success = Substitute.For<Func<int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1);
            var result = Task.FromResult<Result<(int, int), string>?>(new Success<(int, int), string>(values));
            var success = Substitute.For<Func<int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int)>?>(new Success<(int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int), string>?>(new Success<(int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int)>?>(new Success<(int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int), string>?>(new Success<(int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int)>?>(new Success<(int, int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int), string>?>(new Success<(int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int)>?>(new Success<(int, int, int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int)>?>(new Success<(int, int, int, int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleTaskResult(Type TValue)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int, int)>?>(new Success<(int, int, int, int, int, int, int, int)>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [TestCase(typeof(Payload), typeof(Error))]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleTaskResult(Type TValue, Type TError)
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }
    }
}