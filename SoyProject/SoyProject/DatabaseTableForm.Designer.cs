namespace SoyProject
{
    partial class DatabaseTableForm
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
            this.LV_DBTable = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LV_DBTable
            // 
            this.LV_DBTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_DBTable.Location = new System.Drawing.Point(0, 0);
            this.LV_DBTable.Name = "LV_DBTable";
            this.LV_DBTable.Size = new System.Drawing.Size(816, 473);
            this.LV_DBTable.TabIndex = 0;
            this.LV_DBTable.UseCompatibleStateImageBehavior = false;
            // 
            // DatabaseTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 473);
            this.Controls.Add(this.LV_DBTable);
            this.Name = "DatabaseTableForm";
            this.Text = "DatabaseTableForm";
            this.Load += new System.EventHandler(this.DatabaseTableForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_DBTable;
    }
}