﻿namespace proyecto1
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            Suma = new DataGridViewTextBoxColumn();
            Multipplicacion = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Suma, Multipplicacion, Total });
            dataGridView1.Location = new Point(158, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 275);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 64);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "digame un valor";
            // 
            // button1
            // 
            button1.Location = new Point(486, 61);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 3;
            button1.Text = "ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Suma
            // 
            Suma.HeaderText = "suma";
            Suma.Name = "Suma";
            // 
            // Multipplicacion
            // 
            Multipplicacion.HeaderText = "multiplicacion";
            Multipplicacion.Name = "Multipplicacion";
            // 
            // Total
            // 
            Total.HeaderText = "total";
            Total.Name = "Total";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn Suma;
        private DataGridViewTextBoxColumn Multipplicacion;
        private Button button1;
        private DataGridViewTextBoxColumn Total;
    }
}