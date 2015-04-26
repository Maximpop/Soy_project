namespace SoyProject
{
    partial class FilterDatabaseView
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
            this.Btn_FilterData = new System.Windows.Forms.Button();
            this.CB_Employees = new System.Windows.Forms.ComboBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.ChBox_UseDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_FilterData
            // 
            this.Btn_FilterData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_FilterData.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FilterData.Location = new System.Drawing.Point(0, 297);
            this.Btn_FilterData.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_FilterData.Name = "Btn_FilterData";
            this.Btn_FilterData.Size = new System.Drawing.Size(584, 64);
            this.Btn_FilterData.TabIndex = 29;
            this.Btn_FilterData.Text = "Sía gögn";
            this.Btn_FilterData.UseVisualStyleBackColor = true;
            this.Btn_FilterData.Click += new System.EventHandler(this.Btn_FilterData_Click);
            // 
            // CB_Employees
            // 
            this.CB_Employees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_Employees.Font = new System.Drawing.Font("MingLiU", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Employees.FormattingEnabled = true;
            this.CB_Employees.Location = new System.Drawing.Point(0, 60);
            this.CB_Employees.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Employees.Name = "CB_Employees";
            this.CB_Employees.Size = new System.Drawing.Size(584, 35);
            this.CB_Employees.TabIndex = 26;
            this.CB_Employees.SelectedIndexChanged += new System.EventHandler(this.CB_Employees_SelectedIndexChanged);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft JhengHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.Lbl_Name.Size = new System.Drawing.Size(65, 60);
            this.Lbl_Name.TabIndex = 25;
            this.Lbl_Name.Text = "Nafn";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Date.Font = new System.Drawing.Font("Microsoft JhengHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date.Location = new System.Drawing.Point(0, 95);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.Lbl_Date.Size = new System.Drawing.Size(138, 60);
            this.Lbl_Date.TabIndex = 30;
            this.Lbl_Date.Text = "Dagsetning";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTP_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.DTP_Date.Font = new System.Drawing.Font("Kozuka Mincho Pro M", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Date.Location = new System.Drawing.Point(0, 155);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(584, 61);
            this.DTP_Date.TabIndex = 31;
            // 
            // ChBox_UseDate
            // 
            this.ChBox_UseDate.AutoSize = true;
            this.ChBox_UseDate.Checked = true;
            this.ChBox_UseDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBox_UseDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChBox_UseDate.Font = new System.Drawing.Font("MingLiU", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBox_UseDate.Location = new System.Drawing.Point(0, 216);
            this.ChBox_UseDate.Name = "ChBox_UseDate";
            this.ChBox_UseDate.Size = new System.Drawing.Size(255, 81);
            this.ChBox_UseDate.TabIndex = 32;
            this.ChBox_UseDate.Text = "Nota dagsetningu";
            this.ChBox_UseDate.UseVisualStyleBackColor = true;
            this.ChBox_UseDate.CheckedChanged += new System.EventHandler(this.ChBox_UseDate_CheckedChanged);
            // 
            // FilterDatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ChBox_UseDate);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Btn_FilterData);
            this.Controls.Add(this.CB_Employees);
            this.Controls.Add(this.Lbl_Name);
            this.Name = "FilterDatabaseView";
            this.Text = "FilterDatabaseView";
            this.Load += new System.EventHandler(this.FilterDatabaseView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_FilterData;
        private System.Windows.Forms.ComboBox CB_Employees;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.CheckBox ChBox_UseDate;

    }
}