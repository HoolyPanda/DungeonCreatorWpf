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
            DCDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DungeonCreator";
            if (Directory.Exists(DCDirectory))
            {
                CheckLocations(DCDirectory);
            }
            else
            {
                Directory.CreateDirectory(DCDirectory);
            }
            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DungeonCreator");
            foreach (DirectoryInfo subdir in dir.GetDirectories())
            {
                LocationList.Items.Add(subdir.Name);
            }
        }
       public void CheckLocations(string dir)
       {
            LocationList.Items.Clear();
            DirectoryInfo DirInfo = new DirectoryInfo(dir);
            DirectoryInfo[] Dirs = DirInfo.GetDirectories();
            foreach (DirectoryInfo SubDir in Dirs)
            {
                LocationList.Items.Add(SubDir.Name);
            }
           
       }
        public void CreateNewLocation(object sender, RoutedEventArgs e)
        {
            InputBox InBox = new InputBox("Введите новое название локации");
            InBox.ShowDialog();
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DungeonCreator\\"+InBox.Answer);
            LocationList.Items.Add(InBox.Answer);
           
           // File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DungeonCreator\\test111.png");
            
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
            int Pos = LocationList.SelectedIndex;
            if ((e.Key == System.Windows.Input.Key.Delete)&&(LocationList.SelectedIndex!=-1))
            {
                string SelectedFolder = DCDirectory + "\\" + LocationList.Items[Pos];
                Directory.Delete(SelectedFolder);
                CheckLocations(DCDirectory);
            }
        }

        private void CreateNewDungeonButton_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(DCDirectory + "//"+ LocationList.SelectedItem);
            Constructor NewDungeonConstrucktor = new Constructor(dirinfo);
            NewDungeonConstrucktor.ShowDialog();
            if (NewDungeonConstrucktor.DialogResult == false)
            {
                NewDungeonConstrucktor.Close();
            }
        }
    }
}
