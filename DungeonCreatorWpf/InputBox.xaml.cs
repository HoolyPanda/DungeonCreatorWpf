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
using System.Windows.Shapes;

namespace DungeonCreatorWpf
{
    /// <summary>
    /// Логика взаимодействия для InputBox.xaml
    /// </summary>
    public partial class InputBox : Window
    {
        public InputBox()
        {
            InitializeComponent();
        }
        public InputBox(string message)
        {
            InitializeComponent();
            this.Message.Text=message;
        }
        public string Answer;
        public bool YesWasPressed = false;
        public void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Answer=Data.Text;
            this.Close();
            YesWasPressed = true;
        }
        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
