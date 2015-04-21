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
            this.CB_Employees.Location = new System.Drawing.Point(161, 68);
            this.CB_Employees.Name = "CB_Employees";
            this.CB_Employees.Size = new System.Drawing.Size(412, 58);
            this.CB_Employees.TabIndex = 0;
            // 
            // TxtBox_Quantity
            // 
            this.TxtBox_Quantity.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Quantity.Location = new System.Drawing.Point(378, 166);
            this.TxtBox_Quantity.Name = "TxtBox_Quantity";
            this.TxtBox_Quantity.Size = new System.Drawing.Size(195, 61);
            this.TxtBox_Quantity.TabIndex = 1;
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.AutoSize = true;
            this.Lbl_Quantity.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Quantity.Location = new System.Drawing.Point(154, 179);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(173, 38);
            this.Lbl_Quantity.TabIndex = 2;
            this.Lbl_Quantity.Text = "Fjöldi flaska";
            // 
            // Btn_SendData
            // 
            this.Btn_SendData.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SendData.Location = new System.Drawing.Point(161, 281);
            this.Btn_SendData.Name = "Btn_SendData";
            this.Btn_SendData.Size = new System.Drawing.Size(412, 73);
            this.Btn_SendData.TabIndex = 3;
            this.Btn_SendData.Text = "Senda inn gögn";
            this.Btn_SendData.UseVisualStyleBackColor = true;
            // 
            // SoyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 516);
            this.Controls.Add(this.Btn_SendData);
            this.Controls.Add(this.Lbl_Quantity);
            this.Controls.Add(this.TxtBox_Quantity);
            this.Controls.Add(this.CB_Employees);
            this.Name = "SoyForm";
            this.Text = "Soy";
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

