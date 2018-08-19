using System.IO;
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
using Microsoft.Win32;
using System.Drawing;


namespace DungeonCreatorWpf
{
    /// <summary>
    /// Логика взаимодействия для Constructor.xaml
    /// </summary>
    public partial class Constructor : Window
    {
        public string CurrentMode;
        public Dungeon NewDungeon;
        int currentEncounter;
        int currentAction;
        public Constructor()
        {
            InitializeComponent();
            NewDungeon = new Dungeon();
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            switch (CurrentMode)
            {
                case "Description":
                    NewDungeon.SetDescription(MainData.Text);
                    break;
                case "Answer":
                    NewDungeon.SetAnswer(MainData.Text);
                    break;
                case "Enter":
                    NewDungeon.SetToenter(MainData.Text);
                    break;
                case "EncounterDescription":
                    NewDungeon.GetEncounters[EncounterList.SelectedIndex].SetDis(MainData.Text);
                    break;
                case "EncounterName":
                    //need to rewrite(maybe)
                    NewDungeon.GetEncounters[EncounterList.SelectedIndex].SetName(MainData.Text);
                    EncounterList.Items.Clear();
                    foreach (Encounter enc in NewDungeon.GetEncounters)
                    {
                        EncounterList.Items.Add(enc.Name);
                    }
                    break;
                case "ActionDis":
                    NewDungeon.GetEncounters[EncounterList.SelectedIndex].GetActions[ActionList.SelectedIndex].SetDis(MainData.Text);
                    break;
                case "ActionCons":
                    NewDungeon.GetEncounters[EncounterList.SelectedIndex].GetActions[ActionList.SelectedIndex].SetCons(MainData.Text);
                    break;
            }
        }
        private void Description_Click(object sender, RoutedEventArgs e)
        {
            MainData.Text = NewDungeon.GetDescription();
            CurrentMode = "Description";
        }
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            MainData.Text = NewDungeon.GetAnswer();
            CurrentMode = "Answer";
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            MainData.Text = NewDungeon.GetToenter();
            CurrentMode = "Enter";
        }

        private void EncounterList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EncounterList.Items.Clear();
            NewDungeon.AddNewEncounter();
            foreach (Encounter enc in NewDungeon.GetEncounters)
            {
                EncounterList.Items.Add(enc.Name);
            }
        }

        private void EncounterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ActionList.Items.Clear();
            MainData.Text = "Выберите интересующую вас опцию";
            if (EncounterList.SelectedIndex!=-1)
            {
                currentEncounter = EncounterList.SelectedIndex;
                int i = 1;
                foreach (Action act in NewDungeon.GetEncounters[EncounterList.SelectedIndex].GetActions)
                {
                    ActionList.Items.Add(i);
                    i++;
                }
            }
        }
        private void EncounterDescription(object sender, RoutedEventArgs e)
        {
            if (EncounterList.SelectedIndex != -1)
            {
                MainData.Text = NewDungeon.GetEncounters[EncounterList.SelectedIndex].Dis;
                CurrentMode = "EncounterDescription";
            }
        }

        private void EncounterName_Click(object sender, RoutedEventArgs e)
        {
            if (EncounterList.SelectedIndex != -1)
            {
                MainData.Text = NewDungeon.GetEncounters[EncounterList.SelectedIndex].Name;
                CurrentMode = "EncounterName";
            }
        }

        private void ActionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ActionList.SelectedIndex != -1)
            {
                currentAction = ActionList.SelectedIndex;
                MainData.Text = "";
            }
        }

        private void ActionDis_Click(object sender, RoutedEventArgs e)
        {
            MainData.Text= NewDungeon.GetEncounters[currentEncounter].GetActions[currentAction].Dis;
            CurrentMode = "ActionDis";
        }

        private void ActionCons_Click(object sender, RoutedEventArgs e)
        {
            MainData.Text = NewDungeon.GetEncounters[EncounterList.SelectedIndex].GetActions[ActionList.SelectedIndex].Cons;
            CurrentMode = "ActionCons";
        }

        private void DungeonName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            InputBox InBox = new InputBox("Введите новое название данжа");
            InBox.ShowDialog();
            NewDungeon.SetName(InBox.Answer);
            DungeonName.Content = NewDungeon.Name;
        }

        private void SetDungeonMap_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            if (FD.ShowDialog() == true)
            {
                ImageSourceConverter imsc = new ImageSourceConverter();
                try
                {
                    DungeonMap.SetValue(System.Windows.Controls.Image.SourceProperty, imsc.ConvertFromString(FD.FileName));
                    GetBitmap(FD.FileName);
                    NewDungeon.ImageSourse = FD.FileName;
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Что-то пошло не так. Говорят, должна быть выбрана именно картинка");
                }
            }
            
        }
        void GetBitmap(string ImagePath)
        {
            Bitmap Bm = new Bitmap(ImagePath);
            NewDungeon.image = new byte[Bm.Width,Bm.Height,3];
            NewDungeon.imageWidth = Bm.Width;
            NewDungeon.imageHeigh = Bm.Height;
            for (int i = 0; i<Bm.Width;i++)
            {
                for (int j = 0; j < Bm.Height; j++)
                {
                    NewDungeon.image[i, j, 0] = Bm.GetPixel(i, j).R;
                    NewDungeon.image[i, j, 1] = Bm.GetPixel(i, j).G;
                    NewDungeon.image[i, j, 2] = Bm.GetPixel(i, j).B;

                }
            }
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            Converter Convert = new Converter();
            Convert.Serializator(NewDungeon);
            this.DialogResult = false;
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            if (FD.ShowDialog() == true)
            {
                
                try
                {
                    Converter c = new Converter();
                    NewDungeon = c.Loader(FD.FileName); 
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
        }
    } 
}
