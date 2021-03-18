using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld15
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = null; // por padrão struct não pode receber valor nulo.

            double? x = null; // é possível usar nulo com o operador nullable '?' ou 'Nullable<double> x = null'; // útil para campos não obrigatorios (datas, números).
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // método 'x.GetValueOrDefault()' obtem o valor padrão da variável, nesse caso é '0' por ser nulo.
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // método 'x.HasValue' indica se tem ou não valor, 'true' ou 'false'.
            Console.WriteLine(y.HasValue);


            // Operador de coalescência nula '??'
            double a = x ?? 5; // se o 'x' for null o '5' será atribuido no lugar do 'x'.
            double b = y ?? 5;

            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
