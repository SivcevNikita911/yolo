using System.Data.Entity;

namespace yolo
{
    class DbHelper : DbContext
    {
        public DbSet<Клиенты> Клиенты { get; set; }
        public DbSet<Администраторы> Администраторы { get; set; }
        public DbSet<Материалы> Материалы { get; set; }
        public DbSet<Каталог> Каталог { get; set; }
        public DbSet<Корзина> Корзина { get; set; }
        public DbSet<сотрудники> сотрудники { get; set; }
        public DbHelper() : base("DefaultConnection") { }
    }
}
