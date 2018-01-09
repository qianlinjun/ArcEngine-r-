using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace StuQuery
{
    public partial class PersonalInfor : Form
    {
        public PersonalInfor()
        {
            InitializeComponent();
            String fbImage = "D:\\Work\\Vs2012\\StuQuery\\personalinfor.jpeg";
            Bitmap bm = new Bitmap(fbImage); //fbImage图片路径
            this.BackgroundImage = bm;//设置背景图片
            this.BackgroundImageLayout = ImageLayout.Stretch;//设置背景图片自动适应
        }

        //查询
        private void button1_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from studentinfo", null).Tables[0].DefaultView; 
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM studentinfo WHERE StudentID = ?StudentID ");
            MySqlParameter parameters = new MySqlParameter("?StudentID", MySqlDbType.VarChar, 255);
                                 


            parameters.Value = textBox1.Text;
           MySqlDataReader reader = MySqlHelper.ExecuteReader(CommandType.Text, sb.ToString(), parameters);

            while (reader.Read())
            {
                string studentID = reader.GetString(1);//GetString(1)得到表中第二列的值，用name接收，因为查的是*，所以就和表中的列数一样。
                string name = reader.GetString(2);
                string dormitory = reader.GetString(3);

                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "学号";
                column1.HeaderText = "姓名";
                column1.HeaderText = "学院";
                column1.HeaderText = "寝室";

                dataGridView1.Columns.Add(column1);
                dataGridView1.Columns.Add(column2);
                dataGridView1.Columns.Add(column3);
                dataGridView1.Columns.Add(column4);
                dataGridView1.Rows.Add(1);

                dataGridView1.Rows[0].Cells[0].Value =name;
                dataGridView1.Rows[0].Cells[1].Value = studentID;
                dataGridView1.Rows[0].Cells[2].Value = "资源环境学院";
                dataGridView1.Rows[0].Cells[3].Value = dormitory;
            }
        }
    }
}
