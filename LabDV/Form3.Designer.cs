using System;
using System.Windows.Forms;

namespace LabDV
{
    partial class Form3
    {
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.TextBox txtVector;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnLoadData1;
        private System.Windows.Forms.Button btnLoadData2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private void InitializeComponent()
        {
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.txtVector = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnLoadData1 = new System.Windows.Forms.Button();
            this.btnLoadData2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.txtInitialValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResidualNorm = new System.Windows.Forms.TextBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxIterations = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(64, 252);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(113, 28);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Метод Зейделя";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(27, 30);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(200, 100);
            this.txtMatrix.TabIndex = 4;
            // 
            // txtVector
            // 
            this.txtVector.Location = new System.Drawing.Point(282, 30);
            this.txtVector.Multiline = true;
            this.txtVector.Name = "txtVector";
            this.txtVector.Size = new System.Drawing.Size(38, 100);
            this.txtVector.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(545, 30);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(48, 102);
            this.txtResult.TabIndex = 2;
            // 
            // btnLoadData1
            // 
            this.btnLoadData1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData1.Location = new System.Drawing.Point(27, 136);
            this.btnLoadData1.Name = "btnLoadData1";
            this.btnLoadData1.Size = new System.Drawing.Size(199, 23);
            this.btnLoadData1.TabIndex = 0;
            this.btnLoadData1.Text = "Завантажити";
            this.btnLoadData1.UseVisualStyleBackColor = true;
            this.btnLoadData1.Click += new System.EventHandler(this.btnLoadData1_Click);
            // 
            // btnLoadData2
            // 
            this.btnLoadData2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData2.Location = new System.Drawing.Point(260, 136);
            this.btnLoadData2.Name = "btnLoadData2";
            this.btnLoadData2.Size = new System.Drawing.Size(87, 23);
            this.btnLoadData2.TabIndex = 0;
            this.btnLoadData2.Text = "Завантажити";
            this.btnLoadData2.UseVisualStyleBackColor = true;
            this.btnLoadData2.Click += new System.EventHandler(this.btnLoadData2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Files|*.txt";
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(27, 183);
            this.txtTolerance.Multiline = true;
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(74, 23);
            this.txtTolerance.TabIndex = 5;
            // 
            // txtInitialValues
            // 
            this.txtInitialValues.Location = new System.Drawing.Point(404, 30);
            this.txtInitialValues.Multiline = true;
            this.txtInitialValues.Name = "txtInitialValues";
            this.txtInitialValues.Size = new System.Drawing.Size(38, 100);
            this.txtInitialValues.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Точність:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Початкові наближення:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Матриця А";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вектор B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Норма нев\'язки:";
            // 
            // txtResidualNorm
            // 
            this.txtResidualNorm.Location = new System.Drawing.Point(260, 184);
            this.txtResidualNorm.Multiline = true;
            this.txtResidualNorm.Name = "txtResidualNorm";
            this.txtResidualNorm.ReadOnly = true;
            this.txtResidualNorm.Size = new System.Drawing.Size(78, 22);
            this.txtResidualNorm.TabIndex = 12;
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(629, 108);
            this.txtIterations.Multiline = true;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.ReadOnly = true;
            this.txtIterations.Size = new System.Drawing.Size(42, 24);
            this.txtIterations.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Макс. к-сть ітерацій:";
            // 
            // txtMaxIterations
            // 
            this.txtMaxIterations.Location = new System.Drawing.Point(134, 183);
            this.txtMaxIterations.Multiline = true;
            this.txtMaxIterations.Name = "txtMaxIterations";
            this.txtMaxIterations.Size = new System.Drawing.Size(74, 23);
            this.txtMaxIterations.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Метод простої ітерації";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSolve_Click2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Відповідь:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1012, 341);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxIterations);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.txtResidualNorm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInitialValues);
            this.Controls.Add(this.txtTolerance);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtVector);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.btnLoadData1);
            this.Controls.Add(this.btnLoadData2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Linear Algebraic Equations Solver (Zeidel)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtTolerance;
        private TextBox txtInitialValues;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtResidualNorm;
        private TextBox txtIterations;
        private Label label6;
        private TextBox txtMaxIterations;
        private Button button1;
        private Label label7;
    }
}
