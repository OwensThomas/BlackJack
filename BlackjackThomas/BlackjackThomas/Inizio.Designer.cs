namespace BlackjackThomas
{
    partial class Inizio
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGioca = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.txtGiocatore = new System.Windows.Forms.TextBox();
            this.lblGiocatore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGioca
            // 
            this.btnGioca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGioca.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioca.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGioca.Location = new System.Drawing.Point(12, 687);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(151, 46);
            this.btnGioca.TabIndex = 0;
            this.btnGioca.Text = "GIOCA";
            this.btnGioca.UseVisualStyleBackColor = true;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEsci.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEsci.Location = new System.Drawing.Point(1219, 687);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(121, 46);
            this.btnEsci.TabIndex = 1;
            this.btnEsci.Text = "ESCI";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // txtGiocatore
            // 
            this.txtGiocatore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiocatore.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiocatore.Location = new System.Drawing.Point(509, 673);
            this.txtGiocatore.Multiline = true;
            this.txtGiocatore.Name = "txtGiocatore";
            this.txtGiocatore.Size = new System.Drawing.Size(316, 32);
            this.txtGiocatore.TabIndex = 2;
            // 
            // lblGiocatore
            // 
            this.lblGiocatore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiocatore.AutoSize = true;
            this.lblGiocatore.BackColor = System.Drawing.Color.Transparent;
            this.lblGiocatore.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiocatore.ForeColor = System.Drawing.Color.White;
            this.lblGiocatore.Location = new System.Drawing.Point(481, 629);
            this.lblGiocatore.Name = "lblGiocatore";
            this.lblGiocatore.Size = new System.Drawing.Size(371, 41);
            this.lblGiocatore.TabIndex = 3;
            this.lblGiocatore.Text = "Inserisci il tuo nome";
            // 
            // Inizio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackjackThomas.Properties.Resources.blackjackSfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 745);
            this.Controls.Add(this.lblGiocatore);
            this.Controls.Add(this.txtGiocatore);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnGioca);
            this.Name = "Inizio";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.TextBox txtGiocatore;
        private System.Windows.Forms.Label lblGiocatore;
    }
}

