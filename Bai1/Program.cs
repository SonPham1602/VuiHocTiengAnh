using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;
namespace Bai1
{
    class Program
    {
        public class Word
        {
            public string tu;
            public void setTu(string str)
            {
                tu = str;
                
            }
 
        }
        public class Dictionary
        {
            List<Word> DSWord = new List<Word>();
            List<string> NameUnit = new List<string>();
            public void addword()
            {
                FileStream fs = new FileStream(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai1\Word.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Word temp = new Word();
                    temp.setTu(str);
                    DSWord.Add(temp);
                    str = sr.ReadLine();
                    NameUnit.Add(str);
                }
                fs.Close();
            }
            public void Show()
            {
                for (int i = 0; i < NameUnit.Count; i++)
                {
                    Console.WriteLine(NameUnit[i]);
                }
            }
            public void deleteUnit(string str)
            {
                string contents = File.ReadAllText(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai1\Word.txt");
                contents=contents.Replace("\ntest", "");
                Console.WriteLine(contents);
                File.WriteAllText(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai1\Word.txt", contents);

            }
            public void AddListWordInNewUnit(string name, string noidung)
            {
                using (StreamWriter w = File.AppendText(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai1\Word.txt"))
                {
                    w.WriteLine(name);
                }

                File.WriteAllText(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai1\" + name + ".txt", noidung);

            }
        }
        public void SaveFileImage()
        {
            Image img = Image.FromStream(new MemoryStream(File.ReadAllBytes(Application.StartupPath+"\\ava.dat")));
        }
        static void Main(string[] args)
        {
            //List<int> arr = new List<int>();
            //arr.Add(1);
            //arr.Add(2);
            //arr.Add(3);
            //arr.Add(4);
            //Console.WriteLine("{0}  {1}   {2}", arr[0], arr[1], arr[2]);
            //string name;
            //Console.WriteLine("HELLO WORLD");
            //Console.Write("WHAT'S YOUR NAME?:");
            //name=Console.ReadLine();
            //Console.WriteLine("HELLO {0}", name);
            Dictionary Dic = new Dictionary();
            Dic.addword();
            Dic.Show();
            Dic.deleteUnit("1_cot");
            Dic.Show();
            Dic.AddListWordInNewUnit("Unit1", "noi dung ");
            Console.Read();


        }
    }
}
