namespace KPP_Alpha1
{
    partial class form_KPP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_KPP));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Posiljatelj = new System.Windows.Forms.TextBox();
            this.txt_Pismeno = new System.Windows.Forms.TextBox();
            this.txt_Brojcano = new System.Windows.Forms.TextBox();
            this.txt_Odjel = new System.Windows.Forms.TextBox();
            this.date_datum = new System.Windows.Forms.DateTimePicker();
            this.date_primitka = new System.Windows.Forms.DateTimePicker();
            this.btn_search_posiljatelj = new System.Windows.Forms.Button();
            this.btn_search_odjel = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_kpp = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kpp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum slanja:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pismeno:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primljeno:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pošiljatelj:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Odjel:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Brojčano:";
            // 
            // txt_Posiljatelj
            // 
            this.txt_Posiljatelj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Posiljatelj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Posiljatelj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Posiljatelj.Location = new System.Drawing.Point(430, 23);
            this.txt_Posiljatelj.Name = "txt_Posiljatelj";
            this.txt_Posiljatelj.Size = new System.Drawing.Size(237, 26);
            this.txt_Posiljatelj.TabIndex = 1;
            // 
            // txt_Pismeno
            // 
            this.txt_Pismeno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Pismeno.Location = new System.Drawing.Point(430, 55);
            this.txt_Pismeno.Name = "txt_Pismeno";
            this.txt_Pismeno.Size = new System.Drawing.Size(237, 26);
            this.txt_Pismeno.TabIndex = 2;
            // 
            // txt_Brojcano
            // 
            this.txt_Brojcano.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Brojcano.Location = new System.Drawing.Point(430, 87);
            this.txt_Brojcano.Name = "txt_Brojcano";
            this.txt_Brojcano.Size = new System.Drawing.Size(237, 26);
            this.txt_Brojcano.TabIndex = 3;
            // 
            // txt_Odjel
            // 
            this.txt_Odjel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Odjel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Odjel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Odjel.Location = new System.Drawing.Point(430, 119);
            this.txt_Odjel.Name = "txt_Odjel";
            this.txt_Odjel.Size = new System.Drawing.Size(237, 26);
            this.txt_Odjel.TabIndex = 5;
            // 
            // date_datum
            // 
            this.date_datum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_datum.Location = new System.Drawing.Point(128, 119);
            this.date_datum.Name = "date_datum";
            this.date_datum.Size = new System.Drawing.Size(120, 26);
            this.date_datum.TabIndex = 4;
            // 
            // date_primitka
            // 
            this.date_primitka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_primitka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_primitka.Location = new System.Drawing.Point(128, 87);
            this.date_primitka.Name = "date_primitka";
            this.date_primitka.Size = new System.Drawing.Size(120, 26);
            this.date_primitka.TabIndex = 16;
            this.date_primitka.TabStop = false;
            // 
            // btn_search_posiljatelj
            // 
            this.btn_search_posiljatelj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search_posiljatelj.BackColor = System.Drawing.Color.Moccasin;
            this.btn_search_posiljatelj.Location = new System.Drawing.Point(673, 23);
            this.btn_search_posiljatelj.Name = "btn_search_posiljatelj";
            this.btn_search_posiljatelj.Size = new System.Drawing.Size(46, 26);
            this.btn_search_posiljatelj.TabIndex = 18;
            this.btn_search_posiljatelj.TabStop = false;
            this.btn_search_posiljatelj.Text = "+";
            this.btn_search_posiljatelj.UseVisualStyleBackColor = false;
            this.btn_search_posiljatelj.Click += new System.EventHandler(this.btn_search_posiljatelj_Click);
            // 
            // btn_search_odjel
            // 
            this.btn_search_odjel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search_odjel.BackColor = System.Drawing.Color.Moccasin;
            this.btn_search_odjel.Location = new System.Drawing.Point(673, 119);
            this.btn_search_odjel.Name = "btn_search_odjel";
            this.btn_search_odjel.Size = new System.Drawing.Size(46, 26);
            this.btn_search_odjel.TabIndex = 19;
            this.btn_search_odjel.TabStop = false;
            this.btn_search_odjel.Text = "+";
            this.btn_search_odjel.UseCompatibleTextRendering = true;
            this.btn_search_odjel.UseVisualStyleBackColor = false;
            this.btn_search_odjel.Click += new System.EventHandler(this.btn_search_odjel_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dodaj.Location = new System.Drawing.Point(781, 27);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(90, 65);
            this.btn_dodaj.TabIndex = 6;
            this.btn_dodaj.Text = "Spremi novi (F4)";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_uredi
            // 
            this.btn_uredi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_uredi.Location = new System.Drawing.Point(781, 97);
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.Size = new System.Drawing.Size(90, 65);
            this.btn_uredi.TabIndex = 21;
            this.btn_uredi.TabStop = false;
            this.btn_uredi.Text = "Spremi izmjene (F3)";
            this.btn_uredi.UseVisualStyleBackColor = true;
            this.btn_uredi.Click += new System.EventHandler(this.btn_uredi_Click);
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(128, 151);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(591, 26);
            this.txt_pretrazivanje.TabIndex = 24;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretraži_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Pretraživanje:";
            // 
            // dgv_kpp
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv_kpp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_kpp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_kpp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kpp.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_kpp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kpp.Location = new System.Drawing.Point(12, 185);
            this.dgv_kpp.Name = "dgv_kpp";
            this.dgv_kpp.RowTemplate.Height = 24;
            this.dgv_kpp.Size = new System.Drawing.Size(860, 424);
            this.dgv_kpp.TabIndex = 26;
            this.dgv_kpp.TabStop = false;
            this.dgv_kpp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_kpp_RowHeaderMouseClick);
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(128, 55);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(120, 26);
            this.txt_id.TabIndex = 28;
            this.txt_id.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(19, 59);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 19);
            this.lbl_id.TabIndex = 27;
            this.lbl_id.Text = "ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 29;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Knjiga primljenih pošiljki";
            // 
            // form_KPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.dgv_kpp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_search_odjel);
            this.Controls.Add(this.btn_search_posiljatelj);
            this.Controls.Add(this.date_primitka);
            this.Controls.Add(this.date_datum);
            this.Controls.Add(this.txt_Odjel);
            this.Controls.Add(this.txt_Brojcano);
            this.Controls.Add(this.txt_Pismeno);
            this.Controls.Add(this.txt_Posiljatelj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_KPP";
            this.Text = "KPP";
            this.Load += new System.EventHandler(this.form_KPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kpp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Posiljatelj;
        private System.Windows.Forms.TextBox txt_Pismeno;
        private System.Windows.Forms.TextBox txt_Brojcano;
        private System.Windows.Forms.TextBox txt_Odjel;
        private System.Windows.Forms.DateTimePicker date_datum;
        private System.Windows.Forms.DateTimePicker date_primitka;
        private System.Windows.Forms.Button btn_search_posiljatelj;
        private System.Windows.Forms.Button btn_search_odjel;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_uredi;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_kpp;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}