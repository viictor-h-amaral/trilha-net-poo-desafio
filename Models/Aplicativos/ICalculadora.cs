using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models.Aplicativos
{
	public interface ICalculadora
	{
		public static double Somar()
		{
			List<double> numeros = ListaDeNumeros();
			double soma = 0;
			
			foreach(double numero in numeros)
			{
				soma += numero;
			}
			
			return soma;
		}
		
		public static double Subtrair()
		{
			double num1  = EscolheNumeros(false, true);
			double num2 = EscolheNumeros(false, false);
			double subtracao = num1 - num2;
			return subtracao;
		}
		
		public static double Dividir()
		{
			double num1  = EscolheNumeros(false, true);
			double num2 = EscolheNumeros(false, false);
			double divisao = num1 / num2;
			return divisao;
		}
		
		public double Produto();
		
		public double Quadrado();
		
		public double RaizQuadrada();
		
		public double Potenciacao();
		
		public static double EscolheNumeros(bool umNumeroApenas, bool ehPrimeiroNumero)
		{
			double num = 0;
			bool loopNum = true;
			
			while(loopNum)
			{
				if(umNumeroApenas)
				{
					Console.WriteLine("Digite um número: ");
				}
				else
				{
					Console.WriteLine($"Digite o {(ehPrimeiroNumero ? "primeiro" : "segundo")} número: ");
				}
				
				loopNum = !Double.TryParse(Console.ReadLine(), out num);
			}
			
			if(loopNum)
			{
					Console.WriteLine("Digite um número!");
			}
			
			return num;
		}
		
		public static List<double> ListaDeNumeros()
		{
			List<double> numeros = new();
			while(true)
			{
				Console.WriteLine("Digite um Número para adicionar à Lista ou uma Letra para parar: ");
				bool ehDouble = Double.TryParse(Console.ReadLine(), out double novoNumero);
				
				if(ehDouble)
				{
					numeros.Add(novoNumero);
				}
				else
				{
					return numeros;
				}
			}
		}
		
		public static int EscolheNumerosInteiros(bool umNumeroApenas, bool ehPrimeiroNumero)
		{
			int num = 0;
			bool loopNum = true;
			
			while(loopNum)
			{
				if(umNumeroApenas)
				{
					Console.WriteLine("Digite um número: ");
				}
				else
				{
					Console.WriteLine($"Digite o {(ehPrimeiroNumero ? "primeiro" : "segundo")} número: ");
				}
				
				loopNum = !Int32.TryParse(Console.ReadLine(), out num);
				
				if(loopNum)
				{
					Console.WriteLine("Digite um número Inteiro!");
				}
				
			}
			
			return num;
		}
	
		public void Executar();
	}
	
}