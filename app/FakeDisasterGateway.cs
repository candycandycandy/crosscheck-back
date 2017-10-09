using System.Collections.Generic;
using System.Threading.Tasks;

namespace app
{
    internal class FakeDisasterGateway : IDisasterGateway
    {
        public async Task Save(Disaster disaster)
        {
            List<Disaster> disasters = new List<Disaster>();
            disasters.Add(disaster);
            int id = disasters.IndexOf(disaster);
            disaster.SetId(id);
        }
    }
}