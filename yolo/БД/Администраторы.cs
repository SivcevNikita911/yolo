namespace yolo
{
    class Администраторы
    {
        public int id { get; set; }
        public string имя { get; set; }
        public string пароль { get; set; }

        public Администраторы() { }
        public Администраторы(string имя, string пароль)
        {
            this.имя = имя;
            this.пароль = пароль;
        }
    }
}
