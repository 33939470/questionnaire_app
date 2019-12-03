using System;
using Smobiler.Core;
namespace 问卷调查.Pages
{
    partial class MainPage : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.MenuLeftBtn = new Smobiler.Core.Controls.ImageButton();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.iconMenuData = new Smobiler.Core.Controls.IconMenuView();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
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
            this.label1.Text = "主页";
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
            this.button1.Location = new System.Drawing.Point(200, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 30);
            this.button1.Text = "扫一扫";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.iconMenuData});
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 407);
            // 
            // iconMenuData
            // 
            this.iconMenuData.Border = new Smobiler.Core.Controls.Border(1F);
            this.iconMenuData.ColumnNum = 3;
            this.iconMenuData.Location = new System.Drawing.Point(0, 18);
            this.iconMenuData.Name = "iconMenuData";
            this.iconMenuData.Size = new System.Drawing.Size(300, 368);
            this.iconMenuData.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            toolBarItem1.IconID = "底部导航条/功能";
            toolBarItem1.MessageText = "3";
            toolBarItem1.Name = "functional";
            toolBarItem1.SelectIconColor = System.Drawing.Color.Silver;
            toolBarItem1.SelectIconID = "底部导航条/功能2";
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
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // MainPage
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcodeScanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.toolBar1});
            this.DrawerName = "MenuLeft";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Name = "MainPage";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.IconMenuView iconMenuData;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ImageButton MenuLeftBtn;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
    }
}