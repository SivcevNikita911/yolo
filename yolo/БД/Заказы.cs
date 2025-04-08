using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class Заказы
{
    public int id { get; set; }
    public string номер_заказа { get; set; }
    public string статус { get; set; }
    public DateTime дата { get; set; }
    public string товары { get; set; } // JSON-строка для хранения списка товаров  
    public int общая_цена { get; set; }
    public int Клиент_id { get; set; } // Связь с клиентом

    public List<Товар> ПолучитьТовары()
    {
        return JsonConvert.DeserializeObject<List<Товар>>(товары);
    }

    public void УстановитьТовары(List<Товар> списокТоваров)
    {
        товары = JsonConvert.SerializeObject(списокТоваров);
    }
}

public class Товар
{
    public string название { get; set; }
    public int количество { get; set; }
    public int цена { get; set; }
}
