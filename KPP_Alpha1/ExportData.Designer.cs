namespace KPP_Alpha1
{
    partial class form_ExportData
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
            this.lbl_ExportGod = new System.Windows.Forms.Label();
            this.Txt_Godina = new System.Windows.Forms.TextBox();
            this.Btn_IzvozPodataka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ExportGod
            // 
            this.lbl_ExportGod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ExportGod.AutoSize = true;
            this.lbl_ExportGod.Location = new System.Drawing.Point(15, 23);
            this.lbl_ExportGod.Name = "lbl_ExportGod";
            this.lbl_ExportGod.Size = new System.Drawing.Size(245, 19);
            this.lbl_ExportGod.TabIndex = 0;
            this.lbl_ExportGod.Text = "Godina za koju radimo izvoz podataka:";
            // 
            // Txt_Godina
            // 
            this.Txt_Godina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Godina.Location = new System.Drawing.Point(62, 49);
            this.Txt_Godina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Godina.Name = "Txt_Godina";
            this.Txt_Godina.Size = new System.Drawing.Size(150, 26);
            this.Txt_Godina.TabIndex = 1;
            this.Txt_Godina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_IzvozPodataka
            // 
            this.Btn_IzvozPodataka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_IzvozPodataka.Location = new System.Drawing.Point(62, 87);
            this.Btn_IzvozPodataka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_IzvozPodataka.Name = "Btn_IzvozPodataka";
            this.Btn_IzvozPodataka.Size = new System.Drawing.Size(152, 56);
            this.Btn_IzvozPodataka.TabIndex = 2;
            this.Btn_IzvozPodataka.Text = "Izvoz podataka";
            this.Btn_IzvozPodataka.UseVisualStyleBackColor = true;
            this.Btn_IzvozPodataka.Click += new System.EventHandler(this.Btn_IzvozPodataka_Click);
            // 
            // form_ExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 161);
            this.Controls.Add(this.Btn_IzvozPodataka);
            this.Controls.Add(this.Txt_Godina);
            this.Controls.Add(this.lbl_ExportGod);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_ExportData";
            this.Text = "Izvoz podataka za arhivu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExportGod;
        private System.Windows.Forms.TextBox Txt_Godina;
        private System.Windows.Forms.Button Btn_IzvozPodataka;
    }
}