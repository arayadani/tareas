using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareanumero2
{
    internal class Program
    {
        private static object item;

        static void Main(string[] args)
        {
            string[] empleado = { "daniela", "ale", "migue" };
            int[] salario = { 2000, 3400, 3000 };
            int aguinaldo = 0;
            foreach (string item in empleado)
            {
                Console.WriteLine(item);
            }
            foreach (int item in salario)
            {
                Console.WriteLine("Su salario actual: "+item);
            }
            for (int i = 0; i < salario.Length; i++)
            {
                aguinaldo= salario[i]*12;
                Console.WriteLine("su aguinaldo " + aguinaldo);

            }

            


            }
    }
}
