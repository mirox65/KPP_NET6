namespace KPP_Alpha1
{
    partial class FormKeyCards
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
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Lbl_Naziv = new System.Windows.Forms.Label();
            this.Txt_Naziv = new System.Windows.Forms.TextBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Location = new System.Drawing.Point(452, 16);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 0;
            this.Btn_Insert.Text = "Spremi novi (F4)";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(452, 87);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 65);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "Spremi izmjene (F3)";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Lbl_Naziv
            // 
            this.Lbl_Naziv.AutoSize = true;
            this.Lbl_Naziv.Location = new System.Drawing.Point(296, 62);
            this.Lbl_Naziv.Name = "Lbl_Naziv";
            this.Lbl_Naziv.Size = new System.Drawing.Size(81, 19);
            this.Lbl_Naziv.TabIndex = 2;
            this.Lbl_Naziv.Text = "Broj Kartice:";
            // 
            // Txt_Naziv
            // 
            this.Txt_Naziv.Location = new System.Drawing.Point(249, 87);
            this.Txt_Naziv.Name = "Txt_Naziv";
            this.Txt_Naziv.Size = new System.Drawing.Size(178, 26);
            this.Txt_Naziv.TabIndex = 3;
            // 
            // Dgv
            // 
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 200);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(910, 479);
            this.Dgv.TabIndex = 4;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_ID.Location = new System.Drawing.Point(12, 178);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(21, 19);
            this.Lbl_ID.TabIndex = 35;
            this.Lbl_ID.Text = "Id";
            this.Lbl_ID.Visible = false;
            // 
            // FormKeyCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(934, 691);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Txt_Naziv);
            this.Controls.Add(this.Lbl_Naziv);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Insert);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKeyCards";
            this.Text = "KeyCards";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Label Lbl_Naziv;
        private System.Windows.Forms.TextBox Txt_Naziv;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Label Lbl_ID;
    }
}