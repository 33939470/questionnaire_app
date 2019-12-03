using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using 问卷调查.Business;

namespace 问卷调查.Pages.InitiatingQuestion
{
    partial class InitiatingQuestionnaire : Smobiler.Core.Controls.MobileForm
    {
        //菜单信息逻辑操作层
        MenuInfoOption MenuOption = new MenuInfoOption();
        //菜单ID
        int MeunID;
        public InitiatingQuestionnaire(int MeunInfoID) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            MeunID = MeunInfoID;
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            
        }

        private void InitiatingQuestionnaire_Load(object sender, EventArgs e)
        {

         List<MenuInfo> MenuInfoList = MenuOption.GetMenuByParentID(MeunID);

            DataTable gridTable = new DataTable();

            gridTable.Columns.Add("Portrait");
            gridTable.Columns.Add("MenuName");

            foreach (MenuInfo Menu in MenuInfoList)
            {
                gridTable.Rows.Add(Menu.Portrait, Menu.MenuName);
            }
          
            gridView1.Cells.Clear();     //清除数据
            if (gridTable.Rows.Count > 0)    //绑定数据源
            {
                gridView1.DataSource = gridTable;
                gridView1.DataBind();
            }
        }

        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {

        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}