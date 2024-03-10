using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5oop
{
    /// <summary>
    /// Класс для вычисления интеграла.
    /// </summary>
    public class Integral
    {
        /// <summary>
        /// Метод для вычисления интеграла с использованием метода трапеций.
        /// </summary>
        /// <param name="function">Функция, подынтегральное выражение.</param>
        /// <param name="a">Нижний предел интегрирования.</param>
        /// <param name="b">Верхний предел интегрирования.</param>
        /// <param name="n">Количество разбиений.</param>
        /// <returns>Значение интеграла.</returns>
        public double Calculate(FunctionDelegate function, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double x0 = a + i * h;
                double x1 = a + (i + 1) * h;

                double y0 = function(x0);
                double y1 = function(x1);

                sum += (y0 + y1) * h / 2;
            }

            return sum;
        }
    }
}