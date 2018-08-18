using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DungeonCreatorWpf
{
    class Converter
    {
        public void ToBitmap()
        {

        }
        public void Serializator(Dungeon Dungeon)
        {
            //FileStream FileStrm = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\DungeonCreator", FileMode.OpenOrCreate);
            //File.Create(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\DungeonCreator\\"+Dungeon.Name);
            string Dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DungeonCreator\\" + Dungeon.Name+".dungeon";
            FileStream Fs = new FileStream(Dir,FileMode.Create);
            StreamWriter SW = new StreamWriter(Fs, Encoding.UTF8);
            SW.WriteLine("<Name>");
            SW.WriteLine(Dungeon.Name);
            SW.WriteLine("<Discription>");
            SW.WriteLine(Dungeon.GetDescription());
            SW.WriteLine("<ToEnter>");
            SW.WriteLine(Dungeon.GetToenter());
            SW.WriteLine("<Answer>");
            SW.WriteLine(Dungeon.GetAnswer());
            SW.WriteLine("<Encounters>");
            foreach (Encounter enc in Dungeon.GetEncounters)
            {
                SW.WriteLine("<EncounterName>");
                SW.WriteLine(enc.Name);
                SW.WriteLine("<Discription>");
                SW.WriteLine(enc.Dis);
                SW.WriteLine("<Actions>");
                foreach (Action action in enc.GetActions)
                {
                    SW.WriteLine("<Discription>");
                    SW.WriteLine(action.Dis);
                    SW.WriteLine("<Cons>");
                    SW.WriteLine(action.Cons);
                }
            }
            SW.WriteLine("<Map-BitMap>");
            for (int h= 0; h!=Dungeon.imageHeigh;h++)
            {
                for (int w = 0; w != Dungeon.imageWidth; w++)
                {
                    SW.Write(Dungeon.image[w, h, 0]);
                    SW.Write(Dungeon.image[w, h, 1]);
                    SW.Write(Dungeon.image[w, h, 2]);
                }
                SW.Write(SW.NewLine);
            }
            SW.Close();
            Fs.Close();

        }
    }
}
