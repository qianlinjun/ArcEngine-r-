using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuQuery
{
    public partial class SchoolInfor : Form
    {
        private int index = 0;
        private ArrayList arrPath = new ArrayList();
        Bitmap myBitmap;


        public SchoolInfor()
        {
            InitializeComponent();
            if (pictureBox1.Image != null)
            {
                timer1.Enabled = true;
            }
            arrPath.Add("D:\\Work\\Vs2012\\StuQuery\\StuQuery\\Resources\\1.png");
            arrPath.Add("D:\\Work\\Vs2012\\StuQuery\\StuQuery\\Resources\\2.png");
            arrPath.Add("D:\\Work\\Vs2012\\StuQuery\\StuQuery\\Resources\\3.png");
            arrPath.Add("D:\\Work\\Vs2012\\StuQuery\\StuQuery\\Resources\\4.png");
            arrPath.Add("D:\\Work\\Vs2012\\StuQuery\\StuQuery\\Resources\\5.png");
            pictureBox1.Load(arrPath[index].ToString());
                //Bitmap srcBitmap = new Bitmap(openFile.FileName);
                //myBitmap = new Bitmap(srcBitmap, this.pictureBox1.Width, this.pictureBox1.Height);
                //this.pictureBox1.Image = myBitmap;
                ////this.pictureBox1.Image = Image.FromFile(openFile.FileName);
                //if (openFile.FileNames.Length != -1)
                //{
                //    foreach (string s in openFile.FileNames)
                //    {
                //        arrPath.Add(s);
                //    }
                //    index = 0;
                //    pictureBox1.Load(arrPath[index].ToString());
                //}
        }

        //上一张
        private void button1_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                index = (index == 0) ? (arrPath.Count - 1) : (--index);
                for (int i = 0; i <= index; i++)
                {
                    pictureBox1.Load(arrPath[i].ToString());
                }
            }
        }

        //下一张
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (index < arrPath.Count - 1)
                {
                    pictureBox1.Load(arrPath[++index].ToString());
                }
                else { index = 0; pictureBox1.Load(arrPath[index].ToString()); }
            }
        }


    }
}
