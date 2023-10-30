namespace Practychna1
{
    partial class array_dvovimir
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
            this.exit_button_main = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.N_textBox = new System.Windows.Forms.TextBox();
            this.M_textBox = new System.Windows.Forms.TextBox();
            this.calculating = new System.Windows.Forms.Button();
            this.sum_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button_main
            // 
            this.exit_button_main.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button_main.Location = new System.Drawing.Point(794, 482);
            this.exit_button_main.Name = "exit_button_main";
            this.exit_button_main.Size = new System.Drawing.Size(167, 76);
            this.exit_button_main.TabIndex = 0;
            this.exit_button_main.Text = "Повернутись назад";
            this.exit_button_main.UseVisualStyleBackColor = true;
            this.exit_button_main.Click += new System.EventHandler(this.exit_button_main_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 546);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "M";
            // 
            // N_textBox
            // 
            this.N_textBox.Location = new System.Drawing.Point(630, 10);
            this.N_textBox.Name = "N_textBox";
            this.N_textBox.Size = new System.Drawing.Size(100, 22);
            this.N_textBox.TabIndex = 4;
            // 
            // M_textBox
            // 
            this.M_textBox.Location = new System.Drawing.Point(630, 58);
            this.M_textBox.Name = "M_textBox";
            this.M_textBox.Size = new System.Drawing.Size(100, 22);
            this.M_textBox.TabIndex = 5;
            // 
            // calculating
            // 
            this.calculating.Location = new System.Drawing.Point(588, 112);
            this.calculating.Name = "calculating";
            this.calculating.Size = new System.Drawing.Size(142, 23);
            this.calculating.TabIndex = 6;
            this.calculating.Text = "Розрахувати";
            this.calculating.UseVisualStyleBackColor = true;
            this.calculating.Click += new System.EventHandler(this.calculating_Click);
            // 
            // sum_label
            // 
            this.sum_label.AutoSize = true;
            this.sum_label.Location = new System.Drawing.Point(588, 195);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(41, 16);
            this.sum_label.TabIndex = 7;
            this.sum_label.Text = "Сума";
            // 
            // array_dvovimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 570);
            this.Controls.Add(this.sum_label);
            this.Controls.Add(this.calculating);
            this.Controls.Add(this.M_textBox);
            this.Controls.Add(this.N_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exit_button_main);
            this.Name = "array_dvovimir";
            this.Text = "array_dvovimir";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button_main;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox N_textBox;
        private System.Windows.Forms.TextBox M_textBox;
        private System.Windows.Forms.Button calculating;
        private System.Windows.Forms.Label sum_label;
    }
}