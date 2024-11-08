
using Bismillah.View;

namespace Bismillah
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHaltugas = new Button();
            btnDaftarPengguna = new Button();
            btnHalLogin = new Button();
            SuspendLayout();
            // 
            // btnHaltugas
            // 
            btnHaltugas.Location = new Point(12, 57);
            btnHaltugas.Name = "btnHaltugas";
            btnHaltugas.Size = new Size(209, 85);
            btnHaltugas.TabIndex = 0;
            btnHaltugas.Text = "TUGAS";
            btnHaltugas.UseVisualStyleBackColor = true;
            btnHaltugas.Click += btnHaltugas_Click;
            // 
            // btnDaftarPengguna
            // 
            btnDaftarPengguna.Location = new Point(227, 57);
            btnDaftarPengguna.Name = "btnDaftarPengguna";
            btnDaftarPengguna.Size = new Size(204, 85);
            btnDaftarPengguna.TabIndex = 1;
            btnDaftarPengguna.Text = "DaftarPengguna";
            btnDaftarPengguna.UseVisualStyleBackColor = true;
            // 
            // btnHalLogin
            // 
            btnHalLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHalLogin.Location = new Point(437, 57);
            btnHalLogin.Name = "btnHalLogin";
            btnHalLogin.Size = new Size(182, 85);
            btnHalLogin.TabIndex = 2;
            btnHalLogin.Text = "LOGIN";
            btnHalLogin.UseVisualStyleBackColor = true;
            btnHalLogin.Click += btnHalLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHalLogin);
            Controls.Add(btnDaftarPengguna);
            Controls.Add(btnHaltugas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        private void btnHaltugas_Click(object sender, EventArgs e)
        {
            Tugas baru = new Tugas();
            baru.ShowDialog();
        }

        #endregion

        private Button btnHaltugas;
        private Button btnDaftarPengguna;
        private Button btnHalLogin;
    }
}
