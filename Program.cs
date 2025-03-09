using System.ComponentModel;
using DesafioPOO.Models;
using DesafioPOO.Models.Marcas;
{
// TODO: Realizar os testes com as classes Nokia e Iphone

	List <Smartphone> lista = new();

	/*
	while(true)
	{
		while(true)
		{
			Console.WriteLine("Escolha uma opção : " +
								"\n 1 - Novo Celular " +
								"\n 2 - Acessar Celular " +
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
				ditarContato();
				break;
			case "8":
				return;
			default:
				Console.WriteLine("Opção Inválida! Tente Novamente ...");
				break;
			}	
		}
		
	}*/
	
	bool loopNovoCelular = true;

	Console.WriteLine("===== NOVO CELULAR =====" +
					"\n------------------------");

	while(loopNovoCelular)
	{
		Console.WriteLine("Escolha uma das Marcas: " +
							"\n 1 - Apple " +
							"\n 2 - Samsung " +
							"\n 3 - Xiomi " +
							"\n 4 - Nokia " +
							"\n 5 - Ecerrar Programa");
		string opcao = Console.ReadLine();
			
		switch(opcao)
		{
			case "1":
				string modelo = Apple.EscolheModelo();
				Apple iphone = new Apple(modelo);
				lista.Add(iphone);
				loopNovoCelular = false;
				break;
			case "2":
				string modelo2 = Samsung.EscolheModelo();
				Samsung samsung = new Samsung(modelo2);
				lista.Add(samsung);
				loopNovoCelular = false;
				break;
			case "3":
				string modelo3 = Xiomi.EscolheModelo();
				Xiomi xiomi = new Xiomi(modelo3);
				lista.Add(xiomi);
				loopNovoCelular = false;
				break;
			case "4":
				string modelo4 = Nokia.EscolheModelo();
				Nokia nokia = new Nokia(modelo4);
				lista.Add(nokia);
				loopNovoCelular = false;
				break;
			case "5":
				loopNovoCelular = false;
				break;
			default:
				Console.WriteLine("Opção Inválida! Tente Novamente ...");
				break;
		}	
	}
	
	Console.WriteLine(lista[0].IMEI);
	foreach(string app in lista[0].Apps)
	{
		Console.WriteLine($"APP : {app}");
	}
	
	Console.WriteLine(lista[0].Numero); //erro no padrão dop número
	Console.WriteLine(lista[0].Modelo); //não é assim que pego o modelo ...
	
	foreach(KeyValuePair<string, int> kvp in lista[0].Processamento)
	{
		Console.WriteLine($"{kvp.Key} : {kvp.Value}");
	}
	
	lista[0].AddApp("Calculadora");
	lista[0].AddApp("Mensagens");
	lista[0].AddApp("Dicionário");
	foreach(string app in lista[0].Apps)
	{
		Console.WriteLine($"APP : {app}");
	}
	lista[0].ExecutarAplicativo("calculadora");
	lista[0].ExecutarAplicativo("Dicionario");
	lista[0].ExecutarAplicativo("Mensagens");
	lista[0].Ligar();
	
	
}