namespace KPP_Alpha1
{
    partial class FormOprema
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.CmbAktivno = new System.Windows.Forms.ComboBox();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Txt_InvBroj = new System.Windows.Forms.TextBox();
            this.Txt_SerBroj = new System.Windows.Forms.TextBox();
            this.Txt_Naziv = new System.Windows.Forms.TextBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_Naziv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Dtp_Kupljeno = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Vijek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            "Novo",
            "Za rashod",
            "Rashodovano"});
            this.CmbFilter.Location = new System.Drawing.Point(517, 131);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(133, 25);
            this.CmbFilter.TabIndex = 26;
            this.CmbFilter.TabStop = false;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // CmbAktivno
            // 
            this.CmbAktivno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbAktivno.BackColor = System.Drawing.Color.White;
            this.CmbAktivno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAktivno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbAktivno.FormattingEnabled = true;
            this.CmbAktivno.Items.AddRange(new object[] {
            "Novo",
            "Aktivno",
            "Za rashod",
            "Rashodovano"});
            this.CmbAktivno.Location = new System.Drawing.Point(517, 98);
            this.CmbAktivno.Name = "CmbAktivno";
            this.CmbAktivno.Size = new System.Drawing.Size(133, 25);
            this.CmbAktivno.TabIndex = 25;
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Search.AutoSize = true;
            this.Lbl_Search.Location = new System.Drawing.Point(12, 180);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(85, 17);
            this.Lbl_Search.TabIndex = 30;
            this.Lbl_Search.Text = "Pretraživanje:";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Search.Location = new System.Drawing.Point(118, 175);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(652, 25);
            this.Txt_Search.TabIndex = 29;
            this.Txt_Search.TabStop = false;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Edit.Location = new System.Drawing.Point(680, 102);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 65);
            this.Btn_Edit.TabIndex = 28;
            this.Btn_Edit.TabStop = false;
            this.Btn_Edit.Text = "Spremi izmjene (F3)";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Insert.Location = new System.Drawing.Point(680, 34);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 27;
            this.Btn_Insert.Text = "Spremi novi (F4)";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Dgv
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.Gray;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 207);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(758, 335);
            this.Dgv.TabIndex = 24;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // Txt_InvBroj
            // 
            this.Txt_InvBroj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_InvBroj.Location = new System.Drawing.Point(118, 136);
            this.Txt_InvBroj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_InvBroj.Name = "Txt_InvBroj";
            this.Txt_InvBroj.Size = new System.Drawing.Size(201, 25);
            this.Txt_InvBroj.TabIndex = 22;
            // 
            // Txt_SerBroj
            // 
            this.Txt_SerBroj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_SerBroj.Location = new System.Drawing.Point(118, 102);
            this.Txt_SerBroj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_SerBroj.Name = "Txt_SerBroj";
            this.Txt_SerBroj.Size = new System.Drawing.Size(201, 25);
            this.Txt_SerBroj.TabIndex = 21;
            // 
            // Txt_Naziv
            // 
            this.Txt_Naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Naziv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Naziv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Naziv.Location = new System.Drawing.Point(118, 68);
            this.Txt_Naziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Naziv.Name = "Txt_Naziv";
            this.Txt_Naziv.Size = new System.Drawing.Size(201, 25);
            this.Txt_Naziv.TabIndex = 20;
            // 
            // Txt_Id
            // 
            this.Txt_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Id.Location = new System.Drawing.Point(118, 34);
            this.Txt_Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.ReadOnly = true;
            this.Txt_Id.Size = new System.Drawing.Size(133, 25);
            this.Txt_Id.TabIndex = 17;
            this.Txt_Id.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Invert. br.:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ser. br.:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filter:";
            // 
            // Lbl_Naziv
            // 
            this.Lbl_Naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Naziv.AutoSize = true;
            this.Lbl_Naziv.Location = new System.Drawing.Point(12, 72);
            this.Lbl_Naziv.Name = "Lbl_Naziv";
            this.Lbl_Naziv.Size = new System.Drawing.Size(43, 17);
            this.Lbl_Naziv.TabIndex = 18;
            this.Lbl_Naziv.Text = "Naziv:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status:";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(12, 38);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(23, 17);
            this.Lbl_Id.TabIndex = 12;
            this.Lbl_Id.Text = "ID:";
            // 
            // Dtp_Kupljeno
            // 
            this.Dtp_Kupljeno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dtp_Kupljeno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Kupljeno.Location = new System.Drawing.Point(517, 34);
            this.Dtp_Kupljeno.Name = "Dtp_Kupljeno";
            this.Dtp_Kupljeno.Size = new System.Drawing.Size(133, 25);
            this.Dtp_Kupljeno.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kupljeno:";
            // 
            // Txt_Vijek
            // 
            this.Txt_Vijek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Vijek.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Vijek.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Vijek.Location = new System.Drawing.Point(517, 66);
            this.Txt_Vijek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Vijek.Name = "Txt_Vijek";
            this.Txt_Vijek.Size = new System.Drawing.Size(133, 25);
            this.Txt_Vijek.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Vijek trajanja:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 35;
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
            // FormOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Txt_Vijek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dtp_Kupljeno);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.CmbAktivno);
            this.Controls.Add(this.Lbl_Search);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Txt_InvBroj);
            this.Controls.Add(this.Txt_SerBroj);
            this.Controls.Add(this.Txt_Naziv);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_Naziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_Id);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOprema";
            this.Text = "Oprema";
            this.Load += new System.EventHandler(this.Oprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.ComboBox CmbAktivno;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox Txt_InvBroj;
        private System.Windows.Forms.TextBox Txt_SerBroj;
        private System.Windows.Forms.TextBox Txt_Naziv;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_Naziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.DateTimePicker Dtp_Kupljeno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Vijek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
    }
}