namespace Student_MS_0._1
{
    partial class PrintCourse
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
            this.button_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_print = new System.Windows.Forms.Button();
            this.DataGridView_student = new System.Windows.Forms.DataGridView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_search.Location = new System.Drawing.Point(759, 24);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(28, 27);
            this.button_search.TabIndex = 61;
            this.button_search.Text = "X";
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(381, 44);
            this.label7.TabIndex = 60;
            this.label7.Text = "Acadexa Course List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_print);
            this.panel3.Location = new System.Drawing.Point(0, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 75);
            this.panel3.TabIndex = 58;
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(629, 16);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(158, 36);
            this.button_print.TabIndex = 38;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            // 
            // DataGridView_student
            // 
            this.DataGridView_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.DataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_student.GridColor = System.Drawing.Color.White;
            this.DataGridView_student.Location = new System.Drawing.Point(11, 67);
            this.DataGridView_student.Name = "DataGridView_student";
            this.DataGridView_student.RowHeadersWidth = 51;
            this.DataGridView_student.RowTemplate.Height = 24;
            this.DataGridView_student.Size = new System.Drawing.Size(787, 419);
            this.DataGridView_student.TabIndex = 57;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox_search.Location = new System.Drawing.Point(531, 22);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(222, 27);
            this.textBox_search.TabIndex = 69;
            // 
            // PrintCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(813, 567);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DataGridView_student);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintCourse";
            this.Text = "PrintCourse";
            this.Load += new System.EventHandler(this.PrintCourse_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.DataGridView DataGridView_student;
        private System.Windows.Forms.TextBox textBox_search;
    }
}