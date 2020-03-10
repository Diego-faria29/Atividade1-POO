using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculadora c = new Calculadora();

			c.addNumero(5.4);
			c.addNumero(4.6);
			c.addNumero(5.55);
			System.Console.WriteLine("Soma dos numeros: ");
			System.Console.WriteLine(c.Somar());
			System.Console.WriteLine("\n");

			c.addNumero(50);
			c.addNumero(36);
			c.addNumero(5);
			System.Console.WriteLine("Subtração dos numeros: ");
			System.Console.WriteLine(c.Subtrair());
			System.Console.WriteLine("\n");

			c.addNumero(10);
			c.addNumero(2);
			c.addNumero(8);
			System.Console.WriteLine("Multiplicação dos numeros: ");
			System.Console.WriteLine(c.Multiplicar());
			System.Console.WriteLine("\n");

			c.addNumero(32);
			c.addNumero(16);
			c.addNumero(2);
			System.Console.WriteLine("Divisão dos numeros: ");
			System.Console.WriteLine(c.Dividir());
			System.Console.WriteLine("\n");

			c.addNumero(9);
			System.Console.WriteLine("Numero ao quadrado: ");
			System.Console.WriteLine(c.Quadrado());
			System.Console.WriteLine("\n");
			
			c.addNumero(81);
			System.Console.WriteLine("Raiz quadrada do numero: ");
			System.Console.WriteLine(c.Raiz());
			System.Console.WriteLine("\n");
			
			c.addNumero(10);
			System.Console.WriteLine("Numero multiplicado por PI: ");
			System.Console.WriteLine(c.XPI());

			System.Console.ReadKey();
		}
	}
}
