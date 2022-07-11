using System;
using System.Collections;
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

namespace HashTableApp_HW._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void KeyBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void ValueBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(KeyBox.Text,ValueBox.Text);
            KeyBox.Text = "Key";
            ValueBox.Text = "Value";
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(KeyBox.Text);
            KeyBox.Text = "Key";
            ValueBox.Text = "Value";
        }

        private void ShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            KeyBox.Text = "Key";
            ValueBox.Text = "Value";
            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }

        private void KeyBox_GotFocus(object sender, RoutedEventArgs e)
        {
            KeyBox.Text = "";
        }

        

        private void ValueBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ValueBox.Text = "";
        }

     
    }
}
