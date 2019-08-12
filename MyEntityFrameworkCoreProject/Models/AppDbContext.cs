using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyEntityFrameworkCoreProject.Models {
    public class AppDbContext : DbContext  {            /// inherited from DBContext / Import using Microsoft.EntityFrameworkCore;
                                                        

        public AppDbContext(DbContextOptions/*<AppDbContext>*/ options) : base(options) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {          /// use this to configure the context

            var connStr = 
                "server=localhost\\sqlexpress;database=AppEfDb;trust_connection=true;";
            builder.UseSqlServer(connStr);
        }
        public DbSet<Student> Students { get; set; }        /// define the DbSet property for the each entity ( database table).
    }
}
