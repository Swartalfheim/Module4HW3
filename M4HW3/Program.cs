using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace M4HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (ApplicationContext db = new ApplicationContext(options))
            {
                var users = db.Employees.ToList();
            }
            Console.Read();
        }
    }
}