namespace WFEFcore
{
    partial class MainForm
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
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxIncome = new System.Windows.Forms.GroupBox();
            this.groupBoxExpenses = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАккаунтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxIncome.SuspendLayout();
            this.groupBoxExpenses.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncome
            // 
            this.dgvIncome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(16, 30);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersWidth = 51;
            this.dgvIncome.RowTemplate.Height = 24;
            this.dgvIncome.Size = new System.Drawing.Size(1011, 96);
            this.dgvIncome.TabIndex = 0;
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Location = new System.Drawing.Point(85, 69);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(121, 24);
            this.cbxMonth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Месяц";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(20, 31);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowHeadersWidth = 51;
            this.dgvExpenses.RowTemplate.Height = 24;
            this.dgvExpenses.Size = new System.Drawing.Size(1011, 96);
            this.dgvExpenses.TabIndex = 3;
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(1048, 56);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(95, 46);
            this.btnIncome.TabIndex = 4;
            this.btnIncome.Text = "+ Доход";
            this.btnIncome.UseVisualStyleBackColor = true;
            // 
            // btnExpenses
            // 
            this.btnExpenses.Location = new System.Drawing.Point(1052, 60);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(95, 46);
            this.btnExpenses.TabIndex = 5;
            this.btnExpenses.Text = "+ Расход";
            this.btnExpenses.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1004, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "История операций";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // cbxDay
            // 
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(85, 106);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(121, 24);
            this.cbxDay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "День";
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(85, 33);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 24);
            this.cbxYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Год";
            // 
            // groupBoxIncome
            // 
            this.groupBoxIncome.Controls.Add(this.dgvIncome);
            this.groupBoxIncome.Controls.Add(this.btnIncome);
            this.groupBoxIncome.Location = new System.Drawing.Point(12, 48);
            this.groupBoxIncome.Name = "groupBoxIncome";
            this.groupBoxIncome.Size = new System.Drawing.Size(1169, 146);
            this.groupBoxIncome.TabIndex = 8;
            this.groupBoxIncome.TabStop = false;
            this.groupBoxIncome.Text = "Доходы";
            // 
            // groupBoxExpenses
            // 
            this.groupBoxExpenses.Controls.Add(this.dgvExpenses);
            this.groupBoxExpenses.Controls.Add(this.btnExpenses);
            this.groupBoxExpenses.Location = new System.Drawing.Point(12, 222);
            this.groupBoxExpenses.Name = "groupBoxExpenses";
            this.groupBoxExpenses.Size = new System.Drawing.Size(1169, 144);
            this.groupBoxExpenses.TabIndex = 9;
            this.groupBoxExpenses.TabStop = false;
            this.groupBoxExpenses.Text = "Расходы";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аккаунтToolStripMenuItem,
            this.приложениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАккаунтеToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            // 
            // обАккаунтеToolStripMenuItem
            // 
            this.обАккаунтеToolStripMenuItem.Name = "обАккаунтеToolStripMenuItem";
            this.обАккаунтеToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.обАккаунтеToolStripMenuItem.Text = "Об аккаунте";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // приложениеToolStripMenuItem
            // 
            this.приложениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem1});
            this.приложениеToolStripMenuItem.Name = "приложениеToolStripMenuItem";
            this.приложениеToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.приложениеToolStripMenuItem.Text = "Приложение";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 574);
            this.Controls.Add(this.groupBoxExpenses);
            this.Controls.Add(this.groupBoxIncome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxIncome.ResumeLayout(false);
            this.groupBoxExpenses.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxIncome;
        private System.Windows.Forms.GroupBox groupBoxExpenses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАккаунтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
    }
}