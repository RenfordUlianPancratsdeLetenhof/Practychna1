namespace Practychna1
{
    partial class array_odno
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
            this.exit_button_to_main = new System.Windows.Forms.Button();
            this.later_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.later_label = new System.Windows.Forms.Label();
            this.find_surenames_by_leter_button = new System.Windows.Forms.Button();
            this.surname_list_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button_to_main
            // 
            this.exit_button_to_main.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button_to_main.Location = new System.Drawing.Point(579, 368);
            this.exit_button_to_main.Name = "exit_button_to_main";
            this.exit_button_to_main.Size = new System.Drawing.Size(168, 70);
            this.exit_button_to_main.TabIndex = 0;
            this.exit_button_to_main.Text = "Повернутись на головну";
            this.exit_button_to_main.UseVisualStyleBackColor = true;
            this.exit_button_to_main.Click += new System.EventHandler(this.exit_button_to_main_Click);
            // 
            // later_textbox
            // 
            this.later_textbox.Location = new System.Drawing.Point(579, 22);
            this.later_textbox.Name = "later_textbox";
            this.later_textbox.Size = new System.Drawing.Size(100, 22);
            this.later_textbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surename});
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(354, 416);
            this.dataGridView1.TabIndex = 2;
            // 
            // surename
            // 
            this.surename.HeaderText = "Фамілії";
            this.surename.MinimumWidth = 6;
            this.surename.Name = "surename";
            this.surename.Width = 125;
            // 
            // later_label
            // 
            this.later_label.AutoSize = true;
            this.later_label.Location = new System.Drawing.Point(450, 22);
            this.later_label.Name = "later_label";
            this.later_label.Size = new System.Drawing.Size(50, 16);
            this.later_label.TabIndex = 3;
            this.later_label.Text = "Літера";
            // 
            // find_surenames_by_leter_button
            // 
            this.find_surenames_by_leter_button.Location = new System.Drawing.Point(453, 123);
            this.find_surenames_by_leter_button.Name = "find_surenames_by_leter_button";
            this.find_surenames_by_leter_button.Size = new System.Drawing.Size(226, 61);
            this.find_surenames_by_leter_button.TabIndex = 4;
            this.find_surenames_by_leter_button.Text = "Знайти за літерою";
            this.find_surenames_by_leter_button.UseVisualStyleBackColor = true;
            this.find_surenames_by_leter_button.Click += new System.EventHandler(this.find_surenames_by_leter_button_Click);
            // 
            // surname_list_label
            // 
            this.surname_list_label.AutoSize = true;
            this.surname_list_label.Location = new System.Drawing.Point(450, 55);
            this.surname_list_label.Name = "surname_list_label";
            this.surname_list_label.Size = new System.Drawing.Size(44, 16);
            this.surname_list_label.TabIndex = 5;
            this.surname_list_label.Text = "label1";
            // 
            // array_odno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.surname_list_label);
            this.Controls.Add(this.find_surenames_by_leter_button);
            this.Controls.Add(this.later_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.later_textbox);
            this.Controls.Add(this.exit_button_to_main);
            this.Name = "array_odno";
            this.Text = "array_odno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button_to_main;
        private System.Windows.Forms.TextBox later_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surename;
        private System.Windows.Forms.Label later_label;
        private System.Windows.Forms.Button find_surenames_by_leter_button;
        private System.Windows.Forms.Label surname_list_label;
    }
}