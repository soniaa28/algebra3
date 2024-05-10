using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDV
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix A = ParseMatrix(txtMatrix.Text);
                Vector b = ParseVector(txtVector.Text);
                double tolerance = double.Parse(txtTolerance.Text); 
                int maxIterations = int.Parse(txtMaxIterations.Text); 
                Vector initialValues = ParseVector(txtInitialValues.Text);

                (Vector solution, int iterations, double residualNorm) = LinearEquationSolverZeidel.SolveZeidel(A, b, initialValues, tolerance, maxIterations);

                txtResult.Text = VectorToString(solution);
                txtIterations.Text = iterations.ToString(); 
                txtResidualNorm.Text = residualNorm.ToString("F8"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSolve_Click2(object sender, EventArgs e)
        {
            try
            {
                Matrix A = ParseMatrix(txtMatrix.Text);
                Vector b = ParseVector(txtVector.Text);
                double tolerance = double.Parse(txtTolerance.Text);
                int maxIterations = int.Parse(txtMaxIterations.Text);
                Vector initialValues = ParseVector(txtInitialValues.Text);

                (Vector solution, int iterations, double residualNorm) = LinearEquationSolverSimpleIteration.SolveSimpleIteration(A, b, initialValues, tolerance, maxIterations);

                txtResult.Text = VectorToString(solution);
                txtIterations.Text = iterations.ToString();
                txtResidualNorm.Text = residualNorm.ToString("F8");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLoadData1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    if (lines.Length > 0)
                    {
                        bool isSingleNumber = true;
                        bool isVector = true;

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                            if (parts.Length > 1)
                            {
                                isVector = false;
                                break;
                            }
                            if (lines.Length > 1)
                            {
                                isSingleNumber = false;
                            }
                        }


                        if (isVector)
                        {
                            txtVector.Text = string.Join(Environment.NewLine, lines);
                        }
                        else
                        {
                            txtMatrix.Text = string.Join(Environment.NewLine, lines);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: Не вдалося прочитати файл з диску. Помилка: {ex.Message}");
                }
            }
        }

        private void btnLoadData2_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    if (lines.Length > 0)
                    {
                        bool isSingleNumber = true;
                        bool isVector = true;

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                            if (parts.Length > 1)
                            {
                                isVector = false;
                                break;
                            }
                            if (lines.Length > 1)
                            {
                                isSingleNumber = false;
                            }
                        }

                        if (isVector)
                        {
                            txtVector.Text = string.Join(Environment.NewLine, lines);
                        }
                        else
                        {
                            txtMatrix.Text = string.Join(Environment.NewLine, lines);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: Не вдалося прочитати файл з диску. Помилка: {ex.Message}");
                }
            }
        }
        private string VectorToString(Vector vector)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < vector.Size; i++)
            {
                sb.AppendLine(String.Format("{0:F2}", vector[i]));
            }
            return sb.ToString().TrimEnd();
        }
        private Matrix ParseMatrix(string text)
        {
            string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Matrix matrix = new Matrix(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                string[] nums = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = double.Parse(nums[j]);
                }
            }

            return matrix;
        }

        private Vector ParseVector(string text)
        {
            string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Vector vector = new Vector(lines.Length);
            for (int i = 0; i < lines.Length; i++)
            {
                vector[i] = double.Parse(lines[i].Trim());
            }
            return vector;
        }

    
    }
}
