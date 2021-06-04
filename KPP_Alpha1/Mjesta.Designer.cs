namespace KPP_Alpha1
{
    partial class FormMjesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMjesta));
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.btn_Uredi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.txt_Mjesto = new System.Windows.Forms.TextBox();
            this.txt_Ptt = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_mjesto = new System.Windows.Forms.Label();
            this.lbl_ptt = new System.Windows.Forms.Label();
            this.lbl_id_korisnik = new System.Windows.Forms.Label();
            this.txt_Zupanija = new System.Windows.Forms.TextBox();
            this.lbl_zupanija = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Mjesta = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Mjesta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(12, 180);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(90, 19);
            this.lbl_pretrazivanje.TabIndex = 37;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(148, 176);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(622, 26);
            this.txt_pretrazivanje.TabIndex = 36;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretrazivanje_TextChanged);
            // 
            // btn_Uredi
            // 
            this.btn_Uredi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Uredi.Location = new System.Drawing.Point(680, 105);
            this.btn_Uredi.Name = "btn_Uredi";
            this.btn_Uredi.Size = new System.Drawing.Size(90, 65);
            this.btn_Uredi.TabIndex = 34;
            this.btn_Uredi.TabStop = false;
            this.btn_Uredi.Text = "Spremi izmjene (F3)";
            this.btn_Uredi.UseVisualStyleBackColor = true;
            this.btn_Uredi.Click += new System.EventHandler(this.btn_Uredi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dodaj.Location = new System.Drawing.Point(680, 34);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(90, 65);
            this.btn_dodaj.TabIndex = 4;
            this.btn_dodaj.Text = "Spremi novi (F4)";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // txt_Mjesto
            // 
            this.txt_Mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Mjesto.Location = new System.Drawing.Point(148, 106);
            this.txt_Mjesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Mjesto.Name = "txt_Mjesto";
            this.txt_Mjesto.Size = new System.Drawing.Size(210, 26);
            this.txt_Mjesto.TabIndex = 2;
            // 
            // txt_Ptt
            // 
            this.txt_Ptt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Ptt.Location = new System.Drawing.Point(148, 68);
            this.txt_Ptt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ptt.Name = "txt_Ptt";
            this.txt_Ptt.Size = new System.Drawing.Size(210, 26);
            this.txt_Ptt.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(148, 34);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 26);
            this.txt_id.TabIndex = 28;
            this.txt_id.TabStop = false;
            // 
            // lbl_mjesto
            // 
            this.lbl_mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mjesto.AutoSize = true;
            this.lbl_mjesto.Location = new System.Drawing.Point(12, 110);
            this.lbl_mjesto.Name = "lbl_mjesto";
            this.lbl_mjesto.Size = new System.Drawing.Size(54, 19);
            this.lbl_mjesto.TabIndex = 31;
            this.lbl_mjesto.Text = "Mjesto:";
            // 
            // lbl_ptt
            // 
            this.lbl_ptt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ptt.AutoSize = true;
            this.lbl_ptt.Location = new System.Drawing.Point(12, 74);
            this.lbl_ptt.Name = "lbl_ptt";
            this.lbl_ptt.Size = new System.Drawing.Size(34, 19);
            this.lbl_ptt.TabIndex = 29;
            this.lbl_ptt.Text = "PTT:";
            // 
            // lbl_id_korisnik
            // 
            this.lbl_id_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id_korisnik.AutoSize = true;
            this.lbl_id_korisnik.Location = new System.Drawing.Point(12, 38);
            this.lbl_id_korisnik.Name = "lbl_id_korisnik";
            this.lbl_id_korisnik.Size = new System.Drawing.Size(26, 19);
            this.lbl_id_korisnik.TabIndex = 26;
            this.lbl_id_korisnik.Text = "ID:";
            // 
            // txt_Zupanija
            // 
            this.txt_Zupanija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Zupanija.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Zupanija.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Zupanija.Location = new System.Drawing.Point(148, 142);
            this.txt_Zupanija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Zupanija.Name = "txt_Zupanija";
            this.txt_Zupanija.Size = new System.Drawing.Size(210, 26);
            this.txt_Zupanija.TabIndex = 3;
            // 
            // lbl_zupanija
            // 
            this.lbl_zupanija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_zupanija.AutoSize = true;
            this.lbl_zupanija.Location = new System.Drawing.Point(12, 146);
            this.lbl_zupanija.Name = "lbl_zupanija";
            this.lbl_zupanija.Size = new System.Drawing.Size(64, 19);
            this.lbl_zupanija.TabIndex = 40;
            this.lbl_zupanija.Text = "Županija:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 43;
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
            // DGV_Mjesta
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGV_Mjesta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Mjesta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Mjesta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Mjesta.BackgroundColor = System.Drawing.Color.Gray;
            this.DGV_Mjesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Mjesta.Location = new System.Drawing.Point(12, 208);
            this.DGV_Mjesta.Name = "DGV_Mjesta";
            this.DGV_Mjesta.Size = new System.Drawing.Size(758, 335);
            this.DGV_Mjesta.TabIndex = 44;
            this.DGV_Mjesta.TabStop = false;
            this.DGV_Mjesta.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Mjesta_RowHeaderMouseDoubleClick);
            // 
            // FormMjesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.DGV_Mjesta);
            this.Controls.Add(this.txt_Zupanija);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_zupanija);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btn_Uredi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.txt_Mjesto);
            this.Controls.Add(this.txt_Ptt);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_mjesto);
            this.Controls.Add(this.lbl_ptt);
            this.Controls.Add(this.lbl_id_korisnik);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMjesta";
            this.Text = "Mjesta";
            this.Load += new System.EventHandler(this.Form_Mjesta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Mjesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Button btn_Uredi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.TextBox txt_Mjesto;
        private System.Windows.Forms.TextBox txt_Ptt;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_mjesto;
        private System.Windows.Forms.Label lbl_ptt;
        private System.Windows.Forms.Label lbl_id_korisnik;
        private System.Windows.Forms.TextBox txt_Zupanija;
        private System.Windows.Forms.Label lbl_zupanija;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV_Mjesta;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}