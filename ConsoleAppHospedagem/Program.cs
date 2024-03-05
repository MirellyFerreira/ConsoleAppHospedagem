using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHospedagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da diária do hotel: ");
            double dh = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de adultos: ");
            double qa = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de crianças: ");
            double qc = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de dias que você ficrá hospedado: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de parcelas: ");
            double np = double.Parse(Console.ReadLine());

            double vd = dh * qa + (dh / 2 * qc);
            double vth = vd * h;
            double vp = vth / np;

            Console.WriteLine("O valor da diária da família será: "+ vd);
            Console.WriteLine("O valor total da hospedagem será: "+ vth);
            Console.WriteLine("O valor de cada parcela será: "+ vp);

            Console.ReadKey();
        }
    }
}
