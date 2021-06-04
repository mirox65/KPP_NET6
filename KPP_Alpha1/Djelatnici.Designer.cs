
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_prezime_korisnik = new System.Windows.Forms.Label();
            this.lbl_ime_korisnik = new System.Windows.Forms.Label();
            this.lbl_id_korisnik = new System.Windows.Forms.Label();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.lbl_PN = new System.Windows.Forms.Label();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.lbl_odjel = new System.Windows.Forms.Label();
            this.txtOdjelId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(14, 195);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(85, 17);
            this.lbl_pretrazivanje.TabIndex = 21;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(111, 190);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(661, 25);
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
            // txt_prezime
            // 
            this.txt_prezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_prezime.Location = new System.Drawing.Point(111, 111);
            this.txt_prezime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(210, 25);
            this.txt_prezime.TabIndex = 3;
            // 
            // txt_ime
            // 
            this.txt_ime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ime.Location = new System.Drawing.Point(111, 78);
            this.txt_ime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(210, 25);
            this.txt_ime.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(111, 12);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 25);
            this.txt_id.TabIndex = 14;
            this.txt_id.TabStop = false;
            // 
            // lbl_prezime_korisnik
            // 
            this.lbl_prezime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_prezime_korisnik.AutoSize = true;
            this.lbl_prezime_korisnik.Location = new System.Drawing.Point(14, 115);
            this.lbl_prezime_korisnik.Name = "lbl_prezime_korisnik";
            this.lbl_prezime_korisnik.Size = new System.Drawing.Size(57, 17);
            this.lbl_prezime_korisnik.TabIndex = 17;
            this.lbl_prezime_korisnik.Text = "Prezime:";
            // 
            // lbl_ime_korisnik
            // 
            this.lbl_ime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ime_korisnik.AutoSize = true;
            this.lbl_ime_korisnik.Location = new System.Drawing.Point(14, 82);
            this.lbl_ime_korisnik.Name = "lbl_ime_korisnik";
            this.lbl_ime_korisnik.Size = new System.Drawing.Size(32, 17);
            this.lbl_ime_korisnik.TabIndex = 15;
            this.lbl_ime_korisnik.Text = "Ime:";
            // 
            // lbl_id_korisnik
            // 
            this.lbl_id_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id_korisnik.AutoSize = true;
            this.lbl_id_korisnik.Location = new System.Drawing.Point(14, 16);
            this.lbl_id_korisnik.Name = "lbl_id_korisnik";
            this.lbl_id_korisnik.Size = new System.Drawing.Size(23, 17);
            this.lbl_id_korisnik.TabIndex = 12;
            this.lbl_id_korisnik.Text = "ID:";
            // 
            // Dgv
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.Gray;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 222);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(760, 326);
            this.Dgv.TabIndex = 22;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // lbl_PN
            // 
            this.lbl_PN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_PN.AutoSize = true;
            this.lbl_PN.Location = new System.Drawing.Point(14, 49);
            this.lbl_PN.Name = "lbl_PN";
            this.lbl_PN.Size = new System.Drawing.Size(28, 17);
            this.lbl_PN.TabIndex = 15;
            this.lbl_PN.Text = "PN:";
            // 
            // txtPN
            // 
            this.txtPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPN.Location = new System.Drawing.Point(111, 45);
            this.txtPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(210, 25);
            this.txtPN.TabIndex = 1;
            // 
            // lbl_odjel
            // 
            this.lbl_odjel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_odjel.AutoSize = true;
            this.lbl_odjel.Location = new System.Drawing.Point(14, 148);
            this.lbl_odjel.Name = "lbl_odjel";
            this.lbl_odjel.Size = new System.Drawing.Size(42, 17);
            this.lbl_odjel.TabIndex = 17;
            this.lbl_odjel.Text = "Odjel:";
            // 
            // txtOdjelId
            // 
            this.txtOdjelId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOdjelId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOdjelId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOdjelId.Location = new System.Drawing.Point(111, 144);
            this.txtOdjelId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOdjelId.Name = "txtOdjelId";
            this.txtOdjelId.Size = new System.Drawing.Size(210, 25);
            this.txtOdjelId.TabIndex = 4;
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
            // FormDjelatnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtOdjelId);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_odjel);
            this.Controls.Add(this.lbl_PN);
            this.Controls.Add(this.lbl_prezime_korisnik);
            this.Controls.Add(this.lbl_ime_korisnik);
            this.Controls.Add(this.lbl_id_korisnik);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_prezime_korisnik;
        private System.Windows.Forms.Label lbl_ime_korisnik;
        private System.Windows.Forms.Label lbl_id_korisnik;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Label lbl_PN;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label lbl_odjel;
        private System.Windows.Forms.TextBox txtOdjelId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
    }
}