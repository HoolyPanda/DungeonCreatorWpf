using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCreatorWpf
{

    public class Encounter
    {
        public Encounter()
        {
            InputBox newInputBox = new InputBox("Введите название нового енкаунтера");
            newInputBox.ShowDialog();
            name = newInputBox.Answer;
        }
        string name;
        string dis;
        Action[] Actions = new Action[4];
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Dis
        {
            get
            {
              return  dis;
            }
        }
        public void SetDis(string NewDis)
        {
            dis = NewDis;
        }
        public void SetName(string NewName)
        {
            name = NewName;
        }
        public Action[] GetActions
        {
            get
            {
                return Actions;
            }
        }
    }
}
