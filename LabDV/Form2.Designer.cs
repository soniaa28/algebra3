using System;
using System.Windows.Forms;

namespace LabDV
{
    partial class Form2
    {
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnSolveStrip;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.TextBox txtMatrixStrip;
        private System.Windows.Forms.TextBox txtVector;
        private System.Windows.Forms.TextBox txtVectorStrip;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtResultStrip;
        private System.Windows.Forms.Button btnLoadData1;
        private System.Windows.Forms.Button btnLoadData2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private void InitializeComponent()
        {
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnSolveStrip = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.txtMatrixStrip = new System.Windows.Forms.TextBox();
            this.txtVector = new System.Windows.Forms.TextBox();
            this.txtVectorStrip = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtResultStrip = new System.Windows.Forms.TextBox();
            this.btnLoadData1 = new System.Windows.Forms.Button();
            this.btnLoadData2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Location = new System.Drawing.Point(474, 194);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(124, 28);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Метод Гауса";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnSolveStrip
            // 
            this.btnSolveStrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolveStrip.Location = new System.Drawing.Point(474, 434);
            this.btnSolveStrip.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolveStrip.Name = "btnSolveStrip";
            this.btnSolveStrip.Size = new System.Drawing.Size(124, 28);
            this.btnSolveStrip.TabIndex = 2;
            this.btnSolveStrip.Text = "Метод Гауса";
            this.btnSolveStrip.UseVisualStyleBackColor = true;
            this.btnSolveStrip.Click += new System.EventHandler(this.btnSolveStrip_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(6, 43);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(200, 133);
            this.txtMatrix.TabIndex = 4;
            // 
            // txtMatrixStrip
            // 
            this.txtMatrixStrip.Location = new System.Drawing.Point(6, 279);
            this.txtMatrixStrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixStrip.Multiline = true;
            this.txtMatrixStrip.Name = "txtMatrixStrip";
            this.txtMatrixStrip.Size = new System.Drawing.Size(200, 137);
            this.txtMatrixStrip.TabIndex = 5;
            // 
            // txtVector
            // 
            this.txtVector.Location = new System.Drawing.Point(296, 58);
            this.txtVector.Multiline = true;
            this.txtVector.Name = "txtVector";
            this.txtVector.Size = new System.Drawing.Size(50, 118);
            this.txtVector.TabIndex = 3;
            // 
            // txtVectorStrip
            // 
            this.txtVectorStrip.Location = new System.Drawing.Point(296, 279);
            this.txtVectorStrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtVectorStrip.Multiline = true;
            this.txtVectorStrip.Name = "txtVectorStrip";
            this.txtVectorStrip.Size = new System.Drawing.Size(50, 137);
            this.txtVectorStrip.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(474, 58);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(124, 118);
            this.txtResult.TabIndex = 2;
            // 
            // txtResultStrip
            // 
            this.txtResultStrip.Location = new System.Drawing.Point(474, 279);
            this.txtResultStrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultStrip.Multiline = true;
            this.txtResultStrip.Name = "txtResultStrip";
            this.txtResultStrip.ReadOnly = true;
            this.txtResultStrip.Size = new System.Drawing.Size(124, 137);
            this.txtResultStrip.TabIndex = 3;
            // 
            // btnLoadData1
            // 
            this.btnLoadData1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData1.Location = new System.Drawing.Point(7, 197);
            this.btnLoadData1.Name = "btnLoadData1";
            this.btnLoadData1.Size = new System.Drawing.Size(199, 23);
            this.btnLoadData1.TabIndex = 0;
            this.btnLoadData1.Text = "Завантажити дані для матриці";
            this.btnLoadData1.UseVisualStyleBackColor = true;
            this.btnLoadData1.Click += new System.EventHandler(this.btnLoadData1_Click);
            // 
            // btnLoadData2
            // 
            this.btnLoadData2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData2.Location = new System.Drawing.Point(225, 197);
            this.btnLoadData2.Name = "btnLoadData2";
            this.btnLoadData2.Size = new System.Drawing.Size(193, 23);
            this.btnLoadData2.TabIndex = 0;
            this.btnLoadData2.Text = "Завантаження даних для вектору";
            this.btnLoadData2.UseVisualStyleBackColor = true;
            this.btnLoadData2.Click += new System.EventHandler(this.btnLoadData2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Files|*.txt";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(225, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Завантажити дані для вектору";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Завантажити дані для матриці ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Для звичайної матриці :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(221, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Для стрічкової матриці :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(648, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnSolveStrip);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtResultStrip);
            this.Controls.Add(this.txtVector);
            this.Controls.Add(this.txtVectorStrip);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.txtMatrixStrip);
            this.Controls.Add(this.btnLoadData1);
            this.Controls.Add(this.btnLoadData2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Linear Algebraic Equations Solver (Gaussian)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}
