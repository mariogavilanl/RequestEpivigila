using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiegoRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaHTTP consultahttp = new ConsultaHTTP();
            Archivos archivos = new Archivos();

            var dt = archivos.LeerArchivoBase1();
            foreach (DataRow item in dt.Rows)
            {
                string resultado = consultahttp.ConsultaRuts(item[0].ToString()).ToString();
                JObject o = JObject.Parse(resultado);
                String primerFolio = o.Last.First.First.First.First.ToString();

                var pico = "asdasd";


            }

            //var lines = new List<string>();

            //string[] columnNames = dataTable.Columns
            //    .Cast<DataColumn>()
            //    .Select(column => column.ColumnName)
            //    .ToArray();

            //var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
            //lines.Add(header);

            //var valueLines = dataTable.AsEnumerable()
            //    .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));

            //lines.AddRange(valueLines);

            //File.WriteAllLines("excel.csv", lines);

        }

       
    }
}
