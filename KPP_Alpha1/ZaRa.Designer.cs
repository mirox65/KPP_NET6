namespace KPP_Alpha1
{
    partial class FormZaRa
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
            this.label3 = new System.Windows.Forms.Label();
            this.Dtp_Zaduženo = new System.Windows.Forms.DateTimePicker();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.CmbZaRa = new System.Windows.Forms.ComboBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Txt_Oprema = new System.Windows.Forms.TextBox();
            this.Txt_Djelatnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_Naziv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_Razduženo = new System.Windows.Forms.DateTimePicker();
            this.Btn_Pretraži = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Dat. Zaduženja:";
            // 
            // Dtp_Zaduženo
            // 
            this.Dtp_Zaduženo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dtp_Zaduženo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Zaduženo.Location = new System.Drawing.Point(523, 27);
            this.Dtp_Zaduženo.Name = "Dtp_Zaduženo";
            this.Dtp_Zaduženo.Size = new System.Drawing.Size(133, 25);
            this.Dtp_Zaduženo.TabIndex = 48;
            // 
            // CmbFilter
            // 
            this.CmbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbFilter.BackColor = System.Drawing.Color.White;
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "Zaduženo",
            "Razduženo"});
            this.CmbFilter.Location = new System.Drawing.Point(523, 88);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(133, 25);
            this.CmbFilter.TabIndex = 43;
            this.CmbFilter.TabStop = false;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // CmbZaRa
            // 
            this.CmbZaRa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbZaRa.BackColor = System.Drawing.Color.White;
            this.CmbZaRa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbZaRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbZaRa.FormattingEnabled = true;
            this.CmbZaRa.Items.AddRange(new object[] {
            "Zaduživanje",
            "Razduživanje"});
            this.CmbZaRa.Location = new System.Drawing.Point(85, 59);
            this.CmbZaRa.Name = "CmbZaRa";
            this.CmbZaRa.Size = new System.Drawing.Size(133, 25);
            this.CmbZaRa.TabIndex = 42;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Edit.Location = new System.Drawing.Point(680, 95);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 65);
            this.Btn_Edit.TabIndex = 45;
            this.Btn_Edit.TabStop = false;
            this.Btn_Edit.Text = "Spremi izmjene (F3)";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Insert.Location = new System.Drawing.Point(680, 27);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 44;
            this.Btn_Insert.Text = "Spremi novi (F4)";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
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
            this.Dgv.Location = new System.Drawing.Point(12, 167);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersWidth = 62;
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(758, 375);
            this.Dgv.TabIndex = 41;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // Txt_Oprema
            // 
            this.Txt_Oprema.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Oprema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Oprema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Oprema.Location = new System.Drawing.Point(85, 91);
            this.Txt_Oprema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Oprema.Name = "Txt_Oprema";
            this.Txt_Oprema.Size = new System.Drawing.Size(297, 25);
            this.Txt_Oprema.TabIndex = 40;
            // 
            // Txt_Djelatnik
            // 
            this.Txt_Djelatnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Djelatnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Djelatnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Djelatnik.Location = new System.Drawing.Point(85, 27);
            this.Txt_Djelatnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Djelatnik.Name = "Txt_Djelatnik";
            this.Txt_Djelatnik.Size = new System.Drawing.Size(201, 25);
            this.Txt_Djelatnik.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Oprema:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Filter:";
            // 
            // Lbl_Naziv
            // 
            this.Lbl_Naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Naziv.AutoSize = true;
            this.Lbl_Naziv.Location = new System.Drawing.Point(14, 30);
            this.Lbl_Naziv.Name = "Lbl_Naziv";
            this.Lbl_Naziv.Size = new System.Drawing.Size(65, 19);
            this.Lbl_Naziv.TabIndex = 38;
            this.Lbl_Naziv.Text = "Djelatnik:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "ZaRa:";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Id.Location = new System.Drawing.Point(14, 141);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(21, 19);
            this.Lbl_Id.TabIndex = 33;
            this.Lbl_Id.Text = "Id";
            this.Lbl_Id.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Dat. Razduženja:";
            // 
            // Dtp_Razduženo
            // 
            this.Dtp_Razduženo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dtp_Razduženo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Razduženo.Location = new System.Drawing.Point(523, 58);
            this.Dtp_Razduženo.Name = "Dtp_Razduženo";
            this.Dtp_Razduženo.Size = new System.Drawing.Size(133, 25);
            this.Dtp_Razduženo.TabIndex = 50;
            // 
            // Btn_Pretraži
            // 
            this.Btn_Pretraži.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Pretraži.Location = new System.Drawing.Point(292, 27);
            this.Btn_Pretraži.Name = "Btn_Pretraži";
            this.Btn_Pretraži.Size = new System.Drawing.Size(90, 57);
            this.Btn_Pretraži.TabIndex = 53;
            this.Btn_Pretraži.Text = "Pretraži (F5)";
            this.Btn_Pretraži.UseVisualStyleBackColor = true;
            this.Btn_Pretraži.Click += new System.EventHandler(this.Btn_Pretraži_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.SearchToolStripMenuItem});
            this.datotekaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // InsertToolStripMenuItem
            // 
            this.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            this.InsertToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.InsertToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.InsertToolStripMenuItem.Text = "Spremi novi unos";
            this.InsertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.UpdateToolStripMenuItem.Text = "Spremi izmjene";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.SearchToolStripMenuItem.Text = "Pretraži";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // FormZaRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Btn_Pretraži);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dtp_Razduženo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dtp_Zaduženo);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.CmbZaRa);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Txt_Oprema);
            this.Controls.Add(this.Txt_Djelatnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_Naziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_Id);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormZaRa";
            this.Text = "ZaRa";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtp_Zaduženo;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.ComboBox CmbZaRa;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox Txt_Oprema;
        private System.Windows.Forms.TextBox Txt_Djelatnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_Naziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_Razduženo;
        private System.Windows.Forms.Button Btn_Pretraži;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
    }
}