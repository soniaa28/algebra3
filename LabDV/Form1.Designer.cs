using System;
using System.Windows.Forms;

namespace LabDV
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnLoadData1;
        private System.Windows.Forms.Button btnLoadData2;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtMatrix1;
        private System.Windows.Forms.TextBox txtMatrix2;
        private System.Windows.Forms.TextBox txtVector1;
        private System.Windows.Forms.TextBox txtVector2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSwapData;
        private System.Windows.Forms.Button btnMaxNormMatrix;
        private System.Windows.Forms.Button btnEuclideanNormMatrix;
        private System.Windows.Forms.Button btnMaxNormVector;
        private System.Windows.Forms.Button btnEuclideanNormVector;
        private System.Windows.Forms.Button btnGausian;
        private System.Windows.Forms.Button btnZeidel;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.btnLoadData1 = new System.Windows.Forms.Button();
            this.btnLoadData2 = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtMatrix1 = new System.Windows.Forms.TextBox();
            this.txtMatrix2 = new System.Windows.Forms.TextBox();
            this.txtVector1 = new System.Windows.Forms.TextBox();
            this.txtVector2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnSwapData = new System.Windows.Forms.Button();
            this.btnMaxNormMatrix = new System.Windows.Forms.Button();
            this.btnEuclideanNormMatrix = new System.Windows.Forms.Button();
            this.btnMaxNormVector = new System.Windows.Forms.Button();
            this.btnEuclideanNormVector = new System.Windows.Forms.Button();
            this.btnGausian = new System.Windows.Forms.Button();
            this.btnZeidel = new System.Windows.Forms.Button();
            this.btnParallel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "MxV",
            "VxM",
            "MxM",
            "M+M",
            "M-M",
            "VхV",
            "V+V",
            "V-V",
            "NxM",
            "NxV"});
            this.comboBoxOperation.Location = new System.Drawing.Point(293, 70);
            this.comboBoxOperation.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(141, 24);
            this.comboBoxOperation.TabIndex = 0;
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // btnLoadData1
            // 
            this.btnLoadData1.Location = new System.Drawing.Point(19, 167);
            this.btnLoadData1.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadData1.Name = "btnLoadData1";
            this.btnLoadData1.Size = new System.Drawing.Size(267, 28);
            this.btnLoadData1.TabIndex = 0;
            this.btnLoadData1.Text = "Load Data";
            this.btnLoadData1.UseVisualStyleBackColor = true;
            this.btnLoadData1.Click += new System.EventHandler(this.btnLoadData1_Click);
            // 
            // btnLoadData2
            // 
            this.btnLoadData2.Location = new System.Drawing.Point(444, 167);
            this.btnLoadData2.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadData2.Name = "btnLoadData2";
            this.btnLoadData2.Size = new System.Drawing.Size(267, 28);
            this.btnLoadData2.TabIndex = 0;
            this.btnLoadData2.Text = "Load Data";
            this.btnLoadData2.UseVisualStyleBackColor = true;
            this.btnLoadData2.Click += new System.EventHandler(this.btnLoadData2_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(293, 167);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(143, 28);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtMatrix1
            // 
            this.txtMatrix1.Location = new System.Drawing.Point(13, 34);
            this.txtMatrix1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatrix1.Multiline = true;
            this.txtMatrix1.Name = "txtMatrix1";
            this.txtMatrix1.Size = new System.Drawing.Size(265, 122);
            this.txtMatrix1.TabIndex = 2;
            // 
            // txtMatrix2
            // 
            this.txtMatrix2.Location = new System.Drawing.Point(446, 34);
            this.txtMatrix2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatrix2.Multiline = true;
            this.txtMatrix2.Name = "txtMatrix2";
            this.txtMatrix2.Size = new System.Drawing.Size(265, 122);
            this.txtMatrix2.TabIndex = 3;
            this.txtMatrix2.Visible = false;
            // 
            // txtVector1
            // 
            this.txtVector1.Location = new System.Drawing.Point(118, 34);
            this.txtVector1.Margin = new System.Windows.Forms.Padding(4);
            this.txtVector1.Multiline = true;
            this.txtVector1.Name = "txtVector1";
            this.txtVector1.Size = new System.Drawing.Size(85, 122);
            this.txtVector1.TabIndex = 4;
            // 
            // txtVector2
            // 
            this.txtVector2.Location = new System.Drawing.Point(530, 34);
            this.txtVector2.Margin = new System.Windows.Forms.Padding(4);
            this.txtVector2.Multiline = true;
            this.txtVector2.Name = "txtVector2";
            this.txtVector2.Size = new System.Drawing.Size(85, 122);
            this.txtVector2.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(757, 37);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(265, 122);
            this.txtResult.TabIndex = 6;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(83, 70);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber1.Multiline = true;
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(132, 61);
            this.txtNumber1.TabIndex = 7;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(497, 73);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber2.Multiline = true;
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(132, 61);
            this.txtNumber2.TabIndex = 8;
            this.txtNumber2.Visible = false;
            // 
            // btnSwapData
            // 
            this.btnSwapData.Location = new System.Drawing.Point(293, 106);
            this.btnSwapData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwapData.Name = "btnSwapData";
            this.btnSwapData.Size = new System.Drawing.Size(143, 28);
            this.btnSwapData.TabIndex = 9;
            this.btnSwapData.Text = "<-->";
            this.btnSwapData.UseVisualStyleBackColor = true;
            this.btnSwapData.Click += new System.EventHandler(this.btnSwapData_Click);
            // 
            // btnMaxNormMatrix
            // 
            this.btnMaxNormMatrix.Location = new System.Drawing.Point(57, 222);
            this.btnMaxNormMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxNormMatrix.Name = "btnMaxNormMatrix";
            this.btnMaxNormMatrix.Size = new System.Drawing.Size(158, 28);
            this.btnMaxNormMatrix.TabIndex = 10;
            this.btnMaxNormMatrix.Text = "MaxNormMatrix";
            this.btnMaxNormMatrix.UseVisualStyleBackColor = true;
            this.btnMaxNormMatrix.Click += new System.EventHandler(this.btnMaxNormMatrix_Click);
            // 
            // btnEuclideanNormMatrix
            // 
            this.btnEuclideanNormMatrix.Location = new System.Drawing.Point(57, 256);
            this.btnEuclideanNormMatrix.Name = "btnEuclideanNormMatrix";
            this.btnEuclideanNormMatrix.Size = new System.Drawing.Size(158, 35);
            this.btnEuclideanNormMatrix.TabIndex = 11;
            this.btnEuclideanNormMatrix.Text = "EuclideanNormMatrix";
            this.btnEuclideanNormMatrix.Click += new System.EventHandler(this.btnEuclideanNormMatrix_Click);
            // 
            // btnMaxNormVector
            // 
            this.btnMaxNormVector.Location = new System.Drawing.Point(497, 221);
            this.btnMaxNormVector.Name = "btnMaxNormVector";
            this.btnMaxNormVector.Size = new System.Drawing.Size(158, 29);
            this.btnMaxNormVector.TabIndex = 12;
            this.btnMaxNormVector.Text = "MaxNormVector";
            this.btnMaxNormVector.Click += new System.EventHandler(this.btnMaxNormVector_Click);
            // 
            // btnEuclideanNormVector
            // 
            this.btnEuclideanNormVector.Location = new System.Drawing.Point(497, 256);
            this.btnEuclideanNormVector.Name = "btnEuclideanNormVector";
            this.btnEuclideanNormVector.Size = new System.Drawing.Size(158, 35);
            this.btnEuclideanNormVector.TabIndex = 13;
            this.btnEuclideanNormVector.Text = "EuclideanNormVector";
            this.btnEuclideanNormVector.Click += new System.EventHandler(this.btnEuclideanNormVector_Click);
            // 
            // btnGausian
            // 
            this.btnGausian.Location = new System.Drawing.Point(820, 256);
            this.btnGausian.Name = "btnGausian";
            this.btnGausian.Size = new System.Drawing.Size(187, 54);
            this.btnGausian.TabIndex = 14;
            this.btnGausian.Text = "GausianSolver";
            this.btnGausian.Click += new System.EventHandler(this.btnGausian_Click);
            // 
            // btnZeidel
            // 
            this.btnZeidel.Location = new System.Drawing.Point(820, 325);
            this.btnZeidel.Name = "btnZeidel";
            this.btnZeidel.Size = new System.Drawing.Size(187, 54);
            this.btnZeidel.TabIndex = 15;
            this.btnZeidel.Text = "ZeidelSolver";
            this.btnZeidel.Click += new System.EventHandler(this.btnZeidel_Click);
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(614, 325);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(187, 54);
            this.btnParallel.TabIndex = 15;
            this.btnParallel.Text = "ParallelJacobi";
 
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Files|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 410);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.btnLoadData1);
            this.Controls.Add(this.btnLoadData2);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtMatrix1);
            this.Controls.Add(this.txtMatrix2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtVector1);
            this.Controls.Add(this.txtVector2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSwapData);
            this.Controls.Add(this.btnMaxNormMatrix);
            this.Controls.Add(this.btnMaxNormVector);
            this.Controls.Add(this.btnEuclideanNormMatrix);
            this.Controls.Add(this.btnEuclideanNormVector);
            this.Controls.Add(this.btnGausian);
            this.Controls.Add(this.btnZeidel);
            this.Controls.Add(this.btnParallel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Matrix Vector Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllInputFields();
            switch (comboBoxOperation.SelectedItem.ToString())
            {
                case "MxV":
                    txtMatrix1.Visible = true;
                    txtVector2.Visible = true;
                    btnLoadData1.Visible = true;
                    btnLoadData2.Visible = true;
                    btnEuclideanNormMatrix.Visible = true;
                    btnEuclideanNormVector.Visible = true;
                    btnMaxNormMatrix.Visible = true;
                    btnMaxNormVector.Visible = true;
                    break;
                case "VxM":
                    txtMatrix2.Visible = true;
                    txtVector1.Visible = true;
                    btnLoadData1.Visible = true;
                    btnLoadData2.Visible = true;
                    break;
                case "M+M":
                    txtMatrix1.Visible = true;
                    txtMatrix2.Visible = true;
                    btnLoadData1.Visible = true;
                    btnLoadData2.Visible = true;
                    btnSwapData.Visible = false;
                    break;
                case "MxM":
                case "M-M":
                    txtMatrix1.Visible = true;
                    txtMatrix2.Visible = true;
                    btnLoadData1.Visible = true;
                    btnLoadData2.Visible = true;
                    btnSwapData.Visible = true;
                    break;
                case "VхV":
                case "V+V":
                case "V-V":
                    txtVector1.Visible = true;
                    txtVector2.Visible = true;
                    btnLoadData1.Visible = true;
                    btnLoadData2.Visible = true;
                    btnSwapData.Visible = true;
                    break;
                case "NxM":
                    txtNumber1.Visible = true;
                    txtMatrix2.Visible = true;
                    btnLoadData2.Visible = true;
                    break;
                case "NxV":
                    txtNumber1.Visible = true;
                    txtVector2.Visible = true;
                    btnLoadData2.Visible = true; 
                    break;
            }
        }

    }
}

