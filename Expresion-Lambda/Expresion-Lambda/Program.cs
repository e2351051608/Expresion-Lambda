//En el código que se da a continuación, tenemos una lista de números enteros. 
//La primera expresión lambda evalúa el cuadrado de cada elemento { x = > x * x } 
//la segunda se usa para encontrar qué valores son divisibles por 3 { x = > (x % 3) == 0 } 
//los bucles foreach se utilizan para mostrar.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expressions
{
	class Program
	{
		static void Main(string[] args)
		{
			// List to store numbers
			List<int> numeros = new List<int>() {15, 45, 6,
							8, 21, 9, 14, 10, 4, 18, 25, 30, 11};

			// Bucle para mostrar la lista
			Console.Write("La lista : ");
			foreach (var value in numeros)
			{
				Console.Write("{0} ", value);
			}
			Console.WriteLine();

			// Uso de la expresión lambda para calcular el cuadrado.
			var cuadrado = numeros.Select(x => x * x);

			// Bucle para mostrar los cuadrados
			Console.Write("Cuadrados de  cada numero : ");
			foreach (var value in cuadrado)
			{
				Console.Write("{0} ", value);
			}
			Console.WriteLine();

			// Uso de la expresión lambda para encontrar numeros divisibles para 3.
			List<int> divd3 = numeros.FindAll(x => (x % 3) == 0);

			// Bucle para mostrar los divisibles de 3
			Console.Write("Numeros divisibles para 3 : ");
			foreach (var value in divd3)
			{
				Console.Write("{0} ", value);
			}
			Console.WriteLine();
		}
	}
}
