namespace AdressBok
{
    partial class AdressBok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gwKontaktLista = new System.Windows.Forms.DataGridView();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gatuadress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSkapaNyKontakt = new System.Windows.Forms.Button();
            this.lblNamn = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.lblGatuadress = new System.Windows.Forms.Label();
            this.txtGatuAdress = new System.Windows.Forms.TextBox();
            this.lblPostnummer = new System.Windows.Forms.Label();
            this.txtPostnummer = new System.Windows.Forms.TextBox();
            this.lblPostOrt = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPostOrt = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSpara = new System.Windows.Forms.Button();
            this.cbKontaktTyp = new System.Windows.Forms.ComboBox();
            this.lblKontaktTyp = new System.Windows.Forms.Label();
            this.btnRadera = new System.Windows.Forms.Button();
            this.lblSökNamn = new System.Windows.Forms.Label();
            this.txtSök = new System.Windows.Forms.TextBox();
            this.cbEditera = new System.Windows.Forms.CheckBox();
            this.lblSökPostOrt = new System.Windows.Forms.Label();
            this.txtSök1 = new System.Windows.Forms.TextBox();
            this.lblSökKontaktTyp = new System.Windows.Forms.Label();
            this.cbSökKontaktTyp = new System.Windows.Forms.ComboBox();
            this.btnSök = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gwKontaktLista)).BeginInit();
            this.SuspendLayout();
            // 
            // gwKontaktLista
            // 
            this.gwKontaktLista.AllowUserToAddRows = false;
            this.gwKontaktLista.AllowUserToDeleteRows = false;
            this.gwKontaktLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwKontaktLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namn,
            this.TypID,
            this.KontaktID,
            this.Email,
            this.Gatuadress,
            this.Postnummer,
            this.Postort,
            this.Telefon,
            this.TypNamn});
            this.gwKontaktLista.Location = new System.Drawing.Point(41, 62);
            this.gwKontaktLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gwKontaktLista.MultiSelect = false;
            this.gwKontaktLista.Name = "gwKontaktLista";
            this.gwKontaktLista.ReadOnly = true;
            this.gwKontaktLista.RowTemplate.Height = 28;
            this.gwKontaktLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gwKontaktLista.Size = new System.Drawing.Size(617, 120);
            this.gwKontaktLista.TabIndex = 0;
            this.gwKontaktLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwKontaktLista_CellClick);
            // 
            // Namn
            // 
            this.Namn.DataPropertyName = "Namn";
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            // 
            // TypID
            // 
            this.TypID.DataPropertyName = "TypID";
            this.TypID.HeaderText = "TypID";
            this.TypID.Name = "TypID";
            this.TypID.ReadOnly = true;
            this.TypID.Visible = false;
            // 
            // KontaktID
            // 
            this.KontaktID.DataPropertyName = "KontaktID";
            this.KontaktID.HeaderText = "KontaktID";
            this.KontaktID.Name = "KontaktID";
            this.KontaktID.ReadOnly = true;
            this.KontaktID.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Gatuadress
            // 
            this.Gatuadress.DataPropertyName = "Gatuadress";
            this.Gatuadress.HeaderText = "Gatuadress";
            this.Gatuadress.Name = "Gatuadress";
            this.Gatuadress.ReadOnly = true;
            // 
            // Postnummer
            // 
            this.Postnummer.DataPropertyName = "PostNummer";
            this.Postnummer.HeaderText = "Postnummer";
            this.Postnummer.Name = "Postnummer";
            this.Postnummer.ReadOnly = true;
            this.Postnummer.Visible = false;
            // 
            // Postort
            // 
            this.Postort.DataPropertyName = "PostOrt";
            this.Postort.HeaderText = "Postort";
            this.Postort.Name = "Postort";
            this.Postort.ReadOnly = true;
            this.Postort.Visible = false;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // TypNamn
            // 
            this.TypNamn.DataPropertyName = "TypNamn";
            this.TypNamn.HeaderText = "Typ";
            this.TypNamn.Name = "TypNamn";
            this.TypNamn.ReadOnly = true;
            this.TypNamn.Visible = false;
            // 
            // btnSkapaNyKontakt
            // 
            this.btnSkapaNyKontakt.Location = new System.Drawing.Point(41, 186);
            this.btnSkapaNyKontakt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSkapaNyKontakt.Name = "btnSkapaNyKontakt";
            this.btnSkapaNyKontakt.Size = new System.Drawing.Size(96, 39);
            this.btnSkapaNyKontakt.TabIndex = 1;
            this.btnSkapaNyKontakt.Text = "Skapa ny kontakt";
            this.btnSkapaNyKontakt.UseVisualStyleBackColor = true;
            this.btnSkapaNyKontakt.Click += new System.EventHandler(this.btnSkapaNyKontakt_Click);
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(37, 233);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(45, 17);
            this.lblNamn.TabIndex = 2;
            this.lblNamn.Text = "Namn";
            // 
            // txtNamn
            // 
            this.txtNamn.Enabled = false;
            this.txtNamn.Location = new System.Drawing.Point(126, 230);
            this.txtNamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(89, 22);
            this.txtNamn.TabIndex = 3;
            // 
            // lblGatuadress
            // 
            this.lblGatuadress.AutoSize = true;
            this.lblGatuadress.Location = new System.Drawing.Point(37, 261);
            this.lblGatuadress.Name = "lblGatuadress";
            this.lblGatuadress.Size = new System.Drawing.Size(82, 17);
            this.lblGatuadress.TabIndex = 4;
            this.lblGatuadress.Text = "Gatuadress";
            // 
            // txtGatuAdress
            // 
            this.txtGatuAdress.Enabled = false;
            this.txtGatuAdress.Location = new System.Drawing.Point(126, 256);
            this.txtGatuAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGatuAdress.Name = "txtGatuAdress";
            this.txtGatuAdress.Size = new System.Drawing.Size(89, 22);
            this.txtGatuAdress.TabIndex = 5;
            // 
            // lblPostnummer
            // 
            this.lblPostnummer.AutoSize = true;
            this.lblPostnummer.Location = new System.Drawing.Point(37, 285);
            this.lblPostnummer.Name = "lblPostnummer";
            this.lblPostnummer.Size = new System.Drawing.Size(87, 17);
            this.lblPostnummer.TabIndex = 6;
            this.lblPostnummer.Text = "Postnummer";
            // 
            // txtPostnummer
            // 
            this.txtPostnummer.Enabled = false;
            this.txtPostnummer.Location = new System.Drawing.Point(126, 282);
            this.txtPostnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPostnummer.Name = "txtPostnummer";
            this.txtPostnummer.Size = new System.Drawing.Size(89, 22);
            this.txtPostnummer.TabIndex = 7;
            // 
            // lblPostOrt
            // 
            this.lblPostOrt.AutoSize = true;
            this.lblPostOrt.Location = new System.Drawing.Point(252, 234);
            this.lblPostOrt.Name = "lblPostOrt";
            this.lblPostOrt.Size = new System.Drawing.Size(53, 17);
            this.lblPostOrt.TabIndex = 8;
            this.lblPostOrt.Text = "Postort";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(252, 256);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(252, 282);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtPostOrt
            // 
            this.txtPostOrt.Enabled = false;
            this.txtPostOrt.Location = new System.Drawing.Point(310, 228);
            this.txtPostOrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPostOrt.Name = "txtPostOrt";
            this.txtPostOrt.Size = new System.Drawing.Size(89, 22);
            this.txtPostOrt.TabIndex = 11;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Location = new System.Drawing.Point(310, 256);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(89, 22);
            this.txtTelefon.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(310, 285);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(89, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // btnSpara
            // 
            this.btnSpara.Enabled = false;
            this.btnSpara.Location = new System.Drawing.Point(609, 329);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(67, 23);
            this.btnSpara.TabIndex = 14;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // cbKontaktTyp
            // 
            this.cbKontaktTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKontaktTyp.Enabled = false;
            this.cbKontaktTyp.FormattingEnabled = true;
            this.cbKontaktTyp.Location = new System.Drawing.Point(515, 233);
            this.cbKontaktTyp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKontaktTyp.Name = "cbKontaktTyp";
            this.cbKontaktTyp.Size = new System.Drawing.Size(108, 24);
            this.cbKontaktTyp.TabIndex = 15;
            // 
            // lblKontaktTyp
            // 
            this.lblKontaktTyp.AutoSize = true;
            this.lblKontaktTyp.Location = new System.Drawing.Point(430, 234);
            this.lblKontaktTyp.Name = "lblKontaktTyp";
            this.lblKontaktTyp.Size = new System.Drawing.Size(75, 17);
            this.lblKontaktTyp.TabIndex = 16;
            this.lblKontaktTyp.Text = "Kontakttyp";
            // 
            // btnRadera
            // 
            this.btnRadera.Location = new System.Drawing.Point(501, 329);
            this.btnRadera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(68, 26);
            this.btnRadera.TabIndex = 17;
            this.btnRadera.Text = "Radera";
            this.btnRadera.UseVisualStyleBackColor = true;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click);
            // 
            // lblSökNamn
            // 
            this.lblSökNamn.AutoSize = true;
            this.lblSökNamn.Location = new System.Drawing.Point(51, 22);
            this.lblSökNamn.Name = "lblSökNamn";
            this.lblSökNamn.Size = new System.Drawing.Size(49, 17);
            this.lblSökNamn.TabIndex = 18;
            this.lblSökNamn.Text = "Namn:";
            // 
            // txtSök
            // 
            this.txtSök.Location = new System.Drawing.Point(105, 22);
            this.txtSök.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSök.Name = "txtSök";
            this.txtSök.Size = new System.Drawing.Size(89, 22);
            this.txtSök.TabIndex = 19;
            // 
            // cbEditera
            // 
            this.cbEditera.AutoSize = true;
            this.cbEditera.Location = new System.Drawing.Point(557, 197);
            this.cbEditera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEditera.Name = "cbEditera";
            this.cbEditera.Size = new System.Drawing.Size(75, 21);
            this.cbEditera.TabIndex = 20;
            this.cbEditera.Text = "Editera";
            this.cbEditera.UseVisualStyleBackColor = true;
            this.cbEditera.CheckedChanged += new System.EventHandler(this.cbEditera_CheckedChanged);
            // 
            // lblSökPostOrt
            // 
            this.lblSökPostOrt.AutoSize = true;
            this.lblSökPostOrt.Location = new System.Drawing.Point(211, 22);
            this.lblSökPostOrt.Name = "lblSökPostOrt";
            this.lblSökPostOrt.Size = new System.Drawing.Size(57, 17);
            this.lblSökPostOrt.TabIndex = 21;
            this.lblSökPostOrt.Text = "Postort:";
            // 
            // txtSök1
            // 
            this.txtSök1.Location = new System.Drawing.Point(274, 21);
            this.txtSök1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSök1.Name = "txtSök1";
            this.txtSök1.Size = new System.Drawing.Size(89, 22);
            this.txtSök1.TabIndex = 22;
            // 
            // lblSökKontaktTyp
            // 
            this.lblSökKontaktTyp.AutoSize = true;
            this.lblSökKontaktTyp.Location = new System.Drawing.Point(397, 24);
            this.lblSökKontaktTyp.Name = "lblSökKontaktTyp";
            this.lblSökKontaktTyp.Size = new System.Drawing.Size(79, 17);
            this.lblSökKontaktTyp.TabIndex = 23;
            this.lblSökKontaktTyp.Text = "Kontakttyp:";
            // 
            // cbSökKontaktTyp
            // 
            this.cbSökKontaktTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSökKontaktTyp.FormattingEnabled = true;
            this.cbSökKontaktTyp.Items.AddRange(new object[] {
            "Jobb",
            "Övrig",
            "Personlig"});
            this.cbSökKontaktTyp.Location = new System.Drawing.Point(482, 19);
            this.cbSökKontaktTyp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSökKontaktTyp.Name = "cbSökKontaktTyp";
            this.cbSökKontaktTyp.Size = new System.Drawing.Size(108, 24);
            this.cbSökKontaktTyp.TabIndex = 24;
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(629, 10);
            this.btnSök.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(46, 33);
            this.btnSök.TabIndex = 25;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // AdressBok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 362);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.cbSökKontaktTyp);
            this.Controls.Add(this.lblSökKontaktTyp);
            this.Controls.Add(this.txtSök1);
            this.Controls.Add(this.lblSökPostOrt);
            this.Controls.Add(this.cbEditera);
            this.Controls.Add(this.txtSök);
            this.Controls.Add(this.lblSökNamn);
            this.Controls.Add(this.btnRadera);
            this.Controls.Add(this.lblKontaktTyp);
            this.Controls.Add(this.cbKontaktTyp);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPostOrt);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblPostOrt);
            this.Controls.Add(this.txtPostnummer);
            this.Controls.Add(this.lblPostnummer);
            this.Controls.Add(this.txtGatuAdress);
            this.Controls.Add(this.lblGatuadress);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.btnSkapaNyKontakt);
            this.Controls.Add(this.gwKontaktLista);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdressBok";
            this.Text = "AdressBok";
            this.Load += new System.EventHandler(this.AdressBok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gwKontaktLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gwKontaktLista;
        private System.Windows.Forms.Button btnSkapaNyKontakt;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.Label lblGatuadress;
        private System.Windows.Forms.TextBox txtGatuAdress;
        private System.Windows.Forms.Label lblPostnummer;
        private System.Windows.Forms.TextBox txtPostnummer;
        private System.Windows.Forms.Label lblPostOrt;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPostOrt;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.ComboBox cbKontaktTyp;
        private System.Windows.Forms.Label lblKontaktTyp;
        private System.Windows.Forms.Button btnRadera;
        private System.Windows.Forms.Label lblSökNamn;
        private System.Windows.Forms.TextBox txtSök;
        private System.Windows.Forms.CheckBox cbEditera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gatuadress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypNamn;
        private System.Windows.Forms.Label lblSökPostOrt;
        private System.Windows.Forms.TextBox txtSök1;
        private System.Windows.Forms.Label lblSökKontaktTyp;
        private System.Windows.Forms.ComboBox cbSökKontaktTyp;
        private System.Windows.Forms.Button btnSök;
    }
}

