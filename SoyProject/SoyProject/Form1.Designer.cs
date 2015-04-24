namespace SoyProject
{
    partial class SoyForm
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
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.TxtBox_Quantity = new System.Windows.Forms.TextBox();
            this.Lbl_Quantity = new System.Windows.Forms.Label();
            this.CB_Employees = new System.Windows.Forms.ComboBox();
            this.Btn_ViewDB = new System.Windows.Forms.Button();
            this.Btn_SendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Lbl_Name.TabIndex = 18;
            this.Lbl_Name.Text = "Nafn";
            // 
            // TxtBox_Quantity
            // 
            this.TxtBox_Quantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBox_Quantity.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Quantity.Location = new System.Drawing.Point(0, 155);
            this.TxtBox_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBox_Quantity.Name = "TxtBox_Quantity";
            this.TxtBox_Quantity.Size = new System.Drawing.Size(561, 43);
            this.TxtBox_Quantity.TabIndex = 22;
            this.TxtBox_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.AutoSize = true;
            this.Lbl_Quantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Quantity.Font = new System.Drawing.Font("Microsoft JhengHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Quantity.Location = new System.Drawing.Point(0, 95);
            this.Lbl_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.Lbl_Quantity.Size = new System.Drawing.Size(151, 60);
            this.Lbl_Quantity.TabIndex = 21;
            this.Lbl_Quantity.Text = "Fjöldi flaskna";
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
            this.CB_Employees.Size = new System.Drawing.Size(561, 35);
            this.CB_Employees.TabIndex = 19;
            this.CB_Employees.SelectedIndexChanged += new System.EventHandler(this.CB_Employees_SelectedIndexChanged);
            // 
            // Btn_ViewDB
            // 
            this.Btn_ViewDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_ViewDB.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewDB.Location = new System.Drawing.Point(0, 298);
            this.Btn_ViewDB.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ViewDB.Name = "Btn_ViewDB";
            this.Btn_ViewDB.Size = new System.Drawing.Size(561, 67);
            this.Btn_ViewDB.TabIndex = 23;
            this.Btn_ViewDB.Text = "Skoða gagnagrunn";
            this.Btn_ViewDB.UseVisualStyleBackColor = true;
            this.Btn_ViewDB.Click += new System.EventHandler(this.Btn_ViewDB_Click);
            // 
            // Btn_SendData
            // 
            this.Btn_SendData.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SendData.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SendData.Location = new System.Drawing.Point(0, 198);
            this.Btn_SendData.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SendData.Name = "Btn_SendData";
            this.Btn_SendData.Size = new System.Drawing.Size(561, 64);
            this.Btn_SendData.TabIndex = 24;
            this.Btn_SendData.Text = "Senda inn gögn";
            this.Btn_SendData.UseVisualStyleBackColor = true;
            this.Btn_SendData.Click += new System.EventHandler(this.Btn_SendData_Click_1);
            // 
            // SoyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 365);
            this.Controls.Add(this.Btn_SendData);
            this.Controls.Add(this.Btn_ViewDB);
            this.Controls.Add(this.TxtBox_Quantity);
            this.Controls.Add(this.Lbl_Quantity);
            this.Controls.Add(this.CB_Employees);
            this.Controls.Add(this.Lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SoyForm";
            this.Text = "Soy";
            this.Load += new System.EventHandler(this.SoyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox TxtBox_Quantity;
        private System.Windows.Forms.Label Lbl_Quantity;
        private System.Windows.Forms.ComboBox CB_Employees;
        private System.Windows.Forms.Button Btn_ViewDB;
        private System.Windows.Forms.Button Btn_SendData;

    }
}

