using DesafioPOO.Models.Systems;
using DesafioPOO.Models.Aplicativos.Calculadora;
using DesafioPOO.Models.Aplicativos.Dicionario;
using DesafioPOO.Models.Aplicativos.Mensagens;

namespace DesafioPOO.Models.Marcas
{
	// TODO: Herdar da classe "Smartphone"
	public class Nokia : Sysbian
	{
		public Nokia(string modelo) : base(modelo)
		{
		}
		public static string EscolheModelo()
		{
			string modelo = String.Empty;
			while(modelo == String.Empty)
			{
				Console.WriteLine("Escolha uma opção de função do Dicionário: " +
								  "\n 1 - Tijolão " +
								  "\n 2 - Tijolão Cinza Abre e Fecha" +
								  "\n 3 - Brick -- EngVersion" +
								  "\n 4 - OldSchool 2.0");
				string opcao = Console.ReadLine();
				
				switch(opcao)
				{
					case "1":
						modelo = "Tijolão";
						break;
					case "2":
						modelo = "Tijolão Cinza Abre e Fecha";
						break;
					case "3":
						modelo = "Brick -- EngVersion";
						break;
					case "4":
						modelo = "OldSchool 2.0";
						break;
					default:
						Console.WriteLine("Opção Inválida! Tente Novamente ...");
						break;
				}	
			}
			return "Nokia." + modelo;
		}
	}
}