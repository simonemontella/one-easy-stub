using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using DesktopFrontend.Models;

namespace DesktopFrontend.Controllers {
	public class LineaOrdineController {

		public List<LineaOrdine> GetLineeByOrdineId(int ordineId) {
			var linee = new List<LineaOrdine>();

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = @"SELECT ID, OrdineID, Prodotto, Quantita, PrezzoUnitario, Subtotale 
					               FROM LineeOrdine 
					               WHERE OrdineID = @ordineId
					               ORDER BY ID";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@ordineId", ordineId);

						using (var reader = cmd.ExecuteReader()) {
							while (reader.Read()) {
								linee.Add(new LineaOrdine {
									ID = (int)reader["ID"],
									OrdineID = (int)reader["OrdineID"],
									Prodotto = reader["Prodotto"]?.ToString() ?? "",
									Quantita = (float)reader["Quantita"],
									PrezzoUnitario = (float)reader["PrezzoUnitario"],
									Subtotale = (float)reader["Subtotale"]
								});
							}
						}
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nel caricamento delle linee ordine: " + ex.Message);
			}

			return linee;
		}

		public void AddLineaOrdine(LineaOrdine linea) {
			if (linea.OrdineID <= 0) {
				throw new ArgumentException("Ordine non valido");
			}

			if (string.IsNullOrWhiteSpace(linea.Prodotto)) {
				throw new ArgumentException("La descrizione del prodotto è obbligatoria");
			}

			if (linea.Quantita <= 0) {
				throw new ArgumentException("La quantità deve essere maggiore di 0");
			}

			if (linea.PrezzoUnitario < 0) {
				throw new ArgumentException("Il prezzo non può essere negativo");
			}

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = @"INSERT INTO LineeOrdine (OrdineID, Prodotto, Quantita, PrezzoUnitario, Subtotale) 
					               VALUES (@ordineId, @prodotto, @quantita, @prezzo, @subtotale)";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@ordineId", linea.OrdineID);
						cmd.Parameters.AddWithValue("@prodotto", linea.Prodotto);
						cmd.Parameters.AddWithValue("@quantita", linea.Quantita);
						cmd.Parameters.AddWithValue("@prezzo", linea.PrezzoUnitario);
						cmd.Parameters.AddWithValue("@subtotale", linea.Subtotale);

						cmd.ExecuteNonQuery();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nell'aggiunta della linea ordine: " + ex.Message);
			}
		}

		public void DeleteLineaOrdine(int id) {
			if (id <= 0) {
				throw new ArgumentException("ID linea ordine non valido");
			}

			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = "DELETE FROM LineeOrdine WHERE ID = @id";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@id", id);
						cmd.ExecuteNonQuery();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nell'eliminazione della linea ordine: " + ex.Message);
			}
		}

		public float GetTotaleOrdine(int ordineId) {
			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = "SELECT SUM(Subtotale) FROM LineeOrdine WHERE OrdineID = @ordineId";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@ordineId", ordineId);
						object result = cmd.ExecuteScalar();
						return result != null && result != DBNull.Value ? (float)result : 0;
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nel calcolo del totale: " + ex.Message);
			}
		}

		public void UpdateTotaleOrdine(int ordineId, float totale) {
			try {
				using (var connection = DbHelper.GetConnection()) {
					connection.Open();
					string query = "UPDATE Ordini SET Totale = @totale WHERE ID = @ordineId";

					using (var cmd = new SqlCommand(query, connection)) {
						cmd.Parameters.AddWithValue("@totale", totale);
						cmd.Parameters.AddWithValue("@ordineId", ordineId);
						cmd.ExecuteNonQuery();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Errore nell'aggiornamento del totale: " + ex.Message);
			}
		}
	}
}
