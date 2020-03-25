using System;
using System.Collections.Generic;

namespace Manejo_Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Juan", "55423412"); 
            values.Add("Ernesto", "56985623"); 
            values.Add("Mariana", "54787451");

            if(values.ContainsKey("Juan"))
            {
                Console.WriteLine("Valor correspondiente al indice Juan: " + values["Juan"]);
                Console.WriteLine();
            }

            String value = " ";

            if(values.TryGetValue("Pedro", out value))
            {
                Console.WriteLine(values["Pedro"]);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No contiene la llave");
                Console.WriteLine();
            }

            foreach (KeyValuePair<string, string> valor in values)
            {
                Console.WriteLine("Indice: " + valor.Key + " Valor: "+ valor.Value);
            }

            if (values.TryGetValue("Mariana", out value))
            {
                Console.WriteLine();
                values["Mariana"] = "58251425";
                Console.WriteLine("Indice: Mariana Valor: " + values["Mariana"]);
            }

        }
    }
}
