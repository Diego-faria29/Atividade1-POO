﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
	public class Calculadora
	{
		private List<double> listNumero = new List<double>();

		public void addNumero(double num)
		{
			this.listNumero.Add(num);
		}

		public double Somar()
		{
			double soma = 0;
			foreach (double numero in this.listNumero)
			{
				soma += numero;
			}
			this.listNumero.Clear();
			return soma;
		}
		public double Subtrair()
		{
			double diferenca = this.listNumero[0];
			this.listNumero.RemoveAt(0);
			foreach (double numero in this.listNumero)
			{
				diferenca -= numero;
			}
			this.listNumero.Clear();
			return diferenca;
		}

		public double Multiplicar()
		{
			double produto = this.listNumero[0];
			this.listNumero.RemoveAt(0);
			foreach (double numero in this.listNumero)
			{
				produto *=  numero;
			}
			this.listNumero.Clear();
			return produto;
		}
		public double Dividir()
		{
			double quociente = this.listNumero[0];
			this.listNumero.RemoveAt(0);
			foreach (double numero in this.listNumero)
			{
				quociente /= numero;
			}
			this.listNumero.Clear();
			return quociente;
			}

		public double Quadrado()
		{
			double pot = 0;
			
			foreach (double numero in this.listNumero)
			{
				pot = numero * numero;
			}
			this.listNumero.Clear();
			return pot;
		}
		
		public double Raiz()
		{
			double quadrada = 0;
			
			foreach (double numero in this.listNumero)
			{
				quadrada = Math.Sqrt(numero);
			}
			this.listNumero.Clear();
			return quadrada;
		}

		public double XPI()
		{
			double pi = 0;

			foreach (double numero in this.listNumero)
			{
				pi = Math.PI * numero;
			}
			this.listNumero.Clear();
			return pi;
		}
	}
}

	

