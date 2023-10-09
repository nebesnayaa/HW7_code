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

namespace HW7_code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string correct_password = "12345";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string digit = button.Content.ToString();

            codeTextBox.Text += digit;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            codeTextBox.Clear();
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            if (isCorrect(codeTextBox.Text))
            {
                MessageBox.Show("The safe was opened successfully!");
            }
            else
            {
                MessageBox.Show("The code is wrong :(");
            }
        }

        private bool isCorrect(string code)
        {
            if (code == correct_password)
                return true;
            return false;
        }
    }
}
