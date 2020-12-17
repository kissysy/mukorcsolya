using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2019_10_21_helsinki_Console
{
    class Verseny
    {
        public int helyezes, sorszam;
        public string nev,versenyszam;
        public Verseny(string egysor)
        {
            string[] darabok = egysor.Split(' ');
            helyezes = int.Parse(darabok[0]);
            sorszam = int.Parse(darabok[1]);
            nev = darabok[2];
            versenyszam = darabok[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("helsinki.txt", Encoding.Default);
            Verseny[] versenyek = new Verseny[beolvas.Length];
            for (int i = 0; i < versenyek.Length; i++)
            {
                versenyek[i] = new Verseny(beolvas[i]);
            }

            Console.WriteLine("3.feladat: Pontszerző helyezések száma: {0}",versenyek.Length);
            //
            //4.feladat
            int arany=0, ezust=0, bronz=0, oszz=0,negyedik=0,otodik=0,hatodik=0, ossz_5=0;
            for (int i = 0; i < versenyek.Length; i++)
            {
                switch (versenyek[i].helyezes)
                {
                    case 1:
                        arany++;
                        break;
                    case 2:
                        ezust++;
                        break;
                    case 3:
                        bronz++;
                        break;
                    case 4:
                        negyedik++;
                        break;
                    case 5:
                        otodik++;
                        break;
                    case 6:
                        hatodik++;
                        break;
                }
            }
            oszz = oszz + arany + ezust + bronz;
            Console.WriteLine("4.feladat: Arany {0}" +
                "                      \n Ezüst {1}" +
                "                      \n Bronz {2}" +
                "                      \n összesen {3}"
                                       ,arany,ezust,bronz,oszz);
            //
            //5.feladat
            ossz_5 = ossz_5 +
                (arany * 7) + 
                (ezust * 5) + 
                (bronz * 4) + 
                (negyedik * 3) + 
                (otodik * 2) + 
                (hatodik * 1);
            Console.WriteLine("5.feladat: {0} ",ossz_5);
            //
            //6.feladat
            int torna = 0, uszas = 0;
            for (int i = 0; i < versenyek.Length; i++)
            {
                switch (versenyek[i].nev)
                {
                    case "torna":
                        torna++;
                        break;
                    case "uszas":
                        uszas++;
                        break;
                    default:
                        break;
                }
            }
            if (torna>uszas)
            {
                Console.WriteLine("6.feladat:A tornaban volt több érem");
            }
            else if (torna== uszas)
            {
                Console.WriteLine("6.feladat:egyenlő volt a érem szám");
            }
            else
            {
                Console.WriteLine("6.feladat:Az uszásban volt több érem");
            }

            





            
            Console.WriteLine("\nNyombd meg az Entert!");
            Console.ReadLine();
        }
    }
}
