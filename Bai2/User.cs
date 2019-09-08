using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Bunifu.Framework.UI;
using System.Media;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace Bai2
{

    public class Word
    {
        // cac thuoc tinh cua word

        public string tu;
        public string anh;
        public int NameUnit;
        public int OrdinalNumbers;
        public string Example;
        public void setTu(string str)
        {
            tu = str;
        }
        public void setAnh(string img)
        {
            anh = img;
        }
        public void setNameUnit(int str)
        {
            NameUnit = str;
        }
       
        public void setOrdinalNumbers(int n)
        {
            OrdinalNumbers = n;
        }
        public Image getAnh()
        {

            string n = anh + ".dat";
            try
            {
                Image img;
                img = Image.FromStream(new MemoryStream(File.ReadAllBytes(@"data\images\" + n)));
                return img;
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);

            }
            finally
            {

            }
            return null;



            // temp = ((System.Drawing.Image)Resource.ResourceManager.GetObject(anh));

        }
        public string getTu()
        {
            return tu;
        }
        public Image getAnh(string path)
        {
            Image temp;
            temp = Image.FromFile(path);
            return temp;
        }
        public string GetMeanWord()
        {
            string kq = tu;
            for (int i = 0; i < tu.Length; i++)
            {
                if (tu[i] == '_')
                {
                    kq = tu.Substring(i + 1);
                    while (kq.IndexOf("_") != -1)
                    {
                        kq = kq.Replace("_", " ");
                    }
                    return kq;
                }
            }
            return null;
        }


    }// class word
    public enum TypeUpdateUnit
    {
        CREATE,DELETE,CHANGE
    }
    public class Dictionary
    {

        private List<Word> DSWord = new List<Word>();
        private List<string> NameUnit = new List<string>();
        
        public Dictionary()
        {
            addword();
        }
        /// <summary>
        /// Ham tra ve anh sach cac tu trong unit cua tu dien 
        /// </summary>
        /// <param name="numberUnit">So thu tu Unit</param>
        /// <returns></returns>
        public List<int> ListWordInUnit(int numberUnit)
        {
            List<int> result = new List<int>();
            int s = 0;
            int e = 0;
            getStartEndUnit(ref s, ref e, numberUnit);
            for (int i = s; i < e + 1; i++)
            {
                result.Add(i);
            }
            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="noidung"></param>
        public void AddListWordInNewUnit(string name, string noidung)
        {
            using (StreamWriter w = File.AppendText(@"data\data.txt"))
            {
                w.WriteLine();
                w.Write(name);
            }

            File.WriteAllText(@"data\"+name+".txt", noidung);

        }
        /// <summary>
        /// Ham dung de them mot unit vao trong data
        /// </summary>
        /// <param name="nameUnit"> Name of Unit Which U want to Add </param>
        public void AddNewUnit(string nameUnit,string content)
        {
            using (StreamWriter w = File.AppendText(@"data\data.txt"))
            {
                w.WriteLine(nameUnit);
                string path = @"data\"+nameUnit+".txt";
                if(content == String.Empty)
                {
                    File.Create(path);
                }
                else
                {
                    File.WriteAllText(path, content);
                }
                
            }

        }
        /// <summary>
        /// Ham dung de xoa unit trong dictionnary
        /// </summary>
        /// <param name="NameUnit"></param>
        public void DeleteUnit(string NameUnit)
        {
            string contents = File.ReadAllText(@"data\data.txt");// noi dung
            contents = contents.Replace(NameUnit+"\n","");
            File.WriteAllText(@"data\data.txt", contents);
           
        }
        /// <summary>
        /// Update Word in Unit 
        /// 
        /// </summary>
        /// <param name="NameUnit"> Name of Unit which you need to update</param>
        public void UpdateUnit(string NameUnit,TypeUpdateUnit type)
        {
            if (type == TypeUpdateUnit.CREATE)
            {
                using (StreamWriter w = File.AppendText(@"data\"+NameUnit+".txt"))
                {
                    
                }
            }
            else if (type == TypeUpdateUnit.CHANGE)
            {

            }
            else if (type == TypeUpdateUnit.DELETE)
            {

            }
        }
        public string ReadUnit(string NameUnit)
        {
            string path = "data\\" + NameUnit + ".txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();
            fs.Close();
            return str;       
        }
        public bool OpenFileAndLoad(string path, int nameunit)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            int i = 1;
            try
            {
                while (str != null)
                {
                    Word temp = new Word();
                    temp.setTu(str);
                    // ngay sua 13/8/2018
                    // ly do: doi sang doc file nhi phan ne phai bo "_"
                    //temp.setAnh("_" + str);
                    temp.setAnh(str);
                    temp.setNameUnit(nameunit);
                    temp.setOrdinalNumbers(i);
                    DSWord.Add(temp);
                    str = sr.ReadLine();
                    i++;

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
            finally
            {
                fs.Close();
            }
            fs.Close();
            return true;
        }
        public void OpenFileAndLoad(Stream path, int nameunit)
        {
            Stream fs = path;
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            int i = 1;
            try
            {
                while (str != null)
                {
                    Word temp = new Word();
                    temp.setTu(str);
                    temp.setAnh("_" + str);
                    temp.setNameUnit(nameunit);
                    temp.setOrdinalNumbers(i);
                    DSWord.Add(temp);
                    str = sr.ReadLine();
                    i++;

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
            finally
            {
                fs.Close();
            }
            fs.Close();

        }
        public int getNumberOfUnit()
        {
            return NameUnit.Count;
        }
        public Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
       
        public int ShowNumberWordOfUnit(int numberUnit)
        {
            int result = 0;
            for (int i = 0; i < getNumberList(); i++)
            {
                if (DSWord[i].NameUnit == numberUnit)
                {
                    result++;
                }
            }
            return result;
        }
        /// <summary>
        /// Ham xuat ten cua unit
        /// VD unit 1 thi nhap vao so 1
        /// </summary>
        /// <param name="number">Chu cho unit</param>
        /// <returns></returns>
        public string GetNameOfUnitByNumber(int number)
        {
            return NameUnit[number-1];
        }
        /// <summary>
        /// This function will return list of Unit
        /// </summary>
        /// <returns></returns>
        public List<string> RefeshAndLoadListUnit()
        {
            List<string> arrayUnit = new List<string>();
            FileStream fs = new FileStream(@"data\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while (str != null)
            {
                arrayUnit.Add(str);
                str = sr.ReadLine();
            }
            return arrayUnit;
        }
        public void addword()
        {
            /*1
            object O = Resource.ResourceManager.GetObject("Unit_1_It_sTimeToWakeUp");
            Stream path = GenerateStreamFromString((string)O);
            OpenFileAndLoad(path, 1);
          

            //string path = @"data\Unit_1_It'sTimeToWakeUp.txt";
            //OpenFileAndLoad(path, 1);*/
            FileStream fs = new FileStream(@"data\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while (str != null)
            {
                NameUnit.Add(str);
                str = sr.ReadLine();
            }
            fs.Close();
            string path;
            for (int i = 0; i < NameUnit.Count; i++)
            {
                path = @"data\"+NameUnit[i]+".txt";
                OpenFileAndLoad(path, i + 1);
            }

        }
        public void Show()
        {
            for (int i = 0; i < DSWord.Count; i++)
            {
                Console.WriteLine(DSWord[i].tu);
            }
        }
        public Word FindWord(string str)
        {
            Word Result = new Word();
            Result = null;
            for (int i = 0; i < DSWord.Count; i++)
            {
                if (str == DSWord[i].tu)
                {
                    Result = DSWord[i];
                }
            }
            return Result;
        }
        public List<Word> FindAnyWord(string str)
        {
            List<Word> ketqua = new List<Word>();
            Word Result = new Word();
            Result = null;
            for (int i = 0; i < DSWord.Count; i++)
            {
                if (DSWord[i].tu.Contains(str) == true)
                {
                    ketqua.Add(DSWord[i]);
               
                }
            }
            return ketqua;
               
        }
        public int getNumberList()
        {
            return DSWord.Count;
        }
        public Image getImageWordByNumber(int n)
        {
            Word result = new Word();
            result = DSWord[n];
            return result.getAnh();
        }
       
        public Image getImageWordByWord(string nameword)
        {
            Word result = new Word();
            result = FindWord(nameword);
            return result.getAnh();
        }
        public Word getWordByNumber(int n)
        {
            return DSWord[n];
        }
        public void getStartEndUnit(ref int s, ref int e)
        {
            for (int i = 0; i < DSWord.Count; i++)
            {
                if (DSWord[i].NameUnit == s)
                {
                    s = i;
                }
            }
            for (int i = 0; i < DSWord.Count; i++)
            {
                if (DSWord[i].NameUnit == e + 1)
                {
                    e = i - 1;
                }
            }
        }
        public void getStartEndUnit(ref int s, ref int e, int unit)// theo unit duoc chon
        {
            if (unit == DSWord[DSWord.Count - 1].NameUnit)
            {
                for (int i = 0; i < DSWord.Count; i++)
                {
                    if (DSWord[i].NameUnit == unit)
                    {
                        s = i;
                        break;
                    }
                }
                e = DSWord.Count - 1;
            }
            else
            {
                for (int i = 0; i < DSWord.Count; i++)
                {
                    if (DSWord[i].NameUnit == unit)
                    {
                        s = i;
                        break;
                    }
                }
                for (int i = 0; i < DSWord.Count; i++)
                {
                    if (DSWord[i].NameUnit == unit + 1)
                    {
                        e = i - 1;
                        break;
                    }
                }
            }

        }
        public string GetMeanWord(int n)
        {
            Word result = new Word();
            result = DSWord[n];
            string str = result.getTu();
            string kq;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '_')
                {
                    kq = str.Substring(i + 1);
                    while (kq.IndexOf("_") != -1)
                    {
                        kq = kq.Replace("_", " ");
                    }
                    return kq;
                }
            }
            return str;
        }
        private void addword(string w, string image, int unit)
        {
            Word word = new Word();
            word.anh = image;
            word.tu = w;
            word.NameUnit = unit;
            DSWord.Add(word);
        }

        public void CreateAnswers(int number, ref string T_Answers, ref string F_Answers1, ref string F_Answers2, ref string F_Answers3, ref string F_Answers4, ref string F_Answers5, ref string F_Answers6, ref string F_Answers7)
        {
            Random r = new Random();
            int n1, n2, n3, n4, n5, n6, n7;
            //tao dap an sai thu 1
            n1 = r.Next(DSWord.Count);
            while (n1 == number)
            {
                n1 = r.Next(DSWord.Count);

            }
            // tao dap an sai thu 2
            n2 = r.Next(DSWord.Count);
            while (n2 == number || n2 == n1)
            {
                n2 = r.Next(DSWord.Count);

            }
            // tao dap an sai thu 3
            n3 = r.Next(DSWord.Count);
            while (n3 == number || n3 == n1 || n3 == n2)
            {
                n3 = r.Next(DSWord.Count);
            }
            // tao dap an sai thu 4
            n4 = r.Next(DSWord.Count);
            while (n4 == number || n4 == n1 || n4 == n2 || n4 == n3)
            {
                n4 = r.Next(DSWord.Count);

            }
            // tao dap an sai thu 5
            n5 = r.Next(DSWord.Count);
            while (n5 == number || n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4)
            {
                n5 = r.Next(DSWord.Count);

            }
            // tao dap an sai thu 6
            n6 = r.Next(DSWord.Count);
            while (n6 == number || n6 == n1 || n6 == n2 || n6 == n3 || n6 == n4 || n6 == n5)
            {
                n6 = r.Next(DSWord.Count);

            }
            // tao dap an sai thu 7
            n7 = r.Next(DSWord.Count);
            while (n7 == number || n7 == n1 || n7 == n2 || n7 == n3 || n7 == n4 || n7 == n5 || n7 == n6)
            {
                n7 = r.Next(DSWord.Count);

            }
            T_Answers = getWordByNumber(number).GetMeanWord();
            F_Answers1 = getWordByNumber(n1).GetMeanWord();
            F_Answers2 = getWordByNumber(n2).GetMeanWord();
            F_Answers3 = getWordByNumber(n3).GetMeanWord();
            F_Answers4 = getWordByNumber(n4).GetMeanWord();
            F_Answers5 = getWordByNumber(n5).GetMeanWord();
            F_Answers6 = getWordByNumber(n6).GetMeanWord();
            F_Answers7 = getWordByNumber(n7).GetMeanWord();
        }

        public void CreateAnswers(int number, ref string T_Answers, ref string F_Answers1, ref string F_Answers2, ref string F_Answers3)
        {
            Random r = new Random();
            int n1, n2, n3;
            n1 = r.Next(DSWord.Count);
            while (n1 == number)
            {
                n1 = r.Next(DSWord.Count);

            }
            n2 = r.Next(DSWord.Count);
            while (n2 == number || n2 == n1)
            {
                n2 = r.Next(DSWord.Count);

            }
            n3 = r.Next(DSWord.Count);
            while (n3 == number || n3 == n1 || n3 == n2)
            {
                n3 = r.Next(DSWord.Count);

            }
            T_Answers = getWordByNumber(number).GetMeanWord();
            F_Answers1 = getWordByNumber(n1).GetMeanWord();
            F_Answers2 = getWordByNumber(n2).GetMeanWord();
            F_Answers3 = getWordByNumber(n3).GetMeanWord();
        }
        /// <summary>
        /// Ham nay de tao cau hoi trac nghiem voi 4 dap an trong do
        /// T_Answers la dung , don lai la sai
        /// </summary>
        /// <param name="number"></param>
        /// <param name="T_Answers"></param>
        /// <param name="F_Answers1"></param>
        /// <param name="F_Answers2"></param>
        /// <param name="F_Answers3"></param>
        /// <param name="start">vi tri bat dau</param>
        /// <param name="end">vi tri ket thuc</param>
        public void CreateAnswers(ref int number, ref Image T_Answers, ref Image F_Answers1, ref Image F_Answers2, ref Image F_Answers3, int start, int end)
        {

            Random r = new Random();
            int n1, n2, n3;
            number = r.Next(start, end);
            n1 = r.Next(start, end);
            while (n1 == number)
            {
                n1 = r.Next(start, end);

            }
            n2 = r.Next(DSWord.Count);
            while (n2 == number)
            {
                n2 = r.Next(start, end);

            }
            n3 = r.Next(DSWord.Count);
            while (n3 == number)
            {
                n3 = r.Next(start, end);

            }
            T_Answers = getImageWordByNumber(number);
            F_Answers1 = getImageWordByNumber(n1);
            F_Answers2 = getImageWordByNumber(n2);
            F_Answers3 = getImageWordByNumber(n3);
        }
    }// class tu dien
    public class Book 
    {
        
    }
    public delegate void EventSuccess(object sender, ChangeUI e);

    public class ChangeUI : EventArgs
    {
        public Size size { get; set; }
        public Color color { get; set; }
        public Size sizeofbutton { get; set; }
        //private Size SizeOfForm;// kích thước cửa sổ chính
        //private Size SizeOfButton;// kích thước button
        //private  Color ColorTop;// màu trên của thanh bar 
        //private Color ColorBot;// màu dưới của thanh bar 
        // public Size GetSizeOfForm()// hàm lấy giá trị kích thươc của form
        // {
        //     return SizeOfForm;
        // }
        // /// <summary>
        // /// Ham tra ve gia tri cua kich thuoc cua button
        // /// </summary>
        // /// size <returns></returns>
        // public Size GetSizeOfButton()
        // {
        //     return SizeOfButton;
        // }
        // public Color GetColorTop()
        // {
        //     return ColorTop;
        // }
        // public Color GetColorBot()
        // {
        //     return ColorBot;
        // }
        // public void SetSizeOfForm(Size s)
        // {
        //     SizeOfForm = s;
        // }
        // public void SetSizeOfForm(int w,int h)
        // {
        //     SizeOfForm.Height = h;
        //     SizeOfForm.Width = w;
        // }
        // public void SetSizeOfButton(Size s)
        // {
        //     SizeOfButton = s;
        // }
        // public void SetSizeOfButton(int w,int h)
        // {
        //     SizeOfButton.Height = h;
        //     SizeOfButton.Width = w;
        // }
        // public void SetColor(Color cTop,Color cBot)
        // {
        //     ColorTop = cTop;
        //     ColorBot = cBot;
        // }
    }
    public class Sound
    {
        SoundPlayer sound;
        public void loadSound(string path)
        {
            sound = new SoundPlayer(path);
        }
        public void playSound()
        {
            sound.Play();
        }
        public void stopSound()
        {
            sound.Stop();
        }

    }
    public class User
    {
        string username;
        string name;
        string pass;
        public void CreateFile()// ham tao file nhị phân, name là tên file
        {
            BinaryWriter bw;
            try
            {
                string s = "user_data" + "\\Name";
                bw = new BinaryWriter(new FileStream(s, FileMode.Create));
                //MessageBox.Show("Successful");
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot create file.");
                return;
            }
            bw.Close();
        }
        public void LoadFile()// ham đọc file, out data là chuỗi data của file
        {

            try
            {

                string name_user = "user_data" + "\\Name";
                if (File.Exists(name_user) == false)
                {
                    SaveFile("Name");

                }
                else
                {
                    string fileBytes = File.ReadAllText(name_user);
                    name = fileBytes;
                }



            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
            }
        }


        public void SaveFile(string s)
        {
            try
            {
                CreateFile();
                name = "user_data" + "\\Name";
                string appendText = s;//+Environment.NewLine;
                File.AppendAllText(name, appendText, Encoding.UTF8);

            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot write to file.");
                return;
            }
        }
        public User()
        {
            name = string.Empty;
            pass = string.Empty;
        }
        public void setname(string n)
        {
            name = n;
        }
        public void setpass(string p)
        {
            pass = p;
        }
        public void setuser(string n, string p, string un)
        {
            username = un;
            name = n;
            pass = p;
        }
        public string getname()
        {
            return name;
        }
        public string getpass()
        {
            return pass;
        }

    }

    class UserFile
    {
        public void CreateFolder(string name)// hàm tạo thư mục mới, name là tên thư mục
        {
            try
            {
                string directoryPath = name;
                // Bước 2: kiểm tra nếu thư mục "StoredFiles" chưa tồn tại thì tạo mới
                if (!System.IO.Directory.Exists(directoryPath))
                {
                    System.IO.Directory.CreateDirectory(directoryPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }
        public void createfile(string name)// ham tao file nhị phân, name là tên file
        {
            BinaryWriter bw;
            try
            {
                string s = "user_data" + "\\" + name;
                bw = new BinaryWriter(new FileStream(s, FileMode.Create));
                //MessageBox.Show("Successful");
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot create file.");
                return;
            }
            bw.Close();
        }
        public void writefile(string s, string name)
        {

            try
            {
                //bw = new BinaryWriter(new FileStream("mydata", FileMode.Append, FileAccess.Write));
                //bw.Write(s);
                //bw.Write(s1);
                //MessageBox.Show("thanh cong");
                name = "user_data" + "\\" + name;
                string appendText = s;//+Environment.NewLine;
                File.AppendAllText(name, appendText, Encoding.UTF8);

            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot write to file.");
                return;
            }


        }
        public bool login_user(string name_user, string pass)// hàm kiểm tra đăng nhập, nếu đúng thì return true, nếu sai return false
        {
            string t_name_user = "user_data" + "\\" + name_user;
            if (File.Exists(t_name_user) == true)
            {
                string temp = "";
                //MessageBox.Show("Tai khoan ton tai");
                readfile(name_user, ref temp);
                //MessageBox.Show("PassWord:" + temp+"/");
                // MessageBox.Show("PassWord:" + tb_pass.Text + "/");
                if (temp.Equals(pass) == true)
                {
                    return true;
                    // MessageBox.Show("Đăng nhập thành công","THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng", "THÔNG BÁO");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Tài khoản chưa tồn tài\nVui lòng nhấn Create để tạo tài khoản", "THÔNG BÁO");
            }
            return false;
        }
        public void readfile(string name_user, ref string out_data)// ham đọc file, out data là chuỗi data của file
        {


            //string str="";
            // string s="";
            try
            {
                //br = new BinaryReader(new FileStream("mydata", FileMode.Open,FileAccess.Read));
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot open file.");

            }
            try
            {
                // = "";
                //int count = br.ReadInt32();
                //// Read in all pairs.
                //for (  int i= 0; i < count; i++)
                //{
                //    str = br.ReadString();

                //} 
                name_user = "user_data" + "\\" + name_user;
                string fileBytes = File.ReadAllText(name_user);
                out_data = fileBytes;
                // StringBuilder sb = new StringBuilder();

                // foreach (string b in fileBytes)
                // {
                //  sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                // }

                //MessageBox.Show("PassWord:" + fileBytes);


                //s = br.ReadString();
                //str = br.ReadString();
                //MessageBox.Show("data " + str+s);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
            }
            // br.Close();

        }

    }
    public class UIUserSetting// class thong số giao dien nguoi dung 
    {
        private Size SizeOfForm;// kích thước cửa sổ chính
        private Size SizeOfButton;// kích thước button
        private Color ColorTop;// màu trên của thanh bar 
        private Color ColorBot;// màu dưới của thanh bar 
        public Size GetSizeOfForm()// hàm lấy giá trị kích thươc của form
        {
            return SizeOfForm;
        }
        /// <summary>
        /// Ham tra ve gia tri cua kich thuoc cua button
        /// </summary>
        /// size <returns></returns>
        public Size GetSizeOfButton()
        {
            return SizeOfButton;
        }
        public Color GetColorTop()
        {
            return ColorTop;
        }
        public Color GetColorBot()
        {
            return ColorBot;
        }
        public UIUserSetting()
        {
            SizeOfForm = new Size(1228, 842);
            SizeOfButton = new Size(60, 60);
            ColorTop = Color.FromArgb(133, 203, 248);
            ColorBot = Color.FromArgb(0, 192, 192);
        }
        public void SetSizeOfForm(Size s)
        {
            SizeOfForm = s;
        }
        public void SetSizeOfForm(int w, int h)
        {
            SizeOfForm.Height = h;
            SizeOfForm.Width = w;
        }
        public void SetSizeOfButton(Size s)
        {
            SizeOfButton = s;
        }
        public void SetSizeOfButton(int w, int h)
        {
            SizeOfButton.Height = h;
            SizeOfButton.Width = w;
        }
        public void SetColor(Color cTop, Color cBot)
        {
            ColorTop = cTop;
            ColorBot = cBot;
        }
    }
    public class HamCanThiet
    {
        private void CreateIfMissing(string path)
        {
            try
            {
                string directoryPath = path;
                // Bước 2: kiểm tra nếu thư mục "StoredFiles" chưa tồn tại thì tạo mới
                if (!System.IO.Directory.Exists(directoryPath))
                {
                    System.IO.Directory.CreateDirectory(directoryPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
        /// <summary>
        /// tao hinh tron image
        /// </summary>
        /// <param name="img">Hinh anh can chuyen vao</param>
        /// <param name="s">Kich thuoc duong vien</param>
        /// <param name="c">Mau sac</param>
        /// <returns></returns>
        public Image ImageCrop(Image img, int s, Color c)// cắt ảnh và thêm viền, dùng để tạo avatar
        {
            int circleDiameter;
            Bitmap bm = new Bitmap(img);
            if (bm.Height > bm.Width)
            {
                circleDiameter = bm.Width;
            }
            else
            {
                circleDiameter = bm.Height;
            }
            Rectangle crop = new Rectangle(0, 0, circleDiameter, circleDiameter);
            bm = bm.Clone(crop, bm.PixelFormat);
            TextureBrush tb = new TextureBrush(bm);
            Bitmap final = new Bitmap(circleDiameter, circleDiameter);
            Graphics gp = Graphics.FromImage(final);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gp.FillEllipse(tb, 0, 0, circleDiameter, circleDiameter);
            gp.DrawEllipse(new Pen(c, (float)(s)), s / 2, s / 2, circleDiameter - s, circleDiameter - s);
            return final;
        }
        public Image AddBackgroundFrame(Image img, int s, Color c)// them vien cho anh hinh chu nhat
        {
            Bitmap bm = new Bitmap(img);
            Graphics gp = Graphics.FromImage(bm);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gp.DrawRectangle(new Pen(c, (float)(s)), s / 2, s / 2, bm.Size.Width - s, bm.Size.Height - s);
            return bm;

        }
        public void BalanceLable(ref Label l, int left, int right)
        {
            int middle = right - left;
            l.Location = new Point(l.Location.X, middle - l.Size.Width / 2);
        }
        public void SetImageProperties()
        {

        }
        public void SaveImageData(Image img, string namefile)// lưu ảnh cần save dưới dạng file nhị phân
        {
            string n = namefile + ".dat";
            img.Save(@"user_data\" + n);
        }
        public void SaveImageData(Image img, string namefile, string path)// lưu ảnh cần save dưới dạng file nhị phân
        {
            string n = namefile + ".dat";
            img.Save(path + "\\" + n);
        }
        public Image OpenImageData(string name)// mở file ảnh dưới dạng file nhị phân
        {
            string n = name + ".dat";
            Image img = Image.FromStream(new MemoryStream(File.ReadAllBytes(@"user_data\" + n)));
            return img;
        }
        public string[] LoadPropertiesUser()
        {
            string[] data = File.ReadAllLines(@"user_data\setting.dat");
            return data;
        }
        public void SetPropertiesUser(string SizeOfForm, string r, string g, string b)
        {
            string[] data = new string[4];
            data[0] = SizeOfForm;
            data[1] = r;
            data[2] = g;
            data[3] = b;
            File.WriteAllLines(@"user_data\setting.dat", data);
        }
        public string GetRGBValueColor(Color c)// ham lay gia tri rgb cua mau 
        {
            return c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString();
        }
        public void AudioVoice(string str, int volume, int speed)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = volume;  // 0...100  
            speechSynthesizer.Rate = speed;
            speechSynthesizer.Speak(str);
        }
        public void PlaySoundEffect(string path)
        {
            SoundPlayer sound = new SoundPlayer(path);
            sound.PlaySync();
        }
    }
    public class HistoryUse
    {
        
    }
    public static class ProfileUser
    {
        public static string ChamNgon =""; // Cau noi tao dong luc
        public static string TimeOpen="";// Time of open application
        public static int SoLanMoChuongTrinh=0;// So lan mo chuong trinh
        public static int SoLanChoiGame=0;// so luong gan choi game
        public static int DiemCaoNhatDatDuocGame=0;
        public static int SoLanLamTest=0;
        public static List<string> DsChuaThuoc;




        //Function

        /// <summary>
        /// Ham dung de Doc du lieu ban dau 
        /// Neu ko co: tao moi
        /// Neu co r : Doc du lieu
        /// </summary>

        public  static void ReadData()
        {
            
            try
            {
                List<string> Result=new List<string>();
                var fileBytes = File.ReadLines("user_data\\History.dat");
                foreach (var line in fileBytes)
                {
                    Result.Add(line);

                }
         
                ChamNgon = Result[0];
                TimeOpen = Result[1];
                SoLanMoChuongTrinh = Int32.Parse(Result[2]);
                SoLanChoiGame = Int32.Parse(Result[3]);
                DiemCaoNhatDatDuocGame = Int32.Parse(Result[4]);
                SoLanLamTest = Int32.Parse(Result[5]);
               // MessageBox.Show(SoLanMoChuongTrinh.ToString());
                

             
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
            }
          

           
        }
        public static void SaveData()
        {
            string HistoryData = ChamNgon + "\n" + TimeOpen + "\n" + SoLanMoChuongTrinh.ToString() + "\n" +SoLanChoiGame.ToString() + "\n" + DiemCaoNhatDatDuocGame.ToString() + "\n" + SoLanLamTest.ToString();
            try
            {
                string s = "user_data" + "\\History.dat";
      
                File.WriteAllText(s, HistoryData, Encoding.UTF8);
                //MessageBox.Show("Successful");
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot create file.");
                return;
            }
           
        }
        public static string CalulateTime()
        {
            string result = "";
            DateTime d = DateTime.Now;
            return result;
        }
        public static void ReadListMarkWord()
        {
            try
            {
                List<string> Result = new List<string>();
                var fileBytes = File.ReadLines("user_data\\ListWord.dat");
                foreach (var line in fileBytes)
                {
                    Result.Add(line);

                }
                DsChuaThuoc = Result;
                // MessageBox.Show(SoLanMoChuongTrinh.ToString());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
            }
        }
        public static void SaveListMarkWord()
        {
            string CacTu = "";
            for (int i = 0; i < DsChuaThuoc.Count; i++)
            {
                CacTu = string.Concat(CacTu,DsChuaThuoc[i]);

            }
           
            try
            {
                string s = "user_data" + "\\ListWord.dat";

                File.WriteAllText(s, CacTu, Encoding.UTF8);
                //MessageBox.Show("Successful");
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot create file.");
                return;
            }
        }
        public static bool CheckWordOnList(string str)
        {
            if (DsChuaThuoc.Count == 0)
            {
                return false;
            }
           
            for (int i = 0; i < DsChuaThuoc.Count; i++)
            {
                if (str == DsChuaThuoc[i])
                {
                    return true;
                }
            }
            return false;
        }


    }
}
