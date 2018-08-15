using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCreatorWpf
{
    public class Dungeon
    {
          
       public Dungeon()
       {
       }
       Encounter[] encounters= new Encounter[0];
       string name;
       string answer;
       string description;
       string toenter;
       byte[][][] image;
       public string Name
       {
            get
            {
                return name;
            }
       }
        public void SetName(string NewName)
        {
            name = NewName;
        }
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
       public void AddNewEncounter()
       {
            int i = encounters.Length;
            Array.Resize(ref encounters, i + 1);
            encounters[encounters.Length-1] = new Encounter();           
       }
       public Encounter[] GetEncounters
       {
            get
            {
                return encounters;
            }
       }
           
       public int encountersLength
            {
                get
                {
                    return encounters.Length;
                }
            }
       
    }
}
