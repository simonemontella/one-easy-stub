namespace DesktopFrontend {
	partial class LineeOrdineForm {
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent() {
			this.labelTitolo = new System.Windows.Forms.Label();
			this.dataGridViewLinee = new System.Windows.Forms.DataGridView();
			this.labelProdotto = new System.Windows.Forms.Label();
			this.textBoxProdotto = new System.Windows.Forms.TextBox();
			this.labelQuantita = new System.Windows.Forms.Label();
			this.numericUpDownQuantita = new System.Windows.Forms.NumericUpDown();
			this.labelPrezzoUnitario = new System.Windows.Forms.Label();
			this.textBoxPrezzoUnitario = new System.Windows.Forms.TextBox();
			this.labelSubtotale = new System.Windows.Forms.Label();
			this.textBoxSubtotale = new System.Windows.Forms.TextBox();
			this.buttonAggiungi = new System.Windows.Forms.Button();
			this.buttonElimina = new System.Windows.Forms.Button();
			this.buttonChiudi = new System.Windows.Forms.Button();
			this.labelMessaggio = new System.Windows.Forms.Label();
			this.labelTotaleOrdine = new System.Windows.Forms.Label();
			this.textBoxTotaleOrdine = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinee)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantita)).BeginInit();
			this.SuspendLayout();

			// labelTitolo
			this.labelTitolo.AutoSize = true;
			this.labelTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.labelTitolo.Location = new System.Drawing.Point(12, 9);
			this.labelTitolo.Name = "labelTitolo";
			this.labelTitolo.Size = new System.Drawing.Size(120, 24);
			this.labelTitolo.TabIndex = 0;
			this.labelTitolo.Text = "Linee Ordine";

			// dataGridViewLinee
			this.dataGridViewLinee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLinee.Location = new System.Drawing.Point(12, 220);
			this.dataGridViewLinee.Name = "dataGridViewLinee";
			this.dataGridViewLinee.ReadOnly = true;
			this.dataGridViewLinee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewLinee.Size = new System.Drawing.Size(760, 240);
			this.dataGridViewLinee.TabIndex = 1;
			this.dataGridViewLinee.SelectionChanged += new System.EventHandler(this.DataGridViewLinee_SelectionChanged);

			// labelProdotto
			this.labelProdotto.AutoSize = true;
			this.labelProdotto.Location = new System.Drawing.Point(12, 45);
			this.labelProdotto.Name = "labelProdotto";
			this.labelProdotto.Size = new System.Drawing.Size(53, 13);
			this.labelProdotto.TabIndex = 2;
			this.labelProdotto.Text = "Prodotto";

			// textBoxProdotto
			this.textBoxProdotto.Location = new System.Drawing.Point(12, 61);
			this.textBoxProdotto.Name = "textBoxProdotto";
			this.textBoxProdotto.Size = new System.Drawing.Size(200, 20);
			this.textBoxProdotto.TabIndex = 3;

			// labelQuantita
			this.labelQuantita.AutoSize = true;
			this.labelQuantita.Location = new System.Drawing.Point(220, 45);
			this.labelQuantita.Name = "labelQuantita";
			this.labelQuantita.Size = new System.Drawing.Size(54, 13);
			this.labelQuantita.TabIndex = 4;
			this.labelQuantita.Text = "Quantità";

			// numericUpDownQuantita
			this.numericUpDownQuantita.Location = new System.Drawing.Point(220, 61);
			this.numericUpDownQuantita.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDownQuantita.Name = "numericUpDownQuantita";
			this.numericUpDownQuantita.Size = new System.Drawing.Size(100, 20);
			this.numericUpDownQuantita.TabIndex = 5;
			this.numericUpDownQuantita.Value = new decimal(new int[] { 1, 0, 0, 0 });

			// labelPrezzoUnitario
			this.labelPrezzoUnitario.AutoSize = true;
			this.labelPrezzoUnitario.Location = new System.Drawing.Point(330, 45);
			this.labelPrezzoUnitario.Name = "labelPrezzoUnitario";
			this.labelPrezzoUnitario.Size = new System.Drawing.Size(80, 13);
			this.labelPrezzoUnitario.TabIndex = 6;
			this.labelPrezzoUnitario.Text = "Prezzo Unitario";

			// textBoxPrezzoUnitario
			this.textBoxPrezzoUnitario.Location = new System.Drawing.Point(330, 61);
			this.textBoxPrezzoUnitario.Name = "textBoxPrezzoUnitario";
			this.textBoxPrezzoUnitario.Size = new System.Drawing.Size(100, 20);
			this.textBoxPrezzoUnitario.TabIndex = 7;
			this.textBoxPrezzoUnitario.Text = "0.00";
			this.textBoxPrezzoUnitario.TextChanged += new System.EventHandler(this.TextBoxPrezzoUnitario_TextChanged);

			// labelSubtotale
			this.labelSubtotale.AutoSize = true;
			this.labelSubtotale.Location = new System.Drawing.Point(440, 45);
			this.labelSubtotale.Name = "labelSubtotale";
			this.labelSubtotale.Size = new System.Drawing.Size(60, 13);
			this.labelSubtotale.TabIndex = 8;
			this.labelSubtotale.Text = "Subtotale";

			// textBoxSubtotale
			this.textBoxSubtotale.Location = new System.Drawing.Point(440, 61);
			this.textBoxSubtotale.Name = "textBoxSubtotale";
			this.textBoxSubtotale.ReadOnly = true;
			this.textBoxSubtotale.Size = new System.Drawing.Size(100, 20);
			this.textBoxSubtotale.TabIndex = 9;
			this.textBoxSubtotale.Text = "0.00";

			// buttonAggiungi
			this.buttonAggiungi.Location = new System.Drawing.Point(12, 90);
			this.buttonAggiungi.Name = "buttonAggiungi";
			this.buttonAggiungi.Size = new System.Drawing.Size(75, 23);
			this.buttonAggiungi.TabIndex = 10;
			this.buttonAggiungi.Text = "Aggiungi";
			this.buttonAggiungi.UseVisualStyleBackColor = true;
			this.buttonAggiungi.Click += new System.EventHandler(this.ButtonAggiungi_Click);

			// buttonElimina
			this.buttonElimina.Location = new System.Drawing.Point(93, 90);
			this.buttonElimina.Name = "buttonElimina";
			this.buttonElimina.Size = new System.Drawing.Size(75, 23);
			this.buttonElimina.TabIndex = 11;
			this.buttonElimina.Text = "Elimina";
			this.buttonElimina.UseVisualStyleBackColor = true;
			this.buttonElimina.Click += new System.EventHandler(this.ButtonElimina_Click);

			// labelTotaleOrdine
			this.labelTotaleOrdine.AutoSize = true;
			this.labelTotaleOrdine.Location = new System.Drawing.Point(12, 125);
			this.labelTotaleOrdine.Name = "labelTotaleOrdine";
			this.labelTotaleOrdine.Size = new System.Drawing.Size(82, 13);
			this.labelTotaleOrdine.TabIndex = 12;
			this.labelTotaleOrdine.Text = "Totale Ordine";

			// textBoxTotaleOrdine
			this.textBoxTotaleOrdine.Location = new System.Drawing.Point(12, 141);
			this.textBoxTotaleOrdine.Name = "textBoxTotaleOrdine";
			this.textBoxTotaleOrdine.ReadOnly = true;
			this.textBoxTotaleOrdine.Size = new System.Drawing.Size(200, 20);
			this.textBoxTotaleOrdine.TabIndex = 13;
			this.textBoxTotaleOrdine.Text = "0.00";

			// buttonChiudi
			this.buttonChiudi.Location = new System.Drawing.Point(697, 479);
			this.buttonChiudi.Name = "buttonChiudi";
			this.buttonChiudi.Size = new System.Drawing.Size(75, 23);
			this.buttonChiudi.TabIndex = 14;
			this.buttonChiudi.Text = "Chiudi";
			this.buttonChiudi.UseVisualStyleBackColor = true;
			this.buttonChiudi.Click += new System.EventHandler(this.ButtonChiudi_Click);

			// labelMessaggio
			this.labelMessaggio.AutoSize = true;
			this.labelMessaggio.ForeColor = System.Drawing.Color.Red;
			this.labelMessaggio.Location = new System.Drawing.Point(12, 175);
			this.labelMessaggio.Name = "labelMessaggio";
			this.labelMessaggio.Size = new System.Drawing.Size(0, 13);
			this.labelMessaggio.TabIndex = 15;

			// LineeOrdineForm
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 514);
			this.Controls.Add(this.labelMessaggio);
			this.Controls.Add(this.buttonChiudi);
			this.Controls.Add(this.textBoxTotaleOrdine);
			this.Controls.Add(this.labelTotaleOrdine);
			this.Controls.Add(this.buttonElimina);
			this.Controls.Add(this.buttonAggiungi);
			this.Controls.Add(this.textBoxSubtotale);
			this.Controls.Add(this.labelSubtotale);
			this.Controls.Add(this.textBoxPrezzoUnitario);
			this.Controls.Add(this.labelPrezzoUnitario);
			this.Controls.Add(this.numericUpDownQuantita);
			this.Controls.Add(this.labelQuantita);
			this.Controls.Add(this.textBoxProdotto);
			this.Controls.Add(this.labelProdotto);
			this.Controls.Add(this.dataGridViewLinee);
			this.Controls.Add(this.labelTitolo);
			this.Name = "LineeOrdineForm";
			this.Text = "Gestione Linee Ordine";
			this.Load += new System.EventHandler(this.LineeOrdineForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinee)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantita)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label labelTitolo;
		private System.Windows.Forms.DataGridView dataGridViewLinee;
		private System.Windows.Forms.Label labelProdotto;
		private System.Windows.Forms.TextBox textBoxProdotto;
		private System.Windows.Forms.Label labelQuantita;
		private System.Windows.Forms.NumericUpDown numericUpDownQuantita;
		private System.Windows.Forms.Label labelPrezzoUnitario;
		private System.Windows.Forms.TextBox textBoxPrezzoUnitario;
		private System.Windows.Forms.Label labelSubtotale;
		private System.Windows.Forms.TextBox textBoxSubtotale;
		private System.Windows.Forms.Button buttonAggiungi;
		private System.Windows.Forms.Button buttonElimina;
		private System.Windows.Forms.Button buttonChiudi;
		private System.Windows.Forms.Label labelMessaggio;
		private System.Windows.Forms.Label labelTotaleOrdine;
		private System.Windows.Forms.TextBox textBoxTotaleOrdine;
	}
}
