using System;
using Smobiler.Core;
namespace 问卷调查.Pages.InitiatingQuestion
{
    partial class InitiatingQuestionnaire : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem4 = new Smobiler.Core.Controls.ToolBarItem();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.MenuLeftBtn = new Smobiler.Core.Controls.ImageButton();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.MenuLeftBtn,
            this.button1});
            this.panel1.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 45);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.FontSize = 18F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.Text = "发起问卷";
            // 
            // MenuLeftBtn
            // 
            this.MenuLeftBtn.Name = "MenuLeftBtn";
            this.MenuLeftBtn.ResourceID = "MenuLeft.png";
            this.MenuLeftBtn.ResourcePath = "..\\..\\Source\\Images\\LoginBackGround\\";
            this.MenuLeftBtn.Size = new System.Drawing.Size(45, 45);
            this.MenuLeftBtn.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 30);
            this.button1.Text = "返回";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridView1});
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 407);
            // 
            // gridView1
            // 
            this.gridView1.BackColor = System.Drawing.Color.White;
            this.gridView1.BorderColor = System.Drawing.Color.Transparent;
            this.gridView1.BorderRadius = 3;
            this.gridView1.ColumnNum = 2;
            this.gridView1.GridLineColor = System.Drawing.Color.Transparent;
            this.gridView1.Location = new System.Drawing.Point(0, 19);
            this.gridView1.Name = "gridView1";
            this.gridView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridView1.PageSizeTextSize = 11F;
            this.gridView1.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.gridView1.ShowGridLine = true;
            this.gridView1.Size = new System.Drawing.Size(300, 368);
            this.gridView1.TemplateControlName = "InitiatingQuestionnaireControl";
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            toolBarItem3.IconID = "底部导航条/功能";
            toolBarItem3.MessageText = "3";
            toolBarItem3.Name = "functional";
            toolBarItem3.SelectIconColor = System.Drawing.Color.Silver;
            toolBarItem3.SelectIconID = "底部导航条/功能2";
            toolBarItem4.IconID = "底部导航条/me";
            toolBarItem4.Name = "My";
            toolBarItem4.SelectIconColor = System.Drawing.Color.Silver;
            toolBarItem4.SelectIconID = "底部导航条/me2";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem3,
            toolBarItem4});
            this.toolBar1.Location = new System.Drawing.Point(192, 459);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.SelectedIndex = 0;
            this.toolBar1.Size = new System.Drawing.Size(100, 48);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // InitiatingQuestionnaire
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.toolBar1});
            this.Load += new System.EventHandler(this.InitiatingQuestionnaire_Load);
            this.Name = "InitiatingQuestionnaire";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ImageButton MenuLeftBtn;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.GridView gridView1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Button button1;
    }
}