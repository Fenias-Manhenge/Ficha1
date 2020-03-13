using System;

public class Exercicio3
{
	public static void main(String [] args)
	{
		Console.WriteLine("Introduza uma nota: ");
		double nota = double.Parse(Console.ReadLine());

		do
		{
			if(nota >= 0 && nota < 6)
            {
				Console.WriteLine("Mau");
            }else if (nota >= 6 && nota < 9.5)
			{
				Console.WriteLine("Mediocre");
			}else if (nota >= 9.5 && nota < 13.5)
			{
				Console.WriteLine("Suficiente");
			}
			else if(nota >= 13.5 && nota < 16.5)

			{
				Console.WriteLine("Bom");
			}else
			{
				Console.WriteLine("Muito Bom");
			}


		} while (nota <= 20);

		if(! nota <= 20){
			System.Console.WriteLine("Nota Invalida");
        }
	}
}
