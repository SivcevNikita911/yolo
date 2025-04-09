using System;
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
        public DbSet<Должности> Должности { get; set; }
        public DbSet<Заказы> Заказы { get; set; }

        public DbHelper() : base("DefaultConnection") { }

        // Метод для проверки инициализации всех DbSet
        public void ValidateDbSets()
        {
            if (Клиенты == null)
                throw new InvalidOperationException("DbSet 'Клиенты' не инициализирован.");
            if (Администраторы == null)
                throw new InvalidOperationException("DbSet 'Администраторы' не инициализирован.");
            if (Материалы == null)
                throw new InvalidOperationException("DbSet 'Материалы' не инициализирован.");
            if (Каталог == null)
                throw new InvalidOperationException("DbSet 'Каталог' не инициализирован.");
            if (Корзина == null)
                throw new InvalidOperationException("DbSet 'Корзина' не инициализирован.");
            if (сотрудники == null)
                throw new InvalidOperationException("DbSet 'сотрудники' не инициализирован.");
            if (Должности == null)
                throw new InvalidOperationException("DbSet 'Должности' не инициализирован.");
            if (Заказы == null)
                throw new InvalidOperationException("DbSet 'Заказы' не инициализирован.");
        }
    }
}
