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
            InputBox newInputBox = new InputBox();
            newInputBox.ShowDialog(); 
            name = newInputBox.Answer;
        }
        string name;
        string dis;
        Action[] Actions=new Action[4];
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
