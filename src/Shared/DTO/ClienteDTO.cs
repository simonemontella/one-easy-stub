namespace Shared.DTO {
	public class CreateClienteDTO {
		public string RagioneSociale { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Telefono { get; set; } = null!;
		public string Indirizzo { get; set; } = null!;
		public string Citta { get; set; } = null!;
		public string Cap { get; set; } = null!;
		public string Provincia { get; set; } = null!;
	}

	public class UpdateClienteDTO {
		public string RagioneSociale { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Telefono { get; set; } = null!;
		public string Indirizzo { get; set; } = null!;
		public string Citta { get; set; } = null!;
		public string Cap { get; set; } = null!;
		public string Provincia { get; set; } = null!;
	}

	public class ClienteDTO {
		public int Id { get; set; }
		public string RagioneSociale { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Telefono { get; set; } = null!;
		public string Indirizzo { get; set; } = null!;
		public string Citta { get; set; } = null!;
		public string Cap { get; set; } = null!;
		public string Provincia { get; set; } = null!;
	}

	public class ClienteListDTO {
		public int Id { get; set; }
		public string RagioneSociale { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Citta { get; set; } = null!;
	}

}
