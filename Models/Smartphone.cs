using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
	public abstract class Smartphone
	{
		//
		// NÚMERO
		//
		private string _numero = String.Empty;
		public string Numero { 
			get
			{
				return _numero;
			}
			set
			{
				string padraoNumero = @"^\(\d{2}\)[9]\d{4}\-\d{4}$";
				bool numeroNoPadrao = Regex.IsMatch(value, padraoNumero, RegexOptions.None, TimeSpan.FromSeconds(2));
				try
				{
					if(numeroNoPadrao && _numero == String.Empty)
					{
						_numero = value;
					}
					else if (!numeroNoPadrao)
					{
						throw new Exception($"Número informado não está no formato correto! \n" +
											$"Padrão de número é (99)99999-9999");
					}
					else 
					{
						throw new Exception($"Já há um número cadastrado neste telefone!");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Erro! : " + ex.Message);
				}
				
			}
		}
		//
		// MODELO
		//
		private string _modelo = String.Empty;
		public string Modelo { 
			get
			{
				return _modelo;
			} 
			set
			{
				try
				{
					if(_modelo == String.Empty)
					{
						_modelo = value;
					}
					else
					{
						throw new Exception("Modelo já cadastrado!");
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine("Erro! : " + ex.Message);
				}
				
			}
		}
		// TODO: Implementar as propriedades faltantes de acordo com o diagrama
		//
		// IMEI
		//
		private int _imei;
		public int IMEI 
		{
			get
			{
				return _imei;
			}
		} 
		//
		// PROCESSAMENTO
		//
		private Dictionary<string, int> _processamento;
		public Dictionary<string, int> Processamento
		{
			get
			{
				return _processamento;
			}
		}
		//
		// LISTA DE APPS
		//
		public List<string> Apps { get;set; } = [];
		//
		// CONSTRUTORES
		//
		public Smartphone(string modelo)
		{
			bool loopNumero = true;
			while(loopNumero)
			{
				try
				{
					Console.WriteLine("Digite o número do Smartphone (formato '(00)90000-0000'): ");
					Numero = Console.ReadLine();
					
					loopNumero = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Erro! : " + ex.Message);
				}
			}
			
			_imei = GeraIMEI();
			Modelo = modelo;
			
			Dictionary<string, int> processamento = NovoProcess();
			_processamento = processamento;
		}
		//
		// MÉTODOS
		//
		private static Dictionary<string, int> NovoProcess()
		{
			while(true)
			{
				Dictionary<string, int> novoProcess = new();
				try
				{
					Console.WriteLine("Digite o número de MB da memória RAM: ");
					novoProcess["Memória RAM"] = Convert.ToInt32(Console.ReadLine());
							
					Console.WriteLine("Digite o número de núcleos do processador: ");
					novoProcess["Núcleos"] = Convert.ToInt32(Console.ReadLine());
					
					Console.WriteLine("Digite o número de GB do seu armazenamento: ");
					novoProcess["Armazenamento"] = Convert.ToInt32(Console.ReadLine());
					
					return novoProcess;
				}
				catch (FormatException)
				{
					Console.WriteLine("\n Erro! : Digite um número inteiro!");
				}	
				catch (Exception ex)
				{
					Console.WriteLine("\n Erro! : " + ex.Message);
				}
			}
			
			
		}
		
		private static int GeraIMEI()
		{
			Random gerador = new Random();
			int novoIMEI = gerador.Next(Convert.ToInt32(Math.Pow(10,5)), Convert.ToInt32(Math.Pow(10,8)-1));
			return novoIMEI;
		}
		
		
		public void AddApp(string novoApp)
		{
			switch(novoApp.ToLower())
			{
				case "calculadora":
				case "dicionario":
				case "dicionário":
				case "mensagens":
					Apps.Add(novoApp.ToLower());
					InstalarAplicativo(novoApp);
					break;
				default:
					Console.WriteLine("Nenhum App com esse nome encontrado!");
					break;
			}
		}
		
		public abstract void InstalarAplicativo(string nomeApp);
		
		public abstract void ExecutarAplicativo(string nomeApp);
		
		public abstract void Ligar();

	}
}