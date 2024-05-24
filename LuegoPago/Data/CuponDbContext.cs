using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LuegoPago.Models;
namespace SolidTest.Data
{
    public class CuponDbContext : DbContext
    {
        public CuponDbContext(DbContextOptions<CuponDbContext> options): base(options){
            
        }
        public DbSet<Cupon> Cupones { get;set;}
        
    }
}