using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.IO;
using 问卷调查.BLL;
using System.Drawing;

namespace 问卷调查.Pages
{
    partial class LoginPage : Smobiler.Core.Controls.MobileForm
    {
        public LoginPage() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passName">密码</param>
        /// <returns></returns>
        public string CheckUserInfo(string userName, string passName,ref int userID)
        {
            string reMsg = "";
            bool LoginState = false;
            LoginPageBLL loginBLL = new LoginPageBLL();
            if (string.IsNullOrWhiteSpace(userName))
                return "用户名不能为空";
            else
            {
                if (string.IsNullOrWhiteSpace(passName))
                    return "密码不能为空";
                string checkInfo = loginBLL.CheckUserInfo(userName, passName, ref LoginState, ref userID);
                if (!LoginState)
                    return checkInfo;
                else
                    return string.Empty;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //设置登录背景图片
            this.BackgroundImagePath = Path.GetFullPath((@"..//..") + @"\Source\Images\LoginBackGround\");
            this.BackgroundImage = @"LoginBackGround.jpg";
            this.BackgroundImageSizeMode = ImageSizeMode.Stretch;
            //设置按钮颜色
            // LoginBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF34B3");


            //设置用户名模块属性
            this.userName.Location = new Point(30, 200);     
            this.userNameBox.Width = 190;
            this.userNameBox.Height = 35;
            this.userNameBox.Location = new Point(75, 200);

            //设置密码模块属性
            this.passWord.Location = new Point(30, 250);
            this.passWordBox.Width = 190;
            this.passWordBox.Height = 35;                                 
            this.passWordBox.Location = new Point(75, 250);

            //设置登录按钮属性
            this.LoginBtn.Width = 230;
            this.LoginBtn.Height = 40;
            this.LoginBtn.Location = new Point(35,360);
        }

        
        private void LoginBtn_Press(object sender, EventArgs e)
        {
            //int userID = 0;
            //string CheckResult = CheckUserInfo(userNameBox.Text, passWordBox.Text,ref userID);
            //if (string.Empty == CheckResult)
            //{
            //    MainPage mainPage = new MainPage();
            //    this.Show(mainPage);
            //    Client.Session["UserId"] = userID;
            //    MessageBox.Show(Client.Session["UserId"].ToString());
            //}
            //else
            //    MessageBox.Show(CheckResult);



            //MainPage mainPage = new MainPage();
            //this.Show(mainPage);
            Show(new MainPage(), true);
        }
    }
}