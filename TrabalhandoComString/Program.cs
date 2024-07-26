using System;
using System.Globalization;

namespace stringteste
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 29;
            string nome = "Matheus Britto";
            double saldo = 840.45;

            Console.WriteLine("Cliente Sr(a) {0} tem {1} anos, e seu saldo é de R${2:F2}", nome, idade, saldo);
            Console.WriteLine($"Cliente Sr(a) {nome} tem {idade} anos, e seu saldo é de R${saldo:F2}");
            Console.WriteLine("Cliente Sr(a) " + nome + " tem " + idade + " anos, e seu saldo é de R$" + saldo.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
