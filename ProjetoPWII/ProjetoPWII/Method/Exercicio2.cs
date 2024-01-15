using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPWII.Method
{
    internal class Exercicio2
    {
        public string Consumo(float c1, float c2, float c3, float c4, float c5, float c6)
        {
            string resposta = "";
            float media = (c1 + c2 + c3 + c4 + c5 + c6) / 6;

            if (media < 100 )
            {
                resposta = "Consumo de " + media.ToString("C") + ". Seu consumo é normal!";
            }
            else if (media >= 100 && media < 300)
            {
                resposta = "Consumo de " + media.ToString("C") + ". Seu consumo é alto!";
            }
            else if (media >= 300 )
            {
                resposta = "Consumo de " + media.ToString("C") + ". Seu consumo esta muito alto!";
            }

            return resposta;
        }
    }
}
