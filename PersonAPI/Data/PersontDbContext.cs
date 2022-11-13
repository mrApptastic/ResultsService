using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonAPI.Data
{
    public class PersonDbContext: DbContext {
        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
            { }

        public DbSet<Person> Wrestling_Persons { get; set; }        
        public DbSet<Role> Wrestling_Roles { get; set; }      
    }
}   

