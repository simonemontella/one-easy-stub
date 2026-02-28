namespace DesktopFrontend {
	partial class OrdiniForm {
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent() {
			this.labelTitolo = new System.Windows.Forms.Label();
			this.dataGridViewOrdini = new System.Windows.Forms.DataGridView();
			this.labelCliente = new System.Windows.Forms.Label();
			this.comboBoxCliente = new System.Windows.Forms.ComboBox();
			this.labelData = new System.Windows.Forms.Label();
			this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
			this.buttonAggiungi = new System.Windows.Forms.Button();
			this.buttonElimina = new System.Windows.Forms.Button();
			this.buttonTorna = new System.Windows.Forms.Button();
			this.labelMessaggio = new System.Windows.Forms.Label();
			this.groupBoxDettagli = new System.Windows.Forms.GroupBox();
			this.labelTotale = new System.Windows.Forms.Label();
			this.textBoxTotale = new System.Windows.Forms.TextBox();
			this.buttonVisualizzaLinee = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdini)).BeginInit();
			this.groupBoxDettagli.SuspendLayout();
			this.SuspendLayout();

			// labelTitolo
			this.labelTitolo.AutoSize = true;
			this.labelTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.labelTitolo.Location = new System.Drawing.Point(12, 9);
			this.labelTitolo.Name = "labelTitolo";
			this.labelTitolo.Size = new System.Drawing.Size(76, 24);
			this.labelTitolo.TabIndex = 0;
			this.labelTitolo.Text = "Ordini";

			// dataGridViewOrdini
			this.dataGridViewOrdini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrdini.Location = new System.Drawing.Point(12, 200);
			this.dataGridViewOrdini.Name = "dataGridViewOrdini";
			this.dataGridViewOrdini.ReadOnly = true;
			this.dataGridViewOrdini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewOrdini.Size = new System.Drawing.Size(760, 240);
			this.dataGridViewOrdini.TabIndex = 1;
			this.dataGridViewOrdini.SelectionChanged += new System.EventHandler(this.DataGridViewOrdini_SelectionChanged);

			// labelCliente
			this.labelCliente.AutoSize = true;
			this.labelCliente.Location = new System.Drawing.Point(12, 40);
			this.labelCliente.Name = "labelCliente";
			this.labelCliente.Size = new System.Drawing.Size(44, 13);
			this.labelCliente.TabIndex = 2;
			this.labelCliente.Text = "Cliente";

			// comboBoxCliente
			this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCliente.FormattingEnabled = true;
			this.comboBoxCliente.Location = new System.Drawing.Point(12, 56);
			this.comboBoxCliente.Name = "comboBoxCliente";
			this.comboBoxCliente.Size = new System.Drawing.Size(200, 21);
			this.comboBoxCliente.TabIndex = 3;

			// labelData
			this.labelData.AutoSize = true;
			this.labelData.Location = new System.Drawing.Point(220, 40);
			this.labelData.Name = "labelData";
			this.labelData.Size = new System.Drawing.Size(33, 13);
			this.labelData.TabIndex = 4;
			this.labelData.Text = "Data";

			// dateTimePickerData
			this.dateTimePickerData.Location = new System.Drawing.Point(220, 56);
			this.dateTimePickerData.Name = "dateTimePickerData";
			this.dateTimePickerData.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerData.TabIndex = 5;

			// groupBoxDettagli
			this.groupBoxDettagli.Controls.Add(this.labelTotale);
			this.groupBoxDettagli.Controls.Add(this.textBoxTotale);
			this.groupBoxDettagli.Location = new System.Drawing.Point(12, 85);
			this.groupBoxDettagli.Name = "groupBoxDettagli";
			this.groupBoxDettagli.Size = new System.Drawing.Size(760, 80);
			this.groupBoxDettagli.TabIndex = 6;
			this.groupBoxDettagli.TabStop = false;
			this.groupBoxDettagli.Text = "Dettagli Ordine";

			// labelTotale
			this.labelTotale.AutoSize = true;
			this.labelTotale.Location = new System.Drawing.Point(12, 25);
			this.labelTotale.Name = "labelTotale";
			this.labelTotale.Size = new System.Drawing.Size(41, 13);
			this.labelTotale.TabIndex = 0;
			this.labelTotale.Text = "Totale";

			// textBoxTotale
			this.textBoxTotale.Location = new System.Drawing.Point(12, 41);
			this.textBoxTotale.Name = "textBoxTotale";
			this.textBoxTotale.ReadOnly = true;
			this.textBoxTotale.Size = new System.Drawing.Size(200, 20);
			this.textBoxTotale.TabIndex = 1;

			// buttonAggiungi
			this.buttonAggiungi.Location = new System.Drawing.Point(12, 450);
			this.buttonAggiungi.Name = "buttonAggiungi";
			this.buttonAggiungi.Size = new System.Drawing.Size(75, 23);
			this.buttonAggiungi.TabIndex = 7;
			this.buttonAggiungi.Text = "Aggiungi";
			this.buttonAggiungi.UseVisualStyleBackColor = true;
			this.buttonAggiungi.Click += new System.EventHandler(this.ButtonAggiungi_Click);

			// buttonVisualizzaLinee
			this.buttonVisualizzaLinee.Location = new System.Drawing.Point(93, 450);
			this.buttonVisualizzaLinee.Name = "buttonVisualizzaLinee";
			this.buttonVisualizzaLinee.Size = new System.Drawing.Size(100, 23);
			this.buttonVisualizzaLinee.TabIndex = 8;
			this.buttonVisualizzaLinee.Text = "Visualizza Linee";
			this.buttonVisualizzaLinee.UseVisualStyleBackColor = true;
			this.buttonVisualizzaLinee.Click += new System.EventHandler(this.ButtonVisualizzaLinee_Click);

			// buttonElimina
			this.buttonElimina.Location = new System.Drawing.Point(199, 450);
			this.buttonElimina.Name = "buttonElimina";
			this.buttonElimina.Size = new System.Drawing.Size(75, 23);
			this.buttonElimina.TabIndex = 9;
			this.buttonElimina.Text = "Elimina";
			this.buttonElimina.UseVisualStyleBackColor = true;
			this.buttonElimina.Click += new System.EventHandler(this.ButtonElimina_Click);

			// buttonTorna
			this.buttonTorna.Location = new System.Drawing.Point(697, 479);
			this.buttonTorna.Name = "buttonTorna";
			this.buttonTorna.Size = new System.Drawing.Size(75, 23);
			this.buttonTorna.TabIndex = 10;
			this.buttonTorna.Text = "Torna";
			this.buttonTorna.UseVisualStyleBackColor = true;
			this.buttonTorna.Click += new System.EventHandler(this.ButtonTorna_Click);

			// labelMessaggio
			this.labelMessaggio.AutoSize = true;
			this.labelMessaggio.ForeColor = System.Drawing.Color.Red;
			this.labelMessaggio.Location = new System.Drawing.Point(12, 475);
			this.labelMessaggio.Name = "labelMessaggio";
			this.labelMessaggio.Size = new System.Drawing.Size(0, 13);
			this.labelMessaggio.TabIndex = 11;

			// OrdiniForm
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 514);
			this.Controls.Add(this.labelMessaggio);
			this.Controls.Add(this.buttonTorna);
			this.Controls.Add(this.buttonElimina);
			this.Controls.Add(this.buttonVisualizzaLinee);
			this.Controls.Add(this.buttonAggiungi);
			this.Controls.Add(this.groupBoxDettagli);
			this.Controls.Add(this.dateTimePickerData);
			this.Controls.Add(this.labelData);
			this.Controls.Add(this.comboBoxCliente);
			this.Controls.Add(this.labelCliente);
			this.Controls.Add(this.dataGridViewOrdini);
			this.Controls.Add(this.labelTitolo);
			this.Name = "OrdiniForm";
			this.Text = "Gestione Ordini";
			this.Load += new System.EventHandler(this.OrdiniForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdini)).EndInit();
			this.groupBoxDettagli.ResumeLayout(false);
			this.groupBoxDettagli.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label labelTitolo;
		private System.Windows.Forms.DataGridView dataGridViewOrdini;
		private System.Windows.Forms.Label labelCliente;
		private System.Windows.Forms.ComboBox comboBoxCliente;
		private System.Windows.Forms.Label labelData;
		private System.Windows.Forms.DateTimePicker dateTimePickerData;
		private System.Windows.Forms.Button buttonAggiungi;
		private System.Windows.Forms.Button buttonElimina;
		private System.Windows.Forms.Button buttonTorna;
		private System.Windows.Forms.Label labelMessaggio;
		private System.Windows.Forms.GroupBox groupBoxDettagli;
		private System.Windows.Forms.Label labelTotale;
		private System.Windows.Forms.TextBox textBoxTotale;
		private System.Windows.Forms.Button buttonVisualizzaLinee;
	}
}
