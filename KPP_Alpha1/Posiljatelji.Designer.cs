namespace KPP_Alpha1
{
    partial class form_Posiljatelji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Posiljatelji));
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.dgv_posiljatelji = new System.Windows.Forms.DataGridView();
            this.txt_mjesto = new System.Windows.Forms.TextBox();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_mjesto = new System.Windows.Forms.Label();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.lbl_id_korisnik = new System.Windows.Forms.Label();
            this.lbl_Mjesto_Id = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posiljatelji)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(12, 180);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(90, 19);
            this.lbl_pretrazivanje.TabIndex = 24;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(148, 175);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(622, 26);
            this.txt_pretrazivanje.TabIndex = 23;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretrazivanje_TextChanged);
            // 
            // btn_uredi
            // 
            this.btn_uredi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_uredi.Location = new System.Drawing.Point(680, 104);
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.Size = new System.Drawing.Size(90, 65);
            this.btn_uredi.TabIndex = 21;
            this.btn_uredi.TabStop = false;
            this.btn_uredi.Text = "Spremi izmjene(F3)";
            this.btn_uredi.UseVisualStyleBackColor = true;
            this.btn_uredi.Click += new System.EventHandler(this.lbl_uredi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dodaj.Location = new System.Drawing.Point(680, 33);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(90, 65);
            this.btn_dodaj.TabIndex = 19;
            this.btn_dodaj.Text = "Spremi novi (F4)";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.lbl_dodaj_Click);
            // 
            // dgv_posiljatelji
            // 
            this.dgv_posiljatelji.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_posiljatelji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_posiljatelji.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_posiljatelji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_posiljatelji.Location = new System.Drawing.Point(12, 208);
            this.dgv_posiljatelji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_posiljatelji.Name = "dgv_posiljatelji";
            this.dgv_posiljatelji.RowTemplate.Height = 24;
            this.dgv_posiljatelji.Size = new System.Drawing.Size(758, 334);
            this.dgv_posiljatelji.TabIndex = 20;
            this.dgv_posiljatelji.TabStop = false;
            this.dgv_posiljatelji.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_posiljatelji_RowHeaderMouseClick);
            // 
            // txt_mjesto
            // 
            this.txt_mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mjesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_mjesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_mjesto.Location = new System.Drawing.Point(148, 128);
            this.txt_mjesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mjesto.Name = "txt_mjesto";
            this.txt_mjesto.Size = new System.Drawing.Size(210, 26);
            this.txt_mjesto.TabIndex = 17;
            // 
            // txt_naziv
            // 
            this.txt_naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_naziv.Location = new System.Drawing.Point(148, 81);
            this.txt_naziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(210, 26);
            this.txt_naziv.TabIndex = 14;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(148, 33);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 26);
            this.txt_id.TabIndex = 15;
            this.txt_id.TabStop = false;
            // 
            // lbl_mjesto
            // 
            this.lbl_mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mjesto.AutoSize = true;
            this.lbl_mjesto.Location = new System.Drawing.Point(12, 132);
            this.lbl_mjesto.Name = "lbl_mjesto";
            this.lbl_mjesto.Size = new System.Drawing.Size(54, 19);
            this.lbl_mjesto.TabIndex = 18;
            this.lbl_mjesto.Text = "Mjesto:";
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Location = new System.Drawing.Point(12, 85);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(45, 19);
            this.lbl_naziv.TabIndex = 16;
            this.lbl_naziv.Text = "Naziv:";
            // 
            // lbl_id_korisnik
            // 
            this.lbl_id_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id_korisnik.AutoSize = true;
            this.lbl_id_korisnik.Location = new System.Drawing.Point(12, 37);
            this.lbl_id_korisnik.Name = "lbl_id_korisnik";
            this.lbl_id_korisnik.Size = new System.Drawing.Size(26, 19);
            this.lbl_id_korisnik.TabIndex = 13;
            this.lbl_id_korisnik.Text = "ID:";
            // 
            // lbl_Mjesto_Id
            // 
            this.lbl_Mjesto_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Mjesto_Id.AutoSize = true;
            this.lbl_Mjesto_Id.Location = new System.Drawing.Point(381, 127);
            this.lbl_Mjesto_Id.Name = "lbl_Mjesto_Id";
            this.lbl_Mjesto_Id.Size = new System.Drawing.Size(0, 19);
            this.lbl_Mjesto_Id.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 44;
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
            // form_Posiljatelji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_Mjesto_Id);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.dgv_posiljatelji);
            this.Controls.Add(this.txt_mjesto);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_mjesto);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.lbl_id_korisnik);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Posiljatelji";
            this.Text = "Posiljatelji";
            this.Load += new System.EventHandler(this.form_Posiljatelji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posiljatelji)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Button btn_uredi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.DataGridView dgv_posiljatelji;
        private System.Windows.Forms.TextBox txt_mjesto;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_mjesto;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.Label lbl_id_korisnik;
        private System.Windows.Forms.Label lbl_Mjesto_Id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
    }
}