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

namespace WpfApp_WordsInText
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

        private void splitBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] words = inpTextSp.Text.Split(' ');
            listBox.Items.Clear();
            foreach (var item in words)
            {
                listBox.Items.Add(item);
            }
        }

        private void reverseBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] words = inpTextRv.Text.Split(' ');
            if (words.Length > 0)
            {
                StringBuilder sb = new StringBuilder(words[words.Length - 1]);
                for (int i = words.Length - 1; i > 0; i--) 
                {
                    sb.Append(" " + words[i - 1]);
                }
                label.Content = sb.ToString();
            }
            else
            {
                label.Content = "";
            }
        }
    }
}
