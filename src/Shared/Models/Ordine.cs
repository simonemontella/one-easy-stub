namespace Shared.Models {

	public class Ordine {

		public int ID { get; set; }
		public DateTime Data { get; set; }

		public float Totale { get; set; }

		public int ClienteID { get; set; }

		public virtual Cliente Cliente { get; set; } = null!;

		public virtual ICollection<LineaOrdine> Linee { get; set; } = new List<LineaOrdine>();

	}

	public class LineaOrdine {

		public int ID { get; set; }

		public string Prodotto { get; set; } = null!;

		public float Quantita { get; set; }

		public float PrezzoUnitario { get; set; }

		public float Subtotale { get; set; }

		public int OrdineID { get; set; }

		public virtual Ordine Ordine { get; set; } = null!;
	}
}
