namespace KPP_Alpha1
{
    partial class form_Odjeli
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
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.lbl_uredi = new System.Windows.Forms.Button();
            this.lbl_dodaj = new System.Windows.Forms.Button();
            this.dgv_odjel = new System.Windows.Forms.DataGridView();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_naziv_odjel = new System.Windows.Forms.Label();
            this.lbl_id_odjel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_odjel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(12, 179);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(112, 23);
            this.lbl_pretrazivanje.TabIndex = 24;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(148, 175);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(622, 30);
            this.txt_pretrazivanje.TabIndex = 2;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretrazivanje_TextChanged);
            // 
            // lbl_uredi
            // 
            this.lbl_uredi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_uredi.Location = new System.Drawing.Point(695, 69);
            this.lbl_uredi.Name = "lbl_uredi";
            this.lbl_uredi.Size = new System.Drawing.Size(75, 35);
            this.lbl_uredi.TabIndex = 21;
            this.lbl_uredi.TabStop = false;
            this.lbl_uredi.Text = "Uredi";
            this.lbl_uredi.UseVisualStyleBackColor = true;
            this.lbl_uredi.Click += new System.EventHandler(this.lbl_uredi_Click);
            // 
            // lbl_dodaj
            // 
            this.lbl_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dodaj.Location = new System.Drawing.Point(680, 17);
            this.lbl_dodaj.Name = "lbl_dodaj";
            this.lbl_dodaj.Size = new System.Drawing.Size(90, 35);
            this.lbl_dodaj.TabIndex = 2;
            this.lbl_dodaj.Text = "Dodaj";
            this.lbl_dodaj.UseVisualStyleBackColor = true;
            this.lbl_dodaj.Click += new System.EventHandler(this.lbl_dodaj_Click);
            // 
            // dgv_odjel
            // 
            this.dgv_odjel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_odjel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_odjel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_odjel.Location = new System.Drawing.Point(12, 238);
            this.dgv_odjel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_odjel.Name = "dgv_odjel";
            this.dgv_odjel.RowTemplate.Height = 24;
            this.dgv_odjel.Size = new System.Drawing.Size(758, 304);
            this.dgv_odjel.TabIndex = 19;
            this.dgv_odjel.TabStop = false;
            this.dgv_odjel.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_odjel_RowHeaderMouseClick);
            // 
            // txt_naziv
            // 
            this.txt_naziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_naziv.Location = new System.Drawing.Point(148, 97);
            this.txt_naziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(210, 30);
            this.txt_naziv.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(148, 19);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 30);
            this.txt_id.TabIndex = 1;
            this.txt_id.TabStop = false;
            // 
            // lbl_naziv_odjel
            // 
            this.lbl_naziv_odjel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_naziv_odjel.AutoSize = true;
            this.lbl_naziv_odjel.Location = new System.Drawing.Point(12, 101);
            this.lbl_naziv_odjel.Name = "lbl_naziv_odjel";
            this.lbl_naziv_odjel.Size = new System.Drawing.Size(107, 23);
            this.lbl_naziv_odjel.TabIndex = 15;
            this.lbl_naziv_odjel.Text = "Naziv odjela:";
            // 
            // lbl_id_odjel
            // 
            this.lbl_id_odjel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id_odjel.AutoSize = true;
            this.lbl_id_odjel.Location = new System.Drawing.Point(12, 23);
            this.lbl_id_odjel.Name = "lbl_id_odjel";
            this.lbl_id_odjel.Size = new System.Drawing.Size(31, 23);
            this.lbl_id_odjel.TabIndex = 13;
            this.lbl_id_odjel.Text = "ID:";
            // 
            // form_Odjeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.lbl_uredi);
            this.Controls.Add(this.lbl_dodaj);
            this.Controls.Add(this.dgv_odjel);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_naziv_odjel);
            this.Controls.Add(this.lbl_id_odjel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Odjeli";
            this.Text = "Odjeli";
            this.Load += new System.EventHandler(this.form_Odjeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_odjel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Button lbl_uredi;
        private System.Windows.Forms.Button lbl_dodaj;
        private System.Windows.Forms.DataGridView dgv_odjel;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_naziv_odjel;
        private System.Windows.Forms.Label lbl_id_odjel;
    }
}