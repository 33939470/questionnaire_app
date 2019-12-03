using System;
using Smobiler.Core;
using System.IO;

namespace 问卷调查.Pages
{
    partial class LoginPage : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.gps1 = new Smobiler.Core.Controls.GPS();
            this.userName = new Smobiler.Core.Controls.Label();
            this.userNameBox = new Smobiler.Core.Controls.TextBox();
            this.passWord = new Smobiler.Core.Controls.Label();
            this.passWordBox = new Smobiler.Core.Controls.TextBox();
            this.LoginBtn = new Smobiler.Core.Controls.Button();
            // 
            // gps1
            // 
            this.gps1.Name = "gps1";
            // 
            // userName
            // 
            this.userName.FontSize = 18F;
            this.userName.Location = new System.Drawing.Point(33, 180);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(36, 35);
            this.userName.Text = "账号";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(88, 180);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(165, 35);
            // 
            // passWord
            // 
            this.passWord.FontSize = 18F;
            this.passWord.Location = new System.Drawing.Point(33, 238);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(36, 35);
            this.passWord.Text = "密码";
            // 
            // passWordBox
            // 
            this.passWordBox.Location = new System.Drawing.Point(87, 238);
            this.passWordBox.Name = "passWordBox";
            this.passWordBox.Size = new System.Drawing.Size(166, 35);
            // 
            // LoginBtn
            // 
            this.LoginBtn.FontSize = 18F;
            this.LoginBtn.Location = new System.Drawing.Point(30, 327);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(223, 36);
            this.LoginBtn.Text = "登       录";
            this.LoginBtn.Press += new System.EventHandler(this.LoginBtn_Press);
            // 
            // LoginPage
            // 
            this.BackgroundImage = "LoginBackGround.jpg";
            this.BackgroundImagePath = "..\\..\\Source\\Images\\LoginBackGround\\";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.userName,
            this.userNameBox,
            this.passWord,
            this.passWordBox,
            this.LoginBtn});
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Name = "LoginPage";

        }
        #endregion

        private Smobiler.Core.Controls.GPS gps1;
        private Smobiler.Core.Controls.Label userName;
        private Smobiler.Core.Controls.TextBox userNameBox;
        private Smobiler.Core.Controls.Label passWord;
        private Smobiler.Core.Controls.TextBox passWordBox;
        private Smobiler.Core.Controls.Button LoginBtn;
    }
}