namespace Design
{
    partial class LogIn
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
            txt_name = new TextBox();
            txt_password = new TextBox();
            label3 = new Label();
            lbForgotPassword = new Label();
            label5 = new Label();
            lbSignUp = new Label();
            btnLogIn = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 122);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 200);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.InactiveBorder;
            txt_name.Location = new Point(262, 125);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(340, 27);
            txt_name.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.InactiveBorder;
            txt_password.Location = new Point(262, 200);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(340, 27);
            txt_password.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(349, 33);
            label3.Name = "label3";
            label3.Size = new Size(104, 39);
            label3.TabIndex = 4;
            label3.Text = "Log In";
            // 
            // lbForgotPassword
            // 
            lbForgotPassword.AutoSize = true;
            lbForgotPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lbForgotPassword.ForeColor = Color.Blue;
            lbForgotPassword.Location = new Point(262, 233);
            lbForgotPassword.Name = "lbForgotPassword";
            lbForgotPassword.Size = new Size(181, 29);
            lbForgotPassword.TabIndex = 5;
            lbForgotPassword.Text = "Forgot password?";
            lbForgotPassword.Click += lbForgotPassword_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(262, 262);
            label5.Name = "label5";
            label5.Size = new Size(259, 28);
            label5.TabIndex = 6;
            label5.Text = "Don't have an account yet?";
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lbSignUp.ForeColor = Color.Blue;
            lbSignUp.Location = new Point(517, 261);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(85, 28);
            lbSignUp.TabIndex = 7;
            lbSignUp.Text = "Sign Up";
            lbSignUp.Click += lbSignUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.AutoSize = true;
            btnLogIn.BackColor = Color.Blue;
            btnLogIn.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.ButtonHighlight;
            btnLogIn.Location = new Point(173, 335);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(155, 61);
            btnLogIn.TabIndex = 8;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = Color.FromArgb(192, 0, 0);
            btnBack.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(428, 335);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 61);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(782, 450);
            Controls.Add(btnBack);
            Controls.Add(btnLogIn);
            Controls.Add(lbSignUp);
            Controls.Add(label5);
            Controls.Add(lbForgotPassword);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "LogIn";
            Text = "LogIn";
            FormClosing += LogIn_FormClosing;
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_password;
        private Label label3;
        private Label lbForgotPassword;
        private Label label5;
        private Label lbSignUp;
        private Button btnLogIn;
        private Button btnBack;
    }
}