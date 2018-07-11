namespace KPP_Alpha1
{
    partial class form_KPP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Posiljatelj = new System.Windows.Forms.TextBox();
            this.txt_Pismeno = new System.Windows.Forms.TextBox();
            this.txt_Brojcano = new System.Windows.Forms.TextBox();
            this.txt_Odjel = new System.Windows.Forms.TextBox();
            this.txt_Korisnik = new System.Windows.Forms.TextBox();
            this.date_datum = new System.Windows.Forms.DateTimePicker();
            this.date_primitka = new System.Windows.Forms.DateTimePicker();
            this.btn_search_korisnik = new System.Windows.Forms.Button();
            this.btn_search_posiljatelj = new System.Windows.Forms.Button();
            this.btn_search_odjel = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_kpp = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kpp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pismeno:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum primitka:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pošiljatelj:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Odjel:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Korisnik:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Brojčano:";
            // 
            // txt_Posiljatelj
            // 
            this.txt_Posiljatelj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Posiljatelj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Posiljatelj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Posiljatelj.Location = new System.Drawing.Point(312, 35);
            this.txt_Posiljatelj.Name = "txt_Posiljatelj";
            this.txt_Posiljatelj.Size = new System.Drawing.Size(389, 30);
            this.txt_Posiljatelj.TabIndex = 1;
            // 
            // txt_Pismeno
            // 
            this.txt_Pismeno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Pismeno.Location = new System.Drawing.Point(309, 98);
            this.txt_Pismeno.Name = "txt_Pismeno";
            this.txt_Pismeno.Size = new System.Drawing.Size(129, 30);
            this.txt_Pismeno.TabIndex = 2;
            // 
            // txt_Brojcano
            // 
            this.txt_Brojcano.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Brojcano.Location = new System.Drawing.Point(451, 98);
            this.txt_Brojcano.Name = "txt_Brojcano";
            this.txt_Brojcano.Size = new System.Drawing.Size(302, 30);
            this.txt_Brojcano.TabIndex = 3;
            // 
            // txt_Odjel
            // 
            this.txt_Odjel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Odjel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Odjel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Odjel.Location = new System.Drawing.Point(451, 167);
            this.txt_Odjel.Name = "txt_Odjel";
            this.txt_Odjel.Size = new System.Drawing.Size(250, 30);
            this.txt_Odjel.TabIndex = 5;
            // 
            // txt_Korisnik
            // 
            this.txt_Korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Korisnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Korisnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Korisnik.Location = new System.Drawing.Point(16, 168);
            this.txt_Korisnik.Name = "txt_Korisnik";
            this.txt_Korisnik.Size = new System.Drawing.Size(220, 30);
            this.txt_Korisnik.TabIndex = 15;
            this.txt_Korisnik.TabStop = false;
            // 
            // date_datum
            // 
            this.date_datum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_datum.Location = new System.Drawing.Point(309, 167);
            this.date_datum.Name = "date_datum";
            this.date_datum.Size = new System.Drawing.Size(129, 30);
            this.date_datum.TabIndex = 4;
            // 
            // date_primitka
            // 
            this.date_primitka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_primitka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_primitka.Location = new System.Drawing.Point(16, 99);
            this.date_primitka.Name = "date_primitka";
            this.date_primitka.Size = new System.Drawing.Size(129, 30);
            this.date_primitka.TabIndex = 16;
            this.date_primitka.TabStop = false;
            // 
            // btn_search_korisnik
            // 
            this.btn_search_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search_korisnik.Location = new System.Drawing.Point(243, 168);
            this.btn_search_korisnik.Name = "btn_search_korisnik";
            this.btn_search_korisnik.Size = new System.Drawing.Size(46, 30);
            this.btn_search_korisnik.TabIndex = 17;
            this.btn_search_korisnik.TabStop = false;
            this.btn_search_korisnik.Text = "...";
            this.btn_search_korisnik.UseVisualStyleBackColor = true;
            // 
            // btn_search_posiljatelj
            // 
            this.btn_search_posiljatelj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search_posiljatelj.Location = new System.Drawing.Point(707, 35);
            this.btn_search_posiljatelj.Name = "btn_search_posiljatelj";
            this.btn_search_posiljatelj.Size = new System.Drawing.Size(46, 30);
            this.btn_search_posiljatelj.TabIndex = 18;
            this.btn_search_posiljatelj.TabStop = false;
            this.btn_search_posiljatelj.Text = "...";
            this.btn_search_posiljatelj.UseVisualStyleBackColor = true;
            // 
            // btn_search_odjel
            // 
            this.btn_search_odjel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search_odjel.Location = new System.Drawing.Point(707, 167);
            this.btn_search_odjel.Name = "btn_search_odjel";
            this.btn_search_odjel.Size = new System.Drawing.Size(46, 30);
            this.btn_search_odjel.TabIndex = 19;
            this.btn_search_odjel.TabStop = false;
            this.btn_search_odjel.Text = "...";
            this.btn_search_odjel.UseCompatibleTextRendering = true;
            this.btn_search_odjel.UseVisualStyleBackColor = true;
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dodaj.Location = new System.Drawing.Point(780, 33);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(90, 35);
            this.btn_dodaj.TabIndex = 6;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_uredi
            // 
            this.btn_uredi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_uredi.Location = new System.Drawing.Point(795, 99);
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.Size = new System.Drawing.Size(75, 35);
            this.btn_uredi.TabIndex = 21;
            this.btn_uredi.TabStop = false;
            this.btn_uredi.Text = "Uredi";
            this.btn_uredi.UseVisualStyleBackColor = true;
            this.btn_uredi.Click += new System.EventHandler(this.btn_uredi_Click);
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(16, 231);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(854, 30);
            this.txt_pretrazivanje.TabIndex = 24;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretraži_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Pretraživanje:";
            // 
            // dgv_kpp
            // 
            this.dgv_kpp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_kpp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kpp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kpp.Location = new System.Drawing.Point(12, 291);
            this.dgv_kpp.Name = "dgv_kpp";
            this.dgv_kpp.RowTemplate.Height = 24;
            this.dgv_kpp.Size = new System.Drawing.Size(858, 252);
            this.dgv_kpp.TabIndex = 26;
            this.dgv_kpp.TabStop = false;
            this.dgv_kpp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_kpp_RowHeaderMouseClick);
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(20, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 30);
            this.txt_id.TabIndex = 28;
            this.txt_id.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(16, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(31, 23);
            this.lbl_id.TabIndex = 27;
            this.lbl_id.Text = "ID:";
            // 
            // form_KPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(882, 555);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.dgv_kpp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_search_odjel);
            this.Controls.Add(this.btn_search_posiljatelj);
            this.Controls.Add(this.btn_search_korisnik);
            this.Controls.Add(this.date_primitka);
            this.Controls.Add(this.date_datum);
            this.Controls.Add(this.txt_Korisnik);
            this.Controls.Add(this.txt_Odjel);
            this.Controls.Add(this.txt_Brojcano);
            this.Controls.Add(this.txt_Pismeno);
            this.Controls.Add(this.txt_Posiljatelj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_KPP";
            this.Text = "KPP";
            this.Load += new System.EventHandler(this.form_KPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kpp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Posiljatelj;
        private System.Windows.Forms.TextBox txt_Pismeno;
        private System.Windows.Forms.TextBox txt_Brojcano;
        private System.Windows.Forms.TextBox txt_Odjel;
        private System.Windows.Forms.TextBox txt_Korisnik;
        private System.Windows.Forms.DateTimePicker date_datum;
        private System.Windows.Forms.DateTimePicker date_primitka;
        private System.Windows.Forms.Button btn_search_korisnik;
        private System.Windows.Forms.Button btn_search_posiljatelj;
        private System.Windows.Forms.Button btn_search_odjel;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_uredi;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_kpp;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}