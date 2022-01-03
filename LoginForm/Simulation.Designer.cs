
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fs = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.FeederSize = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.DayPortion = new System.Windows.Forms.Label();
            this.dp = new System.Windows.Forms.TextBox();
            this.FullFeeder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.feedersList = new System.Windows.Forms.ComboBox();
            this.back1 = new System.Windows.Forms.Button();
            this.Feeders = new System.Windows.Forms.Label();
            this.mf = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Faster = new System.Windows.Forms.Button();
            this.Slower = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.TextBox();
            this.ManualFeeding = new System.Windows.Forms.TextBox();
            this.FeedNow = new System.Windows.Forms.Button();
            this.portion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.fs);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.FeederSize);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.DayPortion);
            this.panel1.Controls.Add(this.dp);
            this.panel1.Controls.Add(this.FullFeeder);
            this.panel1.Location = new System.Drawing.Point(286, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 322);
            this.panel1.TabIndex = 0;
            // 
            // fs
            // 
            this.fs.Location = new System.Drawing.Point(115, 159);
            this.fs.Margin = new System.Windows.Forms.Padding(2);
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(68, 26);
            this.fs.TabIndex = 16;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(28, 252);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(87, 34);
            this.start.TabIndex = 5;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // FeederSize
            // 
            this.FeederSize.AutoSize = true;
            this.FeederSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeederSize.Location = new System.Drawing.Point(26, 159);
            this.FeederSize.Name = "FeederSize";
            this.FeederSize.Size = new System.Drawing.Size(73, 29);
            this.FeederSize.TabIndex = 15;
            this.FeederSize.Text = "Bowl:";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(142, 252);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(87, 34);
            this.stop.TabIndex = 6;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // DayPortion
            // 
            this.DayPortion.AutoSize = true;
            this.DayPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayPortion.Location = new System.Drawing.Point(23, 92);
            this.DayPortion.Name = "DayPortion";
            this.DayPortion.Size = new System.Drawing.Size(76, 29);
            this.DayPortion.TabIndex = 14;
            this.DayPortion.Text = "Food:";
            this.DayPortion.Click += new System.EventHandler(this.label1_Click);
            // 
            // dp
            // 
            this.dp.Location = new System.Drawing.Point(115, 95);
            this.dp.Margin = new System.Windows.Forms.Padding(2);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(68, 26);
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
            this.FullFeeder.Location = new System.Drawing.Point(56, 3);
            this.FullFeeder.Name = "FullFeeder";
            this.FullFeeder.Size = new System.Drawing.Size(149, 69);
            this.FullFeeder.TabIndex = 1;
            this.FullFeeder.Text = "Пополнить кормушку";
            this.FullFeeder.UseVisualStyleBackColor = false;
            this.FullFeeder.Click += new System.EventHandler(this.FullFeeder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(-2, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // feedersList
            // 
            this.feedersList.FormattingEnabled = true;
            this.feedersList.Location = new System.Drawing.Point(598, 84);
            this.feedersList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedersList.Name = "feedersList";
            this.feedersList.Size = new System.Drawing.Size(235, 28);
            this.feedersList.TabIndex = 8;
            this.feedersList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // back1
            // 
            this.back1.Location = new System.Drawing.Point(758, 385);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(87, 34);
            this.back1.TabIndex = 9;
            this.back1.Text = "back";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back_Click);
            // 
            // Feeders
            // 
            this.Feeders.AutoSize = true;
            this.Feeders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Feeders.Location = new System.Drawing.Point(662, 50);
            this.Feeders.Name = "Feeders";
            this.Feeders.Size = new System.Drawing.Size(104, 29);
            this.Feeders.TabIndex = 12;
            this.Feeders.Text = "Feeders";
            // 
            // mf
            // 
            this.mf.AutoSize = true;
            this.mf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mf.Location = new System.Drawing.Point(50, 200);
            this.mf.Name = "mf";
            this.mf.Size = new System.Drawing.Size(178, 29);
            this.mf.TabIndex = 13;
            this.mf.Text = "Manual feeding";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Faster
            // 
            this.Faster.Location = new System.Drawing.Point(295, 348);
            this.Faster.Name = "Faster";
            this.Faster.Size = new System.Drawing.Size(106, 39);
            this.Faster.TabIndex = 14;
            this.Faster.Text = "Faster";
            this.Faster.UseVisualStyleBackColor = true;
            this.Faster.Click += new System.EventHandler(this.Faster_Click);
            // 
            // Slower
            // 
            this.Slower.Location = new System.Drawing.Point(428, 348);
            this.Slower.Name = "Slower";
            this.Slower.Size = new System.Drawing.Size(94, 39);
            this.Slower.TabIndex = 15;
            this.Slower.Text = "Slower";
            this.Slower.UseVisualStyleBackColor = true;
            this.Slower.Click += new System.EventHandler(this.Slower_Click);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(-2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(134, 26);
            this.Time.TabIndex = 17;
            // 
            // ManualFeeding
            // 
            this.ManualFeeding.Location = new System.Drawing.Point(32, 256);
            this.ManualFeeding.Name = "ManualFeeding";
            this.ManualFeeding.Size = new System.Drawing.Size(100, 26);
            this.ManualFeeding.TabIndex = 18;
            // 
            // FeedNow
            // 
            this.FeedNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FeedNow.Location = new System.Drawing.Point(153, 250);
            this.FeedNow.Name = "FeedNow";
            this.FeedNow.Size = new System.Drawing.Size(105, 39);
            this.FeedNow.TabIndex = 19;
            this.FeedNow.Text = "FeedNow";
            this.FeedNow.UseVisualStyleBackColor = false;
            this.FeedNow.Click += new System.EventHandler(this.FeedNow_Click);
            // 
            // portion
            // 
            this.portion.Location = new System.Drawing.Point(714, 186);
            this.portion.Name = "portion";
            this.portion.Size = new System.Drawing.Size(100, 26);
            this.portion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Portion";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portion);
            this.Controls.Add(this.FeedNow);
            this.Controls.Add(this.ManualFeeding);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Slower);
            this.Controls.Add(this.Faster);
            this.Controls.Add(this.mf);
            this.Controls.Add(this.Feeders);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.feedersList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ComboBox feedersList;
        private System.Windows.Forms.Button back1;
        private System.Windows.Forms.Label Feeders;
        private System.Windows.Forms.Label mf;
        private System.Windows.Forms.Label DayPortion;
        private System.Windows.Forms.Label FeederSize;
        private System.Windows.Forms.TextBox fs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Faster;
        private System.Windows.Forms.Button Slower;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox ManualFeeding;
        private System.Windows.Forms.Button FeedNow;
        private System.Windows.Forms.TextBox portion;
        private System.Windows.Forms.Label label1;
    }
}