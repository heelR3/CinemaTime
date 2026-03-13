using CinemaTime.Data.Base;
using CinemaTime.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaTime.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
