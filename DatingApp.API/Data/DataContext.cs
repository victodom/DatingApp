using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext // dbcontext it is used for a session with the datbase 
    {//with : symbol Datacontext heritage from dbcontext
        public DataContext(DbContextOptions<DataContext>options) :base(options){}

        public DbSet<Value> Values { get; set; }


    }
}