
namespace LoginForm
{
    partial class ManualHandlingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualHandlingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.feeders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Enter1 = new System.Windows.Forms.Button();
            this.food1 = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.Label();
            this.back1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hand fedding";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feeders
            // 
            this.feeders.FormattingEnabled = true;
            this.feeders.Location = new System.Drawing.Point(105, 221);
            this.feeders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feeders.Name = "feeders";
            this.feeders.Size = new System.Drawing.Size(313, 21);
            this.feeders.TabIndex = 2;
            this.feeders.SelectedIndexChanged += new System.EventHandler(this.feeders_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "How mush?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose feeder";
            // 
            // Enter1
            // 
            this.Enter1.Location = new System.Drawing.Point(228, 332);
            this.Enter1.Name = "Enter1";
            this.Enter1.Size = new System.Drawing.Size(75, 23);
            this.Enter1.TabIndex = 5;
            this.Enter1.Text = "Enter";
            this.Enter1.UseVisualStyleBackColor = true;
            this.Enter1.Click += new System.EventHandler(this.Enter_Click);
            // 
            // food1
            // 
            this.food1.Location = new System.Drawing.Point(105, 167);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(313, 20);
            this.food1.TabIndex = 6;
            this.food1.Text = "g";
            this.food1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food1.TextChanged += new System.EventHandler(this.food1_TextChanged);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(248, 278);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 13);
            this.answer.TabIndex = 7;
            // 
            // back1
            // 
            this.back1.Location = new System.Drawing.Point(453, 269);
            this.back1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(58, 22);
            this.back1.TabIndex = 10;
            this.back1.Text = "back";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back1_Click);
            // 
            // ManualHandlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 401);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.food1);
            this.Controls.Add(this.Enter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feeders);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManualHandlingForm";
            this.Text = "ManualHandlingForm";
            this.Load += new System.EventHandler(this.ManualHandlingForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox feeders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Enter1;
        private System.Windows.Forms.TextBox food1;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button back1;
    }
}