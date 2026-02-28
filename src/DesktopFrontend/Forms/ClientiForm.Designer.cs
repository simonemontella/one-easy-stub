namespace DesktopFrontend {
	partial class ClientiForm {
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent() {
			this.labelTitolo = new System.Windows.Forms.Label();
			this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
			this.labelRagioneSociale = new System.Windows.Forms.Label();
			this.textBoxRagioneSociale = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelTelefono = new System.Windows.Forms.Label();
			this.textBoxTelefono = new System.Windows.Forms.TextBox();
			this.labelIndirizzo = new System.Windows.Forms.Label();
			this.textBoxIndirizzo = new System.Windows.Forms.TextBox();
			this.labelCitta = new System.Windows.Forms.Label();
			this.textBoxCitta = new System.Windows.Forms.TextBox();
			this.labelCap = new System.Windows.Forms.Label();
			this.textBoxCap = new System.Windows.Forms.TextBox();
			this.labelProvincia = new System.Windows.Forms.Label();
			this.textBoxProvincia = new System.Windows.Forms.TextBox();
			this.buttonAggiungi = new System.Windows.Forms.Button();
			this.buttonModifica = new System.Windows.Forms.Button();
			this.buttonElimina = new System.Windows.Forms.Button();
			this.buttonTorna = new System.Windows.Forms.Button();
			this.labelMessaggio = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
			this.SuspendLayout();

			// labelTitolo
			this.labelTitolo.AutoSize = true;
			this.labelTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.labelTitolo.Location = new System.Drawing.Point(12, 9);
			this.labelTitolo.Name = "labelTitolo";
			this.labelTitolo.Size = new System.Drawing.Size(75, 24);
			this.labelTitolo.TabIndex = 0;
			this.labelTitolo.Text = "Clienti";

			// dataGridViewClienti
			this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClienti.Location = new System.Drawing.Point(12, 250);
			this.dataGridViewClienti.Name = "dataGridViewClienti";
			this.dataGridViewClienti.ReadOnly = true;
			this.dataGridViewClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewClienti.Size = new System.Drawing.Size(760, 240);
			this.dataGridViewClienti.TabIndex = 1;
			this.dataGridViewClienti.SelectionChanged += new System.EventHandler(this.DataGridViewClienti_SelectionChanged);

			// labelRagioneSociale
			this.labelRagioneSociale.AutoSize = true;
			this.labelRagioneSociale.Location = new System.Drawing.Point(12, 40);
			this.labelRagioneSociale.Name = "labelRagioneSociale";
			this.labelRagioneSociale.Size = new System.Drawing.Size(95, 13);
			this.labelRagioneSociale.TabIndex = 2;
			this.labelRagioneSociale.Text = "Ragione Sociale";

			// textBoxRagioneSociale
			this.textBoxRagioneSociale.Location = new System.Drawing.Point(12, 56);
			this.textBoxRagioneSociale.Name = "textBoxRagioneSociale";
			this.textBoxRagioneSociale.Size = new System.Drawing.Size(200, 20);
			this.textBoxRagioneSociale.TabIndex = 3;

			// labelEmail
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(220, 40);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(35, 13);
			this.labelEmail.TabIndex = 4;
			this.labelEmail.Text = "Email";

			// textBoxEmail
			this.textBoxEmail.Location = new System.Drawing.Point(220, 56);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
			this.textBoxEmail.TabIndex = 5;

			// labelTelefono
			this.labelTelefono.AutoSize = true;
			this.labelTelefono.Location = new System.Drawing.Point(430, 40);
			this.labelTelefono.Name = "labelTelefono";
			this.labelTelefono.Size = new System.Drawing.Size(56, 13);
			this.labelTelefono.TabIndex = 6;
			this.labelTelefono.Text = "Telefono";

			// textBoxTelefono
			this.textBoxTelefono.Location = new System.Drawing.Point(430, 56);
			this.textBoxTelefono.Name = "textBoxTelefono";
			this.textBoxTelefono.Size = new System.Drawing.Size(120, 20);
			this.textBoxTelefono.TabIndex = 7;

			// labelIndirizzo
			this.labelIndirizzo.AutoSize = true;
			this.labelIndirizzo.Location = new System.Drawing.Point(12, 85);
			this.labelIndirizzo.Name = "labelIndirizzo";
			this.labelIndirizzo.Size = new System.Drawing.Size(49, 13);
			this.labelIndirizzo.TabIndex = 8;
			this.labelIndirizzo.Text = "Indirizzo";

			// textBoxIndirizzo
			this.textBoxIndirizzo.Location = new System.Drawing.Point(12, 101);
			this.textBoxIndirizzo.Name = "textBoxIndirizzo";
			this.textBoxIndirizzo.Size = new System.Drawing.Size(200, 20);
			this.textBoxIndirizzo.TabIndex = 9;

			// labelCitta
			this.labelCitta.AutoSize = true;
			this.labelCitta.Location = new System.Drawing.Point(220, 85);
			this.labelCitta.Name = "labelCitta";
			this.labelCitta.Size = new System.Drawing.Size(29, 13);
			this.labelCitta.TabIndex = 10;
			this.labelCitta.Text = "Città";

			// textBoxCitta
			this.textBoxCitta.Location = new System.Drawing.Point(220, 101);
			this.textBoxCitta.Name = "textBoxCitta";
			this.textBoxCitta.Size = new System.Drawing.Size(200, 20);
			this.textBoxCitta.TabIndex = 11;

			// labelCap
			this.labelCap.AutoSize = true;
			this.labelCap.Location = new System.Drawing.Point(430, 85);
			this.labelCap.Name = "labelCap";
			this.labelCap.Size = new System.Drawing.Size(24, 13);
			this.labelCap.TabIndex = 12;
			this.labelCap.Text = "CAP";

			// textBoxCap
			this.textBoxCap.Location = new System.Drawing.Point(430, 101);
			this.textBoxCap.Name = "textBoxCap";
			this.textBoxCap.Size = new System.Drawing.Size(120, 20);
			this.textBoxCap.TabIndex = 13;

			// labelProvincia
			this.labelProvincia.AutoSize = true;
			this.labelProvincia.Location = new System.Drawing.Point(12, 130);
			this.labelProvincia.Name = "labelProvincia";
			this.labelProvincia.Size = new System.Drawing.Size(55, 13);
			this.labelProvincia.TabIndex = 14;
			this.labelProvincia.Text = "Provincia";

			// textBoxProvincia
			this.textBoxProvincia.Location = new System.Drawing.Point(12, 146);
			this.textBoxProvincia.Name = "textBoxProvincia";
			this.textBoxProvincia.Size = new System.Drawing.Size(120, 20);
			this.textBoxProvincia.TabIndex = 15;

			// buttonAggiungi
			this.buttonAggiungi.Location = new System.Drawing.Point(12, 180);
			this.buttonAggiungi.Name = "buttonAggiungi";
			this.buttonAggiungi.Size = new System.Drawing.Size(75, 23);
			this.buttonAggiungi.TabIndex = 16;
			this.buttonAggiungi.Text = "Aggiungi";
			this.buttonAggiungi.UseVisualStyleBackColor = true;
			this.buttonAggiungi.Click += new System.EventHandler(this.ButtonAggiungi_Click);

			// buttonModifica
			this.buttonModifica.Location = new System.Drawing.Point(93, 180);
			this.buttonModifica.Name = "buttonModifica";
			this.buttonModifica.Size = new System.Drawing.Size(75, 23);
			this.buttonModifica.TabIndex = 17;
			this.buttonModifica.Text = "Modifica";
			this.buttonModifica.UseVisualStyleBackColor = true;
			this.buttonModifica.Click += new System.EventHandler(this.ButtonModifica_Click);

			// buttonElimina
			this.buttonElimina.Location = new System.Drawing.Point(174, 180);
			this.buttonElimina.Name = "buttonElimina";
			this.buttonElimina.Size = new System.Drawing.Size(75, 23);
			this.buttonElimina.TabIndex = 18;
			this.buttonElimina.Text = "Elimina";
			this.buttonElimina.UseVisualStyleBackColor = true;
			this.buttonElimina.Click += new System.EventHandler(this.ButtonElimina_Click);

			// buttonTorna
			this.buttonTorna.Location = new System.Drawing.Point(697, 509);
			this.buttonTorna.Name = "buttonTorna";
			this.buttonTorna.Size = new System.Drawing.Size(75, 23);
			this.buttonTorna.TabIndex = 19;
			this.buttonTorna.Text = "Torna";
			this.buttonTorna.UseVisualStyleBackColor = true;
			this.buttonTorna.Click += new System.EventHandler(this.ButtonTorna_Click);

			// labelMessaggio
			this.labelMessaggio.AutoSize = true;
			this.labelMessaggio.ForeColor = System.Drawing.Color.Red;
			this.labelMessaggio.Location = new System.Drawing.Point(12, 220);
			this.labelMessaggio.Name = "labelMessaggio";
			this.labelMessaggio.Size = new System.Drawing.Size(0, 13);
			this.labelMessaggio.TabIndex = 20;

			// ClientiForm
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 544);
			this.Controls.Add(this.labelMessaggio);
			this.Controls.Add(this.buttonTorna);
			this.Controls.Add(this.buttonElimina);
			this.Controls.Add(this.buttonModifica);
			this.Controls.Add(this.buttonAggiungi);
			this.Controls.Add(this.textBoxProvincia);
			this.Controls.Add(this.labelProvincia);
			this.Controls.Add(this.textBoxCap);
			this.Controls.Add(this.labelCap);
			this.Controls.Add(this.textBoxCitta);
			this.Controls.Add(this.labelCitta);
			this.Controls.Add(this.textBoxIndirizzo);
			this.Controls.Add(this.labelIndirizzo);
			this.Controls.Add(this.textBoxTelefono);
			this.Controls.Add(this.labelTelefono);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxRagioneSociale);
			this.Controls.Add(this.labelRagioneSociale);
			this.Controls.Add(this.dataGridViewClienti);
			this.Controls.Add(this.labelTitolo);
			this.Name = "ClientiForm";
			this.Text = "Gestione Clienti";
			this.Load += new System.EventHandler(this.ClientiForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label labelTitolo;
		private System.Windows.Forms.DataGridView dataGridViewClienti;
		private System.Windows.Forms.Label labelRagioneSociale;
		private System.Windows.Forms.TextBox textBoxRagioneSociale;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelTelefono;
		private System.Windows.Forms.TextBox textBoxTelefono;
		private System.Windows.Forms.Label labelIndirizzo;
		private System.Windows.Forms.TextBox textBoxIndirizzo;
		private System.Windows.Forms.Label labelCitta;
		private System.Windows.Forms.TextBox textBoxCitta;
		private System.Windows.Forms.Label labelCap;
		private System.Windows.Forms.TextBox textBoxCap;
		private System.Windows.Forms.Label labelProvincia;
		private System.Windows.Forms.TextBox textBoxProvincia;
		private System.Windows.Forms.Button buttonAggiungi;
		private System.Windows.Forms.Button buttonModifica;
		private System.Windows.Forms.Button buttonElimina;
		private System.Windows.Forms.Button buttonTorna;
		private System.Windows.Forms.Label labelMessaggio;
	}
}
