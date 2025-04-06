public class Каталог
{
    public int id { get; set; }
    public string название { get; set; }
    public int цена { get; set; }
    public string описание { get; set; }
    public int количество_в_корзине { get; set; } // Количество товара в каталоге

    public Каталог() { }

    public Каталог(string название, int цена, string описание, int количество_в_корзине)
    {
        this.название = название;
        this.цена = цена;
        this.описание = описание;
        this.количество_в_корзине = количество_в_корзине;
    }
}
