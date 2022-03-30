namespace KPP_Alpha1
{
    partial class UsersData
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
            this.Lbl_Filter = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiIzmjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_Mjesto_Id = new System.Windows.Forms.Label();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_Djelatnik = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_Djelatnik = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.Lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Filter
            // 
            this.Lbl_Filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Filter.AutoSize = true;
            this.Lbl_Filter.Location = new System.Drawing.Point(405, 123);
            this.Lbl_Filter.Name = "Lbl_Filter";
            this.Lbl_Filter.Size = new System.Drawing.Size(42, 19);
            this.Lbl_Filter.TabIndex = 81;
            this.Lbl_Filter.Text = "Filter:";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Username.Location = new System.Drawing.Point(109, 77);
            this.Txt_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(210, 26);
            this.Txt_Username.TabIndex = 2;
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Location = new System.Drawing.Point(13, 80);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(74, 19);
            this.Lbl_Username.TabIndex = 80;
            this.Lbl_Username.Text = "Username:";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // spremiIzmjeneToolStripMenuItem
            // 
            this.spremiIzmjeneToolStripMenuItem.Name = "spremiIzmjeneToolStripMenuItem";
            this.spremiIzmjeneToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.spremiIzmjeneToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.spremiIzmjeneToolStripMenuItem.Text = "Spremi izmjene";
            // 
            // dodajNoviUnosToolStripMenuItem
            // 
            this.dodajNoviUnosToolStripMenuItem.Name = "dodajNoviUnosToolStripMenuItem";
            this.dodajNoviUnosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.dodajNoviUnosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dodajNoviUnosToolStripMenuItem.Text = "Spremi novi unos";
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
            this.CmbFilter.Location = new System.Drawing.Point(465, 119);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(133, 27);
            this.CmbFilter.TabIndex = 82;
            this.CmbFilter.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 78;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // lbl_Mjesto_Id
            // 
            this.lbl_Mjesto_Id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Mjesto_Id.AutoSize = true;
            this.lbl_Mjesto_Id.Location = new System.Drawing.Point(382, 136);
            this.lbl_Mjesto_Id.Name = "lbl_Mjesto_Id";
            this.lbl_Mjesto_Id.Size = new System.Drawing.Size(0, 19);
            this.lbl_Mjesto_Id.TabIndex = 77;
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Search.AutoSize = true;
            this.Lbl_Search.Location = new System.Drawing.Point(13, 157);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Search.TabIndex = 76;
            this.Lbl_Search.Text = "Pretraživanje:";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Search.Location = new System.Drawing.Point(109, 152);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(566, 26);
            this.Txt_Search.TabIndex = 75;
            this.Txt_Search.TabStop = false;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Edit.Location = new System.Drawing.Point(681, 113);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 65);
            this.Btn_Edit.TabIndex = 74;
            this.Btn_Edit.TabStop = false;
            this.Btn_Edit.Text = "Spremi izmjene(F3)";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Insert.Location = new System.Drawing.Point(681, 42);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(90, 65);
            this.Btn_Insert.TabIndex = 6;
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
            this.Dgv.Location = new System.Drawing.Point(13, 185);
            this.Dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(758, 366);
            this.Dgv.TabIndex = 73;
            this.Dgv.TabStop = false;
            this.Dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Password.Location = new System.Drawing.Point(109, 111);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(210, 26);
            this.Txt_Password.TabIndex = 3;
            // 
            // Txt_Djelatnik
            // 
            this.Txt_Djelatnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Djelatnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Djelatnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Djelatnik.Location = new System.Drawing.Point(109, 43);
            this.Txt_Djelatnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Djelatnik.Name = "Txt_Djelatnik";
            this.Txt_Djelatnik.Size = new System.Drawing.Size(210, 26);
            this.Txt_Djelatnik.TabIndex = 1;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(13, 114);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(70, 19);
            this.Lbl_Password.TabIndex = 71;
            this.Lbl_Password.Text = "Password:";
            // 
            // Lbl_Djelatnik
            // 
            this.Lbl_Djelatnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Djelatnik.AutoSize = true;
            this.Lbl_Djelatnik.Location = new System.Drawing.Point(13, 46);
            this.Lbl_Djelatnik.Name = "Lbl_Djelatnik";
            this.Lbl_Djelatnik.Size = new System.Drawing.Size(65, 19);
            this.Lbl_Djelatnik.TabIndex = 69;
            this.Lbl_Djelatnik.Text = "Djelatnik:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Email.Location = new System.Drawing.Point(465, 42);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(210, 26);
            this.Txt_Email.TabIndex = 4;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(353, 46);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(44, 19);
            this.Lbl_Email.TabIndex = 86;
            this.Lbl_Email.Text = "Email:";
            // 
            // Txt_PhoneNumber
            // 
            this.Txt_PhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_PhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_PhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_PhoneNumber.Location = new System.Drawing.Point(465, 76);
            this.Txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_PhoneNumber.Name = "Txt_PhoneNumber";
            this.Txt_PhoneNumber.Size = new System.Drawing.Size(210, 26);
            this.Txt_PhoneNumber.TabIndex = 5;
            // 
            // Lbl_PhoneNumber
            // 
            this.Lbl_PhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_PhoneNumber.AutoSize = true;
            this.Lbl_PhoneNumber.Location = new System.Drawing.Point(353, 79);
            this.Lbl_PhoneNumber.Name = "Lbl_PhoneNumber";
            this.Lbl_PhoneNumber.Size = new System.Drawing.Size(105, 19);
            this.Lbl_PhoneNumber.TabIndex = 84;
            this.Lbl_PhoneNumber.Text = "Phone Number:";
            // 
            // UsersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_PhoneNumber);
            this.Controls.Add(this.Lbl_PhoneNumber);
            this.Controls.Add(this.Lbl_Filter);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.Lbl_Username);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.lbl_Mjesto_Id);
            this.Controls.Add(this.Lbl_Search);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Djelatnik);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Djelatnik);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersData";
            this.Text = "UsersData";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Filter;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiIzmjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_Mjesto_Id;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_Djelatnik;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_Djelatnik;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_PhoneNumber;
        private System.Windows.Forms.Label Lbl_PhoneNumber;
    }
}