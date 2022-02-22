namespace KPP_Alpha1
{
    partial class FormOvlastenja
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
            this.Dtp_DatumOvlastenja = new System.Windows.Forms.DateTimePicker();
            this.Txt_Djelatnik = new System.Windows.Forms.TextBox();
            this.Lbl_Djelatnik = new System.Windows.Forms.Label();
            this.Lbl_Automobil = new System.Windows.Forms.Label();
            this.Txt_Automobil = new System.Windows.Forms.TextBox();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Lbl_Datum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dtp_DatumOvlastenja
            // 
            this.Dtp_DatumOvlastenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DatumOvlastenja.Location = new System.Drawing.Point(114, 156);
            this.Dtp_DatumOvlastenja.Name = "Dtp_DatumOvlastenja";
            this.Dtp_DatumOvlastenja.Size = new System.Drawing.Size(182, 26);
            this.Dtp_DatumOvlastenja.TabIndex = 0;
            // 
            // Txt_Djelatnik
            // 
            this.Txt_Djelatnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Djelatnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Djelatnik.Location = new System.Drawing.Point(114, 92);
            this.Txt_Djelatnik.Name = "Txt_Djelatnik";
            this.Txt_Djelatnik.Size = new System.Drawing.Size(182, 26);
            this.Txt_Djelatnik.TabIndex = 1;
            // 
            // Lbl_Djelatnik
            // 
            this.Lbl_Djelatnik.AutoSize = true;
            this.Lbl_Djelatnik.Location = new System.Drawing.Point(43, 95);
            this.Lbl_Djelatnik.Name = "Lbl_Djelatnik";
            this.Lbl_Djelatnik.Size = new System.Drawing.Size(65, 19);
            this.Lbl_Djelatnik.TabIndex = 2;
            this.Lbl_Djelatnik.Text = "Djelatnik:";
            // 
            // Lbl_Automobil
            // 
            this.Lbl_Automobil.AutoSize = true;
            this.Lbl_Automobil.Location = new System.Drawing.Point(32, 127);
            this.Lbl_Automobil.Name = "Lbl_Automobil";
            this.Lbl_Automobil.Size = new System.Drawing.Size(76, 19);
            this.Lbl_Automobil.TabIndex = 3;
            this.Lbl_Automobil.Text = "Automobil:";
            // 
            // Txt_Automobil
            // 
            this.Txt_Automobil.Location = new System.Drawing.Point(114, 124);
            this.Txt_Automobil.Name = "Txt_Automobil";
            this.Txt_Automobil.Size = new System.Drawing.Size(182, 26);
            this.Txt_Automobil.TabIndex = 4;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(314, 92);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(90, 90);
            this.Btn_Create.TabIndex = 5;
            this.Btn_Create.Text = "Create  docx";
            this.Btn_Create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Lbl_Datum
            // 
            this.Lbl_Datum.AutoSize = true;
            this.Lbl_Datum.Location = new System.Drawing.Point(54, 159);
            this.Lbl_Datum.Name = "Lbl_Datum";
            this.Lbl_Datum.Size = new System.Drawing.Size(54, 19);
            this.Lbl_Datum.TabIndex = 6;
            this.Lbl_Datum.Text = "Datum:";
            // 
            // FormOvlastenja
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(493, 278);
            this.Controls.Add(this.Lbl_Datum);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.Txt_Automobil);
            this.Controls.Add(this.Lbl_Automobil);
            this.Controls.Add(this.Lbl_Djelatnik);
            this.Controls.Add(this.Txt_Djelatnik);
            this.Controls.Add(this.Dtp_DatumOvlastenja);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOvlastenja";
            this.Text = "Ovlaštenja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtp_DatumOvlastenja;
        private System.Windows.Forms.TextBox Txt_Djelatnik;
        private System.Windows.Forms.Label Lbl_Djelatnik;
        private System.Windows.Forms.Label Lbl_Automobil;
        private System.Windows.Forms.TextBox Txt_Automobil;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Label Lbl_Datum;
    }
}