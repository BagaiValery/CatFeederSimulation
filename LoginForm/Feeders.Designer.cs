
namespace LoginForm
{
    partial class Feeders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feeders));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ReturnFromFeddersList = new System.Windows.Forms.Button();
            this.populateDG = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(533, 292);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ReturnFromFeddersList
            // 
            this.ReturnFromFeddersList.Location = new System.Drawing.Point(441, 0);
            this.ReturnFromFeddersList.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnFromFeddersList.Name = "ReturnFromFeddersList";
            this.ReturnFromFeddersList.Size = new System.Drawing.Size(92, 30);
            this.ReturnFromFeddersList.TabIndex = 1;
            this.ReturnFromFeddersList.Text = "Exit";
            this.ReturnFromFeddersList.UseVisualStyleBackColor = true;
            this.ReturnFromFeddersList.Click += new System.EventHandler(this.ReturnFromFeddersList_Click);
            // 
            // populateDG
            // 
            this.populateDG.Location = new System.Drawing.Point(410, 177);
            this.populateDG.Name = "populateDG";
            this.populateDG.Size = new System.Drawing.Size(75, 23);
            this.populateDG.TabIndex = 3;
            this.populateDG.Text = "Load";
            this.populateDG.UseVisualStyleBackColor = true;
            this.populateDG.Click += new System.EventHandler(this.populateDG_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 239);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Feeders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.populateDG);
            this.Controls.Add(this.ReturnFromFeddersList);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Feeders";
            this.Text = "Feeders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ReturnFromFeddersList;
        private System.Windows.Forms.Button populateDG;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}