using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using DesktopFrontend.Controllers;
using DesktopFrontend.Models;

namespace DesktopFrontend {
	public partial class OrdiniForm : Form {
		private readonly OrdineController _ordineController = new OrdineController();
		private int _selectedOrdineId = -1;

		public OrdiniForm() {
			InitializeComponent();
		}

		private void OrdiniForm_Load(object sender, EventArgs e) {
			LoadClienti();
			LoadOrdini();
		}

		private void LoadClienti() {
			try {
				List<Cliente> clienti = _ordineController.GetClientiPerCombo();
				BindComboBoxClienti(clienti);
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore nel caricamento clienti: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void BindComboBoxClienti(List<Cliente> clienti) {
			var bindingSource = new BindingSource();
			bindingSource.DataSource = clienti;
			comboBoxCliente.DataSource = bindingSource;
			comboBoxCliente.DisplayMember = "RagioneSociale";
			comboBoxCliente.ValueMember = "ID";
			comboBoxCliente.SelectedIndex = -1;
		}

		private void LoadOrdini() {
			try {
				List<Ordine> ordini = _ordineController.GetAllOrdini();
				BindDataGridView(ordini);
				labelMessaggio.Text = "";
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore nel caricamento: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void BindDataGridView(List<Ordine> ordini) {
			var bindingSource = new BindingSource();
			bindingSource.DataSource = ordini;
			dataGridViewOrdini.DataSource = bindingSource;
			dataGridViewOrdini.AutoResizeColumns();
		}

		private void DataGridViewOrdini_SelectionChanged(object sender, EventArgs e) {
			if (dataGridViewOrdini.SelectedRows.Count > 0) {
				DataGridViewRow row = dataGridViewOrdini.SelectedRows[0];
				_selectedOrdineId = (int)row.Cells["ID"].Value;
				textBoxTotale.Text = row.Cells["Totale"].Value?.ToString() ?? "0.00";
			}
		}

		private void ButtonAggiungi_Click(object sender, EventArgs e) {
			if (comboBoxCliente.SelectedIndex < 0) {
				labelMessaggio.Text = "Selezionare un cliente!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return;
			}

			try {
				int clienteId = (int)comboBoxCliente.SelectedValue;
				DateTime data = dateTimePickerData.Value;

				var ordine = new Ordine {
					ClienteID = clienteId,
					Data = data,
					Totale = 0
				};

				_ordineController.AddOrdine(ordine);
				LoadOrdini();
				comboBoxCliente.SelectedIndex = -1;
				dateTimePickerData.Value = DateTime.Now;
				textBoxTotale.Clear();
				labelMessaggio.Text = "Ordine aggiunto con successo!";
				labelMessaggio.ForeColor = System.Drawing.Color.Green;
			} catch (Exception ex) {
				labelMessaggio.Text = "Errore: " + ex.Message;
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void ButtonVisualizzaLinee_Click(object sender, EventArgs e) {
			if (_selectedOrdineId < 0) {
				labelMessaggio.Text = "Selezionare un ordine!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return;
			}

			new LineeOrdineForm(_selectedOrdineId).ShowDialog();
			LoadOrdini();
		}

		private void ButtonElimina_Click(object sender, EventArgs e) {
			if (_selectedOrdineId < 0) {
				labelMessaggio.Text = "Selezionare un ordine prima di eliminare!";
				labelMessaggio.ForeColor = System.Drawing.Color.Red;
				return;
			}

			if (MessageBox.Show("Sei sicuro di voler eliminare questo ordine?", "Conferma eliminazione", MessageBoxButtons.YesNo) != DialogResult.Yes) {
				return;
			}

			try {
				_ordineController.DeleteOrdine(_selectedOrdineId);
				LoadOrdini();
				textBoxTotale.Clear();
				labelMessaggio.Text = "Ordine eliminato con successo!";
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
	}
}
