using CsvHelper.Configuration.Attributes;

class Transaccion
{
    [Name("id")]
    public int Id { get; set; }

    [Name("tipo")]
    public string Tipo { get; set; }

    [Name("monto")]
    public double Monto { get; set; }
}