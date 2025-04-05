public class Корзина
{
    public int id { get; set; }

    public int Клиент_id { get; set; }
    public int товар_id { get; set; }
    public int цена { get; set; }
    public int количество { get; set; }

    public Корзина() { }

    public Корзина(int Клиент_id, int товар_id, int цена, int количество)
    {
        this.товар_id = товар_id;
        this.цена = цена;
        this.количество = количество;
    }
}
