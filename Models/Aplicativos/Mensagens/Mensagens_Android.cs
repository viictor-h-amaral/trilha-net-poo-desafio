using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models.Aplicativos;

namespace DesafioPOO.Models.Aplicativos.Mensagens
{
	public class Mensagens_Android : IMensagens
	{
		public Dictionary< string, Dictionary<DateTime, string> > ContatosEConversas {get; set;}

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

		public void VisualizarContato()
		{
			string contato = SelecionarContato();
			if (contato == String.Empty)
			{
				return;
			}
			
			MostrarMensagens(contato);
		}
	
		public DateTime SelecionarMensagem(string contato, bool paraApagar)
		{
			Console.WriteLine($"===== MENSAGENS DO CONTATO '{contato}' =====");
			MostrarMensagens(contato);
			
			Console.WriteLine($"Digite a Data da Mensagem a ser {(paraApagar ? "apagada" : "editada")} (formato esperado 'dd/MM/aaaa HH:mm:ss'): ");
			string dataMensagemString = Console.ReadLine();
			
			bool noFormatoDeData = DateTime.TryParse(dataMensagemString, out DateTime dataMensagem);
			
			if(noFormatoDeData && ContatosEConversas[contato].ContainsKey(dataMensagem))
			{
				Console.WriteLine("Mensagem Selecionada!");
				return dataMensagem;
			}
			else if(!noFormatoDeData)
			{
				Console.WriteLine("Formato de Data Inválido!");
			}
			else
			{
				Console.WriteLine("Não há mensagens nessa data!");
			}
			
			DateTime padrao = new DateTime();
			return padrao;
		}
	
		public void ApagarMensagem()
		{
			string contato = SelecionarContato();
			if (contato == String.Empty)
			{
				return;
			}
			DateTime dataMensagem = SelecionarMensagem(contato, true);
			
			ContatosEConversas[contato].Remove(dataMensagem);
		}
		
		public void EditarMensagem()
		{
			string contato = SelecionarContato();
			if (contato == String.Empty)
			{
				return;
			}
			DateTime dataMensagem = SelecionarMensagem(contato, false);
			
			Console.WriteLine("Digite a nova Mensagem: ");
			string novaMensagem = Console.ReadLine();
			
			ContatosEConversas[contato][dataMensagem] = novaMensagem;
			
		}
		
		public void MostrarMensagens(string contato)
		{
			Console.WriteLine($"Mensagens do contato '{contato}' :" +
							  $"-------------------------------------------");
			foreach(KeyValuePair<DateTime, string> kvp in ContatosEConversas[contato])
			{
				Console.WriteLine($"\n{kvp.Value} -- {kvp.Key:dd/MM/yyyy HH:mm:ss}");
			}
		}
	
		public void EditarContato()
		{
			string contato = SelecionarContato();
			if (contato == String.Empty)
			{
				return;
			}
			Console.WriteLine("Digite o novo nome do seu Contato: ");
			string novoContato = Console.ReadLine();
			
			ContatosEConversas.Add(novoContato, ContatosEConversas[contato]);
			ContatosEConversas.Remove(contato);
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
								  "\n 5 - Apagar uma Mensagem " +
								  "\n 6 - Editar uma Mensagem " +
								  "\n 7 - Editar um Contato " +
								  "\n 8 - Sair");
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
						ApagarMensagem();
						break;
					case "6":
						EditarMensagem();
						break;
					case "7":
						EditarContato();
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