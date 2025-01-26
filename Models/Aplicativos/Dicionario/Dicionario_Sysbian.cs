using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models.Aplicativos;

namespace DesafioPOO.Models.Aplicativos.Dicionario
{
	public class Dicionario_Sysbian : IDicionario
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

		public void Executar()
		{
			while(true)
			{
				Console.WriteLine("Escolha uma opção de função do Dicionário: " +
								  "\n 1 - Adicionar Palavra Ao Dicionário " +
								  "\n 2 - Remover Palavra Do Dicionário " +
								  "\n 3 - Consultar o Dicionário " +
								  "\n 4 - Sair");
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
						return;
					default:
						Console.WriteLine("Opção Inválida! Tente Novamente ...");
						break;
				}	
			}
		}
	}
}