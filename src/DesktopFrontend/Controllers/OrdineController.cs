using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using DesktopFrontend.Models;

namespace DesktopFrontend.Controllers {
	public class OrdineController {

		public List<Ordine> GetAllOrdini() {
			var ordini = new List<Ordine>();

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = @"SELECT o.ID, o.ClienteID, c.RagioneSociale, o.Data, o.Totale 
					               FROM Ordini o 
					               INNER JOIN Clienti c ON o.ClienteID = c.ID
					               ORDER BY o.Data DESC";

					using (var cmd = new SqlCommand(query, connection)) {
						using (var reader = cmd.ExecuteReader()) {
							while (reader.Read()) {
								ordini.Add(new Ordine {
									ID = (int)reader["ID"],
									ClienteID = (int)reader["ClienteID"],
									ClienteRagioneSociale = reader["RagioneSociale"]?.ToString() ?? "",
									Data = (DateTime)reader["Data"],
									Totale = (float)reader["Totale"]
								});
							}
						}
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nel caricamento degli ordini: " + ex.Message);
			}

			return ordini;
		}

		public Ordine GetOrdineById(int id) {
			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = @"SELECT o.ID, o.ClienteID, c.RagioneSociale, o.Data, o.Totale 
					               FROM Ordini o 
					               INNER JOIN Clienti c ON o.ClienteID = c.ID
					               WHERE o.ID = @id";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@id", id);

						using (var reader = cmd.ExecuteReader()) {
							if (reader.Read()) {
								return new Ordine {
									ID = (int)reader["ID"],
									ClienteID = (int)reader["ClienteID"],
									ClienteRagioneSociale = reader["RagioneSociale"]?.ToString() ?? "",
									Data = (DateTime)reader["Data"],
									Totale = (float)reader["Totale"]
								};
							}
						}
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nel caricamento dell'ordine: " + ex.Message);
			}

			return null;
		}

		public void AddOrdine(Ordine ordine) {
			if (ordine.ClienteID <= 0) {
				throw new ArgumentException("Cliente non valido");
			}

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = "INSERT INTO Ordini (ClienteID, Data, Totale) VALUES (@clienteId, @data, @totale)";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@clienteId", ordine.ClienteID);
						cmd.Parameters.AddWithValue("@data", ordine.Data);
						cmd.Parameters.AddWithValue("@totale", ordine.Totale);

						cmd.ExecuteNonQuery();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nell'aggiunta dell'ordine: " + ex.Message);
			}
		}

		public void DeleteOrdine(int id) {
			if (id <= 0) {
				throw new ArgumentException("ID ordine non valido");
			}

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();

					// Eliminare prima le linee dell'ordine
					string deleteLineeQuery = "DELETE FROM LineeOrdine WHERE OrdineID=@id";
					using (var cmd = new SqlCommand(deleteLineeQuery, connection)) {
						cmd.Parameters.AddWithValue("@id", id);
						cmd.ExecuteNonQuery();
					}

					// Poi eliminare l'ordine
					string deleteOrdineQuery = "DELETE FROM Ordini WHERE ID=@id";
					using (var cmd = new SqlCommand(deleteOrdineQuery, connection)) {
						cmd.Parameters.AddWithValue("@id", id);
						cmd.ExecuteNonQuery();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nell'eliminazione dell'ordine: " + ex.Message);
			}
		}

		public List<Cliente> GetClientiPerCombo() {
			var clienti = new List<Cliente>();

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = "SELECT ID, RagioneSociale FROM Clienti ORDER BY RagioneSociale";

					using (var cmd = new SqlCommand(query, connection)) {
						using (var reader = cmd.ExecuteReader()) {
							while (reader.Read()) {
								clienti.Add(new Cliente {
									ID = (int)reader["ID"],
									RagioneSociale = reader["RagioneSociale"]?.ToString() ?? ""
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
	}
}
