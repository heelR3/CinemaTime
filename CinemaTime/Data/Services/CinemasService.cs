using CinemaTime.Data.Base;
using CinemaTime.Models;

namespace CinemaTime.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
