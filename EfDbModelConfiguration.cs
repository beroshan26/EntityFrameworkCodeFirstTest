using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstTest
{
    public class EfDbModelConfiguration<T> : EntityTypeConfiguration<T> where T : DomainModel
    {
        protected EfDbModelConfiguration()
        {
           
        }
    }

    public class RegistrationConfiguration : EfDbModelConfiguration<Registration>
    {
        public RegistrationConfiguration()
        {
            ToTable(typeof(Registration).Name);
        }
    }
}
