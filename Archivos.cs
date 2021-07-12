using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiegoRequest
{
    class Archivos
    {

        public DataTable LeerArchivoBase1()
        {
            DataTable dt = new DataTable("Ruts");

            dt.Columns.Add("Rut",   typeof(string));
            dt.Columns.Add("Col1",  typeof(string));
            dt.Columns.Add("Col2",  typeof(string));
            dt.Columns.Add("Col3",  typeof(string));


            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\dev\diego\base1.txt");
            while ((line = file.ReadLine()) != null)
            {

                DataRow row;
                row = dt.NewRow();
                row[0] = line;
                dt.Rows.Add(row);
                counter++;
            }
            file.Close();

            return dt;
        }


    }
}
