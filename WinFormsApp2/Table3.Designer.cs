
namespace WinFormsApp2
{
    partial class Table3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table3));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recordDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.txtConData = new System.Windows.Forms.TextBox();
            this.txtDateAnt = new System.Windows.Forms.TextBox();
            this.txtNameTake = new System.Windows.Forms.TextBox();
            this.txtGiveit = new System.Windows.Forms.TextBox();
            this.txtGiveRec = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(338, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вставить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование поставщиков";
            // 
            // recordDataGridView
            // 
            this.recordDataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordDataGridView.Location = new System.Drawing.Point(12, 37);
            this.recordDataGridView.Name = "recordDataGridView";
            this.recordDataGridView.RowTemplate.Height = 25;
            this.recordDataGridView.Size = new System.Drawing.Size(704, 198);
            this.recordDataGridView.TabIndex = 4;
            this.recordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordDataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Контактные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата установки, Антивирусной ЛПО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Принял оборудование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сдал оборудование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сдал оборудование на ремонт";
            // 
            // txtNameP
            // 
            this.txtNameP.Location = new System.Drawing.Point(359, 253);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.Size = new System.Drawing.Size(100, 23);
            this.txtNameP.TabIndex = 10;
            // 
            // txtConData
            // 
            this.txtConData.Location = new System.Drawing.Point(359, 282);
            this.txtConData.Name = "txtConData";
            this.txtConData.Size = new System.Drawing.Size(100, 23);
            this.txtConData.TabIndex = 11;
            // 
            // txtDateAnt
            // 
            this.txtDateAnt.Location = new System.Drawing.Point(359, 311);
            this.txtDateAnt.Name = "txtDateAnt";
            this.txtDateAnt.Size = new System.Drawing.Size(100, 23);
            this.txtDateAnt.TabIndex = 12;
            // 
            // txtNameTake
            // 
            this.txtNameTake.Location = new System.Drawing.Point(359, 340);
            this.txtNameTake.Name = "txtNameTake";
            this.txtNameTake.Size = new System.Drawing.Size(100, 23);
            this.txtNameTake.TabIndex = 13;
            // 
            // txtGiveit
            // 
            this.txtGiveit.Location = new System.Drawing.Point(359, 369);
            this.txtGiveit.Name = "txtGiveit";
            this.txtGiveit.Size = new System.Drawing.Size(100, 23);
            this.txtGiveit.TabIndex = 14;
            // 
            // txtGiveRec
            // 
            this.txtGiveRec.Location = new System.Drawing.Point(359, 398);
            this.txtGiveRec.Name = "txtGiveRec";
            this.txtGiveRec.Size = new System.Drawing.Size(100, 23);
            this.txtGiveRec.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(434, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 16;
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
            this.button3.TabIndex = 17;
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
            this.button4.TabIndex = 18;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(12, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Меню";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Table3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 478);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGiveRec);
            this.Controls.Add(this.txtGiveit);
            this.Controls.Add(this.txtNameTake);
            this.Controls.Add(this.txtDateAnt);
            this.Controls.Add(this.txtConData);
            this.Controls.Add(this.txtNameP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Table3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table3";
            this.Load += new System.EventHandler(this.Table3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView recordDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameP;
        private System.Windows.Forms.TextBox txtConData;
        private System.Windows.Forms.TextBox txtDateAnt;
        private System.Windows.Forms.TextBox txtNameTake;
        private System.Windows.Forms.TextBox txtGiveit;
        private System.Windows.Forms.TextBox txtGiveRec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}