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
		public Android(string modelo) : base(modelo)
		{
		}
		
		
		Dicionario_Android dicionario = new();
		
		Calculadora_Android calculadora = new();

		Mensagens_Android mensagens = new();
		
		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine("Aplicativo {0}_Android instalado com sucesso!", nomeApp);
		}

		public override void ExecutarAplicativo(string nomeApp)
		{
			if(Apps.Contains(nomeApp.ToLower()))
			{
				switch(nomeApp.ToLower())
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
	
		public override void Ligar()
		{
			if(!Apps.Contains("Mensagens"))
			{
				Console.WriteLine("Aplicativo 'Mensagens' não está instalado no seu Smartphone!");
				return;
			}
			string contato = mensagens.SelecionarContato();
			if(contato != String.Empty)
			{
				Random gerador = new Random();
				int num = gerador.Next(1,100);
				
				if(num % 5 == 0)
				{
					Console.WriteLine("Chamada não atendida! Deixe um recado: ");
					mensagens.EnviarMensagem();
				}
				else
				{
					Console.WriteLine("Você ligou para {0}!", contato);
				}
			}
		}
	}
}