namespace KPP_Alpha1
{
    partial class form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Login));
            this.lbl_korIme = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.txt_korIme = new System.Windows.Forms.TextBox();
            this.txt_lozinka = new System.Windows.Forms.TextBox();
            this.btn_prijava = new System.Windows.Forms.Button();
            this.btn_izlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_korIme
            // 
            this.lbl_korIme.AutoSize = true;
            this.lbl_korIme.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbl_korIme.Location = new System.Drawing.Point(114, 44);
            this.lbl_korIme.Name = "lbl_korIme";
            this.lbl_korIme.Size = new System.Drawing.Size(124, 23);
            this.lbl_korIme.TabIndex = 0;
            this.lbl_korIme.Text = "Korisničko ime:";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbl_lozinka.Location = new System.Drawing.Point(114, 99);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(71, 23);
            this.lbl_lozinka.TabIndex = 0;
            this.lbl_lozinka.Text = "Lozinka:";
            // 
            // txt_korIme
            // 
            this.txt_korIme.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_korIme.Location = new System.Drawing.Point(114, 67);
            this.txt_korIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_korIme.Name = "txt_korIme";
            this.txt_korIme.Size = new System.Drawing.Size(342, 30);
            this.txt_korIme.TabIndex = 1;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_lozinka.Location = new System.Drawing.Point(114, 123);
            this.txt_lozinka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.PasswordChar = '*';
            this.txt_lozinka.Size = new System.Drawing.Size(342, 30);
            this.txt_lozinka.TabIndex = 2;
            this.txt_lozinka.UseSystemPasswordChar = true;
            this.txt_lozinka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // btn_prijava
            // 
            this.btn_prijava.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_prijava.Location = new System.Drawing.Point(114, 179);
            this.btn_prijava.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_prijava.Name = "btn_prijava";
            this.btn_prijava.Size = new System.Drawing.Size(137, 51);
            this.btn_prijava.TabIndex = 3;
            this.btn_prijava.Text = "Prijava";
            this.btn_prijava.UseVisualStyleBackColor = true;
            this.btn_prijava.Click += new System.EventHandler(this.Btn_prijava_Click_1);
            // 
            // btn_izlaz
            // 
            this.btn_izlaz.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_izlaz.Location = new System.Drawing.Point(320, 179);
            this.btn_izlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_izlaz.Name = "btn_izlaz";
            this.btn_izlaz.Size = new System.Drawing.Size(137, 51);
            this.btn_izlaz.TabIndex = 4;
            this.btn_izlaz.Text = "Izlaz";
            this.btn_izlaz.UseVisualStyleBackColor = true;
            this.btn_izlaz.Click += new System.EventHandler(this.Btn_izlaz_Click_1);
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(553, 292);
            this.Controls.Add(this.btn_izlaz);
            this.Controls.Add(this.btn_prijava);
            this.Controls.Add(this.txt_lozinka);
            this.Controls.Add(this.txt_korIme);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_korIme);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_korIme;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.TextBox txt_korIme;
        private System.Windows.Forms.TextBox txt_lozinka;
        private System.Windows.Forms.Button btn_prijava;
        private System.Windows.Forms.Button btn_izlaz;
    }
}