
namespace OrgaMS
{
    partial class frmAuftraege
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtAuftragstitel = new System.Windows.Forms.TextBox();
            this.txtAuftrErstDatum = new System.Windows.Forms.TextBox();
            this.txtAuftrDesc = new System.Windows.Forms.TextBox();
            this.txtKuNummer = new System.Windows.Forms.TextBox();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.txtAuftragsNr = new System.Windows.Forms.TextBox();
            this.cbKategorie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(32, 420);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(178, 28);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Speichern";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtAuftragstitel
            // 
            this.txtAuftragstitel.Location = new System.Drawing.Point(32, 37);
            this.txtAuftragstitel.Name = "txtAuftragstitel";
            this.txtAuftragstitel.Size = new System.Drawing.Size(486, 20);
            this.txtAuftragstitel.TabIndex = 1;
            this.txtAuftragstitel.Text = "Titel des Auftrags";
            this.txtAuftragstitel.Click += new System.EventHandler(this.ClearText);
            // 
            // txtAuftrErstDatum
            // 
            this.txtAuftrErstDatum.Location = new System.Drawing.Point(377, 89);
            this.txtAuftrErstDatum.Name = "txtAuftrErstDatum";
            this.txtAuftrErstDatum.Size = new System.Drawing.Size(141, 20);
            this.txtAuftrErstDatum.TabIndex = 3;
            this.txtAuftrErstDatum.Text = "Erstelldatum";
            this.txtAuftrErstDatum.Click += new System.EventHandler(this.ClearText);
            // 
            // txtAuftrDesc
            // 
            this.txtAuftrDesc.Location = new System.Drawing.Point(32, 162);
            this.txtAuftrDesc.Multiline = true;
            this.txtAuftrDesc.Name = "txtAuftrDesc";
            this.txtAuftrDesc.Size = new System.Drawing.Size(486, 252);
            this.txtAuftrDesc.TabIndex = 5;
            this.txtAuftrDesc.Text = "Beschreibung";
            this.txtAuftrDesc.Click += new System.EventHandler(this.ClearText);
            // 
            // txtKuNummer
            // 
            this.txtKuNummer.Location = new System.Drawing.Point(32, 89);
            this.txtKuNummer.Name = "txtKuNummer";
            this.txtKuNummer.Size = new System.Drawing.Size(157, 20);
            this.txtKuNummer.TabIndex = 6;
            this.txtKuNummer.Text = "Kundennummer";
            this.txtKuNummer.Click += new System.EventHandler(this.ClearText);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.Location = new System.Drawing.Point(195, 89);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(123, 20);
            this.btnCustomerList.TabIndex = 7;
            this.btnCustomerList.Text = "Kundenliste";
            this.btnCustomerList.UseVisualStyleBackColor = true;
            // 
            // txtAuftragsNr
            // 
            this.txtAuftragsNr.Location = new System.Drawing.Point(32, 63);
            this.txtAuftragsNr.Name = "txtAuftragsNr";
            this.txtAuftragsNr.Size = new System.Drawing.Size(141, 20);
            this.txtAuftragsNr.TabIndex = 8;
            this.txtAuftragsNr.Text = "Auftragsnummer";
            // 
            // cbKategorie
            // 
            this.cbKategorie.FormattingEnabled = true;
            this.cbKategorie.Items.AddRange(new object[] {
            "App",
            "Website",
            "AddOn",
            "Plugin",
            "Extensions",
            "Database",
            "None"});
            this.cbKategorie.Location = new System.Drawing.Point(377, 62);
            this.cbKategorie.Name = "cbKategorie";
            this.cbKategorie.Size = new System.Drawing.Size(141, 21);
            this.cbKategorie.TabIndex = 9;
            // 
            // frmAuftraege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 460);
            this.Controls.Add(this.cbKategorie);
            this.Controls.Add(this.txtAuftragsNr);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.txtKuNummer);
            this.Controls.Add(this.txtAuftrDesc);
            this.Controls.Add(this.txtAuftrErstDatum);
            this.Controls.Add(this.txtAuftragstitel);
            this.Controls.Add(this.btnAccept);
            this.Name = "frmAuftraege";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtAuftragstitel;
        private System.Windows.Forms.TextBox txtAuftrErstDatum;
        private System.Windows.Forms.TextBox txtAuftrDesc;
        private System.Windows.Forms.TextBox txtKuNummer;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.TextBox txtAuftragsNr;
        private System.Windows.Forms.ComboBox cbKategorie;
    }
}

