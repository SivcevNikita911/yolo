public class Каталог
{
    public int id { get; set; }
    public string название { get; set; }
    public int цена { get; set; }
    public string описание { get; set; }

    public Каталог() { }

    public Каталог(string название, int цена, string описание)
    {
        this.название = название;
        this.цена = цена;
        this.описание = описание;
    }
}
