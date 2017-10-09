using System;
using System.Threading.Tasks;
using Xunit;

namespace app
{
    public class CreateDisasterUseCaseTests
    {
        [Fact]
        public void GivenNullData_ExceptionThrown()
        {
            IDisasterGateway fakeGateway = new FakeDisasterGateway();
            var usecase = new DisasterUseCase(fakeGateway);
            Assert.ThrowsAsync<Exception>(() => usecase.Create(null));
        }

        [Fact]
        public async Task GivenData_DisasterCreated()
        {
            IDisasterGateway fakeGateway = new FakeDisasterGateway();
            var usecase = new DisasterUseCase(fakeGateway);
            var disaster = new Disaster();

            await usecase.Create(disaster);

            Assert.True(disaster.IsSaved());
        }

    }
}
