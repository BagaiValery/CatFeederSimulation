
namespace LoginForm
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.LoginUser = new System.Windows.Forms.Button();
            this.LoginAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.simulation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginUser
            // 
            this.LoginUser.BackColor = System.Drawing.Color.DimGray;
            this.LoginUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginUser.FlatAppearance.BorderSize = 4;
            this.LoginUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.LoginUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.LoginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoginUser.Location = new System.Drawing.Point(81, 145);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(295, 70);
            this.LoginUser.TabIndex = 0;
            this.LoginUser.Text = "Login as user";
            this.LoginUser.UseMnemonic = false;
            this.LoginUser.UseVisualStyleBackColor = false;
            this.LoginUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginAdmin
            // 
            this.LoginAdmin.BackColor = System.Drawing.Color.DimGray;
            this.LoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAdmin.FlatAppearance.BorderSize = 4;
            this.LoginAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.LoginAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.LoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginAdmin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoginAdmin.Location = new System.Drawing.Point(81, 289);
            this.LoginAdmin.Name = "LoginAdmin";
            this.LoginAdmin.Size = new System.Drawing.Size(295, 70);
            this.LoginAdmin.TabIndex = 1;
            this.LoginAdmin.Text = "Login as admin";
            this.LoginAdmin.UseMnemonic = false;
            this.LoginAdmin.UseVisualStyleBackColor = false;
            this.LoginAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authorization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // simulation
            // 
            this.simulation.BackColor = System.Drawing.Color.DimGray;
            this.simulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulation.FlatAppearance.BorderSize = 4;
            this.simulation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.simulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.simulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simulation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.simulation.Location = new System.Drawing.Point(81, 419);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(295, 70);
            this.simulation.TabIndex = 3;
            this.simulation.Text = "simulation";
            this.simulation.UseMnemonic = false;
            this.simulation.UseVisualStyleBackColor = false;
            this.simulation.Click += new System.EventHandler(this.simulation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 535);
            this.Controls.Add(this.simulation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginAdmin);
            this.Controls.Add(this.LoginUser);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CatFedder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginUser;
        private System.Windows.Forms.Button LoginAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simulation;
    }
}

