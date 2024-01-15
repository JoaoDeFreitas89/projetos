using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPWII.Method;

namespace ProjetoPWII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1 nada = new Exercicio1();

            Console.WriteLine("Exercicio 1 ---> Categorias \n");

            Console.WriteLine("Digite o nome do aluno(a) abaixo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno(a) abaixo: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            nada.Nadador(idade: age, nome: name);
            

            Exercicio2 cons = new Exercicio2();

            Console.WriteLine("Exercicio 2 ---> Consumo \n");

            Console.WriteLine("Insira seu consumo no mes 1 abaixo: ");
            float val1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu consumo no mes 2 abaixo: ");
            float val2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu consumo no mes 3 abaixo: ");
            float val3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu consumo no mes 4 abaixo: ");
            float val4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu consumo no mes 5 abaixo: ");
            float val5 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu consumo no mes 6 abaixo: ");
            float val6 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            string result = cons.Consumo(val1, val2, val3, val4, val5, val6);

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
