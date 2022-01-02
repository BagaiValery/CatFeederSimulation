
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
            this.food = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.dp = new System.Windows.Forms.TextBox();
            this.FullFeeder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.back1 = new System.Windows.Forms.Button();
            this.Feeders = new System.Windows.Forms.Label();
            this.mf = new System.Windows.Forms.Label();
            this.DayPortion = new System.Windows.Forms.Label();
            this.FeederSize = new System.Windows.Forms.Label();
            this.fs = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.food);
            this.panel1.Controls.Add(this.days);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Location = new System.Drawing.Point(191, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 294);
            this.panel1.TabIndex = 0;
            // 
            // food
            // 
            this.food.AutoSize = true;
            this.food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.food.Location = new System.Drawing.Point(26, 134);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(63, 20);
            this.food.TabIndex = 12;
            this.food.Text = "Food: 0";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days.Location = new System.Drawing.Point(26, 92);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(54, 20);
            this.days.TabIndex = 11;
            this.days.Text = "Day: 0";
            this.days.Click += new System.EventHandler(this.days_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(2, 177);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(58, 22);
            this.start.TabIndex = 5;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(73, 177);
            this.stop.Margin = new System.Windows.Forms.Padding(2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(58, 22);
            this.stop.TabIndex = 6;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // dp
            // 
            this.dp.Location = new System.Drawing.Point(431, 143);
            this.dp.Margin = new System.Windows.Forms.Padding(2);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(68, 20);
            this.dp.TabIndex = 1;
            // 
            // FullFeeder
            // 
            this.FullFeeder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FullFeeder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FullFeeder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FullFeeder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.FullFeeder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FullFeeder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullFeeder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullFeeder.Location = new System.Drawing.Point(-1, -2);
            this.FullFeeder.Margin = new System.Windows.Forms.Padding(2);
            this.FullFeeder.Name = "FullFeeder";
            this.FullFeeder.Size = new System.Drawing.Size(97, 41);
            this.FullFeeder.TabIndex = 1;
            this.FullFeeder.Text = "Пополнить кормушку";
            this.FullFeeder.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(-1, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(392, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // back1
            // 
            this.back1.Location = new System.Drawing.Point(441, 248);
            this.back1.Margin = new System.Windows.Forms.Padding(2);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(58, 22);
            this.back1.TabIndex = 9;
            this.back1.Text = "back";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back_Click);
            // 
            // Feeders
            // 
            this.Feeders.AutoSize = true;
            this.Feeders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Feeders.Location = new System.Drawing.Point(412, 30);
            this.Feeders.Name = "Feeders";
            this.Feeders.Size = new System.Drawing.Size(68, 20);
            this.Feeders.TabIndex = 12;
            this.Feeders.Text = "Feeders";
            // 
            // mf
            // 
            this.mf.AutoSize = true;
            this.mf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mf.Location = new System.Drawing.Point(388, 110);
            this.mf.Name = "mf";
            this.mf.Size = new System.Drawing.Size(118, 20);
            this.mf.TabIndex = 13;
            this.mf.Text = "Manual feeding";
            // 
            // DayPortion
            // 
            this.DayPortion.AutoSize = true;
            this.DayPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayPortion.Location = new System.Drawing.Point(329, 141);
            this.DayPortion.Name = "DayPortion";
            this.DayPortion.Size = new System.Drawing.Size(94, 20);
            this.DayPortion.TabIndex = 14;
            this.DayPortion.Text = "Day portion:";
            this.DayPortion.Click += new System.EventHandler(this.label1_Click);
            // 
            // FeederSize
            // 
            this.FeederSize.AutoSize = true;
            this.FeederSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeederSize.Location = new System.Drawing.Point(329, 189);
            this.FeederSize.Name = "FeederSize";
            this.FeederSize.Size = new System.Drawing.Size(96, 20);
            this.FeederSize.TabIndex = 15;
            this.FeederSize.Text = "Feeder size:";
            // 
            // fs
            // 
            this.fs.Location = new System.Drawing.Point(431, 191);
            this.fs.Margin = new System.Windows.Forms.Padding(2);
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(68, 20);
            this.fs.TabIndex = 16;
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.fs);
            this.Controls.Add(this.FeederSize);
            this.Controls.Add(this.DayPortion);
            this.Controls.Add(this.mf);
            this.Controls.Add(this.Feeders);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FullFeeder);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FullFeeder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dp;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button back1;
        private System.Windows.Forms.Label food;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label Feeders;
        private System.Windows.Forms.Label mf;
        private System.Windows.Forms.Label DayPortion;
        private System.Windows.Forms.Label FeederSize;
        private System.Windows.Forms.TextBox fs;
    }
}