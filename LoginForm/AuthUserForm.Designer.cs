
namespace LoginForm
{
    partial class AuthUserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserAuth = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.EnterAuthbutton = new System.Windows.Forms.Button();
            this.back1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.UserAuth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // UserAuth
            // 
            this.UserAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAuth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserAuth.Location = new System.Drawing.Point(0, 0);
            this.UserAuth.Name = "UserAuth";
            this.UserAuth.Size = new System.Drawing.Size(800, 100);
            this.UserAuth.TabIndex = 0;
            this.UserAuth.Text = "User authorization";
            this.UserAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(265, 188);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(271, 26);
            this.NameBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(265, 303);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(271, 26);
            this.PasswordBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(92, 185);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(78, 29);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.Location = new System.Drawing.Point(92, 303);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(120, 29);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Password";
            // 
            // EnterAuthbutton
            // 
            this.EnterAuthbutton.Location = new System.Drawing.Point(354, 389);
            this.EnterAuthbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnterAuthbutton.Name = "EnterAuthbutton";
            this.EnterAuthbutton.Size = new System.Drawing.Size(112, 35);
            this.EnterAuthbutton.TabIndex = 10;
            this.EnterAuthbutton.Text = "Enter";
            this.EnterAuthbutton.UseVisualStyleBackColor = true;
            this.EnterAuthbutton.Click += new System.EventHandler(this.EnterAuthbutton_Click);
            // 
            // back1
            // 
            this.back1.Location = new System.Drawing.Point(674, 389);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(87, 34);
            this.back1.TabIndex = 11;
            this.back1.Text = "back";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back1_Click);
            // 
            // AuthUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.EnterAuthbutton);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.panel1);
            this.Name = "AuthUserForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserAuth;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button EnterAuthbutton;
        private System.Windows.Forms.Button back1;
    }
}