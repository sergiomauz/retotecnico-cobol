using CsvHelper;
using System.Globalization;


// Obtener directorio del proyecto
var directorioSolucion = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;

// Obtener ruta del archivo. Con fines de depuracion siempre estará en la misma carpeta que la solucion
var directorioArchivoCsv = Path.Combine(directorioSolucion ?? "", "data.csv");

// Iniciar variables y leer archivo y procesarlo a memoria
var conteoCreditos = 0;
var conteoDebitos = 0;
var balanceFinal = 0.0;
var mayorId = 0;
var mayorMonto = 0.0;
if (File.Exists(directorioArchivoCsv))
{
    using (var reader = new StreamReader(directorioArchivoCsv))
    {
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            //Recorrer los registros del archivo CSV
            var records = csv.GetRecords<Transaccion>().ToList();
            foreach (var record in records)
            {
                // Obtener mayor
                if (record.Monto > mayorMonto)
                {
                    mayorMonto = record.Monto;
                    mayorId = record.Id;
                }

                // Diferencia creditos y debitos
                if (record.Tipo == "Crédito")
                {
                    balanceFinal += record.Monto;
                    conteoCreditos++;
                }
                else if (record.Tipo == "Débito")
                {
                    balanceFinal -= record.Monto;
                    conteoDebitos++;
                }
            }
        }
    }

    //Imprimir reporte
    Console.WriteLine("Reporte de Transacciones");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Balance Final: {balanceFinal.ToString("0.00")}");
    Console.WriteLine($"Transacción de Mayor Monto: ID {mayorId} - {mayorMonto.ToString("0.00")}");
    Console.WriteLine($"Conteo de Transacciones: Crédito: {conteoCreditos} Débito: {conteoDebitos}");
}
else
{
    Console.WriteLine($"El archivo CSV no existe. La ruta del archivo es: '{directorioArchivoCsv}'");
}
