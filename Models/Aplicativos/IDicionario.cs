using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  DesafioPOO.Models.Aplicativos
{
	public interface IDicionario
	{
		public Dictionary<string, string> Dicionario { get; set; }
		
		public void AdicionarAoDicionario();
		
		public void RemoverDoDicionario();
		
		public void ConsultarDicionario(); //consulta todo o dicionario
		
		public void Executar();
	}
}