﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //上面代码莫动
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //此处放读取文本框内字符作为用户名的程序
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PassWord_TextChanged(object sender, EventArgs e)
        {
            //此处放读取文本框内字符作为密码的程序
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //此处为登录处理函数
            login();
        }

        public void login()
        {

        }
    }
}

