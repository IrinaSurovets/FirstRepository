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

namespace WpfApplication1
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            int m = ComboBox1.SelectedIndex;
            int n=ListBox1.Items.Count;
            int k=ListBox1.SelectedIndex;
            switch (m)
            {
                case 0:

                    ListBox1.Items.Add(ListBox1.Items + "");
                    for (int i = n - 1; i >= 0; i--)
                    {
                        ListBox1.Items[i + 1] = ListBox1.Items[i];
                    }

                    ListBox1.Items[0] = TextBox1.Text;
                    break;
                case 1:
                    ListBox1.Items.Add(TextBox1.Text);
                    break;
                case 2:

                    ListBox1.Items.Add(ListBox1.Items + "");
                    for (int i = n - 1; i >= k; i--)
                    {
                        ListBox1.Items[i + 1] = ListBox1.Items[i];
                    }

                    ListBox1.Items[k] = TextBox1.Text;
                    break;
                case 3:
                    ListBox1.Items.Add(ListBox1.Items + "");
                    for (int i = n - 1; i > k; i--)
                    {
                        ListBox1.Items[i + 1] = ListBox1.Items[i];
                    }

                    ListBox1.Items[k + 1] = TextBox1.Text;
                    break;
                default:
                    ListBox1.Items.Add(TextBox1.Text);
                    break;
            }
            TextBox1.Text = "";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int k = ListBox1.SelectedItems.Count;
            for (int i = k - 1; i >= 0; i--)
            {
                ListBox2.Items.Add(ListBox1.Items[i]);
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int k = ListBox2.SelectedItems.Count;
            for (int i = k - 1; i >= 0; i--)
            {
                ListBox1.Items.Add(ListBox2.Items[i]);
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int n = ListBox1.Items.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                ListBox2.Items.Add(ListBox1.Items[i]);
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            int n = ListBox2.Items.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                ListBox1.Items.Add(ListBox2.Items[i]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
        }

        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
