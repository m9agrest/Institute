using Microsoft.EntityFrameworkCore;

namespace work.Models
{
    public class MessengerDBContext : DbContext
    {
        public MessengerDBContext(DbContextOptions<MessengerDBContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<ChatMessage> ChatMessage { get; set; }
        public DbSet<ChatMessageText> ChatMessageText { get; set; }
        public DbSet<ChatMessagePhoto> ChatMessagePhoto { get; set; }

    }
}
