using Shared.Models;

namespace Shared.DTO {
	public class CreateOrdineDTO {
		public int ClienteId { get; set; }
		public DateTime Data { get; set; }
		public float Totale { get; set; }
		public List<LineaOrdine>? Linee { get; set; }
	}

	public class OrdineDTO {
		public int Id { get; set; }
		public int ClienteId { get; set; }
		public string ClienteRagioneSociale { get; set; } = null!;
		public DateTime Data { get; set; }
		public float Totale { get; set; }
		public List<LineaOrdine> Linee { get; set; } = [];
	}
}