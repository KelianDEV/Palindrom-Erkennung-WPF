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

namespace Palindrom_Erkennung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public String TextBox1Text = "";
        public String TextBox1TextReverse = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckIfPalindrom_Click(object sender, RoutedEventArgs e)
        {

            char[] charArray = TextBox1Text.ToCharArray();
            Array.Reverse(charArray);
            TextBox1TextReverse = charArray.ToString();

            if (TextBox1Text.ToLower() == TextBox1TextReverse.ToLower())
            {
                IsPalindrom.Content = "Ist ein Palindrom";
            }
            else
            {
                IsPalindrom.Content = "Ist Kein Palindrom";
            }
        }
    }
}
