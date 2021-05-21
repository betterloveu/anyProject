
namespace WinFormsApp2
{
    partial class Table2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table2));
            this.menuButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recordDataGridView = new System.Windows.Forms.DataGridView();
            this.txtSystemMono = new System.Windows.Forms.TextBox();
            this.txtSystemBlock = new System.Windows.Forms.TextBox();
            this.txtWorkItem = new System.Windows.Forms.TextBox();
            this.comboWorkItem = new System.Windows.Forms.ComboBox();
            this.comboSystemStat = new System.Windows.Forms.ComboBox();
            this.comboCompStat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Location = new System.Drawing.Point(12, 8);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Меню";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertButton
            // 
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertButton.Location = new System.Drawing.Point(338, 431);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(90, 35);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Вставить";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(434, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(530, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сбросить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(626, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование оборудование ввода и вывода";
            // 
            // recordDataGridView
            // 
            this.recordDataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordDataGridView.Location = new System.Drawing.Point(12, 37);
            this.recordDataGridView.Name = "recordDataGridView";
            this.recordDataGridView.RowTemplate.Height = 25;
            this.recordDataGridView.Size = new System.Drawing.Size(704, 198);
            this.recordDataGridView.TabIndex = 7;
            this.recordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordDataGridView_CellClick);
            // 
            // txtSystemMono
            // 
            this.txtSystemMono.Location = new System.Drawing.Point(432, 401);
            this.txtSystemMono.Name = "txtSystemMono";
            this.txtSystemMono.Size = new System.Drawing.Size(100, 23);
            this.txtSystemMono.TabIndex = 8;
            // 
            // txtSystemBlock
            // 
            this.txtSystemBlock.Location = new System.Drawing.Point(432, 372);
            this.txtSystemBlock.Name = "txtSystemBlock";
            this.txtSystemBlock.Size = new System.Drawing.Size(100, 23);
            this.txtSystemBlock.TabIndex = 9;
            // 
            // txtWorkItem
            // 
            this.txtWorkItem.Location = new System.Drawing.Point(432, 285);
            this.txtWorkItem.Name = "txtWorkItem";
            this.txtWorkItem.Size = new System.Drawing.Size(100, 23);
            this.txtWorkItem.TabIndex = 10;
            // 
            // comboWorkItem
            // 
            this.comboWorkItem.FormattingEnabled = true;
            this.comboWorkItem.Items.AddRange(new object[] {
            "Клавиратура",
            "Мышь",
            "Веб-камера",
            "Микрофон",
            "Колонки"});
            this.comboWorkItem.Location = new System.Drawing.Point(432, 256);
            this.comboWorkItem.Name = "comboWorkItem";
            this.comboWorkItem.Size = new System.Drawing.Size(121, 23);
            this.comboWorkItem.TabIndex = 11;
            // 
            // comboSystemStat
            // 
            this.comboSystemStat.FormattingEnabled = true;
            this.comboSystemStat.Items.AddRange(new object[] {
            "Работает",
            "Не работает",
            "В ремонте",
            "На хранении в складе",
            "В ожидании отправки на ремонт"});
            this.comboSystemStat.Location = new System.Drawing.Point(432, 314);
            this.comboSystemStat.Name = "comboSystemStat";
            this.comboSystemStat.Size = new System.Drawing.Size(121, 23);
            this.comboSystemStat.TabIndex = 12;
            // 
            // comboCompStat
            // 
            this.comboCompStat.FormattingEnabled = true;
            this.comboCompStat.Items.AddRange(new object[] {
            "Работает",
            "Не работает",
            "В ремонте",
            "На хранении в складе",
            "В ожидании отправки на ремонт"});
            this.comboCompStat.Location = new System.Drawing.Point(432, 343);
            this.comboCompStat.Name = "comboCompStat";
            this.comboCompStat.Size = new System.Drawing.Size(121, 23);
            this.comboCompStat.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Наименование  оборудование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Статус системного блока ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Статус ноутбука/моноблока";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дата поставки, дата регистрации системного блока ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата поставки, дата регистрации ноутбука/моноблока ";
            // 
            // Table2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 478);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCompStat);
            this.Controls.Add(this.comboSystemStat);
            this.Controls.Add(this.comboWorkItem);
            this.Controls.Add(this.txtWorkItem);
            this.Controls.Add(this.txtSystemBlock);
            this.Controls.Add(this.txtSystemMono);
            this.Controls.Add(this.recordDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.menuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Table2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица 2";
            this.Load += new System.EventHandler(this.Table2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView recordDataGridView;
        private System.Windows.Forms.TextBox txtSystemMono;
        private System.Windows.Forms.TextBox txtSystemBlock;
        private System.Windows.Forms.TextBox txtWorkItem;
        private System.Windows.Forms.ComboBox comboWorkItem;
        private System.Windows.Forms.ComboBox comboSystemStat;
        private System.Windows.Forms.ComboBox comboCompStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}