using System;
using System.Data;

namespace ConsolaDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("Ejemplo");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));

            //añdimso valores al DataTable
            dt.Rows.Add(4, "Victor");
            dt.Rows.Add(5, "Ana");
            dt.Rows.Add(6, "Luis");
            dt.Rows.Add(7, "Sofia");

            //Obtener todo
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Obtiene todos los valores de la columna nombre
                Console.WriteLine(dt.Rows[i]["Nombre"].ToString());
            }

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row.Field<int>(0));
                Console.WriteLine(row.Field<string>(1));
            }

            //Obtener valores de las celdas: Valor otenido de la primera fila, columna Nombre
            //guardamos el valor en una variable
            string nombre= dt.Rows[0]["Nombre"].ToString();

            Console.WriteLine(nombre);
            Console.ReadLine();
        }
        
    }
}
