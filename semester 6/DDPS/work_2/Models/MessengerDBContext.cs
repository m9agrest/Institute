using Microsoft.EntityFrameworkCore;

public class MessengerDBContext : DbContext
{
    public MessengerDBContext(DbContextOptions<MessengerDBContext> options) : base(options)
    {

    }
    public DbSet<User> User { get; set; }
    public DbSet<Interaction> Interaction { get; set; }
    public DbSet<Message> Chat { get; set; }
    public DbSet<Photo> Photo { get; set; }

}
