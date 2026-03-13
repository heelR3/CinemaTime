using CinemaTime.Data.Base;
using CinemaTime.Models;

namespace CinemaTime.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
