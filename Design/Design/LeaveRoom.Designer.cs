namespace Design
{
    partial class LeaveRoom
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.gnBtnStay = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnLeave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // gnBtnStay
            // 
            this.gnBtnStay.CustomizableEdges = customizableEdges1;
            this.gnBtnStay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnStay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnStay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnStay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnStay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gnBtnStay.ForeColor = System.Drawing.Color.White;
            this.gnBtnStay.Location = new System.Drawing.Point(109, 102);
            this.gnBtnStay.Name = "gnBtnStay";
            this.gnBtnStay.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.gnBtnStay.Size = new System.Drawing.Size(225, 56);
            this.gnBtnStay.TabIndex = 0;
            this.gnBtnStay.Text = "Stay in session";
            this.gnBtnStay.Click += new System.EventHandler(this.gnBtnStay_Click);
            // 
            // gnBtnLeave
            // 
            this.gnBtnLeave.CustomizableEdges = customizableEdges3;
            this.gnBtnLeave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnLeave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnBtnLeave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnBtnLeave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnBtnLeave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gnBtnLeave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gnBtnLeave.ForeColor = System.Drawing.Color.White;
            this.gnBtnLeave.Location = new System.Drawing.Point(415, 102);
            this.gnBtnLeave.Name = "gnBtnLeave";
            this.gnBtnLeave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.gnBtnLeave.Size = new System.Drawing.Size(225, 56);
            this.gnBtnLeave.TabIndex = 1;
            this.gnBtnLeave.Text = "Leave Room";
            this.gnBtnLeave.Click += new System.EventHandler(this.gnBtnLeave_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(181, 34);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(369, 34);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Are you sure you want to leave?";
            // 
            // LeaveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 208);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.gnBtnLeave);
            this.Controls.Add(this.gnBtnStay);
            this.Name = "LeaveRoom";
            this.Text = "LeaveRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button gnBtnStay;
        private Guna.UI2.WinForms.Guna2Button gnBtnLeave;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}