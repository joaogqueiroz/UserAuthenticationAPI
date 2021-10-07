using AspNetAPIProject02.Data.Entities;
using AspNetAPIProject02.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetAPIProject02.Data.Contexts
{
    //Inherit DbContext
    public class SqlServerContext :DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {

        }
        //Need to declare DbSet for each entity
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Need to add each mapping class in the project 
            modelBuilder.ApplyConfiguration(new UserMapping());
        }
    }
}
