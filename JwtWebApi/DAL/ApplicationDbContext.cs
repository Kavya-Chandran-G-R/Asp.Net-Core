using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JwtWebApi.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<UserDto> UserDtos { get; set; }
    }
}
