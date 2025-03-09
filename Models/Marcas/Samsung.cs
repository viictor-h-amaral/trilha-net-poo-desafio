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
	public class Samsung : Android
	{
		public Samsung(string modelo) : base(modelo)
		{
		}
		
		public static string EscolheModelo()
		{
			string modelo = String.Empty;
			while(modelo == String.Empty)
			{
				Console.WriteLine("Escolha uma opção de função do Dicionário: " +
								  "\n 1 - Galaxy A01 " +
								  "\n 2 - Galaxy A15 " +
								  "\n 3 - Galaxy AZ " +
								  "\n 4 - Galaxy M5 " +
								  "\n 5 - Galaxy S22 ULTRA " +
								  "\n 6 - Galaxy S20 PLUS " +
								  "\n 7 - Galaxy Tab S6");
				string opcao = Console.ReadLine();
				
				switch(opcao)
				{
					case "1":
						modelo = "Galaxy A01";
						break;
					case "2":
						modelo = "Galaxy A15";
						break;
					case "3":
						modelo = "Galaxy AZ";
						break;
					case "4":
						modelo = "Galaxy M5";
						break;
					case "5":
						modelo = "Galaxy S22 ULTRA";
						break;
					case "6":
						modelo = "Galaxy S20 PLUS";
						break;
					case "7":
						modelo = "Galaxy Tab S6";
						break;
					default:
						Console.WriteLine("Opção Inválida! Tente Novamente ...");
						break;
				}	
			}
			return "Samsung." + modelo;
		}
		
	
	}
}