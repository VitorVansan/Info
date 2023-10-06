using ProcessToCsv.Model;
using System.Collections.Generic;
using System.Numerics;

namespace ProcessToCsv.Service
{
    public class CsvService
    {
        public CsvService() { }

        public void insereDadosCsv(List<Dados> listaDados)
        {
            string filePath = @"C:\Users\vitor\source\repos\ProcessToCsv\ProcessToCsv\Data\Dados.csv";

            var transformToCsv = new List<string>();

            foreach (var item in listaDados)
            {
                transformToCsv.Add($"{item.Dados1},{item.Dados2},{item.Dados3},{item.Dados4},{item.Dados5},{item.Dados6},{item.Dados7},{item.Dados8},{item.Dados9},{item.Dados10}");
            }


            if (File.Exists(filePath))
            {
                File.AppendAllLines(filePath, transformToCsv);
            }
            else
            {
                File.WriteAllLines(filePath, transformToCsv);
            }

        }


    }
}
