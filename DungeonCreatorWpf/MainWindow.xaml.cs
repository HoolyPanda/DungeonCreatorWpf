using System;
using System.Windows;
using System.IO;

namespace DungeonCreatorWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string DCDirectory;
        public MainWindow()
        {
            InitializeComponent();
            DCDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\DungeonCreator";
            if (Directory.Exists(DCDirectory))
            {
                CheckLocations(DCDirectory);
            }
            else
            {
                Directory.CreateDirectory(DCDirectory);
            }
        }
       public void CheckLocations(string dir)
       {
            List.Items.Clear();
            DirectoryInfo DirInfo = new DirectoryInfo(dir);
            DirectoryInfo[] Dirs = DirInfo.GetDirectories();
            foreach (DirectoryInfo SubDir in Dirs)
            {
                List.Items.Add(SubDir.Name);
            }
           
       }
        public void CreateNewLocation(object sender, RoutedEventArgs e)
        {
            //InputBox.Visibility = Visibility.Visible;
            //InputTextBox.Focus();
            Constructor NewDungeonConstrucktor = new Constructor();
            NewDungeonConstrucktor.Show();
            //Dungeon NewDungeon = new Dungeon();
        }
        public void YesButtonClick(object sender, RoutedEventArgs e)
        {
            if (InputTextBox.Text!="")
            {
                Directory.CreateDirectory(DCDirectory+"\\"+InputTextBox.Text);
            }
            InputTextBox.Text = "";
            CheckLocations(DCDirectory);
            InputBox.Visibility = Visibility.Collapsed;
        }
        public void NoButtonClick(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = "";
            InputBox.Visibility = Visibility.Collapsed;
        }

        private void List_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int Pos = List.SelectedIndex;
            if ((e.Key == System.Windows.Input.Key.Delete)&&(List.SelectedIndex!=-1))
            {
                string SelectedFolder = DCDirectory + "\\" + List.Items[Pos];
                Directory.Delete(SelectedFolder);
                CheckLocations(DCDirectory);
            }
        }
    }
}
