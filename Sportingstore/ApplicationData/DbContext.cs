using Sportingstore.Models;
using System.Data.Entity;

public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    // Укажите строку подключения к базе данных в конструкторе
    public MyDbContext() : base("name=DbConnection")
    {
    }
}
