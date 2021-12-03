
namespace LoginForm
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.AddFedder = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.RevieLogs = new System.Windows.Forms.Button();
            this.ListOfFeeders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddFedder
            // 
            this.AddFedder.BackColor = System.Drawing.Color.DimGray;
            this.AddFedder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFedder.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddFedder.FlatAppearance.BorderSize = 4;
            this.AddFedder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddFedder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.AddFedder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFedder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFedder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddFedder.Location = new System.Drawing.Point(0, 0);
            this.AddFedder.Name = "AddFedder";
            this.AddFedder.Size = new System.Drawing.Size(800, 77);
            this.AddFedder.TabIndex = 0;
            this.AddFedder.Text = "Add new fedder";
            this.AddFedder.UseVisualStyleBackColor = false;
            this.AddFedder.Click += new System.EventHandler(this.AddFedder_Click);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.DimGray;
            this.AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddUser.FlatAppearance.BorderSize = 4;
            this.AddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddUser.Location = new System.Drawing.Point(0, 77);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(800, 77);
            this.AddUser.TabIndex = 1;
            this.AddUser.Text = "Add new user";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // RevieLogs
            // 
            this.RevieLogs.BackColor = System.Drawing.Color.DimGray;
            this.RevieLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevieLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.RevieLogs.FlatAppearance.BorderSize = 4;
            this.RevieLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RevieLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.RevieLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevieLogs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RevieLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RevieLogs.Location = new System.Drawing.Point(0, 154);
            this.RevieLogs.Name = "RevieLogs";
            this.RevieLogs.Size = new System.Drawing.Size(800, 77);
            this.RevieLogs.TabIndex = 2;
            this.RevieLogs.Text = "Revie logs";
            this.RevieLogs.UseVisualStyleBackColor = false;
            this.RevieLogs.Click += new System.EventHandler(this.RevieLogs_Click);
            // 
            // ListOfFeeders
            // 
            this.ListOfFeeders.BackColor = System.Drawing.Color.DimGray;
            this.ListOfFeeders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListOfFeeders.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListOfFeeders.FlatAppearance.BorderSize = 4;
            this.ListOfFeeders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ListOfFeeders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ListOfFeeders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListOfFeeders.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfFeeders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ListOfFeeders.Location = new System.Drawing.Point(0, 231);
            this.ListOfFeeders.Name = "ListOfFeeders";
            this.ListOfFeeders.Size = new System.Drawing.Size(800, 77);
            this.ListOfFeeders.TabIndex = 8;
            this.ListOfFeeders.Text = "Feeders";
            this.ListOfFeeders.UseMnemonic = false;
            this.ListOfFeeders.UseVisualStyleBackColor = false;
            this.ListOfFeeders.Click += new System.EventHandler(this.ListOfFeeders_Click);
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListOfFeeders);
            this.Controls.Add(this.RevieLogs);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.AddFedder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddFedder;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button RevieLogs;
        private System.Windows.Forms.Button ListOfFeeders;
    }

}