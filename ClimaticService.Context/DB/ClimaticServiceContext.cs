using ClimaticService.Context.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService.Context.DB
{
    public class ClimaticServiceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<BrokenType> BrokenTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public ClimaticServiceContext(): base("DefaultConnection")
        {

        }
    }
}
