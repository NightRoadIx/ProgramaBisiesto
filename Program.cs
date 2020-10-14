using System;

namespace bisiesto
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Colocar colores y esas cosas en el programa
			int aa;			
			do
			{
				Console.WriteLine("Ingresar un año (valor entero y positivo): ");
				string a = Console.ReadLine();
				// TODO: Revisar que la cadena de texto es un número
				// TODO: Revisar que es un entero también
				// Así ya se puede convertir a un entero de 32 bits
				aa = Convert.ToInt32(a);
				if (aa > 0)
					break;
				else
					Console.WriteLine("No manches, que no sabes leer!");
			}
			while(true);
			
			// Probación de que es un año bisiesto
			if( (aa % 4 == 0)&&(aa % 100 != 0)||(aa % 400 == 0) )
				Console.WriteLine("El año {0} es bisiesto", aa);
			else
				Console.WriteLine("El año {0} NO es bisiesto", aa);
			
			Console.Write("Presione una tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}