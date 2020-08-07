using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.Data
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions<DataBase> options) : base(options)
        {

        }
        public DbSet<debils> debils { get; set; }
        public DbSet<debilscats> debilscat { get; set; }
    }
}
