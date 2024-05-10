using System;

namespace LabDV
{
    public class LinearEquationSolverGaussStrip
    {
        public static Vector SolveGaussStrip(StripMatrix A, Vector b)
        {
            // Отримуємо розмір матриці A
            int n = A.Rows;
            // Отримуємо ширину діагональних полос матриці A
            int lowerStripWidth = A.LowerStripWidth;
            int upperStripWidth = A.UpperStripWidth;

            // Прямий хід методу Гауса з частковим вибором
            for (int i = 0; i < n; i++)
            {
                // Перевіряємо, чи діагональний елемент ненульовий або майже нульовий
                if (Math.Abs(A[i, i]) < 1e-12)
                {
                    // Якщо так, кидаємо виняток
                    throw new Exception("Matrix is singular or nearly singular");
                }

                // Проходимося по всіх рядках нижче поточного
                for (int k = i + 1; k <= Math.Min(i + lowerStripWidth, n - 1); k++)
                {
                    // Обчислюємо коефіцієнт для виразу, який ми віднімаємо від кожного рядка
                    double coeff = A[k, i] / A[i, i];

                    // Проходимося по всіх стовпцях, які входять у діапазон
                    for (int j = Math.Max(i, k - upperStripWidth); j <= Math.Min(n - 1, i + upperStripWidth); j++)
                    {
                        // Віднімаємо від елементів рядка k коефіцієнт, помножений на відповідний елемент рядка i
                        A[k, j] -= A[i, j] * coeff;
                    }
                    // Віднімаємо від кожного елемента вектора b коефіцієнт, помножений на відповідний елемент рядка i
                    b[k] -= b[i] * coeff;
                }
            }

            // Зворотний хід методу Гауса
            Vector x = new Vector(n);
            for (int i = n - 1; i >= 0; i--)
            {
                // Обчислюємо значення x[i]
                x[i] = b[i];

                // Проходимося по всіх стовпцях праворуч від i, які входять у діапазон
                for (int j = i + 1; j <= Math.Min(n - 1, i + upperStripWidth); j++)
                {
                    // Віднімаємо від x[i] елементи, помножені на відповідні елементи рядка i
                    x[i] -= A[i, j] * x[j];
                }
                // Ділимо x[i] на діагональний елемент A[i, i]
                x[i] /= A[i, i];
            }

            // Повертаємо вектор розв'язків
            return x;
        }

    }
}
