namespace Bismillah.View
{
    partial class TambahTugascs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbJudul = new TextBox();
            tbDeskripsi = new TextBox();
            tbDeadline = new TextBox();
            btnTambahtugas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 102);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Judul";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 162);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Deskripsi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 214);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Deadline";
            // 
            // tbJudul
            // 
            tbJudul.Location = new Point(332, 102);
            tbJudul.Name = "tbJudul";
            tbJudul.Size = new Size(159, 27);
            tbJudul.TabIndex = 3;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Location = new Point(332, 162);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(159, 27);
            tbDeskripsi.TabIndex = 4;
            // 
            // tbDeadline
            // 
            tbDeadline.Location = new Point(332, 217);
            tbDeadline.Name = "tbDeadline";
            tbDeadline.Size = new Size(159, 27);
            tbDeadline.TabIndex = 5;
            // 
            // btnTambahtugas
            // 
            btnTambahtugas.Location = new Point(332, 310);
            btnTambahtugas.Name = "btnTambahtugas";
            btnTambahtugas.Size = new Size(94, 29);
            btnTambahtugas.TabIndex = 6;
            btnTambahtugas.Text = "TAMBAH";
            btnTambahtugas.UseVisualStyleBackColor = true;
            // 
            // TambahTugascs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahtugas);
            Controls.Add(tbDeadline);
            Controls.Add(tbDeskripsi);
            Controls.Add(tbJudul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TambahTugascs";
            Text = "TambahTugascs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbJudul;
        private TextBox tbDeskripsi;
        private TextBox tbDeadline;
        private Button btnTambahtugas;
    }
}