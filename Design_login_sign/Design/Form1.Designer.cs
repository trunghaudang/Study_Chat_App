namespace Design
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
            label1 = new Label();
            btnLogIn = new Button();
            btnSignUp = new Button();
            btnHowtoUse = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(152, 46);
            label1.Name = "label1";
            label1.Size = new Size(251, 41);
            label1.TabIndex = 0;
            label1.Text = "Study Chat App";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Blue;
            btnLogIn.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.ButtonHighlight;
            btnLogIn.Location = new Point(152, 135);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(251, 62);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Blue;
            btnSignUp.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(152, 227);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(251, 62);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnHowtoUse
            // 
            btnHowtoUse.BackColor = Color.Blue;
            btnHowtoUse.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHowtoUse.ForeColor = SystemColors.ButtonHighlight;
            btnHowtoUse.Location = new Point(152, 320);
            btnHowtoUse.Name = "btnHowtoUse";
            btnHowtoUse.Size = new Size(251, 62);
            btnHowtoUse.TabIndex = 3;
            btnHowtoUse.Text = "How to Use";
            btnHowtoUse.UseVisualStyleBackColor = false;
            btnHowtoUse.Click += btnHowtoUse_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(152, 413);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(251, 62);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(550, 529);
            Controls.Add(btnExit);
            Controls.Add(btnHowtoUse);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogIn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogIn;
        private Button btnSignUp;
        private Button btnHowtoUse;
        private Button btnExit;
    }
}