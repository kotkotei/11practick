using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.IO;

namespace Pr11Sistem
{
    public partial class ScreenShot : Form
    {
        public static Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        int t = 0;
        public ScreenShot()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Form1.BM;
            
        }
       

        private void ScreenShot_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SaveFileDialog SFD = new SaveFileDialog();
            //SFD.Filter = "JPEG|*.jpg";
            //if (SFD.ShowDialog() == DialogResult.OK)
            //{
            //    Form1.BM.Save(SFD.FileName);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SaveFileDialog SFD = new SaveFileDialog();
            //SFD.Filter = "PNG|*.png";
            //if (SFD.ShowDialog() == DialogResult.OK)
            //{
            //    Form1.BM.Save(SFD.FileName);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Graphics GH = Graphics.FromImage(BM as Image);
            GH.CopyFromScreen(0, 0, 0, 0, BM.Size);
            t++;
            BM.Save(label2.Text+"\\"+t.ToString()+".jpg");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    label2.Text = Convert.ToString(fbd.SelectedPath);

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            timer1.Interval = 30000;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }
    }
}
