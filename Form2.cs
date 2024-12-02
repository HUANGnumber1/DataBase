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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminUI_Load(object sender, EventArgs e)
        {

        }

        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //在此处添加关于查询学生的数据库代码
            Form3 frm3 = new Form3();
            frm3.Owner = this;
            this.Hide();
            frm3.Show();
        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //此处放删除记录的代码
            MessageBox.Show("删除成功！");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //此处放链接到数据表的操作代码
        }

        private void 改变记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //此处放置修改记录的代码
            MessageBox.Show("修改成功！");

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Owner = this;
            this.Hide();
            frm4.Show();
        }
    }
}
