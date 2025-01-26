using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models.Aplicativos;
using DesafioPOO.Models.Aplicativos.Calculadora;
using DesafioPOO.Models.Aplicativos.Dicionario;
using DesafioPOO.Models.Aplicativos.Mensagens;

namespace DesafioPOO.Models.Systems
{
	// TODO: Herdar da classe "Smartphone"
	public abstract class Iphone : Smartphone
	{
		public Iphone(string numero, string modelo) : base(numero, modelo)
		{
		}
		
		public Iphone()
		{
		}
		// TODO: Sobrescrever o método "InstalarAplicativo"
		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine("Aplicativo {0}_IPhone instalado com sucesso!", nomeApp);
		}

		public override void ExecutarAplicativo(string nomeApp)
		{
			if(Apps.Contains(nomeApp))
			{
				switch(nomeApp)
				{
					case "Calculadora":
						Calculadora_Iphone calculadora = new();
						calculadora.Executar();
						break;
					case "Dicionario":
						Dicionario_Iphone dicionario = new();
						dicionario.Executar();
						break;
					case "Mensagens":
						Mensagens_Iphone mensagens = new();
						mensagens.Executar();
						break;
				}	
			}
			else
			{
				Console.WriteLine("App não instalado!");
			}
			
		}

	}
}