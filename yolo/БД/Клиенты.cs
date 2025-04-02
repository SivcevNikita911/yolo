class Клиенты
{
    public int id { get; set; }
    public string пароль { get; set; }
    public string имя { get; set; }
    public string почта { get; set; }

    public Клиенты() { }

    public Клиенты(string почта, string имя, string пароль)
    {
        this.почта = почта;
        this.имя = имя;
        this.пароль = пароль;
    }
}