namespace Shared.Models {
	public class Cliente {

		public int ID { get; set; }

		public string RagioneSociale { get; set; } = null!;

		public string Email { get; set; } = null!;

		public string Telefono { get; set; } = null!;

		public string Indirizzo { get; set; } = null!;

		public string Citta { get; set; } = null!;

		public string Cap { get; set; } = null!;

		public string Provincia { get; set; } = null!;

		public virtual ICollection<Ordine> Ordini { get; set; } = new List<Ordine>();

	}
}
