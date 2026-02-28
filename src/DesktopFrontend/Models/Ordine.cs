using System;
using System.Collections.Generic;

namespace DesktopFrontend.Models {
	public class Ordine {
		public int ID { get; set; }
		public int ClienteID { get; set; }
		public string ClienteRagioneSociale { get; set; }
		public DateTime Data { get; set; }
		public float Totale { get; set; }
		public List<LineaOrdine> Linee { get; set; } = new List<LineaOrdine>();
	}

	public class LineaOrdine {
		public int ID { get; set; }
		public int OrdineID { get; set; }
		public string Prodotto { get; set; }
		public float Quantita { get; set; }
		public float PrezzoUnitario { get; set; }
		public float Subtotale { get; set; }
	}
}
