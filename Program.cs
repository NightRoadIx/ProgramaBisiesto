using System;

namespace bisiesto
{
	class Program
	{
		
		/* Función de lectura para asegurar la conversión a entero
		 * Recibe:
		 * 	string mensaje : Cadena de caracteres con un mensaje a mostrar
		 * 
		 * Regresa:
		 *  int : Un valor entero con la cadena ingresada
		 * */
		public static int ingresarInt(string mensaje = "Ingresar un valor entero: ")
		{
			string resp;
			int valor;
			// Se coloca todo dentro de un ciclo infinito
			// TODO: Hacer que solamente se reciban valores enteros
			while(true)
			{
				// Se recibe una cadena de caracteres
				Console.WriteLine(mensaje);
				resp = Console.ReadLine();
				// Se ingresa a una sección try - catch
				try
				{
					// En este caso se intenará realizar una conversión a un calor entero 
					valor = Convert.ToInt32(resp);
					// En caso de que se logre romperá el ciclo
					break;
				}
				// Aquí se maneja la excepción, esta es del tipo FormatException
				catch(FormatException e)
				{
					Console.WriteLine("El valor no es un número entero");
					Console.WriteLine("¡Favor de ingresar de nuevo!");
				}
			}
			// Una vez que se logre salir del ciclo, se regresa el valor
			return valor;
		}
		
		public static void Main(string[] args)
		{
			// TODO: Colocar colores y esas cosas en el programa
			int aa;			
			
			// Recibir el valor entero positivo del usuario
			aa = ingresarInt("Ingresar un año (valor entero y positivo): ");
			
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
