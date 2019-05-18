using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.Speech.Recognition;

namespace Bai3
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }
        private void AudioVoice(string s)
        {
            speechSynthesizer.Volume = 100; // 0...100  
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(s); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        //    Choices commands = new Choices();
        //    commands.Add(new string[] { "hello", "start test","i love you","print my name","what's your name","where are you from"});
        //    GrammarBuilder gBuilder = new GrammarBuilder();
        //    gBuilder.Append(commands);
        //    Grammar grammar = new Grammar(gBuilder);
        //    recEngine.LoadGrammarAsync(grammar);
        //    recEngine.SetInputToDefaultAudioDevice();
        //    recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        //
        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "hello":
                    AudioVoice("Hello Son");
                    break;
                case "what's your name":
                    AudioVoice("My name David");
                    break;
                case"i love you":
                    AudioVoice("Me too. I love U");
                    break;
                case "start test":
                    MessageBox.Show("Ok ");
                    break;
                case "where are you from":
                    AudioVoice("I'm from USA");
                    break;
                case "print my name":
                    MessageBox.Show("Son");
                    break;
                default:
                    MessageBox.Show("chua cai dat");
       
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            button1.Enabled = true;
        }
        /// <summary>
        /// kiem tra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] {"hello" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized2;
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void recEngine_SpeechRecognized2(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show(e.Result.Text);
            if (e.Result.Text == textBox1.Text)
            {
                SoundPlayer s = new SoundPlayer(@"C:\Windows\media\Windows Unlock.wav");
                s.Play();
            }
            else
            {
                SoundPlayer s = new SoundPlayer(@"C:\Windows\media\Windows Error.wav");
                s.Play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color c = Color.White;
            MessageBox.Show(c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString());
        }
        public void SaveImageData(Image img, string namefile)// lưu ảnh cần save dưới dạng file nhị phân
        {
            //namefile=namefile.Remove(namefile.LastIndexOf("."));
            string n = namefile + ".dat";
            img.Save(@"user_data\" + n);
        }

        private void btn_xulianh_Click(object sender, EventArgs e)
        {
            Image background;
            OpenFileDialog openfiledialog = new OpenFileDialog();
            Stream myStream = null;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openfiledialog.OpenFile()) != null)
                    {

                        background = Image.FromFile(openfiledialog.FileName);
                        //panel_background.BackgroundImage = f.AddBackgroundFrame(background, 8, Color.Gray);
                        if (File.Exists(@"user_data\background.dat"))
                        {
                            File.Delete(@"user_data\background.dat");
                        }
                        SaveImageData(background, "background");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }


           
           
            //List<Bitmap> images = new List<Bitmap>();
        
           
        }
    }
}
