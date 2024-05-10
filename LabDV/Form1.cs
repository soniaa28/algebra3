using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSwapData_Click(object sender, EventArgs e)
        {
            string temp = txtMatrix1.Text;
            txtMatrix1.Text = txtMatrix2.Text;
            txtMatrix2.Text = temp;
            string temp1 = txtVector1.Text;
            txtVector1.Text = txtVector2.Text;
            txtVector2.Text = temp1;
        }
        private void btnMaxNormMatrix_Click(object sender, EventArgs e)
        {
            Matrix A = ParseMatrix(txtMatrix1.Text);
            double maxNorm = A.MaxNorm();
            txtResult.Text = maxNorm.ToString();

        }
        private void btnEuclideanNormMatrix_Click(object sender, EventArgs e)
        {
            Matrix A = ParseMatrix(txtMatrix1.Text);
            double euclideanNorm = A.EuclideanNorm();
            txtResult.Text = euclideanNorm.ToString();

        }
        private void btnMaxNormVector_Click(object sender, EventArgs e)
        {
            Vector v = ParseVector(txtVector2.Text);
            double maxNorm = v.MaxNorm();
            txtResult.Text = maxNorm.ToString();

        }
        private void btnEuclideanNormVector_Click(object sender, EventArgs e)
        {
            Vector v = ParseVector(txtVector2.Text);
            double maxNorm = v.EuclideanNorm();
            txtResult.Text = maxNorm.ToString();

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

                        if (isSingleNumber && lines.Length == 1 && lines[0].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
                        {
                            txtNumber1.Text = lines[0];
                        }
                        else if (isVector)
                        {
                            txtVector1.Text = string.Join(Environment.NewLine, lines);
                        }
                        else
                        {
                            txtMatrix1.Text = string.Join(Environment.NewLine, lines);
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
                                break;
                            }
                        }

                        if (isSingleNumber && lines.Length == 1 && lines[0].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
                        {
                            txtNumber2.Text = lines[0];
                        }
                        else if (isVector)
                        {
                            txtVector2.Text = string.Join(Environment.NewLine, lines);
                        }
                        else
                        {
                            txtMatrix2.Text = string.Join(Environment.NewLine, lines);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: Не вдалося прочитати файл з диску. Помилка: {ex.Message}");
                }
            }
        }


        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {


                switch (comboBoxOperation.SelectedItem.ToString())
                {
                    case "MxV":
                        Matrix A = ParseMatrix(txtMatrix1.Text);
                        Vector v = ParseVector(txtVector2.Text);
                        Vector resultMatrixVector = A * v;
                        txtResult.Text = VectorToString(resultMatrixVector);
                        break;
                    case "VxM":
                        A = ParseMatrix(txtMatrix2.Text);
                        v = ParseVector(txtVector1.Text);
                        Vector resultVectorMatrix = v * A;
                        txtResult.Text = VectorToString(resultVectorMatrix);
                        break;
                    case "MxM":
                        A = ParseMatrix(txtMatrix1.Text);
                        Matrix B = ParseMatrix(txtMatrix2.Text);
                        Matrix resultMatrixMult = A * B;
                        txtResult.Text = MatrixToString(resultMatrixMult);
                        break;
                    case "M+M":
                        A = ParseMatrix(txtMatrix1.Text);
                        B = ParseMatrix(txtMatrix2.Text);
                        Matrix resultMatrixAdd = A + B;
                        txtResult.Text = MatrixToString(resultMatrixAdd);
                        break;
                    case "M-M":
                        A = ParseMatrix(txtMatrix1.Text);
                        B = ParseMatrix(txtMatrix2.Text);
                        Matrix resultMatrixSub = A - B;
                        txtResult.Text = MatrixToString(resultMatrixSub);
                        break;
                    case "VхV":
                        v = ParseVector(txtVector1.Text);
                        Vector k = ParseVector(txtVector2.Text);
                        double resultVectorMult = v * k;
                        txtResult.Text = resultVectorMult.ToString();
                        break;
                    case "V+V":
                        v = ParseVector(txtVector1.Text);
                        k = ParseVector(txtVector2.Text);
                        Vector resultVectorAdd = v + k;
                        txtResult.Text = VectorToString(resultVectorAdd);
                        break;
                    case "V-V":
                        v = ParseVector(txtVector1.Text);
                        k = ParseVector(txtVector2.Text);
                        Vector resultVectorSub = v - k;
                        txtResult.Text = VectorToString(resultVectorSub);
                        break;
                    case "NxM":
                        double n = double.Parse(txtNumber1.Text);
                        B = ParseMatrix(txtMatrix2.Text);
                        Matrix resultNumMatrix = B * n;
                        txtResult.Text = MatrixToString(resultNumMatrix);
                        break;
                    case "NxV":
                        n = double.Parse(txtNumber1.Text);
                        k = ParseVector(txtVector2.Text);
                        Vector resultNumVector = k * n;
                        txtResult.Text = VectorToString(resultNumVector);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnGausian_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void btnZeidel_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
     
        private string MatrixToString(Matrix matrix)
        {
            return string.Join(Environment.NewLine, Enumerable.Range(0, matrix.Rows).Select(row => string.Join(" ", Enumerable.Range(0, matrix.Cols).Select(col => matrix[row, col].ToString()))));
        }

        private string VectorToString(Vector vector)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < vector.Size; i++)
            {
                sb.AppendLine(vector[i].ToString());
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

        private void HideAllInputFields()
        {
            txtMatrix1.Visible = false;
            txtMatrix2.Visible = false;
            txtVector1.Visible = false;
            txtVector2.Visible = false;
            txtNumber1.Visible = false;
            txtNumber2.Visible = false;
            btnLoadData1.Visible = false;
            btnLoadData2.Visible = false;
            btnSwapData.Visible = false;
            btnEuclideanNormMatrix.Visible = false;
            btnEuclideanNormVector.Visible = false;
            btnMaxNormMatrix.Visible = false;
            btnMaxNormVector.Visible = false;
        }


    }
}
