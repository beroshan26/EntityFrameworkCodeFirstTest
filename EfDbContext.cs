using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstTest
{
    public class EfDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<SchoolDetails> SchoolDetails { get; set; }
        
        public EfDbContext() : base("EfDbContextConnString")
        {
            //If codefirst then comment the below and run, the EF will create the database tables
            //if no codefirst then uncomment the below and use sql script file in the project to create db manually
            Database.SetInitializer<EfDbContext>(null);
        }
             
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public IQueryable<T> GetQuery<T> () where T : DomainModel
        {
            return Set<T>();
        }
    }
}
