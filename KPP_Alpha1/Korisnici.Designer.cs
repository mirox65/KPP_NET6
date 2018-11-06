namespace KPP_Alpha1
{
    partial class form_Korisnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Korisnici));
            this.lbl_id_korisnik = new System.Windows.Forms.Label();
            this.lbl_ime_korisnik = new System.Windows.Forms.Label();
            this.lbl_prezime_korisnik = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.dgv_korisnik = new System.Windows.Forms.DataGridView();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_uloga = new System.Windows.Forms.ComboBox();
            this.txt_korIme = new System.Windows.Forms.TextBox();
            this.txt_lozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_korisnik)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_id_korisnik
            // 
            this.lbl_id_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id_korisnik.AutoSize = true;
            this.lbl_id_korisnik.Location = new System.Drawing.Point(12, 43);
            this.lbl_id_korisnik.Name = "lbl_id_korisnik";
            this.lbl_id_korisnik.Size = new System.Drawing.Size(26, 19);
            this.lbl_id_korisnik.TabIndex = 0;
            this.lbl_id_korisnik.Text = "ID:";
            // 
            // lbl_ime_korisnik
            // 
            this.lbl_ime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ime_korisnik.AutoSize = true;
            this.lbl_ime_korisnik.Location = new System.Drawing.Point(12, 90);
            this.lbl_ime_korisnik.Name = "lbl_ime_korisnik";
            this.lbl_ime_korisnik.Size = new System.Drawing.Size(35, 19);
            this.lbl_ime_korisnik.TabIndex = 1;
            this.lbl_ime_korisnik.Text = "Ime:";
            // 
            // lbl_prezime_korisnik
            // 
            this.lbl_prezime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_prezime_korisnik.AutoSize = true;
            this.lbl_prezime_korisnik.Location = new System.Drawing.Point(12, 137);
            this.lbl_prezime_korisnik.Name = "lbl_prezime_korisnik";
            this.lbl_prezime_korisnik.Size = new System.Drawing.Size(60, 19);
            this.lbl_prezime_korisnik.TabIndex = 2;
            this.lbl_prezime_korisnik.Text = "Prezime:";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(109, 39);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 26);
            this.txt_id.TabIndex = 1;
            this.txt_id.TabStop = false;
            // 
            // txt_ime
            // 
            this.txt_ime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ime.Location = new System.Drawing.Point(109, 86);
            this.txt_ime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(210, 26);
            this.txt_ime.TabIndex = 1;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_prezime.Location = new System.Drawing.Point(109, 133);
            this.txt_prezime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(210, 26);
            this.txt_prezime.TabIndex = 2;
            // 
            // dgv_korisnik
            // 
            this.dgv_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_korisnik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_korisnik.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_korisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_korisnik.Location = new System.Drawing.Point(12, 213);
            this.dgv_korisnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_korisnik.Name = "dgv_korisnik";
            this.dgv_korisnik.RowTemplate.Height = 24;
            this.dgv_korisnik.Size = new System.Drawing.Size(758, 329);
            this.dgv_korisnik.TabIndex = 6;
            this.dgv_korisnik.TabStop = false;
            this.dgv_korisnik.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_korisnik_RowHeaderMouseClick);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dodaj.Location = new System.Drawing.Point(680, 39);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(90, 65);
            this.btn_dodaj.TabIndex = 3;
            this.btn_dodaj.Text = "Spremi novi (F4)";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.lbl_dodaj_Click);
            // 
            // btn_uredi
            // 
            this.btn_uredi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_uredi.Location = new System.Drawing.Point(680, 109);
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.Size = new System.Drawing.Size(90, 65);
            this.btn_uredi.TabIndex = 8;
            this.btn_uredi.TabStop = false;
            this.btn_uredi.Text = "Spremi izmjene (F3)";
            this.btn_uredi.UseVisualStyleBackColor = true;
            this.btn_uredi.Click += new System.EventHandler(this.lbl_uredi_Click);
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(109, 180);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(661, 26);
            this.txt_pretrazivanje.TabIndex = 10;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretrazivanje_TextChanged);
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(12, 185);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(90, 19);
            this.lbl_pretrazivanje.TabIndex = 11;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviUnosToolStripMenuItem,
            this.spremiIzmjeneToolStripMenuItem});
            this.datotekaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // dodajNoviUnosToolStripMenuItem
            // 
            this.dodajNoviUnosToolStripMenuItem.Name = "dodajNoviUnosToolStripMenuItem";
            this.dodajNoviUnosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.dodajNoviUnosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dodajNoviUnosToolStripMenuItem.Text = "Spremi novi unos";
            this.dodajNoviUnosToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviUnosToolStripMenuItem_Click);
            // 
            // spremiIzmjeneToolStripMenuItem
            // 
            this.spremiIzmjeneToolStripMenuItem.Name = "spremiIzmjeneToolStripMenuItem";
            this.spremiIzmjeneToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.spremiIzmjeneToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.spremiIzmjeneToolStripMenuItem.Text = "Spremi izmjene";
            this.spremiIzmjeneToolStripMenuItem.Click += new System.EventHandler(this.spremiIzmjeneToolStripMenuItem_Click);
            // 
            // cmb_uloga
            // 
            this.cmb_uloga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_uloga.FormattingEnabled = true;
            this.cmb_uloga.Items.AddRange(new object[] {
            "Korisnik",
            "Administrator"});
            this.cmb_uloga.Location = new System.Drawing.Point(451, 39);
            this.cmb_uloga.Name = "cmb_uloga";
            this.cmb_uloga.Size = new System.Drawing.Size(210, 27);
            this.cmb_uloga.TabIndex = 31;
            // 
            // txt_korIme
            // 
            this.txt_korIme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_korIme.Location = new System.Drawing.Point(451, 86);
            this.txt_korIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_korIme.Name = "txt_korIme";
            this.txt_korIme.Size = new System.Drawing.Size(210, 26);
            this.txt_korIme.TabIndex = 1;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_lozinka.Location = new System.Drawing.Point(451, 133);
            this.txt_lozinka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.PasswordChar = '*';
            this.txt_lozinka.Size = new System.Drawing.Size(210, 26);
            this.txt_lozinka.TabIndex = 2;
            this.txt_lozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tip računa:";
            // 
            // form_Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.cmb_uloga);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.dgv_korisnik);
            this.Controls.Add(this.txt_lozinka);
            this.Controls.Add(this.txt_korIme);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_prezime_korisnik);
            this.Controls.Add(this.lbl_ime_korisnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_id_korisnik);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Korisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.form_Korisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_korisnik)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_korisnik;
        private System.Windows.Forms.Label lbl_ime_korisnik;
        private System.Windows.Forms.Label lbl_prezime_korisnik;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.DataGridView dgv_korisnik;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_uredi;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_uloga;
        private System.Windows.Forms.TextBox txt_korIme;
        private System.Windows.Forms.TextBox txt_lozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}