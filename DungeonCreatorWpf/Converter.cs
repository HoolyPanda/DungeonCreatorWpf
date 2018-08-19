using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Drawing;
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
            SW.Write(SW.NewLine);
            SW.WriteLine("<Map-BitMap>");
            SW.WriteLine(Dungeon.imageWidth);
            SW.WriteLine(Dungeon.imageHeigh);
            for (int h = 0; h != Dungeon.imageHeigh; h++)
            {
                for (int w = 0; w != Dungeon.imageWidth; w++)
                {
                    //Fs.WriteByte(Dungeon.image[w, h, 0]);
                    //Fs.WriteByte(Dungeon.image[w, h, 1]);
                    //Fs.WriteByte(Dungeon.image[w, h, 2]);
                    SW.Write(Dungeon.image[w, h, 0]);
                    SW.Write(",");
                    SW.Write(Dungeon.image[w, h, 1]);
                    SW.Write(",");
                    SW.Write(Dungeon.image[w, h, 2]);
                    SW.Write(";");
                }
                SW.Write(SW.NewLine);
            }
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
            SW.WriteLine("<End>");
            SW.Close();
            Fs.Close();
        }
        public Dungeon Loader(string filePath)
        {
            Dungeon Dungeon=new Dungeon();
            FileStream fs = new FileStream(filePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string data="";
            while (data != "<End>")
            {
                data = sr.ReadLine();
                switch (data)
                {
                    case "<Map-BitMap>":
                        int w = Convert.ToInt32(sr.ReadLine()); 
                        int h = Convert.ToInt32(sr.ReadLine());
                        Dungeon.image = new byte[w,h,3];
                        File.Create(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DungeonCreator\\test111");
                        
                        Bitmap bm= new Bitmap(w,h);
                           for (int i= 0; i!=h;i++)
                           {
                               for (int j= 0; j!=w;j++)
                               {
                                   //проблема с посимвольным чтением и кодировокй (записано 255, по факту получается 50)
                                   //Read возвращает инт аски символа
                                   // byte b = Convert.ToByte(fs.ReadByte());
                                  int r = sr.Read();
                                  int g = sr.Read();
                                  int b = sr.Read();

                                  Color c = Color.FromArgb(r,g,b);

                            
                                  bm.SetPixel(j, i, c);
                                //Dungeon.image[j, i, 0] = (byte)sr.Read();//(byte)fs.ReadByte();
                                //b = Convert.ToByte(fs.ReadByte());
                                //Dungeon.image[j, i, 1] = (byte)sr.Read();
                                //b = Convert.ToByte(fs.ReadByte());
                                //Dungeon.image[j, i, 2] = (byte)sr.Read();
                               }
                           }
                         bm.Save(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DungeonCreator\\test111.jpg" );
                        break;
                    case "<Name>":
                        Dungeon.SetName(sr.ReadLine());
                        break;
                    case "<Discription>":
                        Dungeon.SetDescription(sr.ReadLine());
                        break;
                    case "<ToEnter>":
                        Dungeon.SetToenter(sr.ReadLine());
                        break;
                    case "<Answer>":
                        Dungeon.SetAnswer(sr.ReadLine());
                        break;
                    default:
                        //sr.ReadLine();
                        break;
                }
            }
            return Dungeon;
        }
    }
}
