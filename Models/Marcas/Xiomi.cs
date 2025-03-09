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
	public class Xiomi : Android
	{
		public Xiomi(string modelo) : base(modelo)
		{
		}
		
		public static string EscolheModelo()
		{
			string modelo = String.Empty;
			while(modelo == String.Empty)
			{
				Console.WriteLine("Escolha uma opção de função do Dicionário: " +
								  "\n 1 - POCO C65" +
								  "\n 2 - Redmi Note 13 " +
								  "\n 3 - Redmi Note A3 " +
								  "\n 4 - Redmi 14C Starry " +
								  "\n 5 - Redmi K70 PRO Champion Ed. " +
								  "\n 6 - MI 9 Lite " +
								  "\n 7 - Redmi A3X");
				string opcao = Console.ReadLine();
				
				switch(opcao)
				{
					case "1":
						modelo = "POCO C65";
						break;
					case "2":
						modelo = "Redmi Note 13";
						break;
					case "3":
						modelo = "Redmi Note A3";
						break;
					case "4":
						modelo = "Redmi 14C Starry";
						break;
					case "5":
						modelo = "Redmi K70 PRO Champion Ed.";
						break;
					case "6":
						modelo = "MI 9 Lite";
						break;
					case "7":
						modelo = "Redmi A3X";
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