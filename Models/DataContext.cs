using Microsoft.EntityFrameworkCore;

namespace PropertyRental.Models
{
    public class DataContext : DbContext
    {
            /*
        Run migrations everytime something changes on the models


        - dotnet ef migrations add <someName>
        - dotnet ef database update
    */
    
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
//specify which models/classes will becomes tables on the Db
    public DbSet<Property> Properties {get; set;}

    }
}