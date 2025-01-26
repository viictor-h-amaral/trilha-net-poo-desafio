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
	public abstract class Android : Smartphone
	{
		public Android(string numero, string modelo) : base(numero, modelo)
		{
		}
		
		public Android()
		{
		}
		
		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine("Aplicativo {0}_Android instalado com sucesso!", nomeApp);
		}

		public override void ExecutarAplicativo(string nomeApp)
		{
			if(Apps.Contains(nomeApp))
			{
				switch(nomeApp)
				{
					case "Calculadora":
						Calculadora_Android calculadora = new();
						calculadora.Executar();
						break;
					case "Dicionario":
						Dicionario_Android dicionario = new();
						dicionario.Executar();
						break;
					case "Mensagens":
						Mensagens_Android mensagens = new();
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