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
    /// Логика взаимодействия для Constructor.xaml
    /// </summary>
    public partial class Constructor : Window
    {
        public string CurrentMode;
        public Dungeon NewDungeon;
        public InputBox InputBox= new InputBox();
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
                    NewDungeon.NewData.SetDescription(MainData.Text);
                    break;
                case "Answer":
                    NewDungeon.NewData.SetAnswer(MainData.Text);
                    break;
                case "Enter":
                    NewDungeon.NewData.SetToenter(MainData.Text);
                    break;
            }
        }
        private void Description_Click(object sender, RoutedEventArgs e)
        {
            MainData.Text = NewDungeon.NewData.GetDescription();
            CurrentMode = "Description";
        }
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            MainData.Text = NewDungeon.NewData.GetAnswer();
            CurrentMode = "Answer";
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            MainData.Text = NewDungeon.NewData.GetToenter();
            CurrentMode = "Enter";
        }

        private void EncounterList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NewDungeon.NewData.AddNewEncounter();
            Encounter[] encs = NewDungeon.NewData.GetEncounters();
            EncounterList.Items.Add(encs[NewDungeon.NewData.encountersLength-1].Name);
        }
    }
}
