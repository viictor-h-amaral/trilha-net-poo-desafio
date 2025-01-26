using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models.Aplicativos;

namespace DesafioPOO.Models.Aplicativos.Calculadora
{
	public class Calculadora_Sysbian : ICalculadora
	{
		public double Produto ()
		{
			List<double> numeros = ICalculadora.ListaDeNumeros();
			double produtoFinal = 1;
			
			foreach(double numero in numeros)
			{
				produtoFinal *= numero;
			}
			
			return produtoFinal;
		}
		
		public double Quadrado ()
		{
			double num = ICalculadora.EscolheNumeros(true, true);
			double quadrado = num*num;
			
			return quadrado;
		}
		
		public double RaizQuadrada ()
		{
			double num = ICalculadora.EscolheNumeros(true, true);
			double raizDoQuadradoMaisProximo = Math.Floor(Math.Sqrt(num));
			double quadradoPerfeitoMaisProximo = Math.Pow(raizDoQuadradoMaisProximo, 2);
			
			double raiz = (quadradoPerfeitoMaisProximo + num)/(2*raizDoQuadradoMaisProximo);
			return raiz;
		}
		
		public double Potenciacao()
		{
			int num1 = ICalculadora.EscolheNumerosInteiros(false, true);
			int num2 = ICalculadora.EscolheNumerosInteiros(false, false);
			double potencia = 1;
			
			for(int i = 0; i < num2; i++)
			{
				potencia *= num1;
			}
			
			return potencia;
		}
		
		public void Executar()
		{
			while(true)
			{
				Console.WriteLine("Escolha uma opção de função da Calculadora: " +
								  "\n 1 - Somar " +
								  "\n 2 - Subtrair " +
								  "\n 3 - Dividir " +
								  "\n 4 - Multiplicar " +
								  "\n 5 - Elevar ao Quadrado " +
								  "\n 6 - Raiz Quadrada " +
								  "\n 7 - Potenciação " +
								  "\n 8 - Sair");
				string opcao = Console.ReadLine();
				
				switch(opcao)
				{
					case "1":
						ICalculadora.Somar();
						break;
					case "2":
						ICalculadora.Subtrair();
						break;
					case "3":
						ICalculadora.Dividir();
						break;
					case "4":
						Produto();
						break;
					case "5":
						Quadrado();
						break;
					case "6":
						RaizQuadrada();
						break;
					case "7":
						Potenciacao();
						break;
					case "8":
						return;
					default:
						Console.WriteLine("Opção Inválida! Tente Novamente ...");
						break;
				}	
			}
			
		}
	}
}