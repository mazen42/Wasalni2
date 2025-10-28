using Wasalni_Models;

namespace Wasalni.Infrastructure.Interfaces
{
    public interface ILocation : IRepository<Location>
    {
        void Update (Location obj);
    }
}
