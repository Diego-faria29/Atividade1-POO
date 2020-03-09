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
			System.Console.WriteLine(c.Somar());


			c.addNumero(50);
			c.addNumero(36);
			c.addNumero(5);
			System.Console.WriteLine(c.Subtrair());


			c.addNumero(10);
			c.addNumero(2);
			c.addNumero(8);
			System.Console.WriteLine(c.Multiplicar());


			c.addNumero(32);
			c.addNumero(16);
			c.addNumero(2);
			System.Console.WriteLine(c.Dividir());



			System.Console.ReadKey();
		}
	}
}
