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
            this.CB_Employees = new System.Windows.Forms.ComboBox();
            this.TxtBox_Quantity = new System.Windows.Forms.TextBox();
            this.Lbl_Quantity = new System.Windows.Forms.Label();
            this.Btn_SendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Employees
            // 
            this.CB_Employees.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Employees.FormattingEnabled = true;
            this.CB_Employees.Location = new System.Drawing.Point(107, 44);
            this.CB_Employees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_Employees.Name = "CB_Employees";
            this.CB_Employees.Size = new System.Drawing.Size(276, 42);
            this.CB_Employees.TabIndex = 0;
            // 
            // TxtBox_Quantity
            // 
            this.TxtBox_Quantity.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Quantity.Location = new System.Drawing.Point(258, 108);
            this.TxtBox_Quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBox_Quantity.Name = "TxtBox_Quantity";
            this.TxtBox_Quantity.Size = new System.Drawing.Size(125, 43);
            this.TxtBox_Quantity.TabIndex = 1;
            this.TxtBox_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.AutoSize = true;
            this.Lbl_Quantity.Font = new System.Drawing.Font("Microsoft JhengHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Quantity.Location = new System.Drawing.Point(103, 116);
            this.Lbl_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(151, 30);
            this.Lbl_Quantity.TabIndex = 2;
            this.Lbl_Quantity.Text = "Fjöldi flaskna";
            // 
            // Btn_SendData
            // 
            this.Btn_SendData.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SendData.Location = new System.Drawing.Point(107, 183);
            this.Btn_SendData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_SendData.Name = "Btn_SendData";
            this.Btn_SendData.Size = new System.Drawing.Size(275, 47);
            this.Btn_SendData.TabIndex = 3;
            this.Btn_SendData.Text = "Senda inn gögn";
            this.Btn_SendData.UseVisualStyleBackColor = true;
            // 
            // SoyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 335);
            this.Controls.Add(this.Btn_SendData);
            this.Controls.Add(this.Lbl_Quantity);
            this.Controls.Add(this.TxtBox_Quantity);
            this.Controls.Add(this.CB_Employees);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SoyForm";
            this.Text = "Soy";
            this.Load += new System.EventHandler(this.SoyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Employees;
        private System.Windows.Forms.TextBox TxtBox_Quantity;
        private System.Windows.Forms.Label Lbl_Quantity;
        private System.Windows.Forms.Button Btn_SendData;
    }
}

