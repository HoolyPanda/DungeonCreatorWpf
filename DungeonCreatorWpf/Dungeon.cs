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
            string name;
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
            public void AddNewEncounter()
            {
                if (encounters != null)
                {
                    Array.Resize(ref encounters, encounters.Length + 1);
                    encounters[encounters.Length] = new Encounter();
                }
                else
                {
                    encounters = new Encounter[1];
                    encounters[0] = new Encounter();

                }
            }
            public Encounter[] GetEncounters()
            {
                return encounters;
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
}
