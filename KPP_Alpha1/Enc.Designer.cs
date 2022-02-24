namespace KPP_Alpha1
{
    partial class FormEnc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Txt_Naziv = new System.Windows.Forms.TextBox();
            this.Lbl_Naziv = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.InsertTSMI,
            this.UpdateTSMI,
            this.ClearTSMI});
            this.datotekaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // InsertTSMI
            // 
            this.InsertTSMI.Name = "InsertTSMI";
            this.InsertTSMI.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.InsertTSMI.Size = new System.Drawing.Size(185, 22);
            this.InsertTSMI.Text = "Spremi novi unos";
            this.InsertTSMI.Click += new System.EventHandler(this.InsertTSMI_Click);
            // 
            // UpdateTSMI
            // 
            this.UpdateTSMI.Name = "UpdateTSMI";
            this.UpdateTSMI.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.UpdateTSMI.Size = new System.Drawing.Size(185, 22);
            this.UpdateTSMI.Text = "Spremi izmjene";
            this.UpdateTSMI.Click += new System.EventHandler(this.UpdateTSMI_Click);
            // 
            // ClearTSMI
            // 
            this.ClearTSMI.Name = "ClearTSMI";
            this.ClearTSMI.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ClearTSMI.Size = new System.Drawing.Size(185, 22);
            this.ClearTSMI.Text = "Clear";
            this.ClearTSMI.Click += new System.EventHandler(this.ClearTSMI_Click);
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(12, 185);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(85, 17);
            this.lbl_pretrazivanje.TabIndex = 53;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Search.Location = new System.Drawing.Point(103, 181);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(667, 25);
            this.Txt_Search.TabIndex = 47;
            this.Txt_Search.TabStop = false;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Edit.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Edit.FlatAppearance.BorderSize = 0;
            this.Btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Edit.Location = new System.Drawing.Point(680, 110);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 65);
            this.Btn_Edit.TabIndex = 52;
            this.Btn_Edit.TabStop = false;
            this.Btn_Edit.Text = "Spremi izmjene (F3)";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Insert.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Insert.Location = new System.Drawing.Point(680, 39);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 48;
            this.Btn_Insert.Text = "Spremi novi (F4)";
            this.Btn_Insert.UseVisualStyleBackColor = false;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Dgv
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.Dgv.Size = new System.Drawing.Size(758, 334);
            this.Dgv.TabIndex = 51;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // Txt_Naziv
            // 
            this.Txt_Naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Naziv.Location = new System.Drawing.Point(103, 39);
            this.Txt_Naziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Naziv.Name = "Txt_Naziv";
            this.Txt_Naziv.Size = new System.Drawing.Size(255, 25);
            this.Txt_Naziv.TabIndex = 45;
            // 
            // Lbl_Naziv
            // 
            this.Lbl_Naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Naziv.AutoSize = true;
            this.Lbl_Naziv.Location = new System.Drawing.Point(12, 43);
            this.Lbl_Naziv.Name = "Lbl_Naziv";
            this.Lbl_Naziv.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Naziv.TabIndex = 50;
            this.Lbl_Naziv.Text = "Broj uređaja:";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(12, 168);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(19, 17);
            this.Lbl_Id.TabIndex = 49;
            this.Lbl_Id.Text = "Id";
            this.Lbl_Id.Visible = false;
            // 
            // FormEnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Txt_Naziv);
            this.Controls.Add(this.Lbl_Naziv);
            this.Controls.Add(this.Lbl_Id);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEnc";
            this.Text = "ENC uređaji";
            this.Load += new System.EventHandler(this.FormEnc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertTSMI;
        private System.Windows.Forms.ToolStripMenuItem UpdateTSMI;
        private System.Windows.Forms.ToolStripMenuItem ClearTSMI;
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox Txt_Naziv;
        private System.Windows.Forms.Label Lbl_Naziv;
        private System.Windows.Forms.Label Lbl_Id;
    }
}