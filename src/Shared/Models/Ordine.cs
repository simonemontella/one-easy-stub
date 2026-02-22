namespace Shared.Models {

	public class Ordine {

		public int Id { get; set; }

		public Cliente Cliente { get; set; }
		public DateTime Data { get; set; }

		public List<LineaOrdine> Linee { get; set; }
		public float Totale { get; set; }

	}

	public class LineaOrdine {
		public Prodotto Prodotto { get; set; }
		public int Quantita { get; set; }
		public float Subtotale { get; set; }
	}
}
