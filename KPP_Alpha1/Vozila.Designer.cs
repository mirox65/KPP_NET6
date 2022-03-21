namespace KPP_Alpha1
{
    partial class FormVozila
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
            this.Lbl_Proizvodac = new System.Windows.Forms.Label();
            this.Lbl_Model = new System.Windows.Forms.Label();
            this.Lbl_Opis = new System.Windows.Forms.Label();
            this.Lbl_BrSasije = new System.Windows.Forms.Label();
            this.Lbl_RegOznaka = new System.Windows.Forms.Label();
            this.Lbl_BrUgovora = new System.Windows.Forms.Label();
            this.Txt_Proizvodac = new System.Windows.Forms.TextBox();
            this.Txt_Model = new System.Windows.Forms.TextBox();
            this.Txt_Opis = new System.Windows.Forms.TextBox();
            this.Txt_BrUgovora = new System.Windows.Forms.TextBox();
            this.Txt_RegOznaka = new System.Windows.Forms.TextBox();
            this.Txt_BrSasije = new System.Windows.Forms.TextBox();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Napomena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Proizvodac
            // 
            this.Lbl_Proizvodac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Proizvodac.AutoSize = true;
            this.Lbl_Proizvodac.Location = new System.Drawing.Point(18, 17);
            this.Lbl_Proizvodac.Name = "Lbl_Proizvodac";
            this.Lbl_Proizvodac.Size = new System.Drawing.Size(75, 19);
            this.Lbl_Proizvodac.TabIndex = 1;
            this.Lbl_Proizvodac.Text = "Proizvođač";
            // 
            // Lbl_Model
            // 
            this.Lbl_Model.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Model.AutoSize = true;
            this.Lbl_Model.Location = new System.Drawing.Point(45, 49);
            this.Lbl_Model.Name = "Lbl_Model";
            this.Lbl_Model.Size = new System.Drawing.Size(48, 19);
            this.Lbl_Model.TabIndex = 2;
            this.Lbl_Model.Text = "Model";
            // 
            // Lbl_Opis
            // 
            this.Lbl_Opis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Opis.AutoSize = true;
            this.Lbl_Opis.Location = new System.Drawing.Point(56, 81);
            this.Lbl_Opis.Name = "Lbl_Opis";
            this.Lbl_Opis.Size = new System.Drawing.Size(37, 19);
            this.Lbl_Opis.TabIndex = 3;
            this.Lbl_Opis.Text = "Opis";
            // 
            // Lbl_BrSasije
            // 
            this.Lbl_BrSasije.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_BrSasije.AutoSize = true;
            this.Lbl_BrSasije.Location = new System.Drawing.Point(364, 17);
            this.Lbl_BrSasije.Name = "Lbl_BrSasije";
            this.Lbl_BrSasije.Size = new System.Drawing.Size(61, 19);
            this.Lbl_BrSasije.TabIndex = 4;
            this.Lbl_BrSasije.Text = "Br. šasije";
            // 
            // Lbl_RegOznaka
            // 
            this.Lbl_RegOznaka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_RegOznaka.AutoSize = true;
            this.Lbl_RegOznaka.Location = new System.Drawing.Point(343, 49);
            this.Lbl_RegOznaka.Name = "Lbl_RegOznaka";
            this.Lbl_RegOznaka.Size = new System.Drawing.Size(82, 19);
            this.Lbl_RegOznaka.TabIndex = 5;
            this.Lbl_RegOznaka.Text = "Reg. oznaka";
            // 
            // Lbl_BrUgovora
            // 
            this.Lbl_BrUgovora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_BrUgovora.AutoSize = true;
            this.Lbl_BrUgovora.Location = new System.Drawing.Point(345, 81);
            this.Lbl_BrUgovora.Name = "Lbl_BrUgovora";
            this.Lbl_BrUgovora.Size = new System.Drawing.Size(80, 19);
            this.Lbl_BrUgovora.TabIndex = 6;
            this.Lbl_BrUgovora.Text = "Br. ugovora";
            // 
            // Txt_Proizvodac
            // 
            this.Txt_Proizvodac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Proizvodac.Location = new System.Drawing.Point(99, 14);
            this.Txt_Proizvodac.Name = "Txt_Proizvodac";
            this.Txt_Proizvodac.Size = new System.Drawing.Size(214, 26);
            this.Txt_Proizvodac.TabIndex = 8;
            // 
            // Txt_Model
            // 
            this.Txt_Model.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Model.Location = new System.Drawing.Point(99, 46);
            this.Txt_Model.Name = "Txt_Model";
            this.Txt_Model.Size = new System.Drawing.Size(214, 26);
            this.Txt_Model.TabIndex = 9;
            // 
            // Txt_Opis
            // 
            this.Txt_Opis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Opis.Location = new System.Drawing.Point(99, 78);
            this.Txt_Opis.Name = "Txt_Opis";
            this.Txt_Opis.Size = new System.Drawing.Size(214, 26);
            this.Txt_Opis.TabIndex = 10;
            // 
            // Txt_BrUgovora
            // 
            this.Txt_BrUgovora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_BrUgovora.Location = new System.Drawing.Point(431, 78);
            this.Txt_BrUgovora.Name = "Txt_BrUgovora";
            this.Txt_BrUgovora.Size = new System.Drawing.Size(100, 26);
            this.Txt_BrUgovora.TabIndex = 13;
            // 
            // Txt_RegOznaka
            // 
            this.Txt_RegOznaka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_RegOznaka.Location = new System.Drawing.Point(431, 46);
            this.Txt_RegOznaka.Name = "Txt_RegOznaka";
            this.Txt_RegOznaka.Size = new System.Drawing.Size(100, 26);
            this.Txt_RegOznaka.TabIndex = 12;
            // 
            // Txt_BrSasije
            // 
            this.Txt_BrSasije.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_BrSasije.Location = new System.Drawing.Point(431, 14);
            this.Txt_BrSasije.Name = "Txt_BrSasije";
            this.Txt_BrSasije.Size = new System.Drawing.Size(170, 26);
            this.Txt_BrSasije.TabIndex = 11;
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Insert.Location = new System.Drawing.Point(680, 14);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 14;
            this.Btn_Insert.Text = "Spremi novi (F4)";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Edit.Location = new System.Drawing.Point(680, 85);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 65);
            this.Btn_Edit.TabIndex = 15;
            this.Btn_Edit.Text = "Spremi izmjene (F3)";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_ID.Location = new System.Drawing.Point(18, 156);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(21, 19);
            this.Lbl_ID.TabIndex = 34;
            this.Lbl_ID.Text = "Id";
            this.Lbl_ID.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 52;
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
            // Lbl_Search
            // 
            this.Lbl_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Search.AutoSize = true;
            this.Lbl_Search.Location = new System.Drawing.Point(14, 186);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Search.TabIndex = 51;
            this.Lbl_Search.Text = "Pretraživanje:";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Search.Location = new System.Drawing.Point(105, 181);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(665, 26);
            this.Txt_Search.TabIndex = 50;
            this.Txt_Search.TabStop = false;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
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
            this.Dgv.Location = new System.Drawing.Point(12, 214);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(758, 328);
            this.Dgv.TabIndex = 49;
            this.Dgv.TabStop = false;
            this.Dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentDoubleClick);
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
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
            this.CmbFilter.Location = new System.Drawing.Point(431, 148);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(133, 27);
            this.CmbFilter.TabIndex = 54;
            this.CmbFilter.TabStop = false;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Filter:";
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
            this.CmbStatus.Location = new System.Drawing.Point(99, 110);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(133, 27);
            this.CmbStatus.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Status:";
            // 
            // Txt_Napomena
            // 
            this.Txt_Napomena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Napomena.Location = new System.Drawing.Point(431, 111);
            this.Txt_Napomena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Napomena.Name = "Txt_Napomena";
            this.Txt_Napomena.Size = new System.Drawing.Size(243, 26);
            this.Txt_Napomena.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 57;
            this.label7.Text = "Napomena:";
            // 
            // FormVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.Txt_Napomena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lbl_Search);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Txt_BrUgovora);
            this.Controls.Add(this.Txt_RegOznaka);
            this.Controls.Add(this.Txt_BrSasije);
            this.Controls.Add(this.Txt_Opis);
            this.Controls.Add(this.Txt_Model);
            this.Controls.Add(this.Txt_Proizvodac);
            this.Controls.Add(this.Lbl_BrUgovora);
            this.Controls.Add(this.Lbl_RegOznaka);
            this.Controls.Add(this.Lbl_BrSasije);
            this.Controls.Add(this.Lbl_Opis);
            this.Controls.Add(this.Lbl_Model);
            this.Controls.Add(this.Lbl_Proizvodac);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVozila";
            this.Text = "Vozila";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Proizvodac;
        private System.Windows.Forms.Label Lbl_Model;
        private System.Windows.Forms.Label Lbl_Opis;
        private System.Windows.Forms.Label Lbl_BrSasije;
        private System.Windows.Forms.Label Lbl_RegOznaka;
        private System.Windows.Forms.Label Lbl_BrUgovora;
        private System.Windows.Forms.TextBox Txt_Proizvodac;
        private System.Windows.Forms.TextBox Txt_Model;
        private System.Windows.Forms.TextBox Txt_Opis;
        private System.Windows.Forms.TextBox Txt_BrUgovora;
        private System.Windows.Forms.TextBox Txt_RegOznaka;
        private System.Windows.Forms.TextBox Txt_BrSasije;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Napomena;
        private System.Windows.Forms.Label label7;
    }
}