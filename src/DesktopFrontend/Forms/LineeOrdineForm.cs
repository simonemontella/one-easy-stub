using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using DesktopFrontend.Controllers;
using DesktopFrontend.Models;

namespace DesktopFrontend {
	public partial class LineeOrdineForm : Form {
		private readonly LineaOrdineController _controller = new LineaOrdineController();
		private int _ordineId;
		private int _selectedLineaId = -1;

		public LineeOrdineForm(int ordineId) {
			InitializeComponent();
			_ordineId = ordineId;
		}

		private void LineeOrdineForm_Load(object sender, EventArgs e) {
			LoadLinee();
			UpdateTotaleOrdine();
		}

		private void LoadLinee() {
			try {
				List<LineaOrdine> linee = _controller.GetLineeByOrdineId(_ordineId);
				BindDataGridView(linee);
				labelMessaggio.Text = "";
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore nel caricamento: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void BindDataGridView(List<LineaOrdine> linee) {
			var bindingSource = new BindingSource();
			bindingSource.DataSource = linee;
			dataGridViewLinee.DataSource = bindingSource;
			dataGridViewLinee.AutoResizeColumns();
		}

		private void DataGridViewLinee_SelectionChanged(object sender, EventArgs e) {
			if (dataGridViewLinee.SelectedRows.Count > 0) {
				DataGridViewRow row = dataGridViewLinee.SelectedRows[0];
				_selectedLineaId = (int)row.Cells["ID"].Value;
				textBoxProdotto.Text = row.Cells["Prodotto"].Value?.ToString() ?? "";
				numericUpDownQuantita.Value = (decimal)(float)row.Cells["Quantita"].Value;
				textBoxPrezzoUnitario.Text = ((float)row.Cells["PrezzoUnitario"].Value).ToString("F2");
				textBoxSubtotale.Text = ((float)row.Cells["Subtotale"].Value).ToString("F2");
			}
		}

		private void TextBoxPrezzoUnitario_TextChanged(object sender, EventArgs e) {
			CalculateSubtotale();
		}

		private void CalculateSubtotale() {
			try {
				if (float.TryParse(textBoxPrezzoUnitario.Text, out float prezzo)) {
					float subtotale = (float)numericUpDownQuantita.Value * prezzo;
					textBoxSubtotale.Text = subtotale.ToString("F2");
				}
			} catch { }
		}

		private void UpdateTotaleOrdine() {
			try {
				float totale = _controller.GetTotaleOrdine(_ordineId);
				textBoxTotaleOrdine.Text = totale.ToString("F2");
				_controller.UpdateTotaleOrdine(_ordineId, totale);
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore nell'aggiornamento totale: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void ButtonAggiungi_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxProdotto.Text)) {
				labelMessaggio.Text = "Inserisci la descrizione del prodotto!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return;
			}

			if (!float.TryParse(textBoxPrezzoUnitario.Text, out float prezzo) || prezzo < 0) {
				labelMessaggio.Text = "Inserisci un prezzo unitario valido!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return;
			}

			try {
				float quantita = (float)numericUpDownQuantita.Value;
				float subtotale = quantita * prezzo;

				var linea = new LineaOrdine {
					OrdineID = _ordineId,
					Prodotto = textBoxProdotto.Text,
					Quantita = quantita,
					PrezzoUnitario = prezzo,
					Subtotale = subtotale
				};

				_controller.AddLineaOrdine(linea);
				ClearFields();
				LoadLinee();
				UpdateTotaleOrdine();
				labelMessaggio.Text = "Linea aggiunta con successo!";
				labelMessaggio.ForeColor = System.Drawing.Color.Green;
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void ButtonElimina_Click(object sender, EventArgs e) {
			if (_selectedLineaId < 0) {
				labelMessaggio.Text = "Selezionare una linea prima di eliminare!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return;
			}

			if (MessageBox.Show("Sei sicuro di voler eliminare questa linea?", "Conferma eliminazione", MessageBoxButtons.YesNo) != DialogResult.Yes) {
				return;
			}

			try {
				_controller.DeleteLineaOrdine(_selectedLineaId);
				ClearFields();
				LoadLinee();
				UpdateTotaleOrdine();
				labelMessaggio.Text = "Linea eliminata con successo!";
				labelMessaggio.ForeColor = System.Drawing.Color.Green;
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void ButtonChiudi_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void ClearFields() {
			textBoxProdotto.Clear();
			numericUpDownQuantita.Value = 1;
			textBoxPrezzoUnitario.Text = "0.00";
			textBoxSubtotale.Text = "0.00";
			_selectedLineaId = -1;
		}
	}
}
