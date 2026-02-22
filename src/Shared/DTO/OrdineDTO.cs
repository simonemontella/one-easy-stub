namespace Shared.DTO {
	public class OrdineDTO {

		public int Id { get; set; }
		public int ClienteId { get; set; }
		public string ClienteNome { get; set; }

		public DateTime Data { get; set; }
		public float Totale { get; set; }

		public int NumeroLinee { get; set; }
	}
}
