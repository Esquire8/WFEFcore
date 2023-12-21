namespace WFEFcore
{
    partial class AddIncome
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
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxAdvancePay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(122, 72);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(140, 22);
            this.tbxSalary.TabIndex = 0;
            // 
            // tbxAdvancePay
            // 
            this.tbxAdvancePay.Location = new System.Drawing.Point(122, 119);
            this.tbxAdvancePay.Name = "tbxAdvancePay";
            this.tbxAdvancePay.Size = new System.Drawing.Size(140, 22);
            this.tbxAdvancePay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ЗП";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Аванс";
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(88, 183);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(152, 49);
            this.btnAddIncome.TabIndex = 4;
            this.btnAddIncome.Text = "Добавить";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 314);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAdvancePay);
            this.Controls.Add(this.tbxSalary);
            this.Name = "AddIncome";
            this.ShowIcon = false;
            this.Text = "AddIncome";
            this.Load += new System.EventHandler(this.AddIncome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.TextBox tbxAdvancePay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddIncome;
    }
}