using System;
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
    public partial class _720degree : Form
    {
        
               
        public _720degree()
        {
            InitializeComponent();

        }

        private void _720degree_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://yx.whu.edu.cn/");
        }

       
    }
}
