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
            this.Lbl_DjelatnikName = new System.Windows.Forms.Label();
            this.Lbl_RegOznaka = new System.Windows.Forms.Label();
            this.Txt_RegOznaka = new System.Windows.Forms.TextBox();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Lbl_Datum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dtp_DatumOvlastenja
            // 
            this.Dtp_DatumOvlastenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DatumOvlastenja.Location = new System.Drawing.Point(147, 129);
            this.Dtp_DatumOvlastenja.Name = "Dtp_DatumOvlastenja";
            this.Dtp_DatumOvlastenja.Size = new System.Drawing.Size(182, 26);
            this.Dtp_DatumOvlastenja.TabIndex = 0;
            // 
            // Txt_Djelatnik
            // 
            this.Txt_Djelatnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Djelatnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt_Djelatnik.Location = new System.Drawing.Point(147, 65);
            this.Txt_Djelatnik.Name = "Txt_Djelatnik";
            this.Txt_Djelatnik.Size = new System.Drawing.Size(182, 26);
            this.Txt_Djelatnik.TabIndex = 1;
            // 
            // Lbl_DjelatnikName
            // 
            this.Lbl_DjelatnikName.AutoSize = true;
            this.Lbl_DjelatnikName.Location = new System.Drawing.Point(47, 65);
            this.Lbl_DjelatnikName.Name = "Lbl_DjelatnikName";
            this.Lbl_DjelatnikName.Size = new System.Drawing.Size(94, 19);
            this.Lbl_DjelatnikName.TabIndex = 2;
            this.Lbl_DjelatnikName.Text = "Ime i Prezime:";
            // 
            // Lbl_RegOznaka
            // 
            this.Lbl_RegOznaka.AutoSize = true;
            this.Lbl_RegOznaka.Location = new System.Drawing.Point(53, 100);
            this.Lbl_RegOznaka.Name = "Lbl_RegOznaka";
            this.Lbl_RegOznaka.Size = new System.Drawing.Size(88, 19);
            this.Lbl_RegOznaka.TabIndex = 3;
            this.Lbl_RegOznaka.Text = "Reg. Oznaka:";
            // 
            // Txt_RegOznaka
            // 
            this.Txt_RegOznaka.Location = new System.Drawing.Point(147, 97);
            this.Txt_RegOznaka.Name = "Txt_RegOznaka";
            this.Txt_RegOznaka.Size = new System.Drawing.Size(182, 26);
            this.Txt_RegOznaka.TabIndex = 4;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(347, 65);
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
            this.Lbl_Datum.Location = new System.Drawing.Point(87, 132);
            this.Lbl_Datum.Name = "Lbl_Datum";
            this.Lbl_Datum.Size = new System.Drawing.Size(54, 19);
            this.Lbl_Datum.TabIndex = 6;
            this.Lbl_Datum.Text = "Datum:";
            // 
            // FormOvlastenja
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(903, 433);
            this.Controls.Add(this.Lbl_DjelatnikName);
            this.Controls.Add(this.Txt_Djelatnik);
            this.Controls.Add(this.Lbl_Datum);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.Dtp_DatumOvlastenja);
            this.Controls.Add(this.Txt_RegOznaka);
            this.Controls.Add(this.Lbl_RegOznaka);
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
        private System.Windows.Forms.Label Lbl_DjelatnikName;
        private System.Windows.Forms.Label Lbl_RegOznaka;
        private System.Windows.Forms.TextBox Txt_RegOznaka;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Label Lbl_Datum;
    }
}