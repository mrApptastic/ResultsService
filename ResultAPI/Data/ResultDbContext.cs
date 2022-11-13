using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultAPI.Data
{
    public class ResultDbContext: DbContext {
        public ResultDbContext(DbContextOptions<ResultDbContext> options)
            : base(options)
            { }

        public DbSet<Competition> Competitions { get; set; }        
    }
}   

