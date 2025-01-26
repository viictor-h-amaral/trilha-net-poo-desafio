using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models.Aplicativos;

namespace DesafioPOO.Models.Aplicativos.Mensagens
{
	public class Mensagens_Sysbian : IMensagens
	{
		public Dictionary< string, Dictionary<DateTime, string> > ContatosEConversas {get; set;}

		public void AdicionarContato()
		{
			Console.WriteLine("===== DADASTRO DE CONTATO =====");
			Console.WriteLine(" Digite o Nome do seu Contato:");
			string contato = Console.ReadLine();
			
			if(!ContatosEConversas.ContainsKey(contato))
			{
				ContatosEConversas.Add(contato, 
										new Dictionary<DateTime, string> 
											{ 
												{ DateTime.Now, String.Empty }
											}
									  );
			}
			else
			{
				Console.WriteLine($"Contato {contato} já existe!");
			}
		}

		public void EnviarMensagem()
		{
			string contato = SelecionarContato();
			if (contato == String.Empty)
			{
				return;
			}
			
			Console.WriteLine($"Contato Selcionado: {contato}. "+
							  $"Digite sua mensagem: ");
			
			string mensagem = Console.ReadLine();
			
			ContatosEConversas[contato].Add(DateTime.Now, mensagem);
		}

		public void RemoverContato()
		{
			string contato = SelecionarContato();
			if (contato == String.Empty)
			{
				return;
			}
			
			ContatosEConversas.Remove(contato);
			Console.WriteLine("Contato {0} removido.", contato);
		}

		public string SelecionarContato()
		{
			Console.WriteLine("===== SEUS CONTATOS =====");
			foreach(KeyValuePair<string, Dictionary<DateTime, string> > kvp in ContatosEConversas)
			{
				Console.WriteLine($"Contato: {kvp.Key}");
			}
			Console.WriteLine("--------------------------------------------------");
			string contato = Console.ReadLine();
			
			if(ContatosEConversas.ContainsKey(contato))
			{
				return contato;
			}
			else
			{
				Console.WriteLine("Contato digitado não existe.");
				return String.Empty;
			}
		}

		public void VisualizarContato()
		{
			string contato = SelecionarContato();
			if (contato == String.Empty)
			{
				return;
			}
			
			Console.WriteLine($"Mensagens do contato '{contato}' :" +
							  $"-------------------------------------------");
			foreach(KeyValuePair<DateTime, string> kvp in ContatosEConversas[contato])
			{
				Console.WriteLine($"\n{kvp.Value} -- {kvp.Key:dd/MM/yyyy HH:mm:ss}");
			}
		}
	
		public void Executar()
		{
			while(true)
			{
				Console.WriteLine("Escolha uma opção de função do Dicionário: " +
								  "\n 1 - Adicionar um Contato " +
								  "\n 2 - Enviar Mensagem a um Contato " +
								  "\n 3 - Remover um Contato " +
								  "\n 4 - Visualizar um Contato " +
								  "\n 5 - Sair");
				string opcao = Console.ReadLine();
				
				switch(opcao)
				{
					case "1":
						AdicionarContato();
						break;
					case "2":
						EnviarMensagem();
						break;
					case "3":
						RemoverContato();
						break;
					case "4":
						VisualizarContato();
						break;
					case "5":
						return;
					default:
						Console.WriteLine("Opção Inválida! Tente Novamente ...");
						break;
				}	
			}
		}
	}
}