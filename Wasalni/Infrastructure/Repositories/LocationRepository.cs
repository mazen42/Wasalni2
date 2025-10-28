using Wasalni.Infrastructure.Interfaces;
using Wasalni_DataAccess.Data;
using Wasalni_Models;

namespace Wasalni.Infrastructure.Repositories
{
    public class LocationRepository : Repository<Location>, ILocation
    {
        private AppDbContext _db { get; set; }
        public LocationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _db = appDbContext;
        }
        public void Update(Location obj)
        {
            _db.Locations.Update(obj);
        }
    }
}