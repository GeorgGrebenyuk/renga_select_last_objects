
namespace select_last_objects
{
    partial class Events_frame
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.action_clear = new System.Windows.Forms.Button();
            this.action_select = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.select_option_1 = new System.Windows.Forms.RadioButton();
            this.select_option_2 = new System.Windows.Forms.RadioButton();
            this.select_option_3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Форма с событиями со старта проекта";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(340, 237);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Очистить перечень событий";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 355);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(309, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/GeorgGrebenyuk/renga_select_last_objects";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выбрать отмеченные данные";
            // 
            // action_clear
            // 
            this.action_clear.Location = new System.Drawing.Point(200, 287);
            this.action_clear.Name = "action_clear";
            this.action_clear.Size = new System.Drawing.Size(75, 23);
            this.action_clear.TabIndex = 6;
            this.action_clear.Text = "Очистить";
            this.action_clear.UseVisualStyleBackColor = true;
            this.action_clear.Click += new System.EventHandler(this.action_clear_Click);
            // 
            // action_select
            // 
            this.action_select.Location = new System.Drawing.Point(16, 287);
            this.action_select.Name = "action_select";
            this.action_select.Size = new System.Drawing.Size(75, 23);
            this.action_select.TabIndex = 7;
            this.action_select.Text = "Выбрать";
            this.action_select.UseVisualStyleBackColor = true;
            this.action_select.Click += new System.EventHandler(this.action_select_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Параметры выбора объектов:";
            // 
            // select_option_1
            // 
            this.select_option_1.AutoSize = true;
            this.select_option_1.Checked = true;
            this.select_option_1.Location = new System.Drawing.Point(22, 334);
            this.select_option_1.Name = "select_option_1";
            this.select_option_1.Size = new System.Drawing.Size(114, 17);
            this.select_option_1.TabIndex = 9;
            this.select_option_1.TabStop = true;
            this.select_option_1.Text = "Только выделить";
            this.select_option_1.UseVisualStyleBackColor = true;
            this.select_option_1.CheckedChanged += new System.EventHandler(this.select_option_1_CheckedChanged);
            // 
            // select_option_2
            // 
            this.select_option_2.AutoSize = true;
            this.select_option_2.Location = new System.Drawing.Point(143, 334);
            this.select_option_2.Name = "select_option_2";
            this.select_option_2.Size = new System.Drawing.Size(63, 17);
            this.select_option_2.TabIndex = 10;
            this.select_option_2.TabStop = true;
            this.select_option_2.Text = "Скрыть";
            this.select_option_2.UseVisualStyleBackColor = true;
            this.select_option_2.CheckedChanged += new System.EventHandler(this.select_option_2_CheckedChanged);
            // 
            // select_option_3
            // 
            this.select_option_3.AutoSize = true;
            this.select_option_3.Location = new System.Drawing.Point(212, 334);
            this.select_option_3.Name = "select_option_3";
            this.select_option_3.Size = new System.Drawing.Size(92, 17);
            this.select_option_3.TabIndex = 11;
            this.select_option_3.TabStop = true;
            this.select_option_3.Text = "Изолировать";
            this.select_option_3.UseVisualStyleBackColor = true;
            this.select_option_3.CheckedChanged += new System.EventHandler(this.select_option_3_CheckedChanged);
            // 
            // Events_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(368, 377);
            this.Controls.Add(this.select_option_3);
            this.Controls.Add(this.select_option_2);
            this.Controls.Add(this.select_option_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.action_select);
            this.Controls.Add(this.action_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Events_frame";
            this.Text = "Выбор последних событий";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button action_clear;
        private System.Windows.Forms.Button action_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton select_option_1;
        private System.Windows.Forms.RadioButton select_option_2;
        private System.Windows.Forms.RadioButton select_option_3;
    }
}