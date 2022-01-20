using System;

namespace TesteAberto
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] array = { 4, 8, 6, 1, 3, 7 };
			int valorAlvo = 7;

			for (int indice1 = 0; indice1 < array.Length; indice1++)
			{
				for (int indice2 = 0; indice2 < array.Length; indice2++)
				{
					if (indice1 != indice2 && (array[indice1] + array[indice2]) == valorAlvo)
					{
						Console.WriteLine($"{array[indice1]} (Indice: {indice1}) + {array[indice2]} (Indice: {indice2}) = {valorAlvo}");
					}
				}
			}
		}
    }
}