using ColorParty.Models;
using Microsoft.EntityFrameworkCore;

namespace ColorParty.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>contextOptions)
            :base(contextOptions)
        {
            
        }
        
    // Code - Approach
        
        public DbSet<Employee> Employees { get; set; }






    }


}
