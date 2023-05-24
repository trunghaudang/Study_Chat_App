namespace Server_ltm
{
    partial class Form1
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
            this.lv_message = new System.Windows.Forms.ListView();
            this.bt_sent = new System.Windows.Forms.Button();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lv_message
            // 
            this.lv_message.HideSelection = false;
            this.lv_message.Location = new System.Drawing.Point(85, 39);
            this.lv_message.Name = "lv_message";
            this.lv_message.Size = new System.Drawing.Size(505, 313);
            this.lv_message.TabIndex = 2;
            this.lv_message.UseCompatibleStateImageBehavior = false;
            this.lv_message.View = System.Windows.Forms.View.List;
            // 
            // bt_sent
            // 
            this.bt_sent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_sent.Location = new System.Drawing.Point(660, 386);
            this.bt_sent.Name = "bt_sent";
            this.bt_sent.Size = new System.Drawing.Size(128, 52);
            this.bt_sent.TabIndex = 5;
            this.bt_sent.Text = "Sent";
            this.bt_sent.UseVisualStyleBackColor = true;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(85, 386);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(505, 52);
            this.txt_message.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_sent);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.lv_message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_message;
        private System.Windows.Forms.Button bt_sent;
        private System.Windows.Forms.TextBox txt_message;
    }
}

