using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace DZ_3_KFU_SEM_2
{
    public partial class FormTypography : Form
    {
        string target = "https://www.youtube.com/shorts/D7yxniEUh8U";
        string way = @"..\..\..\sandugach.wav";
        public FormTypography()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxForRead.ReadOnly = true;
        }

        private void buttonTypography_Click(object sender, EventArgs e)
        {
            richTextBoxForRead.Text = Rull9(richTextBoxForWrite.Text);//не плохо было бы чтобы можно было считывать откудать тип чтобы добавлять новые правила не менять код
            richTextBoxForRead.Text = Rull14(richTextBoxForWrite.Text);
            richTextBoxForRead.Text = Rull13(richTextBoxForWrite.Text);
            richTextBoxForRead.Text = Rull3(richTextBoxForWrite.Text);//если стоит после Rull5 невелирует его работу, я не понял почему
            richTextBoxForRead.Text = Rull5(richTextBoxForWrite.Text);

            Rull2(richTextBoxForWrite.Text,target);

            Rull1(richTextBoxForWrite.Text, way);



        }
        public string Rull9(string text)
        {
            text = text.Replace("+-", "±");
            text = text.Replace("-+", "±");
            return text;
        }
        public string Rull13(string text)
        {
            text = text.Replace("...", "\u2026");
            return text;
        }
        public string Rull14(string text)
        {
            text = text.Replace("и т.д.", "и т. д.");//не плохо было бы считывать откуда-то, что бы если бы это была прога можно было вносить изменения в нужные слова для замены
            text = text.Replace("и т.п.", "и т. п.");//у многих сокращения из 2 букв можно меньше когда писать, надо попробывать улучшить
            text = text.Replace("и т.к.", "и т. к.");
            text = text.Replace("до н.э.", "до н. э.");


            List<char> charList = text.ToList();
            List<int> index = new List<int>();
            for (int i = 0; i < charList.Count() - 1; i++)
            {
                if (Char.IsUpper(charList[i]) && charList[i + 1].Equals('.'))
                {
                    if (Char.IsUpper(charList[i + 2]) && charList[i + 3].Equals('.') && Char.IsUpper(charList[i + 4]))
                    {
                        charList.Insert(i + 2, ' ');
                        charList.Insert(i + 5, ' ');
                    }
                    else if(charList[i + 2].Equals(' ') && Char.IsUpper(charList[i + 3]) && charList[i + 4].Equals('.') && Char.IsUpper(charList[i + 5]))
                    {
                        charList.Insert(i + 5, ' ');
                    }
                    else if(Char.IsUpper(charList[i + 2]) && charList[i + 3].Equals('.') && charList[i + 4].Equals(' ') && Char.IsUpper(charList[i + 5]))
                    {
                        charList.Insert(i + 2, ' ');
                    }
                }
            }


                return String.Join("", charList); 
        }
        public string Rull5(string text)
        {
            List<char> listchars = text.ToList();
            for (int i = 0; i < listchars.Count() - 1; i++)
            {
                if (listchars[i] == '-')
                {
                    if (listchars[i + 1] == ' ')
                    {
                        
                        listchars.RemoveAt(i+1);

                    }
                    if (listchars[i - 1] == ' ')
                    {
                        listchars.RemoveAt(i - 1);
                    }
                }
            }
            return String.Join("", listchars);
        }


        public void Rull1(string text, string path)
        {
            if(text.ToLower().Contains("татар"))
            {
                SoundPlayer soundPlayer = new SoundPlayer(path);
                soundPlayer.Play();
            }

        }
        public void Rull2(string text, string youtube)
        {
            
            if (text.ToLower().Contains("отрицательный взлёт"))
            {
                System.Diagnostics.Process.Start(youtube);
            }
        }
        public string Rull3(string text)
        {
            text = text.Replace("хаха", "хохохохохо");
            return text;
        }
    }
}
