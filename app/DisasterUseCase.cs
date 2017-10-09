using System;
using System.Threading.Tasks;

namespace app
{
    internal class DisasterUseCase
    {
        private readonly IDisasterGateway _gateway;

        public DisasterUseCase(IDisasterGateway gateway)
        {
            _gateway = gateway;
        }

        internal async Task Create(Disaster disaster)
        {
            await _gateway.Save(disaster);
        }
    }
}