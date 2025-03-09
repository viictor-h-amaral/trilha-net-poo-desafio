using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models.Systems;
using DesafioPOO.Models.Aplicativos.Calculadora;
using DesafioPOO.Models.Aplicativos.Dicionario;
using DesafioPOO.Models.Aplicativos.Mensagens;

namespace DesafioPOO.Models.Marcas
{
	public class Apple : Iphone
	{
		public Apple(string modelo) : base(modelo)
		{
		}
		
		public static string EscolheModelo()
		{
			string modelo = String.Empty;
			while(modelo == String.Empty)
			{
				Console.WriteLine("Escolha uma opção de função do Dicionário: " +
								  "\n 1 - IPhone 15 " +
								  "\n 2 - IPhone 15 PRO " +
								  "\n 3 - IPhone 15 PRO MÁX " +
								  "\n 4 - IPhone 16 " +
								  "\n 5 - IPhone 16 ULTRA " +
								  "\n 6 - IPad Mini " +
								  "\n 7 - Ipad Giga");
				string opcao = Console.ReadLine();
				
				switch(opcao)
				{
					case "1":
						modelo = "IPhone 15";
						break;
					case "2":
						modelo = "IPhone 15 PRO";
						break;
					case "3":
						modelo = "IPhone 15 PRO MÁX";
						break;
					case "4":
						modelo = "IPhone 16";
						break;
					case "5":
						modelo = "IPhone 16 ULTRA";
						break;
					case "6":
						modelo = "IPad Mini";
						break;
					case "7":
						modelo = "IPad Giga";
						break;
					default:
						Console.WriteLine("Opção Inválida! Tente Novamente ...");
						break;
				}	
			}
			return "Apple." + modelo;
		}
	}
}