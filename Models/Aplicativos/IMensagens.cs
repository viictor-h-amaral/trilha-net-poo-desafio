using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models.Aplicativos
{
	public interface IMensagens
	{
		public Dictionary<string, Dictionary<DateTime, string>> ContatosEConversas {get; set;}
		
		public void AdicionarContato();
		
		public string SelecionarContato();
		
		public void EnviarMensagem();
		
		public void RemoverContato();
		
		public void VisualizarContato();
		
		public void Executar();
		
		//public void ApagarMensagem();
		//public void EditarMensasem();
		//public void SelecionarMensagem();
		//public void EditarContato();
		
	}
}