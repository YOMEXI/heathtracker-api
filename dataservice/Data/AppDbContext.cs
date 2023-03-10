using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using entities.DbSet;

namespace dataservice.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public virtual DbSet<User> User => Set<User>();


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}