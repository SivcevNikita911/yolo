class сотрудники
{
    public int id { get; set; }
    public string фамилия { get; set; }
    public string имя { get; set; }
    public string отчество { get; set; }
    public int должность_id { get; set; }
    public string телефон { get; set; }
    public long зарплата { get; set; }

    public сотрудники() { }
    public сотрудники(string фамилия, string имя, string отчество, int должность_id, string телефон, long зарплата)
    {
        this.фамилия = фамилия;
        this.имя = имя;
        this.отчество = отчество;
        this.должность_id = должность_id;
        this.телефон = телефон;
        this.зарплата = зарплата;
    }
}
