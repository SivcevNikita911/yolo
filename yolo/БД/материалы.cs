public class Материалы
{
    public int id { get; set; }
    public string название { get; set; }
    public int ценаЗаШтуку { get; set; }
    public int количество { get; set; }

    public Материалы() { }

    public Материалы(string название, int ценаЗаШтуку, int количество)
    {
        this.название = название;
        this.ценаЗаШтуку = ценаЗаШтуку;
        this.количество = количество;
    }
}