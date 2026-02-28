using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using DesktopFrontend.Models;

namespace DesktopFrontend.Controllers {
	public class ClienteController {

		public List<Cliente> GetAllClienti() {
			var clienti = new List<Cliente>();

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = "SELECT ID, RagioneSociale, Email, Telefono, Indirizzo, Citta, Cap, Provincia FROM Clienti ORDER BY RagioneSociale";

					using (var cmd = new SqlCommand(query, connection)) {
						using (var reader = cmd.ExecuteReader()) {
							while (reader.Read()) {
								clienti.Add(new Cliente {
									ID = (int)reader["ID"],
									RagioneSociale = reader["RagioneSociale"]?.ToString() ?? "",
									Email = reader["Email"]?.ToString() ?? "",
									Telefono = reader["Telefono"]?.ToString() ?? "",
									Indirizzo = reader["Indirizzo"]?.ToString() ?? "",
									Citta = reader["Citta"]?.ToString() ?? "",
									Cap = reader["Cap"]?.ToString() ?? "",
									Provincia = reader["Provincia"]?.ToString() ?? ""
								});
							}
						}
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nel caricamento dei clienti: " + ex.Message);
			}

			return clienti;
		}

		public Cliente GetClienteById(int id) {
			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = "SELECT ID, RagioneSociale, Email, Telefono, Indirizzo, Citta, Cap, Provincia FROM Clienti WHERE ID = @id";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@id", id);

						using (var reader = cmd.ExecuteReader()) {
							if (reader.Read()) {
								return new Cliente {
									ID = (int)reader["ID"],
									RagioneSociale = reader["RagioneSociale"]?.ToString() ?? "",
									Email = reader["Email"]?.ToString() ?? "",
									Telefono = reader["Telefono"]?.ToString() ?? "",
									Indirizzo = reader["Indirizzo"]?.ToString() ?? "",
									Citta = reader["Citta"]?.ToString() ?? "",
									Cap = reader["Cap"]?.ToString() ?? "",
									Provincia = reader["Provincia"]?.ToString() ?? ""
								};
							}
						}
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nel caricamento del cliente: " + ex.Message);
			}

			return null;
		}

		public void AddCliente(Cliente cliente) {
			if (string.IsNullOrWhiteSpace(cliente.RagioneSociale)) {
				throw new ArgumentException("La Ragione Sociale è obbligatoria");
			}

			if (string.IsNullOrWhiteSpace(cliente.Email)) {
				throw new ArgumentException("L'Email è obbligatoria");
			}

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = @"INSERT INTO Clienti (RagioneSociale, Email, Telefono, Indirizzo, Citta, Cap, Provincia)
					               VALUES (@ragioneSociale, @email, @telefono, @indirizzo, @citta, @cap, @provincia)";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@ragioneSociale", cliente.RagioneSociale);
						cmd.Parameters.AddWithValue("@email", cliente.Email);
						cmd.Parameters.AddWithValue("@telefono", cliente.Telefono ?? "");
						cmd.Parameters.AddWithValue("@indirizzo", cliente.Indirizzo ?? "");
						cmd.Parameters.AddWithValue("@citta", cliente.Citta ?? "");
						cmd.Parameters.AddWithValue("@cap", cliente.Cap ?? "");
						cmd.Parameters.AddWithValue("@provincia", cliente.Provincia ?? "");

						cmd.ExecuteNonQuery();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nell'aggiunta del cliente: " + ex.Message);
			}
		}

		public void UpdateCliente(Cliente cliente) {
			if (cliente.ID <= 0) {
				throw new ArgumentException("ID cliente non valido");
			}

			if (string.IsNullOrWhiteSpace(cliente.RagioneSociale)) {
				throw new ArgumentException("La Ragione Sociale è obbligatoria");
			}

			if (string.IsNullOrWhiteSpace(cliente.Email)) {
				throw new ArgumentException("L'Email è obbligatoria");
			}

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = @"UPDATE Clienti SET RagioneSociale=@ragioneSociale, Email=@email, 
					               Telefono=@telefono, Indirizzo=@indirizzo, Citta=@citta, Cap=@cap, Provincia=@provincia
					               WHERE ID=@id";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@id", cliente.ID);
						cmd.Parameters.AddWithValue("@ragioneSociale", cliente.RagioneSociale);
						cmd.Parameters.AddWithValue("@email", cliente.Email);
						cmd.Parameters.AddWithValue("@telefono", cliente.Telefono ?? "");
						cmd.Parameters.AddWithValue("@indirizzo", cliente.Indirizzo ?? "");
						cmd.Parameters.AddWithValue("@citta", cliente.Citta ?? "");
						cmd.Parameters.AddWithValue("@cap", cliente.Cap ?? "");
						cmd.Parameters.AddWithValue("@provincia", cliente.Provincia ?? "");

						cmd.ExecuteNonQuery();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nella modifica del cliente: " + ex.Message);
			}
		}

		public void DeleteCliente(int id) {
			if (id <= 0) {
				throw new ArgumentException("ID cliente non valido");
			}

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = "DELETE FROM Clienti WHERE ID=@id";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@id", id);
						cmd.ExecuteNonQuery();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nell'eliminazione del cliente: " + ex.Message);
			}
		}
	}
}
