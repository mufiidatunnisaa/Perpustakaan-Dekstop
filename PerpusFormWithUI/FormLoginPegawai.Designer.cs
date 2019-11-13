namespace PerpusFormWithUI
{
    partial class FormLoginPegawai
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username_Textbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.password_Textbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(199, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "IN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(116, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "SIGN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "password";
            // 
            // username_Textbox
            // 
            this.username_Textbox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.username_Textbox.BorderColor = System.Drawing.Color.White;
            this.username_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_Textbox.Location = new System.Drawing.Point(17, 132);
            this.username_Textbox.Name = "username_Textbox";
            this.username_Textbox.Size = new System.Drawing.Size(355, 38);
            this.username_Textbox.TabIndex = 12;
            // 
            // password_Textbox
            // 
            this.password_Textbox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.password_Textbox.BorderColor = System.Drawing.Color.White;
            this.password_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Textbox.Location = new System.Drawing.Point(18, 217);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(355, 38);
            this.password_Textbox.TabIndex = 13;
            this.password_Textbox.UseSystemPasswordChar = true;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Salmon;
            this.button_cancel.Location = new System.Drawing.Point(179, 281);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(88, 39);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_login.Location = new System.Drawing.Point(17, 281);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(156, 39);
            this.button_login.TabIndex = 14;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(328, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "DATEEB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(227, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "PERPUSTAKAAN";
            // 
            // FormLoginPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.username_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormLoginPegawai";
            this.Text = "FormLoginPegawai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox username_Textbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox password_Textbox;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}