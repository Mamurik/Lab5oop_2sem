using System;
using System.Windows;

namespace Lab5oop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки CalculateButton.
        /// </summary>
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем значения из TextBox'ов
                double a = Convert.ToDouble(AValueTextBox.Text);
                double b = Convert.ToDouble(BValueTextBox.Text);
                int n = Convert.ToInt32(NValueTextBox.Text);

                // Создаем экземпляр класса Integral
                Integral integral = new Integral();

                // Создаем делегат и передаем функцию
                FunctionDelegate function = Math.Sin;

                // Вычисляем интеграл
                double result = integral.Calculate(function, a, b, n);

                // Выводим результат
                ResultTextBlock.Text = $"Результат: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Проверьте правильность введенных значений.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ошибка ввода. Введено слишком большое значение.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    public delegate double FunctionDelegate(double x);
}