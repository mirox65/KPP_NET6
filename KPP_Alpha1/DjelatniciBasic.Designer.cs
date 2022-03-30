namespace KPP_Alpha1
{
    partial class DjelatniciBasic
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Txt_Djelatnik = new System.Windows.Forms.TextBox();
            this.lbl_mjesto = new System.Windows.Forms.Label();
            this.Lbl_Djelatnik = new System.Windows.Forms.Label();
            this.Txt_Mjesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Position = new System.Windows.Forms.TextBox();
            this.Txt_Adresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_ChartNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_WorkRelationship = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_WorkRegion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Spol = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 80;
            this.label1.Text = "Rođendan:";
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(13, 220);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(85, 17);
            this.lbl_pretrazivanje.TabIndex = 76;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(105, 215);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(666, 25);
            this.txt_pretrazivanje.TabIndex = 75;
            this.txt_pretrazivanje.TabStop = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Update.Location = new System.Drawing.Point(681, 113);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(90, 65);
            this.Btn_Update.TabIndex = 74;
            this.Btn_Update.TabStop = false;
            this.Btn_Update.Text = "Spremi izmjene(F3)";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Insert.Location = new System.Drawing.Point(681, 42);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 10;
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
            this.Dgv.Location = new System.Drawing.Point(13, 247);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(758, 304);
            this.Dgv.TabIndex = 73;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // Txt_Djelatnik
            // 
            this.Txt_Djelatnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Djelatnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Djelatnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Djelatnik.Location = new System.Drawing.Point(105, 42);
            this.Txt_Djelatnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Djelatnik.Name = "Txt_Djelatnik";
            this.Txt_Djelatnik.Size = new System.Drawing.Size(210, 25);
            this.Txt_Djelatnik.TabIndex = 1;
            // 
            // lbl_mjesto
            // 
            this.lbl_mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mjesto.AutoSize = true;
            this.lbl_mjesto.Location = new System.Drawing.Point(388, 150);
            this.lbl_mjesto.Name = "lbl_mjesto";
            this.lbl_mjesto.Size = new System.Drawing.Size(37, 17);
            this.lbl_mjesto.TabIndex = 71;
            this.lbl_mjesto.Text = "Spol:";
            // 
            // Lbl_Djelatnik
            // 
            this.Lbl_Djelatnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Djelatnik.AutoSize = true;
            this.Lbl_Djelatnik.Location = new System.Drawing.Point(13, 45);
            this.Lbl_Djelatnik.Name = "Lbl_Djelatnik";
            this.Lbl_Djelatnik.Size = new System.Drawing.Size(60, 17);
            this.Lbl_Djelatnik.TabIndex = 69;
            this.Lbl_Djelatnik.Text = "Djelatnik:";
            // 
            // Txt_Mjesto
            // 
            this.Txt_Mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Mjesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Mjesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Mjesto.Location = new System.Drawing.Point(465, 76);
            this.Txt_Mjesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Mjesto.Name = "Txt_Mjesto";
            this.Txt_Mjesto.Size = new System.Drawing.Size(210, 25);
            this.Txt_Mjesto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Grad:";
            // 
            // Txt_Position
            // 
            this.Txt_Position.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Position.Location = new System.Drawing.Point(105, 75);
            this.Txt_Position.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Position.Name = "Txt_Position";
            this.Txt_Position.Size = new System.Drawing.Size(210, 25);
            this.Txt_Position.TabIndex = 2;
            // 
            // Txt_Adresa
            // 
            this.Txt_Adresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Adresa.Location = new System.Drawing.Point(465, 42);
            this.Txt_Adresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Adresa.Name = "Txt_Adresa";
            this.Txt_Adresa.Size = new System.Drawing.Size(210, 25);
            this.Txt_Adresa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Position:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Adresa:";
            // 
            // Txt_ChartNumber
            // 
            this.Txt_ChartNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_ChartNumber.Location = new System.Drawing.Point(105, 108);
            this.Txt_ChartNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_ChartNumber.Name = "Txt_ChartNumber";
            this.Txt_ChartNumber.Size = new System.Drawing.Size(210, 25);
            this.Txt_ChartNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Chart Num.:";
            // 
            // Txt_WorkRelationship
            // 
            this.Txt_WorkRelationship.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_WorkRelationship.Location = new System.Drawing.Point(105, 141);
            this.Txt_WorkRelationship.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_WorkRelationship.Name = "Txt_WorkRelationship";
            this.Txt_WorkRelationship.Size = new System.Drawing.Size(210, 25);
            this.Txt_WorkRelationship.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "Work Rela.:";
            // 
            // Txt_WorkRegion
            // 
            this.Txt_WorkRegion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_WorkRegion.Location = new System.Drawing.Point(105, 174);
            this.Txt_WorkRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_WorkRegion.Name = "Txt_WorkRegion";
            this.Txt_WorkRegion.Size = new System.Drawing.Size(210, 25);
            this.Txt_WorkRegion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 96;
            this.label6.Text = "Work Region:";
            // 
            // Dtp_DateOfBirth
            // 
            this.Dtp_DateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dtp_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DateOfBirth.Location = new System.Drawing.Point(465, 112);
            this.Dtp_DateOfBirth.Name = "Dtp_DateOfBirth";
            this.Dtp_DateOfBirth.Size = new System.Drawing.Size(104, 25);
            this.Dtp_DateOfBirth.TabIndex = 8;
            // 
            // Cmb_Spol
            // 
            this.Cmb_Spol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cmb_Spol.FormattingEnabled = true;
            this.Cmb_Spol.Items.AddRange(new object[] {
            "F",
            "M"});
            this.Cmb_Spol.Location = new System.Drawing.Point(465, 143);
            this.Cmb_Spol.Name = "Cmb_Spol";
            this.Cmb_Spol.Size = new System.Drawing.Size(104, 25);
            this.Cmb_Spol.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 97;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.ClearToolStripMenuItem});
            this.datotekaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            this.datotekaToolStripMenuItem.Visible = false;
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
            // DjelatniciBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Cmb_Spol);
            this.Controls.Add(this.Dtp_DateOfBirth);
            this.Controls.Add(this.Txt_WorkRegion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_ChartNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_WorkRelationship);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Mjesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Position);
            this.Controls.Add(this.Txt_Adresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Txt_Djelatnik);
            this.Controls.Add(this.lbl_mjesto);
            this.Controls.Add(this.Lbl_Djelatnik);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DjelatniciBasic";
            this.Text = "DjelatniciBasic";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox Txt_Djelatnik;
        private System.Windows.Forms.Label lbl_mjesto;
        private System.Windows.Forms.Label Lbl_Djelatnik;
        private System.Windows.Forms.TextBox Txt_Mjesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Position;
        private System.Windows.Forms.TextBox Txt_Adresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_ChartNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_WorkRelationship;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_WorkRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Dtp_DateOfBirth;
        private System.Windows.Forms.ComboBox Cmb_Spol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
    }
}