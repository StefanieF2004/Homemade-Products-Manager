namespace DomasniProizvodi1
{
    partial class Form1
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabKlienti = new System.Windows.Forms.TabPage();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnIzbrisiKlient = new System.Windows.Forms.Button();
            this.btnIzmeniKlient = new System.Windows.Forms.Button();
            this.btnDodadiKlient = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.dgvKlienti = new System.Windows.Forms.DataGridView();
            this.tabProizvodi = new System.Windows.Forms.TabPage();
            this.txtSoSostojki = new System.Windows.Forms.TextBox();
            this.sostojki = new System.Windows.Forms.Label();
            this.btnOpis = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtImeProizvod = new System.Windows.Forms.TextBox();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelImeProizvod = new System.Windows.Forms.Label();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.tabNaracki = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKupuvaci = new System.Windows.Forms.TextBox();
            this.PrikaziKupuvaci = new System.Windows.Forms.Button();
            this.btnProsecnaCena = new System.Windows.Forms.Button();
            this.txtVkupnaCena = new System.Windows.Forms.TextBox();
            this.lblVkupno = new System.Windows.Forms.Label();
            this.dgvNaracki = new System.Windows.Forms.DataGridView();
            this.btnCena = new System.Windows.Forms.Button();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.tabControlMain.SuspendLayout();
            this.tabKlienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienti)).BeginInit();
            this.tabProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.tabNaracki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaracki)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabKlienti);
            this.tabControlMain.Controls.Add(this.tabProizvodi);
            this.tabControlMain.Controls.Add(this.tabNaracki);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(513, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabKlienti
            // 
            this.tabKlienti.Controls.Add(this.txtID);
            this.tabKlienti.Controls.Add(this.btnIzbrisiKlient);
            this.tabKlienti.Controls.Add(this.btnIzmeniKlient);
            this.tabKlienti.Controls.Add(this.btnDodadiKlient);
            this.tabKlienti.Controls.Add(this.txtAdresa);
            this.tabKlienti.Controls.Add(this.txtEmail);
            this.tabKlienti.Controls.Add(this.txtTelefon);
            this.tabKlienti.Controls.Add(this.txtPrezime);
            this.tabKlienti.Controls.Add(this.txtIme);
            this.tabKlienti.Controls.Add(this.labelAdresa);
            this.tabKlienti.Controls.Add(this.labelEmail);
            this.tabKlienti.Controls.Add(this.labelTelefon);
            this.tabKlienti.Controls.Add(this.labelPrezime);
            this.tabKlienti.Controls.Add(this.labelIme);
            this.tabKlienti.Controls.Add(this.dgvKlienti);
            this.tabKlienti.Location = new System.Drawing.Point(4, 22);
            this.tabKlienti.Name = "tabKlienti";
            this.tabKlienti.Padding = new System.Windows.Forms.Padding(3);
            this.tabKlienti.Size = new System.Drawing.Size(505, 424);
            this.tabKlienti.TabIndex = 0;
            this.tabKlienti.Text = "Клиенти";
            this.tabKlienti.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 369);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 14;
            this.txtID.Visible = false;
            // 
            // btnIzbrisiKlient
            // 
            this.btnIzbrisiKlient.Location = new System.Drawing.Point(281, 196);
            this.btnIzbrisiKlient.Name = "btnIzbrisiKlient";
            this.btnIzbrisiKlient.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisiKlient.TabIndex = 13;
            this.btnIzbrisiKlient.Text = "Избриши";
            this.btnIzbrisiKlient.UseVisualStyleBackColor = true;
            this.btnIzbrisiKlient.Click += new System.EventHandler(this.btnIzbrisiKlient_Click);
            // 
            // btnIzmeniKlient
            // 
            this.btnIzmeniKlient.Location = new System.Drawing.Point(281, 248);
            this.btnIzmeniKlient.Name = "btnIzmeniKlient";
            this.btnIzmeniKlient.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeniKlient.TabIndex = 12;
            this.btnIzmeniKlient.Text = "Измени";
            this.btnIzmeniKlient.UseVisualStyleBackColor = true;
            this.btnIzmeniKlient.Click += new System.EventHandler(this.btnIzmeniKlient_Click_1);
            // 
            // btnDodadiKlient
            // 
            this.btnDodadiKlient.Location = new System.Drawing.Point(281, 294);
            this.btnDodadiKlient.Name = "btnDodadiKlient";
            this.btnDodadiKlient.Size = new System.Drawing.Size(75, 23);
            this.btnDodadiKlient.TabIndex = 11;
            this.btnDodadiKlient.Text = "Додади";
            this.btnDodadiKlient.UseVisualStyleBackColor = true;
            this.btnDodadiKlient.Click += new System.EventHandler(this.btnDodadiKlient_Click_1);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(94, 329);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 255);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(94, 219);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 7;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(94, 184);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 6;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(33, 331);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(44, 13);
            this.labelAdresa.TabIndex = 5;
            this.labelAdresa.Text = "Адреса";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(45, 294);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(25, 258);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(52, 13);
            this.labelTelefon.TabIndex = 3;
            this.labelTelefon.Text = "Телефон";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(24, 222);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(53, 13);
            this.labelPrezime.TabIndex = 2;
            this.labelPrezime.Text = "Презиме";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(48, 187);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(29, 13);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Име";
            // 
            // dgvKlienti
            // 
            this.dgvKlienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlienti.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKlienti.Location = new System.Drawing.Point(3, 3);
            this.dgvKlienti.Name = "dgvKlienti";
            this.dgvKlienti.Size = new System.Drawing.Size(499, 150);
            this.dgvKlienti.TabIndex = 0;
            this.dgvKlienti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlienti_CellContentClick);
            // 
            // tabProizvodi
            // 
            this.tabProizvodi.Controls.Add(this.txtSoSostojki);
            this.tabProizvodi.Controls.Add(this.sostojki);
            this.tabProizvodi.Controls.Add(this.btnOpis);
            this.tabProizvodi.Controls.Add(this.txtCena);
            this.tabProizvodi.Controls.Add(this.txtImeProizvod);
            this.tabProizvodi.Controls.Add(this.labelCena);
            this.tabProizvodi.Controls.Add(this.labelImeProizvod);
            this.tabProizvodi.Controls.Add(this.dgvProizvodi);
            this.tabProizvodi.Location = new System.Drawing.Point(4, 22);
            this.tabProizvodi.Name = "tabProizvodi";
            this.tabProizvodi.Padding = new System.Windows.Forms.Padding(3);
            this.tabProizvodi.Size = new System.Drawing.Size(505, 424);
            this.tabProizvodi.TabIndex = 1;
            this.tabProizvodi.Text = "Производи";
            this.tabProizvodi.UseVisualStyleBackColor = true;
            // 
            // txtSoSostojki
            // 
            this.txtSoSostojki.Location = new System.Drawing.Point(270, 239);
            this.txtSoSostojki.Multiline = true;
            this.txtSoSostojki.Name = "txtSoSostojki";
            this.txtSoSostojki.Size = new System.Drawing.Size(117, 86);
            this.txtSoSostojki.TabIndex = 17;
            // 
            // sostojki
            // 
            this.sostojki.AutoSize = true;
            this.sostojki.Location = new System.Drawing.Point(276, 220);
            this.sostojki.Name = "sostojki";
            this.sostojki.Size = new System.Drawing.Size(51, 13);
            this.sostojki.TabIndex = 15;
            this.sostojki.Text = "Состојки";
            // 
            // btnOpis
            // 
            this.btnOpis.Location = new System.Drawing.Point(62, 304);
            this.btnOpis.Name = "btnOpis";
            this.btnOpis.Size = new System.Drawing.Size(75, 23);
            this.btnOpis.TabIndex = 9;
            this.btnOpis.Text = "Пребарај";
            this.btnOpis.UseVisualStyleBackColor = true;
            this.btnOpis.Click += new System.EventHandler(this.btnOpis_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(270, 356);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(117, 20);
            this.txtCena.TabIndex = 6;
            // 
            // txtImeProizvod
            // 
            this.txtImeProizvod.Location = new System.Drawing.Point(54, 276);
            this.txtImeProizvod.Name = "txtImeProizvod";
            this.txtImeProizvod.Size = new System.Drawing.Size(100, 20);
            this.txtImeProizvod.TabIndex = 4;
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(276, 340);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(33, 13);
            this.labelCena.TabIndex = 3;
            this.labelCena.Text = "Цена";
            // 
            // labelImeProizvod
            // 
            this.labelImeProizvod.AutoSize = true;
            this.labelImeProizvod.Location = new System.Drawing.Point(59, 260);
            this.labelImeProizvod.Name = "labelImeProizvod";
            this.labelImeProizvod.Size = new System.Drawing.Size(95, 13);
            this.labelImeProizvod.TabIndex = 1;
            this.labelImeProizvod.Text = "Име на производ";
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProizvodi.Location = new System.Drawing.Point(3, 3);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.Size = new System.Drawing.Size(499, 198);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellContentClick);
            // 
            // tabNaracki
            // 
            this.tabNaracki.Controls.Add(this.label1);
            this.tabNaracki.Controls.Add(this.txtKupuvaci);
            this.tabNaracki.Controls.Add(this.PrikaziKupuvaci);
            this.tabNaracki.Controls.Add(this.btnProsecnaCena);
            this.tabNaracki.Controls.Add(this.txtVkupnaCena);
            this.tabNaracki.Controls.Add(this.lblVkupno);
            this.tabNaracki.Controls.Add(this.dgvNaracki);
            this.tabNaracki.Controls.Add(this.btnCena);
            this.tabNaracki.Controls.Add(this.dtDatum);
            this.tabNaracki.Location = new System.Drawing.Point(4, 22);
            this.tabNaracki.Name = "tabNaracki";
            this.tabNaracki.Size = new System.Drawing.Size(505, 424);
            this.tabNaracki.TabIndex = 2;
            this.tabNaracki.Text = "Нарачки";
            this.tabNaracki.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Клиенти";
            // 
            // txtKupuvaci
            // 
            this.txtKupuvaci.Location = new System.Drawing.Point(295, 194);
            this.txtKupuvaci.Multiline = true;
            this.txtKupuvaci.Name = "txtKupuvaci";
            this.txtKupuvaci.Size = new System.Drawing.Size(178, 101);
            this.txtKupuvaci.TabIndex = 9;
            // 
            // PrikaziKupuvaci
            // 
            this.PrikaziKupuvaci.Location = new System.Drawing.Point(342, 311);
            this.PrikaziKupuvaci.Name = "PrikaziKupuvaci";
            this.PrikaziKupuvaci.Size = new System.Drawing.Size(75, 23);
            this.PrikaziKupuvaci.TabIndex = 8;
            this.PrikaziKupuvaci.Text = "Прикажи купувачи";
            this.PrikaziKupuvaci.UseVisualStyleBackColor = true;
            this.PrikaziKupuvaci.Click += new System.EventHandler(this.PrikaziKupuvaci_Click);
            // 
            // btnProsecnaCena
            // 
            this.btnProsecnaCena.Location = new System.Drawing.Point(130, 207);
            this.btnProsecnaCena.Name = "btnProsecnaCena";
            this.btnProsecnaCena.Size = new System.Drawing.Size(93, 24);
            this.btnProsecnaCena.TabIndex = 7;
            this.btnProsecnaCena.Text = "Просечна цена";
            this.btnProsecnaCena.UseVisualStyleBackColor = true;
            this.btnProsecnaCena.Click += new System.EventHandler(this.btnProsecnaCena_Click);
            // 
            // txtVkupnaCena
            // 
            this.txtVkupnaCena.Location = new System.Drawing.Point(82, 258);
            this.txtVkupnaCena.Name = "txtVkupnaCena";
            this.txtVkupnaCena.Size = new System.Drawing.Size(72, 20);
            this.txtVkupnaCena.TabIndex = 6;
            // 
            // lblVkupno
            // 
            this.lblVkupno.AutoSize = true;
            this.lblVkupno.Location = new System.Drawing.Point(40, 261);
            this.lblVkupno.Name = "lblVkupno";
            this.lblVkupno.Size = new System.Drawing.Size(36, 13);
            this.lblVkupno.TabIndex = 4;
            this.lblVkupno.Text = " Цена";
            // 
            // dgvNaracki
            // 
            this.dgvNaracki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaracki.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNaracki.Location = new System.Drawing.Point(0, 0);
            this.dgvNaracki.Name = "dgvNaracki";
            this.dgvNaracki.Size = new System.Drawing.Size(505, 150);
            this.dgvNaracki.TabIndex = 3;
            // 
            // btnCena
            // 
            this.btnCena.Location = new System.Drawing.Point(23, 207);
            this.btnCena.Name = "btnCena";
            this.btnCena.Size = new System.Drawing.Size(97, 23);
            this.btnCena.TabIndex = 2;
            this.btnCena.Text = "Пресметај цена";
            this.btnCena.UseVisualStyleBackColor = true;
            this.btnCena.Click += new System.EventHandler(this.btnCena_Click);
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(23, 171);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 20);
            this.dtDatum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabKlienti.ResumeLayout(false);
            this.tabKlienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienti)).EndInit();
            this.tabProizvodi.ResumeLayout(false);
            this.tabProizvodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.tabNaracki.ResumeLayout(false);
            this.tabNaracki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaracki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabKlienti;
        private System.Windows.Forms.TabPage tabProizvodi;
        private System.Windows.Forms.DataGridView dgvKlienti;
        private System.Windows.Forms.TabPage tabNaracki;
        private System.Windows.Forms.Button btnIzbrisiKlient;
        private System.Windows.Forms.Button btnIzmeniKlient;
        private System.Windows.Forms.Button btnDodadiKlient;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelImeProizvod;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button btnOpis;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtImeProizvod;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Label lblVkupno;
        private System.Windows.Forms.DataGridView dgvNaracki;
        private System.Windows.Forms.Button btnCena;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.TextBox txtVkupnaCena;
        private System.Windows.Forms.Label sostojki;
        private System.Windows.Forms.TextBox txtSoSostojki;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnProsecnaCena;
        private System.Windows.Forms.TextBox txtKupuvaci;
        private System.Windows.Forms.Button PrikaziKupuvaci;
        private System.Windows.Forms.Label label1;
    }
}

