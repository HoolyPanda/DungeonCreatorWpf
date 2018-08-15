using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCreatorWpf
{
    public class Action
    {
        string cons;
        string dis;
        public Action()
        {
        }
        public string Cons
        {
            get
            {
                return cons;
            }
        }
        public string Dis
        {
            get
            {
                return dis;
            }
        }
        public void SetCons(string NewCons)
        {
            cons = NewCons;
        }
        public void SetDis(string NewDis)
        {
            dis = NewDis;
        }
    }
}
