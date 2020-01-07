using System;
using System.Globalization;

namespace Aluno
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Digite o Nome do Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno: ");
            a.n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double nf = a.NotaFinal();

            Console.WriteLine("NOTA FINAL: " + 
                nf.ToString("F2",CultureInfo.InvariantCulture));

            if(nf >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00 - nf) + " PONTOS");
            }

        }
    }
}
