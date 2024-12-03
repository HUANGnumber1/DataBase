using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseUI
{
    public partial class Form4 : Form
    {
        public Form4(string Value)
        {
            InitializeComponent();
            Select( Value);

        }

        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            //从数据库中读取相应的数据，并显示出来
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //放入增加的代码
        }
        private void Form4_Load(string Value)
        {
            //从数据库中读取相应的数据，并显示出来
            //此处将查询的字符串用Value替换
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //放入修改的代码
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //放入删除的代码
        }
        private void Select(string Value)
        {
            //此处放入查询的代码
        }
    }
}
