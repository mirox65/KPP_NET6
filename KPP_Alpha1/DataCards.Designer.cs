namespace KPP_Alpha1
{
    partial class FormDataCards
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Txt_SerBr = new System.Windows.Forms.TextBox();
            this.Txt_Imei = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Imei = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Txt_Napomena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 45;
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
            // 
            // spremiIzmjeneToolStripMenuItem
            // 
            this.spremiIzmjeneToolStripMenuItem.Name = "spremiIzmjeneToolStripMenuItem";
            this.spremiIzmjeneToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.spremiIzmjeneToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.spremiIzmjeneToolStripMenuItem.Text = "Spremi izmjene";
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Search.AutoSize = true;
            this.Lbl_Search.Location = new System.Drawing.Point(12, 158);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(85, 17);
            this.Lbl_Search.TabIndex = 44;
            this.Lbl_Search.Text = "Pretraživanje:";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Search.Location = new System.Drawing.Point(103, 153);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(667, 25);
            this.Txt_Search.TabIndex = 43;
            this.Txt_Search.TabStop = false;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Edit.Location = new System.Drawing.Point(680, 82);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 65);
            this.Btn_Edit.TabIndex = 42;
            this.Btn_Edit.TabStop = false;
            this.Btn_Edit.Text = "Spremi izmjene (F3)";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Insert.Location = new System.Drawing.Point(680, 14);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 41;
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
            this.Dgv.Location = new System.Drawing.Point(12, 185);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(758, 363);
            this.Dgv.TabIndex = 40;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // Txt_SerBr
            // 
            this.Txt_SerBr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_SerBr.Location = new System.Drawing.Point(103, 48);
            this.Txt_SerBr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_SerBr.Name = "Txt_SerBr";
            this.Txt_SerBr.Size = new System.Drawing.Size(201, 25);
            this.Txt_SerBr.TabIndex = 39;
            // 
            // Txt_Imei
            // 
            this.Txt_Imei.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Imei.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Imei.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Imei.Location = new System.Drawing.Point(103, 14);
            this.Txt_Imei.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Imei.Name = "Txt_Imei";
            this.Txt_Imei.Size = new System.Drawing.Size(201, 25);
            this.Txt_Imei.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ser. br.:";
            // 
            // Lbl_Imei
            // 
            this.Lbl_Imei.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Imei.AutoSize = true;
            this.Lbl_Imei.Location = new System.Drawing.Point(12, 17);
            this.Lbl_Imei.Name = "Lbl_Imei";
            this.Lbl_Imei.Size = new System.Drawing.Size(35, 17);
            this.Lbl_Imei.TabIndex = 37;
            this.Lbl_Imei.Text = "Imei:";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Id.Location = new System.Drawing.Point(12, 130);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(19, 17);
            this.Lbl_Id.TabIndex = 46;
            this.Lbl_Id.Text = "Id";
            this.Lbl_Id.Visible = false;
            // 
            // Txt_Napomena
            // 
            this.Txt_Napomena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Napomena.Location = new System.Drawing.Point(103, 81);
            this.Txt_Napomena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Napomena.Name = "Txt_Napomena";
            this.Txt_Napomena.Size = new System.Drawing.Size(243, 25);
            this.Txt_Napomena.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Napomena:";
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
            this.CmbStatus.Location = new System.Drawing.Point(103, 113);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(133, 25);
            this.CmbStatus.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 61;
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
            this.CmbFilter.Location = new System.Drawing.Point(541, 114);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(133, 25);
            this.CmbFilter.TabIndex = 60;
            this.CmbFilter.TabStop = false;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Filter:";
            // 
            // FormDataCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.Txt_Napomena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lbl_Search);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Txt_SerBr);
            this.Controls.Add(this.Txt_Imei);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Imei);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDataCards";
            this.Text = "Podatkovne kartice";
            this.Load += new System.EventHandler(this.DataCards_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox Txt_SerBr;
        private System.Windows.Forms.TextBox Txt_Imei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Imei;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.TextBox Txt_Napomena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label5;
    }
}