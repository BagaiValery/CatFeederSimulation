﻿
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
            this.listLogs.Name = "listLogs";
            this.listLogs.Size = new System.Drawing.Size(800, 450);
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
            this.ExportLogs.Location = new System.Drawing.Point(0, 0);
            this.ExportLogs.Name = "ExportLogs";
            this.ExportLogs.Size = new System.Drawing.Size(114, 54);
            this.ExportLogs.TabIndex = 9;
            this.ExportLogs.Text = "Export";
            this.ExportLogs.UseMnemonic = false;
            this.ExportLogs.UseVisualStyleBackColor = false;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExportLogs);
            this.Controls.Add(this.listLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogsForm";
            this.Text = "LogsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listLogs;
        private System.Windows.Forms.Button ExportLogs;
    }
}