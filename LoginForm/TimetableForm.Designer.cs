
namespace LoginForm
{
    partial class TimetableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimetableForm));
            this.ExportTimeyable = new System.Windows.Forms.Button();
            this.ImportTimetable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportTimeyable
            // 
            this.ExportTimeyable.BackColor = System.Drawing.Color.DimGray;
            this.ExportTimeyable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportTimeyable.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExportTimeyable.FlatAppearance.BorderSize = 4;
            this.ExportTimeyable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ExportTimeyable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ExportTimeyable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportTimeyable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportTimeyable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExportTimeyable.Location = new System.Drawing.Point(0, 0);
            this.ExportTimeyable.Name = "ExportTimeyable";
            this.ExportTimeyable.Size = new System.Drawing.Size(112, 450);
            this.ExportTimeyable.TabIndex = 9;
            this.ExportTimeyable.Text = "Export";
            this.ExportTimeyable.UseMnemonic = false;
            this.ExportTimeyable.UseVisualStyleBackColor = false;
            // 
            // ImportTimetable
            // 
            this.ImportTimetable.BackColor = System.Drawing.Color.DimGray;
            this.ImportTimetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportTimetable.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImportTimetable.FlatAppearance.BorderSize = 4;
            this.ImportTimetable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ImportTimetable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ImportTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportTimetable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportTimetable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ImportTimetable.Location = new System.Drawing.Point(684, 0);
            this.ImportTimetable.Name = "ImportTimetable";
            this.ImportTimetable.Size = new System.Drawing.Size(116, 450);
            this.ImportTimetable.TabIndex = 10;
            this.ImportTimetable.Text = "Import";
            this.ImportTimetable.UseMnemonic = false;
            this.ImportTimetable.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monday});
            this.dataGridView1.Location = new System.Drawing.Point(118, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(560, 461);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Monday";
            this.Monday.MinimumWidth = 8;
            this.Monday.Name = "Monday";
            this.Monday.Width = 150;
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ImportTimetable);
            this.Controls.Add(this.ExportTimeyable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportTimeyable;
        private System.Windows.Forms.Button ImportTimetable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
    }
}