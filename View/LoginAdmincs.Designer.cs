namespace Bismillah.View
{
    partial class LoginAdmincs
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
            tbUser = new TextBox();
            tbPass = new TextBox();
            btnLOGIN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 102);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 174);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(352, 99);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(177, 27);
            tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(352, 178);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(177, 27);
            tbPass.TabIndex = 3;
            // 
            // btnLOGIN
            // 
            btnLOGIN.Location = new Point(338, 295);
            btnLOGIN.Name = "btnLOGIN";
            btnLOGIN.Size = new Size(94, 29);
            btnLOGIN.TabIndex = 4;
            btnLOGIN.Text = "LOGIN";
            btnLOGIN.UseVisualStyleBackColor = true;
            btnLOGIN.Click += btnLOGIN_Click;
            // 
            // LoginAdmincs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLOGIN);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginAdmincs";
            Text = "LoginAdmincs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUser;
        private TextBox tbPass;
        private Button btnLOGIN;
    }
}