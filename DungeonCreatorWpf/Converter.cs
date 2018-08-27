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
        public void Serializator(Dungeon Dungeon, DirectoryInfo dir)
        {
            //FileStream FileStrm = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\DungeonCreator", FileMode.OpenOrCreate);
            //File.Create(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\DungeonCreator\\"+Dungeon.Name);
            string Dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DungeonCreator\\"+dir.Name + Dungeon.Name + ".dungeon";
            FileStream Fs = new FileStream(Dir, FileMode.Create);
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
                SW.WriteLine("<EndEncounter>");
            }
            SW.WriteLine("<Map-BitMap>");
            SW.WriteLine(Dungeon.imageWidth);
            SW.WriteLine(Dungeon.imageHeigh);
            for (int h = 0; h != Dungeon.imageHeigh; h++)
            {
                for (int w = 0; w != Dungeon.imageWidth; w++)
                {

                    if (Dungeon.image[w, h, 0] > 99)
                    {
                        SW.Write(3);
                    }
                    else if (Dungeon.image[w, h, 0] > 9)
                    {
                        SW.Write(2);
                    }
                    else if (Dungeon.image[w, h, 0] >= 0)
                    {
                        SW.Write(1);
                    }
                    SW.Write(Dungeon.image[w, h, 0]);

                    if (Dungeon.image[w, h, 1] > 99)
                    {
                        SW.Write(3);
                    }
                    else if (Dungeon.image[w, h, 1] > 9)
                    {
                        SW.Write(2);
                    }
                    else if (Dungeon.image[w, h, 1] >= 0)
                    {
                        SW.Write(1);
                    }
                    SW.Write(Dungeon.image[w, h, 1]);

                    if (Dungeon.image[w, h, 2] > 99)
                    {
                        SW.Write(3);
                    }
                    else if (Dungeon.image[w, h, 2] > 9)
                    {
                        SW.Write(2);
                    }
                    else if (Dungeon.image[w, h, 2] >= 0)
                    {
                        SW.Write(1);
                    }
                    SW.Write(Dungeon.image[w, h, 2]);
                }
                SW.Write(SW.NewLine);
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
                                int r=0;
                                int a = sr.Read()-48;
                                if (a<0)
                                {
                                    a = sr.Read();
                                    a = sr.Read() - 48;
                                }
                                switch (a)
                                {
                                    case 3:
                                        {
                                            int t=0;
                                            t += (sr.Read() - 48) * 100;
                                            t += (sr.Read() - 48) * 10;
                                            t += (sr.Read() - 48) ;
                                            r = t;
                                            break;
                                        }
                                    case 2:
                                        {
                                            int t = 0;
                                            t += (sr.Read() - 48) * 10;
                                            t += (sr.Read() - 48);
                                            r = t;
                                            break;
                                        }
                                    case 1:
                                        {
                                            int t = 0;
                                            t += (sr.Read() - 48);
                                            r = t;
                                            break;
                                        }
                                    default:
                                        break;
                                }
                                int g=0;
                                a = sr.Read()-48;
                                switch (a)
                                {
                                    case 3:
                                        {
                                            int t = 0;
                                            t += (sr.Read() - 48) * 100;
                                            t += (sr.Read() - 48) * 10;
                                            t += (sr.Read() - 48);
                                            g = t;
                                            break;
                                        }
                                    case 2:
                                        {
                                            int t = 0;
                                            t += (sr.Read() - 48) * 10;
                                            t += (sr.Read() - 48);
                                            g = t;
                                            break;
                                        }
                                    case 1:
                                        {
                                            int t = 0;
                                            t += (sr.Read() - 48);
                                            g = t;
                                            break;
                                        }
                                    
                                }
                                int b=0;
                                a = sr.Read()-48;
                                switch (a)
                                {
                                    case 3:
                                        {
                                            int t = 0;
                                            t += (sr.Read() - 48) * 100;
                                            t += (sr.Read() - 48) * 10;
                                            t += (sr.Read() - 48);
                                            b = t;
                                            break;
                                        }
                                    case 2:
                                        {
                                            int t = 0;
                                            t += (sr.Read() - 48) * 10;
                                            t += (sr.Read() - 48);
                                            b = t;
                                            break;
                                        }
                                    case 1:
                                        {
                                            int t = 0;
                                            t += (sr.Read() - 48);
                                            b = t;
                                            break;
                                        }
                                    default:
                                        break;
                                }
                                Color c = Color.FromArgb(255,r,g,b);
                                Dungeon.image[j, i, 0] = (byte)r;
                                Dungeon.image[j, i, 1] = (byte)g;
                                Dungeon.image[j, i, 2] = (byte)b;
                                r = 0;
                                g = 0;
                                b = 0;
                                bm.SetPixel(j, i, c);
                               }
                           }
                        Dungeon.map = bm;
                        // bm.Save(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\DungeonCreator\\test111.png");
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
                    case "<Encounters>":
                        {
                            string a = "";
                            
                            while (a!= "<EndEncounter>")
                            {
                                a = sr.ReadLine();
                                switch (a)
                                {
                                    case "<EncounterName>":
                                        Dungeon.AddNewEncounter("load");
                                        Dungeon.GetEncounters[Dungeon.encountersLength - 1].SetName(sr.ReadLine());
                                        break;
                                    case "<Discription>":
                                        Dungeon.GetEncounters[Dungeon.encountersLength - 1].SetDis(sr.ReadLine());
                                        break;
                                    case "<Actions>":
                                        for (int i =0;i!=4;i++)
                                        {
                                            sr.ReadLine();
                                            Dungeon.GetEncounters[Dungeon.encountersLength - 1].GetActions[i].SetDis(sr.ReadLine());
                                            sr.ReadLine();
                                            Dungeon.GetEncounters[Dungeon.encountersLength - 1].GetActions[i].SetCons(sr.ReadLine());
                                        }
                                        break;
                                }
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
            return Dungeon;
        }
    }
}
