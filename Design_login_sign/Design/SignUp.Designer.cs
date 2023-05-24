namespace Design
{
    partial class SignUp
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
            label4 = new Label();
            label5 = new Label();
            txt_birth = new DateTimePicker();
            txt_password = new TextBox();
            txt_username = new TextBox();
            txt_email = new TextBox();
            btnSignUp = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(278, 30);
            label1.Name = "label1";
            label1.Size = new Size(122, 39);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 113);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 167);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 2;
            label3.Text = "User name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(91, 222);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(91, 279);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // txt_birth
            // 
            txt_birth.CalendarMonthBackground = SystemColors.InactiveBorder;
            txt_birth.Location = new Point(215, 280);
            txt_birth.Name = "txt_birth";
            txt_birth.Size = new Size(353, 27);
            txt_birth.TabIndex = 5;
            txt_birth.ValueChanged += txt_birth_ValueChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.InactiveBorder;
            txt_password.Location = new Point(215, 225);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(353, 27);
            txt_password.TabIndex = 6;
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.InactiveBorder;
            txt_username.Location = new Point(215, 170);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(353, 27);
            txt_username.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.BackColor = SystemColors.InactiveBorder;
            txt_email.Location = new Point(215, 116);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(353, 27);
            txt_email.TabIndex = 8;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Blue;
            btnSignUp.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(121, 353);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(147, 54);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 0, 0);
            btnBack.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(390, 353);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 54);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(670, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSignUp);
            Controls.Add(txt_email);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Controls.Add(txt_birth);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            FormClosing += SignUp_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker txt_birth;
        private TextBox txt_password;
        private TextBox txt_username;
        private TextBox txt_email;
        private Button btnSignUp;
        private Button btnBack;
    }
}