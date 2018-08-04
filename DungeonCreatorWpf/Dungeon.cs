using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCreatorWpf
{
    public class Dungeon
    {
       public Data NewData;
        
        public Dungeon()
        {
          
        }
       
       public struct Data
       {
            Encounter[] encounters;
            string answer;
            string description;
            string toenter;
            byte[] image;
            public void SetAnswer(string newAnswer)
            {
                answer = newAnswer;
            }
            public void SetDescription(string newDescription)
            {
                description = newDescription;
            }
            public void SetToenter(string newToenter)
            {
                toenter = newToenter;
            }
            public string GetAnswer()
            {
                return answer;
            }
            public string GetDescription()
            {
                return description;
            }
            public string GetToenter()
            {
                return toenter;
            }
       }
    }
}
