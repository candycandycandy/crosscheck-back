using System.Threading.Tasks;

namespace app
{
    internal interface IDisasterGateway
    {
        Task Save(Disaster disaster);
    }
}