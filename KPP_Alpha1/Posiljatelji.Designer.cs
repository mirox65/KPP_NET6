namespace KPP_Alpha1
{
    partial class FormPosiljatelji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosiljatelji));
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.txt_mjesto = new System.Windows.Forms.TextBox();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.lbl_mjesto = new System.Windows.Forms.Label();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Mjesto_Id = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_Oib = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(12, 148);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(90, 19);
            this.lbl_pretrazivanje.TabIndex = 24;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(108, 143);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(566, 26);
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
            // Dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.Gray;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 176);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(758, 366);
            this.Dgv.TabIndex = 20;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_posiljatelji_RowHeaderMouseClick);
            // 
            // txt_mjesto
            // 
            this.txt_mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mjesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_mjesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_mjesto.Location = new System.Drawing.Point(108, 102);
            this.txt_mjesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mjesto.Name = "txt_mjesto";
            this.txt_mjesto.Size = new System.Drawing.Size(210, 26);
            this.txt_mjesto.TabIndex = 17;
            // 
            // txt_naziv
            // 
            this.txt_naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_naziv.Location = new System.Drawing.Point(108, 34);
            this.txt_naziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(210, 26);
            this.txt_naziv.TabIndex = 14;
            // 
            // lbl_mjesto
            // 
            this.lbl_mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mjesto.AutoSize = true;
            this.lbl_mjesto.Location = new System.Drawing.Point(12, 105);
            this.lbl_mjesto.Name = "lbl_mjesto";
            this.lbl_mjesto.Size = new System.Drawing.Size(54, 19);
            this.lbl_mjesto.TabIndex = 18;
            this.lbl_mjesto.Text = "Mjesto:";
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Location = new System.Drawing.Point(12, 37);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(45, 19);
            this.lbl_naziv.TabIndex = 16;
            this.lbl_naziv.Text = "Naziv:";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(12, 127);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(17, 19);
            this.Lbl_Id.TabIndex = 13;
            this.Lbl_Id.Text = "0";
            this.Lbl_Id.Visible = false;
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
            this.spremiIzmjeneToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.datotekaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            this.datotekaToolStripMenuItem.Visible = false;
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
            // Txt_Oib
            // 
            this.Txt_Oib.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Oib.Location = new System.Drawing.Point(108, 68);
            this.Txt_Oib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Oib.Name = "Txt_Oib";
            this.Txt_Oib.Size = new System.Drawing.Size(210, 26);
            this.Txt_Oib.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "OIB/MB:";
            // 
            // CmbStatus
            // 
            this.CmbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbStatus.BackColor = System.Drawing.Color.White;
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Aktivno",
            "Neaktivno"});
            this.CmbStatus.Location = new System.Drawing.Point(464, 33);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(133, 27);
            this.CmbStatus.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Status:";
            // 
            // CmbFilter
            // 
            this.CmbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbFilter.BackColor = System.Drawing.Color.White;
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "Aktivno",
            "Neaktivno"});
            this.CmbFilter.Location = new System.Drawing.Point(464, 110);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(133, 27);
            this.CmbFilter.TabIndex = 64;
            this.CmbFilter.TabStop = false;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Filter:";
            // 
            // FormPosiljatelji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Oib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_Mjesto_Id);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.txt_mjesto);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.lbl_mjesto);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.Lbl_Id);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPosiljatelji";
            this.Text = "Posiljatelji";
            this.Load += new System.EventHandler(this.form_Posiljatelji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
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
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox txt_mjesto;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.Label lbl_mjesto;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label lbl_Mjesto_Id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox Txt_Oib;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label5;
    }
}