class сотрудники
{
    public int id { get; set; }
    public string ФИО { get; set; }
    public int должность_id { get; set; }
    public string телефон { get; set; }
    public long зарплата { get; set; }

    public сотрудники() { }
    public сотрудники(string ФИО, int должность_id, string телефон, long зарплата)
    {
        this.ФИО = ФИО;
        this.должность_id = должность_id;
        this.телефон = телефон;
        this.зарплата = зарплата;
    }
}
