using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models.Aplicativos;

namespace DesafioPOO.Models.Aplicativos.Dicionario
{
	public class Dicionario_Android : IDicionario
	{
		
		public Dictionary<string, string> Dicionario { get; set; }

		public void AdicionarAoDicionario()
		{
			Console.WriteLine("Digite uma Palavra para Adicionar no Dicionário: ");
			string palavra = Console.ReadLine();
			
			Console.WriteLine("\nDigite a descrição da Palavra escolhida: ");
			string descricao = Console.ReadLine();
			
			if(!Dicionario.ContainsKey(palavra))
			{
				Dicionario.Add(palavra, descricao);
			}
			else
			{
				Console.WriteLine($"Palavra {palavra} já cadastrada!");
			}
		}

		public void RemoverDoDicionario()
		{
			Console.WriteLine("Digite a Palavra que você deseja remover: ");
			string palavra = Console.ReadLine();
			
			if(Dicionario.ContainsKey(palavra))
			{
				Dicionario.Remove(palavra);
				Console.WriteLine("A palavra {0} foi removida do seu Dicionário! ", palavra);
			}
			else
			{
				Console.WriteLine("A palavra {0} não existe no seu Dicionário ... ", palavra);
			}
		}
		
		public void ConsultarDicionario()
		{
			Console.WriteLine("\n------- Seu Dicionário -------");
			foreach(KeyValuePair<string, string> kvp in Dicionario)
			{
				Console.WriteLine($"Palavra: {kvp.Key} ," +
								  $"\nDescrição: {kvp.Value} .");
			}
		}

		public bool ProcurarPalavraNoDicionario()
		{
			Console.WriteLine("Escolha a palavra a ser pesquisada: ");
			string palavra = Console.ReadLine();
			
			bool palavraExiste = Dicionario.ContainsKey(palavra);
			
			if(palavraExiste)
			{
				Console.WriteLine($"Palavra: {palavra} ," +
								  $"Descrição {Dicionario[palavra]}");
			}
			else
			{
				Console.WriteLine($"A palavra {palavra} não está cadastrada no seu Dicionário!😕");
			}
			
			return palavraExiste;
		}

		public bool ProcurarDescricaoNoDicionario()
		{
			Console.WriteLine("Digite a descrição, ou parte desta, a ser pesquisada: ");
			string descricao = Console.ReadLine();
			
			bool descricaoExiste = false;//Dicionario.ContainsValue(descricao);
			
			foreach(KeyValuePair<string, string> kvp in Dicionario)
			{
				if(kvp.Value.Contains(descricao, StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine("-- Descrição Encontrada! --");
					Console.WriteLine($"Palavra {kvp.Key} ," +
									  $"Descrição: {descricao}");
					descricaoExiste = true;
				}
			}
			return descricaoExiste;
		}
		
		public void Executar()
		{
			while(true)
			{
				Console.WriteLine("Escolha uma opção de função do Dicionário: " +
								  "\n 1 - Adicionar Palavra Ao Dicionário " +
								  "\n 2 - Remover Palavra Do Dicionário " +
								  "\n 3 - Consultar o Dicionário " +
								  "\n 4 - Procurar Palavra No Dicionário " +
								  "\n 5 - Procurar Descrição No Dicionario " +
								  "\n 6 - Sair");
				string opcao = Console.ReadLine();
				
				switch(opcao)
				{
					case "1":
						AdicionarAoDicionario();
						break;
					case "2":
						RemoverDoDicionario();
						break;
					case "3":
						ConsultarDicionario();
						break;
					case "4":
						ProcurarPalavraNoDicionario();
						break;
					case "5":
						ProcurarDescricaoNoDicionario();
						break;
					case "6":
						return;
					default:
						Console.WriteLine("Opção Inválida! Tente Novamente ...");
						break;
				}	
			}
		}
	
	}
}