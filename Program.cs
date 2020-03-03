using System;

namespace Ficha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[49];
            
            int acumulo = 0, acumulo1 = 0;
            double media = 0, media1 = 0, soma =0 , soma1 = 0;
            
            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("INTRODUZA A IDADE DO " + (i + 1) + "º ALUNO");
                idade[i] = int.Parse(System.Console.ReadLine());

                if (idade[i] > 18){
                    acumulo ++;

                    soma += idade[i];
                    media = soma / acumulo;
                }
                else
                {
                    acumulo1 ++;

                    soma1 += idade[i];
                    media1 = soma1 / acumulo1;
                }

            }

            Console.WriteLine("Idades maior de 18 anos é: " + acumulo + "\n" +
                            "E menor de 18 é : " + acumulo1 +"\n");

            Console.Write("A media aritmetica de alunos >18 anos é: " + media +"\n" +
                            "E <18 anos é: " + media1);
        }
    }
}
