
namespace ktvsystem
{
    partial class Administratorchangespassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1_account = new System.Windows.Forms.TextBox();
            this.textBox2_old = new System.Windows.Forms.TextBox();
            this.textBox3_new = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文彩云", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Changes Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Old password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "New passage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm modification";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 72);
            this.button2.TabIndex = 5;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1_account
            // 
            this.textBox1_account.Location = new System.Drawing.Point(218, 155);
            this.textBox1_account.Name = "textBox1_account";
            this.textBox1_account.Size = new System.Drawing.Size(282, 33);
            this.textBox1_account.TabIndex = 6;
            // 
            // textBox2_old
            // 
            this.textBox2_old.Location = new System.Drawing.Point(218, 232);
            this.textBox2_old.Name = "textBox2_old";
            this.textBox2_old.Size = new System.Drawing.Size(282, 33);
            this.textBox2_old.TabIndex = 7;
            // 
            // textBox3_new
            // 
            this.textBox3_new.Location = new System.Drawing.Point(218, 304);
            this.textBox3_new.Name = "textBox3_new";
            this.textBox3_new.Size = new System.Drawing.Size(282, 33);
            this.textBox3_new.TabIndex = 8;
            // 
            // Administratorchangespassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 520);
            this.Controls.Add(this.textBox3_new);
            this.Controls.Add(this.textBox2_old);
            this.Controls.Add(this.textBox1_account);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Administratorchangespassword";
            this.Text = "Administratorchangespassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1_account;
        private System.Windows.Forms.TextBox textBox2_old;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox3_new;
    }
}