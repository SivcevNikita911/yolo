public class Материалы
{
    public int id { get; set; }
    public string Название { get; set; }
    public int ценаЗаШтуку { get; set; }
    public int Количество { get; set; }

    public Материалы() { }

    public Материалы(string название, int ценаЗаШтуку, int количество)
    {
        this.Название = название;
        this.ценаЗаШтуку = ценаЗаШтуку;
        this.Количество = количество;
    }
}