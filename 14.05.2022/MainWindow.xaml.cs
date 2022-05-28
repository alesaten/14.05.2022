using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _14._05._2022
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

        private void Input_textBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Input_textBox.Text = "";
            Input_textBox.Opacity = 1;
        }

        private void Output_button_Click(object sender, RoutedEventArgs e)
        {
            if ((Input_textBox.Text == "") || (Input_textBox.Text == "Введите текст"))
            {
                MessageBox.Show("Введите текст в текстовое поле.", "Предупреждение");
            }
            else
            {
                string InputToOutputText = Input_textBox.Text.ToString();

                Output_label.Opacity = 1;
                Output_label.Content = InputToOutputText;

                Input_textBox.Text = "";
            }
        }

        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            Input_textBox.Text = "";
            Output_label.Content = "";
        }
    }
}
