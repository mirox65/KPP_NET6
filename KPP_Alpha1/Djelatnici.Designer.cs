
namespace KPP_Alpha1
{
    partial class FormDjelatnici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.Txt_Prezime = new System.Windows.Forms.TextBox();
            this.Txt_Ime = new System.Windows.Forms.TextBox();
            this.lbl_prezime_korisnik = new System.Windows.Forms.Label();
            this.lbl_ime_korisnik = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.lbl_PN = new System.Windows.Forms.Label();
            this.Txt_Pn = new System.Windows.Forms.TextBox();
            this.lbl_odjel = new System.Windows.Forms.Label();
            this.Txt_OdjelId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComBoxFilter = new System.Windows.Forms.ComboBox();
            this.ComBoxStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Oib = new System.Windows.Forms.TextBox();
            this.Lbl_Oib = new System.Windows.Forms.Label();
            this.Dtp_Otkaz = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_Zaposlen = new System.Windows.Forms.DateTimePicker();
            this.CheckBoxOtkaz = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(14, 158);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(85, 17);
            this.lbl_pretrazivanje.TabIndex = 21;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(105, 153);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(667, 25);
            this.txt_pretrazivanje.TabIndex = 20;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretrazivanje_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Location = new System.Drawing.Point(682, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 65);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Spremi izmjene (F3)";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.Btn_uredi_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsert.Location = new System.Drawing.Point(682, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 65);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Spremi novi (F4)";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.Btn_dodaj_Click);
            // 
            // Txt_Prezime
            // 
            this.Txt_Prezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Prezime.Location = new System.Drawing.Point(77, 79);
            this.Txt_Prezime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Prezime.Name = "Txt_Prezime";
            this.Txt_Prezime.Size = new System.Drawing.Size(210, 25);
            this.Txt_Prezime.TabIndex = 3;
            // 
            // Txt_Ime
            // 
            this.Txt_Ime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Ime.Location = new System.Drawing.Point(77, 46);
            this.Txt_Ime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Ime.Name = "Txt_Ime";
            this.Txt_Ime.Size = new System.Drawing.Size(210, 25);
            this.Txt_Ime.TabIndex = 2;
            // 
            // lbl_prezime_korisnik
            // 
            this.lbl_prezime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_prezime_korisnik.AutoSize = true;
            this.lbl_prezime_korisnik.Location = new System.Drawing.Point(14, 83);
            this.lbl_prezime_korisnik.Name = "lbl_prezime_korisnik";
            this.lbl_prezime_korisnik.Size = new System.Drawing.Size(57, 17);
            this.lbl_prezime_korisnik.TabIndex = 17;
            this.lbl_prezime_korisnik.Text = "Prezime:";
            // 
            // lbl_ime_korisnik
            // 
            this.lbl_ime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ime_korisnik.AutoSize = true;
            this.lbl_ime_korisnik.Location = new System.Drawing.Point(14, 50);
            this.lbl_ime_korisnik.Name = "lbl_ime_korisnik";
            this.lbl_ime_korisnik.Size = new System.Drawing.Size(32, 17);
            this.lbl_ime_korisnik.TabIndex = 15;
            this.lbl_ime_korisnik.Text = "Ime:";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(9, 132);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(19, 17);
            this.Lbl_Id.TabIndex = 12;
            this.Lbl_Id.Text = "Id";
            this.Lbl_Id.Visible = false;
            // 
            // Dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.Gray;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 185);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(760, 363);
            this.Dgv.TabIndex = 22;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // lbl_PN
            // 
            this.lbl_PN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_PN.AutoSize = true;
            this.lbl_PN.Location = new System.Drawing.Point(14, 17);
            this.lbl_PN.Name = "lbl_PN";
            this.lbl_PN.Size = new System.Drawing.Size(28, 17);
            this.lbl_PN.TabIndex = 15;
            this.lbl_PN.Text = "PN:";
            // 
            // Txt_Pn
            // 
            this.Txt_Pn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Pn.Location = new System.Drawing.Point(77, 13);
            this.Txt_Pn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Pn.Name = "Txt_Pn";
            this.Txt_Pn.Size = new System.Drawing.Size(210, 25);
            this.Txt_Pn.TabIndex = 1;
            // 
            // lbl_odjel
            // 
            this.lbl_odjel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_odjel.AutoSize = true;
            this.lbl_odjel.Location = new System.Drawing.Point(295, 17);
            this.lbl_odjel.Name = "lbl_odjel";
            this.lbl_odjel.Size = new System.Drawing.Size(42, 17);
            this.lbl_odjel.TabIndex = 17;
            this.lbl_odjel.Text = "Odjel:";
            // 
            // Txt_OdjelId
            // 
            this.Txt_OdjelId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_OdjelId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_OdjelId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_OdjelId.Location = new System.Drawing.Point(365, 13);
            this.Txt_OdjelId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_OdjelId.Name = "Txt_OdjelId";
            this.Txt_OdjelId.Size = new System.Drawing.Size(133, 25);
            this.Txt_OdjelId.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviUnosToolStripMenuItem,
            this.spremiIzmjeneToolStripMenuItem,
            this.ClearToolStripMenuItem});
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
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // ComBoxFilter
            // 
            this.ComBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComBoxFilter.BackColor = System.Drawing.Color.White;
            this.ComBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBoxFilter.FormattingEnabled = true;
            this.ComBoxFilter.Items.AddRange(new object[] {
            "Aktivno",
            "Neaktivno"});
            this.ComBoxFilter.Location = new System.Drawing.Point(549, 111);
            this.ComBoxFilter.Name = "ComBoxFilter";
            this.ComBoxFilter.Size = new System.Drawing.Size(127, 25);
            this.ComBoxFilter.TabIndex = 34;
            this.ComBoxFilter.TabStop = false;
            this.ComBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComBoxFilter_SelectedIndexChanged);
            // 
            // ComBoxStatus
            // 
            this.ComBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComBoxStatus.BackColor = System.Drawing.Color.White;
            this.ComBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBoxStatus.FormattingEnabled = true;
            this.ComBoxStatus.Items.AddRange(new object[] {
            "Aktivno",
            "Neaktivno"});
            this.ComBoxStatus.Location = new System.Drawing.Point(365, 111);
            this.ComBoxStatus.Name = "ComBoxStatus";
            this.ComBoxStatus.Size = new System.Drawing.Size(133, 25);
            this.ComBoxStatus.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Filter:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Status:";
            // 
            // Txt_Oib
            // 
            this.Txt_Oib.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Oib.Location = new System.Drawing.Point(77, 111);
            this.Txt_Oib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Oib.Name = "Txt_Oib";
            this.Txt_Oib.Size = new System.Drawing.Size(210, 25);
            this.Txt_Oib.TabIndex = 36;
            // 
            // Lbl_Oib
            // 
            this.Lbl_Oib.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Oib.AutoSize = true;
            this.Lbl_Oib.Location = new System.Drawing.Point(14, 115);
            this.Lbl_Oib.Name = "Lbl_Oib";
            this.Lbl_Oib.Size = new System.Drawing.Size(32, 17);
            this.Lbl_Oib.TabIndex = 37;
            this.Lbl_Oib.Text = "Oib:";
            // 
            // Dtp_Otkaz
            // 
            this.Dtp_Otkaz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dtp_Otkaz.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Otkaz.Location = new System.Drawing.Point(365, 79);
            this.Dtp_Otkaz.Name = "Dtp_Otkaz";
            this.Dtp_Otkaz.Size = new System.Drawing.Size(133, 25);
            this.Dtp_Otkaz.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Zaposlen:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Otkaz:";
            // 
            // Dtp_Zaposlen
            // 
            this.Dtp_Zaposlen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dtp_Zaposlen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Zaposlen.Location = new System.Drawing.Point(365, 46);
            this.Dtp_Zaposlen.Name = "Dtp_Zaposlen";
            this.Dtp_Zaposlen.Size = new System.Drawing.Size(133, 25);
            this.Dtp_Zaposlen.TabIndex = 41;
            // 
            // CheckBoxOtkaz
            // 
            this.CheckBoxOtkaz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckBoxOtkaz.AutoSize = true;
            this.CheckBoxOtkaz.Location = new System.Drawing.Point(344, 85);
            this.CheckBoxOtkaz.Name = "CheckBoxOtkaz";
            this.CheckBoxOtkaz.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxOtkaz.TabIndex = 42;
            this.CheckBoxOtkaz.UseVisualStyleBackColor = true;
            // 
            // FormDjelatnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CheckBoxOtkaz);
            this.Controls.Add(this.Dtp_Zaposlen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Otkaz);
            this.Controls.Add(this.Txt_Oib);
            this.Controls.Add(this.Lbl_Oib);
            this.Controls.Add(this.ComBoxFilter);
            this.Controls.Add(this.ComBoxStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Txt_OdjelId);
            this.Controls.Add(this.Txt_Prezime);
            this.Controls.Add(this.Txt_Pn);
            this.Controls.Add(this.Txt_Ime);
            this.Controls.Add(this.lbl_odjel);
            this.Controls.Add(this.lbl_PN);
            this.Controls.Add(this.lbl_prezime_korisnik);
            this.Controls.Add(this.lbl_ime_korisnik);
            this.Controls.Add(this.Lbl_Id);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDjelatnici";
            this.Text = "Djelatnici";
            this.Load += new System.EventHandler(this.Djelatnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox Txt_Prezime;
        private System.Windows.Forms.TextBox Txt_Ime;
        private System.Windows.Forms.Label lbl_prezime_korisnik;
        private System.Windows.Forms.Label lbl_ime_korisnik;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Label lbl_PN;
        private System.Windows.Forms.TextBox Txt_Pn;
        private System.Windows.Forms.Label lbl_odjel;
        private System.Windows.Forms.TextBox Txt_OdjelId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComBoxFilter;
        private System.Windows.Forms.ComboBox ComBoxStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Oib;
        private System.Windows.Forms.Label Lbl_Oib;
        private System.Windows.Forms.DateTimePicker Dtp_Otkaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_Zaposlen;
        private System.Windows.Forms.CheckBox CheckBoxOtkaz;
    }
}