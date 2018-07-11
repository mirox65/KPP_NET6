namespace KPP_Alpha1
{
    partial class form_Korisnici
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
            this.lbl_id_korisnik = new System.Windows.Forms.Label();
            this.lbl_ime_korisnik = new System.Windows.Forms.Label();
            this.lbl_prezime_korisnik = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.dgv_korisnik = new System.Windows.Forms.DataGridView();
            this.lbl_dodaj = new System.Windows.Forms.Button();
            this.lbl_uredi = new System.Windows.Forms.Button();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_korisnik)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_korisnik
            // 
            this.lbl_id_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id_korisnik.AutoSize = true;
            this.lbl_id_korisnik.Location = new System.Drawing.Point(12, 29);
            this.lbl_id_korisnik.Name = "lbl_id_korisnik";
            this.lbl_id_korisnik.Size = new System.Drawing.Size(31, 23);
            this.lbl_id_korisnik.TabIndex = 0;
            this.lbl_id_korisnik.Text = "ID:";
            // 
            // lbl_ime_korisnik
            // 
            this.lbl_ime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ime_korisnik.AutoSize = true;
            this.lbl_ime_korisnik.Location = new System.Drawing.Point(12, 81);
            this.lbl_ime_korisnik.Name = "lbl_ime_korisnik";
            this.lbl_ime_korisnik.Size = new System.Drawing.Size(43, 23);
            this.lbl_ime_korisnik.TabIndex = 1;
            this.lbl_ime_korisnik.Text = "Ime:";
            // 
            // lbl_prezime_korisnik
            // 
            this.lbl_prezime_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_prezime_korisnik.AutoSize = true;
            this.lbl_prezime_korisnik.Location = new System.Drawing.Point(12, 133);
            this.lbl_prezime_korisnik.Name = "lbl_prezime_korisnik";
            this.lbl_prezime_korisnik.Size = new System.Drawing.Size(75, 23);
            this.lbl_prezime_korisnik.TabIndex = 2;
            this.lbl_prezime_korisnik.Text = "Prezime:";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(148, 25);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 30);
            this.txt_id.TabIndex = 1;
            this.txt_id.TabStop = false;
            // 
            // txt_ime
            // 
            this.txt_ime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ime.Location = new System.Drawing.Point(148, 77);
            this.txt_ime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(210, 30);
            this.txt_ime.TabIndex = 1;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_prezime.Location = new System.Drawing.Point(148, 129);
            this.txt_prezime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(210, 30);
            this.txt_prezime.TabIndex = 2;
            // 
            // dgv_korisnik
            // 
            this.dgv_korisnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_korisnik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_korisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_korisnik.Location = new System.Drawing.Point(12, 237);
            this.dgv_korisnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_korisnik.Name = "dgv_korisnik";
            this.dgv_korisnik.RowTemplate.Height = 24;
            this.dgv_korisnik.Size = new System.Drawing.Size(758, 304);
            this.dgv_korisnik.TabIndex = 6;
            this.dgv_korisnik.TabStop = false;
            this.dgv_korisnik.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_korisnik_RowHeaderMouseClick);
            // 
            // lbl_dodaj
            // 
            this.lbl_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dodaj.Location = new System.Drawing.Point(680, 23);
            this.lbl_dodaj.Name = "lbl_dodaj";
            this.lbl_dodaj.Size = new System.Drawing.Size(90, 35);
            this.lbl_dodaj.TabIndex = 3;
            this.lbl_dodaj.Text = "Dodaj";
            this.lbl_dodaj.UseVisualStyleBackColor = true;
            this.lbl_dodaj.Click += new System.EventHandler(this.lbl_dodaj_Click);
            // 
            // lbl_uredi
            // 
            this.lbl_uredi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_uredi.Location = new System.Drawing.Point(695, 75);
            this.lbl_uredi.Name = "lbl_uredi";
            this.lbl_uredi.Size = new System.Drawing.Size(75, 35);
            this.lbl_uredi.TabIndex = 8;
            this.lbl_uredi.TabStop = false;
            this.lbl_uredi.Text = "Uredi";
            this.lbl_uredi.UseVisualStyleBackColor = true;
            this.lbl_uredi.Click += new System.EventHandler(this.lbl_uredi_Click);
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(148, 181);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(622, 30);
            this.txt_pretrazivanje.TabIndex = 10;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretrazivanje_TextChanged);
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(12, 185);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(112, 23);
            this.lbl_pretrazivanje.TabIndex = 11;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // form_Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.lbl_uredi);
            this.Controls.Add(this.lbl_dodaj);
            this.Controls.Add(this.dgv_korisnik);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_prezime_korisnik);
            this.Controls.Add(this.lbl_ime_korisnik);
            this.Controls.Add(this.lbl_id_korisnik);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Korisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.form_Korisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_korisnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_korisnik;
        private System.Windows.Forms.Label lbl_ime_korisnik;
        private System.Windows.Forms.Label lbl_prezime_korisnik;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.DataGridView dgv_korisnik;
        private System.Windows.Forms.Button lbl_dodaj;
        private System.Windows.Forms.Button lbl_uredi;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Label lbl_pretrazivanje;
    }
}