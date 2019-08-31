using SchoolNetwork.API;
using SchoolNetwork.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNetwork.Forms
{
    internal partial class LoginForm : Form
    {
        private int temp;
        private Configuration config { get; set; }

        public LoginForm(Configuration config)
        {
            InitializeComponent();
            temp = 0;
            this.config = config;
        }

        private void Button_true_Click(object sender, EventArgs e)
        {
            var temp_u = username.Text;
            var temp_p = password.Text;
            var temp_c = validcode.Text;

            Task<bool> _back =Task.Run(() => 
            {
                return bool.Parse(config.CallMethod("Login", new object[] { temp_u, temp_p, temp_c}).ToString());
            });
            //while (!_back.IsCompleted)
            //{
            //    this.Invoke(new Action(() =>
            //    {
            //        this.button_true.Text = "";
            //        Thread.Sleep(300);
            //        this.button_true.Text = ".";
            //        Thread.Sleep(300);
            //        this.button_true.Text = "..";
            //        Thread.Sleep(300);
            //        this.button_true.Text = "...";
            //        Thread.Sleep(300);
            //    }));

            //}
            if (_back.Result)//登录成功
            {
                if (checkBox.Checked==true)
                {
                    Expandini.WritePrivateProfileString("User", "username", temp_u, config.RunPath + @"config/config.ini");
                    Expandini.WritePrivateProfileString("User", "password", temp_p, config.RunPath + @"config/config.ini");
                }
                DialogResult = DialogResult.OK;
                Hide();
            }
            else//登录失败
            {
                temp += 1;
                this.button_true.Text = "确定";
                if (temp > 3)
                {
                    panel1.Visible = true;
                    codepicture.Image = (Image)config.CallMethod("GetCode", new object[] { });
                }
            }

        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
