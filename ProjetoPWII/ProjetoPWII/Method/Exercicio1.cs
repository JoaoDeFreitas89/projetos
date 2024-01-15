using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPWII.Method
{
    internal class Exercicio1
    {
        public void Nadador( int idade, string nome)
        {
            if (idade < 5)
            {
                Console.WriteLine("Digite uma idade valida!");
                Console.WriteLine("Pressione Enter para o Exercicio 2");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
            else if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("A Categoria do aluno(a) "+nome+" é: Infantil A");
                Console.WriteLine("Pressione Enter para o Exercicio 2");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("A Categoria do aluno(a) " + nome + " é: Infantil B");
                Console.WriteLine("Pressione Enter para o Exercicio 2");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("A Categoria do aluno(a) " + nome + " é: Juvenil A");
                Console.WriteLine("Pressione Enter para o Exercicio 2");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("A Categoria do aluno(a) " + nome + " é: Juvenil B");
                Console.WriteLine("Pressione Enter para o Exercicio 2");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("A Categoria do aluno(a) " + nome + " é: Adulto");
                Console.WriteLine("Pressione Enter para o Exercicio 2");
                Console.WriteLine("\n");
                Console.ReadKey();
            }

            

        }
    }
}
