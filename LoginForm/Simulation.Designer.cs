
namespace LoginForm
{
    partial class Simulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FullFeeder = new System.Windows.Forms.Button();
            this.mew = new System.Windows.Forms.Button();
            this.FeddersList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(287, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 453);
            this.panel1.TabIndex = 0;
            // 
            // FullFeeder
            // 
            this.FullFeeder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FullFeeder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FullFeeder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.FullFeeder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FullFeeder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullFeeder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullFeeder.Location = new System.Drawing.Point(-1, -3);
            this.FullFeeder.Name = "FullFeeder";
            this.FullFeeder.Size = new System.Drawing.Size(146, 63);
            this.FullFeeder.TabIndex = 1;
            this.FullFeeder.Text = "Пополнить кормушку";
            this.FullFeeder.UseVisualStyleBackColor = false;
            // 
            // mew
            // 
            this.mew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.mew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mew.Location = new System.Drawing.Point(581, 170);
            this.mew.Name = "mew";
            this.mew.Size = new System.Drawing.Size(136, 71);
            this.mew.TabIndex = 2;
            this.mew.Text = "mew";
            this.mew.UseVisualStyleBackColor = true;
            // 
            // FeddersList
            // 
            this.FeddersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FeddersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeddersList.Location = new System.Drawing.Point(694, -3);
            this.FeddersList.Name = "FeddersList";
            this.FeddersList.Size = new System.Drawing.Size(106, 38);
            this.FeddersList.TabIndex = 3;
            this.FeddersList.Text = "Feeders";
            this.FeddersList.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(-1, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FeddersList);
            this.Controls.Add(this.mew);
            this.Controls.Add(this.FullFeeder);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FullFeeder;
        private System.Windows.Forms.Button mew;
        private System.Windows.Forms.Button FeddersList;
        private System.Windows.Forms.Button button1;
    }
}