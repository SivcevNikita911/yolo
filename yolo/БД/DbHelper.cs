using System.Data.Entity;

namespace yolo
{
    class DbHelper : DbContext
    {
        public DbSet<Клиенты> Клиенты { get; set; }
        public DbSet<Администраторы> Администраторы { get; set; }

        public DbHelper() : base("DefaultConnection") { }
    }
}
