﻿namespace KPP_Alpha1
{
    partial class FormKorisnici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKorisnici));
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.lbl_prezime_korisnik = new System.Windows.Forms.Label();
            this.txt_djelatnik = new System.Windows.Forms.TextBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_uloga = new System.Windows.Forms.ComboBox();
            this.txt_korIme = new System.Windows.Forms.TextBox();
            this.txt_lozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComBoxAktivan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComBoxFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(12, 153);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(17, 19);
            this.Lbl_Id.TabIndex = 0;
            this.Lbl_Id.Text = "0";
            this.Lbl_Id.Visible = false;
            // 
            // lbl_prezime_korisnik
            // 
            this.lbl_prezime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_prezime_korisnik.AutoSize = true;
            this.lbl_prezime_korisnik.Location = new System.Drawing.Point(12, 51);
            this.lbl_prezime_korisnik.Name = "lbl_prezime_korisnik";
            this.lbl_prezime_korisnik.Size = new System.Drawing.Size(65, 19);
            this.lbl_prezime_korisnik.TabIndex = 2;
            this.lbl_prezime_korisnik.Text = "Djelatnik:";
            // 
            // txt_djelatnik
            // 
            this.txt_djelatnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_djelatnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_djelatnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_djelatnik.Location = new System.Drawing.Point(118, 47);
            this.txt_djelatnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_djelatnik.Name = "txt_djelatnik";
            this.txt_djelatnik.Size = new System.Drawing.Size(201, 26);
            this.txt_djelatnik.TabIndex = 2;
            // 
            // Dgv
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.Gray;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 213);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(758, 329);
            this.Dgv.TabIndex = 6;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_korisnik_RowHeaderMouseClick);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Insert.Location = new System.Drawing.Point(680, 39);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 7;
            this.Btn_Insert.Text = "Spremi novi (F4)";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Edit.Location = new System.Drawing.Point(680, 107);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 65);
            this.Btn_Edit.TabIndex = 8;
            this.Btn_Edit.TabStop = false;
            this.Btn_Edit.Text = "Spremi izmjene (F3)";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Lbl_uredi_Click);
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(118, 180);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(652, 26);
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
            this.spremiIzmjeneToolStripMenuItem,
            this.clearToolStripMenuItem});
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
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // cmb_uloga
            // 
            this.cmb_uloga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_uloga.BackColor = System.Drawing.Color.White;
            this.cmb_uloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_uloga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_uloga.FormattingEnabled = true;
            this.cmb_uloga.Items.AddRange(new object[] {
            "Korisnik",
            "Administrator"});
            this.cmb_uloga.Location = new System.Drawing.Point(515, 47);
            this.cmb_uloga.Name = "cmb_uloga";
            this.cmb_uloga.Size = new System.Drawing.Size(133, 27);
            this.cmb_uloga.TabIndex = 5;
            // 
            // txt_korIme
            // 
            this.txt_korIme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_korIme.Location = new System.Drawing.Point(118, 81);
            this.txt_korIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_korIme.Name = "txt_korIme";
            this.txt_korIme.Size = new System.Drawing.Size(201, 26);
            this.txt_korIme.TabIndex = 3;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_lozinka.Location = new System.Drawing.Point(118, 115);
            this.txt_lozinka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.PasswordChar = '*';
            this.txt_lozinka.Size = new System.Drawing.Size(201, 26);
            this.txt_lozinka.TabIndex = 4;
            this.txt_lozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tip računa:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Aktivan:";
            // 
            // ComBoxAktivan
            // 
            this.ComBoxAktivan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComBoxAktivan.BackColor = System.Drawing.Color.White;
            this.ComBoxAktivan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxAktivan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBoxAktivan.FormattingEnabled = true;
            this.ComBoxAktivan.Items.AddRange(new object[] {
            "DA",
            "NE"});
            this.ComBoxAktivan.Location = new System.Drawing.Point(515, 79);
            this.ComBoxAktivan.Name = "ComBoxAktivan";
            this.ComBoxAktivan.Size = new System.Drawing.Size(133, 27);
            this.ComBoxAktivan.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filter:";
            // 
            // ComBoxFilter
            // 
            this.ComBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComBoxFilter.BackColor = System.Drawing.Color.White;
            this.ComBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBoxFilter.FormattingEnabled = true;
            this.ComBoxFilter.Items.AddRange(new object[] {
            "Aktivni korisnici",
            "Neaktivni korisnici"});
            this.ComBoxFilter.Location = new System.Drawing.Point(515, 112);
            this.ComBoxFilter.Name = "ComBoxFilter";
            this.ComBoxFilter.Size = new System.Drawing.Size(133, 27);
            this.ComBoxFilter.TabIndex = 6;
            this.ComBoxFilter.TabStop = false;
            this.ComBoxFilter.SelectionChangeCommitted += new System.EventHandler(this.ComBoxFilter_SelectionChangeCommitted);
            // 
            // FormKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.ComBoxFilter);
            this.Controls.Add(this.ComBoxAktivan);
            this.Controls.Add(this.cmb_uloga);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.txt_lozinka);
            this.Controls.Add(this.txt_korIme);
            this.Controls.Add(this.txt_djelatnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_prezime_korisnik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Id);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormKorisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.form_Korisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label lbl_prezime_korisnik;
        private System.Windows.Forms.TextBox txt_djelatnik;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Edit;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComBoxAktivan;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComBoxFilter;
    }
}