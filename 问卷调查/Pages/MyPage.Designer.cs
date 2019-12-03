using System;
using Smobiler.Core;
namespace 问卷调查.Pages
{
    partial class MyPage : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "button1";
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            toolBarItem1.IconID = "底部导航条/功能2";
            toolBarItem1.MessageText = "3";
            toolBarItem1.Name = "functional";
            toolBarItem1.SelectIconColor = System.Drawing.Color.Silver;
            toolBarItem1.SelectIconID = "底部导航条/功能";
            toolBarItem2.IconID = "底部导航条/me";
            toolBarItem2.Name = "My";
            toolBarItem2.SelectIconColor = System.Drawing.Color.Silver;
            toolBarItem2.SelectIconID = "底部导航条/me2";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2});
            this.toolBar1.Location = new System.Drawing.Point(192, 459);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.SelectedIndex = 0;
            this.toolBar1.Size = new System.Drawing.Size(100, 48);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // MyPage
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.toolBar1});
            this.Load += new System.EventHandler(this.MyPage_Load);
            this.Name = "MyPage";

        }
        #endregion

        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
    }
}