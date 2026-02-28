using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFrontend {
	public partial class HomePage : Form {
		public HomePage() {
			InitializeComponent();
		}

		private void ButtonClienti_Click(object sender, EventArgs e) {
			if (!TestDatabaseConnection()) {
				labelMessaggio.Text = "Errore: Impossibile connettersi al database!";
				return;
			}

			this.Hide();
			new ClientiForm().ShowDialog();
			this.Show();
		}

		private void ButtonOrdini_Click(object sender, EventArgs e) {
			if (!TestDatabaseConnection()) {
				labelMessaggio.Text = "Errore: Impossibile connettersi al database!";
				return;
			}

			this.Hide();
			new OrdiniForm().ShowDialog();
			this.Show();
		}

		private void ButtonEsci_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private bool TestDatabaseConnection() {
			return DbHelper.TestConnection();
		}
	}
}
