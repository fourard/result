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

        [Test]
        public void TestActionSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1);
            var result = new Success<(int, int), string>(values);
            var success = Substitute.For<Action<int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1);
        }

        [Test]
        public void TestActionSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1);
        }

        [Test]
        public void TestActionSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1);
        }

        [Test]
        public void TestActionSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [Test]
        public void TestActionSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [Test]
        public void TestActionSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public void TestActionSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Action<int, int, int, int, int, int, int, int>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public void TestFuncSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1);
            var result = new Success<(int, int), string>(values);
            var success = Substitute.For<Func<int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1);
        }

        [Test]
        public void TestFuncSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1);
        }

        [Test]
        public void TestFuncSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1);
        }

        [Test]
        public void TestFuncSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [Test]
        public void TestFuncSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [Test]
        public void TestFuncSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public void TestFuncSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, string>>();
            result.Handle(success);
            success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1);
            var result = new Success<(int, int), string>(values);
            var success = Substitute.For<Func<int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1);
            var result = Task.FromResult<Result<(int, int), string>?>(new Success<(int, int), string>(values));
            var success = Substitute.For<Func<int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int), string>?>(new Success<(int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int), string>?>(new Success<(int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int), string>?>(new Success<(int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1);
            var result = new Success<(int, int), string>(values);
            var success = Substitute.For<Func<int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1);
            var result = new Success<(int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1);
            var result = new Success<(int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = new Success<(int, int, int, int, int, int, int, int), string>(values);
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive2DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1);
            var result = Task.FromResult<Result<(int, int), string>?>(new Success<(int, int), string>(values));
            var success = Substitute.For<Func<int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive3DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int), string>?>(new Success<(int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive4DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int), string>?>(new Success<(int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive5DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int), string>?>(new Success<(int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive6DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive7DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1);
        }

        [Test]
        public async Task TestFuncGenericTaskSuccessHandlerShouldReceive8DeconstructedParametersFromTupleTaskResult()
        {
            var values = (1, 1, 1, 1, 1, 1, 1, 1);
            var result = Task.FromResult<Result<(int, int, int, int, int, int, int, int), string>?>(new Success<(int, int, int, int, int, int, int, int), string>(values));
            var success = Substitute.For<Func<int, int, int, int, int, int, int, int, Task<string>>>();
            await result.Handle(success);
            await success.Received().Invoke(1, 1, 1, 1, 1, 1, 1, 1);
        }
    }
}