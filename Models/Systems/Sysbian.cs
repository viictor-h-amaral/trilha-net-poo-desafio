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
	public abstract class Sysbian : Smartphone
	{
		//
		// CONSTRUTORES
		//
		public Sysbian(string numero, string modelo) : base(numero, modelo)
		{
		}
		
		public Sysbian()
		{
		}
		//
		// MÉTODOS
		//
		
		Dicionario_Sysbian dicionario = new();
		
		Calculadora_Sysbian calculadora = new();

		Mensagens_Sysbian mensagens = new();
		
		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine("Aplicativo {0}_Sysbian instalado com sucesso!", nomeApp);
		}

		public override void ExecutarAplicativo(string nomeApp)
		{
			if(Apps.Contains(nomeApp))
			{
				switch(nomeApp)
				{
					case "Calculadora":
						calculadora.Executar();
						break;
					case "Dicionario":
						dicionario.Executar();
						break;
					case "Mensagens":
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