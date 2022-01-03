
namespace LoginForm
{
    partial class LogsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsForm));
            this.listLogs = new System.Windows.Forms.ListView();
            this.ExportLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLogs
            // 
            this.listLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLogs.HideSelection = false;
            this.listLogs.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.listLogs.Margin = new System.Windows.Forms.Padding(2);
            this.listLogs.Name = "listLogs";
            this.listLogs.Size = new System.Drawing.Size(533, 292);
=======
            this.listLogs.Name = "listLogs";
            this.listLogs.Size = new System.Drawing.Size(800, 449);
>>>>>>> b189b043c66c6978c24ae75fd72cc21f0e9a1a32
            this.listLogs.TabIndex = 0;
            this.listLogs.UseCompatibleStateImageBehavior = false;
            this.listLogs.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ExportLogs
            // 
            this.ExportLogs.BackColor = System.Drawing.Color.DimGray;
            this.ExportLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportLogs.FlatAppearance.BorderSize = 4;
            this.ExportLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ExportLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ExportLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportLogs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
<<<<<<< HEAD
            this.ExportLogs.Location = new System.Drawing.Point(212, 128);
            this.ExportLogs.Margin = new System.Windows.Forms.Padding(2);
            this.ExportLogs.Name = "ExportLogs";
            this.ExportLogs.Size = new System.Drawing.Size(95, 64);
=======
            this.ExportLogs.Location = new System.Drawing.Point(646, 12);
            this.ExportLogs.Name = "ExportLogs";
            this.ExportLogs.Size = new System.Drawing.Size(142, 98);
>>>>>>> b189b043c66c6978c24ae75fd72cc21f0e9a1a32
            this.ExportLogs.TabIndex = 9;
            this.ExportLogs.Text = "Export";
            this.ExportLogs.UseMnemonic = false;
            this.ExportLogs.UseVisualStyleBackColor = false;
            this.ExportLogs.Click += new System.EventHandler(this.ExportLogs_Click);
            // 
            // LogsForm
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ExportLogs);
            this.Controls.Add(this.listLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.ExportLogs);
            this.Controls.Add(this.listLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
>>>>>>> b189b043c66c6978c24ae75fd72cc21f0e9a1a32
            this.Name = "LogsForm";
            this.Text = "LogsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listLogs;
        private System.Windows.Forms.Button ExportLogs;
    }
}