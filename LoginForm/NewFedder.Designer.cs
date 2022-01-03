
namespace LoginForm
{
    partial class NewFedder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFedder));
            this.NewFeederName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.nameFeeder = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewFeederName
            // 
            this.NewFeederName.Location = new System.Drawing.Point(125, 177);
            this.NewFeederName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewFeederName.Name = "NewFeederName";
            this.NewFeederName.Size = new System.Drawing.Size(272, 20);
            this.NewFeederName.TabIndex = 0;
            
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 65);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write new fedder name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(205, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.creat_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(123, 98);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 13);
            this.answer.TabIndex = 3;
            this.answer.Click += new System.EventHandler(this.label2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(123, 111);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 4;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(417, 246);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 20);
            this.back.TabIndex = 5;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // nameFeeder
            // 
            this.nameFeeder.AutoSize = true;
            this.nameFeeder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameFeeder.Location = new System.Drawing.Point(15, 177);
            this.nameFeeder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameFeeder.Name = "nameFeeder";
            this.nameFeeder.Size = new System.Drawing.Size(99, 20);
            this.nameFeeder.TabIndex = 6;
            this.nameFeeder.Text = "name feeder";
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(218, 111);
            this.userList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(82, 21);
            this.userList.TabIndex = 7;
            this.userList.DropDown += new System.EventHandler(this.userList_DropDown);
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(152, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "user";
            // 
            // NewFedder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.nameFeeder);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewFeederName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewFedder";
            this.Text = "NewFedder";
            this.Load += new System.EventHandler(this.NewFedder_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewFeederName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label nameFeeder;
        private System.Windows.Forms.ComboBox userList;
        private System.Windows.Forms.Label label2;
    }
}