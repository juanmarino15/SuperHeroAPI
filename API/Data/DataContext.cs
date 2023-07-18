global using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            object value = optionsBuilder.UseSqlServer("Server=myServerAddress;Port=1234;Database=myDataBase;Uid=myUsername;Pwd=myPassword;");
        }
    }
}