using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Banguat.TipoCambio cliente = new Banguat.TipoCambio();

            var resultado = cliente.TipoCambioDia();

            Console.WriteLine(resultado.CambioDolar.First().fecha);
            Console.WriteLine(resultado.CambioDolar.First().referencia);

            Console.ReadKey();
        }
    }
}
