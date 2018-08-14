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
                case "EncounterDescription":
                    NewDungeon.NewData.GetEncounters[EncounterList.SelectedIndex].SetDis(MainData.Text);
                    break;
                case "EncounterName":
                    //need to rewrite(maybe)
                    NewDungeon.NewData.GetEncounters[EncounterList.SelectedIndex].SetName(MainData.Text);
                    EncounterList.Items.Clear();
                    foreach (Encounter enc in NewDungeon.NewData.GetEncounters)
                    {
                        EncounterList.Items.Add(enc.Name);
                    }
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
            EncounterList.Items.Clear();
            NewDungeon.NewData.AddNewEncounter();
            foreach (Encounter enc in NewDungeon.NewData.GetEncounters)
            {
                EncounterList.Items.Add(enc.Name);
            }
        }

        private void EncounterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ActionList.Items.Clear();
            if (EncounterList.SelectedIndex!=-1)
            {
                int i = 1;
                foreach (Action act in NewDungeon.NewData.GetEncounters[EncounterList.SelectedIndex].GetActions)
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
                MainData.Text = NewDungeon.NewData.GetEncounters[EncounterList.SelectedIndex].Dis;
                CurrentMode = "EncounterDescription";
            }
        }

        private void EncounterName_Click(object sender, RoutedEventArgs e)
        {
            if (EncounterList.SelectedIndex != -1)
            {
                MainData.Text = NewDungeon.NewData.GetEncounters[EncounterList.SelectedIndex].Name;
                CurrentMode = "EncounterName";
            }
        }
    } 
}
