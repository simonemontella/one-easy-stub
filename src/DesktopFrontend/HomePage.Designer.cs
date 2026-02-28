namespace DesktopFrontend {
	partial class HomePage {
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent() {
			this.labelTitolo = new System.Windows.Forms.Label();
			this.buttonClienti = new System.Windows.Forms.Button();
			this.buttonOrdini = new System.Windows.Forms.Button();
			this.buttonEsci = new System.Windows.Forms.Button();
			this.labelMessaggio = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// labelTitolo
			this.labelTitolo.AutoSize = true;
			this.labelTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.labelTitolo.Location = new System.Drawing.Point(150, 50);
			this.labelTitolo.Name = "labelTitolo";
			this.labelTitolo.Size = new System.Drawing.Size(300, 31);
			this.labelTitolo.TabIndex = 0;
			this.labelTitolo.Text = "Gestione Ordini e Clienti";

			// buttonClienti
			this.buttonClienti.Location = new System.Drawing.Point(150, 120);
			this.buttonClienti.Name = "buttonClienti";
			this.buttonClienti.Size = new System.Drawing.Size(300, 50);
			this.buttonClienti.TabIndex = 1;
			this.buttonClienti.Text = "Gestione Clienti";
			this.buttonClienti.UseVisualStyleBackColor = true;
			this.buttonClienti.Click += new System.EventHandler(this.ButtonClienti_Click);

			// buttonOrdini
			this.buttonOrdini.Location = new System.Drawing.Point(150, 180);
			this.buttonOrdini.Name = "buttonOrdini";
			this.buttonOrdini.Size = new System.Drawing.Size(300, 50);
			this.buttonOrdini.TabIndex = 2;
			this.buttonOrdini.Text = "Gestione Ordini";
			this.buttonOrdini.UseVisualStyleBackColor = true;
			this.buttonOrdini.Click += new System.EventHandler(this.ButtonOrdini_Click);

			// buttonEsci
			this.buttonEsci.Location = new System.Drawing.Point(150, 240);
			this.buttonEsci.Name = "buttonEsci";
			this.buttonEsci.Size = new System.Drawing.Size(300, 50);
			this.buttonEsci.TabIndex = 3;
			this.buttonEsci.Text = "Esci";
			this.buttonEsci.UseVisualStyleBackColor = true;
			this.buttonEsci.Click += new System.EventHandler(this.ButtonEsci_Click);

			// labelMessaggio
			this.labelMessaggio.AutoSize = true;
			this.labelMessaggio.ForeColor = System.Drawing.Color.Red;
			this.labelMessaggio.Location = new System.Drawing.Point(150, 310);
			this.labelMessaggio.Name = "labelMessaggio";
			this.labelMessaggio.Size = new System.Drawing.Size(0, 13);
			this.labelMessaggio.TabIndex = 4;

			// Form1
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.labelMessaggio);
			this.Controls.Add(this.buttonEsci);
			this.Controls.Add(this.buttonOrdini);
			this.Controls.Add(this.buttonClienti);
			this.Controls.Add(this.labelTitolo);
			this.Name = "Form1";
			this.Text = "OneEasy - Gestione Ordini";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label labelTitolo;
		private System.Windows.Forms.Button buttonClienti;
		private System.Windows.Forms.Button buttonOrdini;
		private System.Windows.Forms.Button buttonEsci;
		private System.Windows.Forms.Label labelMessaggio;
	}
}

