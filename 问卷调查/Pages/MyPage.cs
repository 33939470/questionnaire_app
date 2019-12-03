using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace 问卷调查.Pages
{
    partial class MyPage : Smobiler.Core.Controls.MobileForm
    {
        public MyPage() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        internal string toolbarItemName = "";
        private void MyPage_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Toolbar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            toolbarItemName = e.Name;
            switch (e.Name)
            {
                case "My":
                    break;
                default:
                    this.Close();
                    break;
            }
            //if (!e.Name.Equals("Me"))
            //{
            //    toolbarItemName = e.Name;
            //    Close();
            //}
        }
    }
}