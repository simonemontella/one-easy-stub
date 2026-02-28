using System;
using System.Data;
using System.Windows.Forms;

using DesktopFrontend.Controllers;
using DesktopFrontend.Models;

namespace DesktopFrontend {
	public partial class ClientiForm : Form {
		private readonly ClienteController _controller = new ClienteController();
		private int _selectedClienteId = -1;

		public ClientiForm() {
			InitializeComponent();
		}

		private void ClientiForm_Load(object sender, EventArgs e) {
			LoadClienti();
		}

		private void LoadClienti() {
			try {
				var clienti = _controller.GetAllClienti();
				BindDataGridView(clienti);
				labelMessaggio.Text = "";
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore nel caricamento: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void BindDataGridView(System.Collections.Generic.List<Cliente> clienti) {
			var bindingSource = new BindingSource();
			bindingSource.DataSource = clienti;
			dataGridViewClienti.DataSource = bindingSource;
			dataGridViewClienti.AutoResizeColumns();
		}

		private void DataGridViewClienti_SelectionChanged(object sender, EventArgs e) {
			if (dataGridViewClienti.SelectedRows.Count > 0) {
				DataGridViewRow row = dataGridViewClienti.SelectedRows[0];
				_selectedClienteId = (int)row.Cells["ID"].Value;
				textBoxRagioneSociale.Text = row.Cells["RagioneSociale"].Value?.ToString() ?? "";
				textBoxEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
				textBoxTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";
				textBoxIndirizzo.Text = row.Cells["Indirizzo"].Value?.ToString() ?? "";
				textBoxCitta.Text = row.Cells["Citta"].Value?.ToString() ?? "";
				textBoxCap.Text = row.Cells["Cap"].Value?.ToString() ?? "";
				textBoxProvincia.Text = row.Cells["Provincia"].Value?.ToString() ?? "";
			}
		}

		private void ButtonAggiungi_Click(object sender, EventArgs e) {
			if (!ValidateInput()) return;

			try {
				var cliente = new Cliente {
					RagioneSociale = textBoxRagioneSociale.Text,
					Email = textBoxEmail.Text,
					Telefono = textBoxTelefono.Text,
					Indirizzo = textBoxIndirizzo.Text,
					Citta = textBoxCitta.Text,
					Cap = textBoxCap.Text,
					Provincia = textBoxProvincia.Text
				};

				_controller.AddCliente(cliente);
				ClearFields();
				LoadClienti();
				labelMessaggio.Text = "Cliente aggiunto con successo!";
				labelMessaggio.ForeColor = System.Drawing.Color.Green;
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void ButtonModifica_Click(object sender, EventArgs e) {
			if (_selectedClienteId < 0) {
				labelMessaggio.Text = "Selezionare un cliente prima di modificare!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return;
			}

			if (!ValidateInput()) return;

			try {
				var cliente = new Cliente {
					ID = _selectedClienteId,
					RagioneSociale = textBoxRagioneSociale.Text,
					Email = textBoxEmail.Text,
					Telefono = textBoxTelefono.Text,
					Indirizzo = textBoxIndirizzo.Text,
					Citta = textBoxCitta.Text,
					Cap = textBoxCap.Text,
					Provincia = textBoxProvincia.Text
				};

				_controller.UpdateCliente(cliente);
				LoadClienti();
				labelMessaggio.Text = "Cliente modificato con successo!";
				labelMessaggio.ForeColor = System.Drawing.Color.Green;
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void ButtonElimina_Click(object sender, EventArgs e) {
			if (_selectedClienteId < 0) {
				labelMessaggio.Text = "Selezionare un cliente prima di eliminare!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return;
			}

			if (MessageBox.Show("Sei sicuro di voler eliminare questo cliente?", "Conferma eliminazione", MessageBoxButtons.YesNo) != DialogResult.Yes) {
				return;
			}

			try {
				_controller.DeleteCliente(_selectedClienteId);
				ClearFields();
				LoadClienti();
				labelMessaggio.Text = "Cliente eliminato con successo!";
				labelMessaggio.ForeColor = System.Drawing.Color.Green;
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void ButtonTorna_Click(object sender, EventArgs e) {
			this.Close();
			new HomePage().Show();
		}

		private bool ValidateInput() {
			if (string.IsNullOrWhiteSpace(textBoxRagioneSociale.Text)) {
				labelMessaggio.Text = "Inserisci la Ragione Sociale!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return false;
			}

			if (string.IsNullOrWhiteSpace(textBoxEmail.Text)) {
				labelMessaggio.Text = "Inserisci l'Email!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return false;
			}

			return true;
		}

		private void ClearFields() {
			textBoxRagioneSociale.Clear();
			textBoxEmail.Clear();
			textBoxTelefono.Clear();
			textBoxIndirizzo.Clear();
			textBoxCitta.Clear();
			textBoxCap.Clear();
			textBoxProvincia.Clear();
			_selectedClienteId = -1;
		}
	}
}
