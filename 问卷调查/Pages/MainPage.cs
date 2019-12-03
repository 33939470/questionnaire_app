using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using 问卷调查.Controls;
using System.Data.SqlClient;
using 问卷调查.Business;
using 问卷调查.Pages.InitiatingQuestion;
using 问卷调查.BLL;
using 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages;

namespace 问卷调查.Pages
{
    partial class MainPage : Smobiler.Core.Controls.MobileForm
    {
        public MainPage() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region "definition"
        /// <summary>
        /// 菜单组字典
        /// </summary>
        /// <remarks></remarks>
        private Dictionary<string, IconMenuViewGroup> MenuGroupDict;//二级菜单
        private DateTime toasttime;//toast时间
        //AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion


        private void MainPage_Load(object sender, EventArgs e)
        {
            
            MenuGroupDict = new Dictionary<string, IconMenuViewGroup>();
            using (var context = new paper_QuestionnaireEntities())
            {
                int userID = context.Database.SqlQuery<int>("select id from userinfo where username=@p0",
                    new SqlParameter("@p0", "admin")).FirstOrDefault();
                Client.Session["UserId"] = userID;
            }
            //获取菜单
            MenuGroup();
        }
        //菜单信息逻辑操作层
        MenuInfoOption MenuOption = new MenuInfoOption();
        /// <summary>
        ///获取菜单
        /// </summary>
        private void MenuGroup()
        {
            try
            {
                List<MenuInfo> listmenu = MenuOption.GetMenuByUserID(int.Parse(Client.Session["UserId"].ToString()));
                this.iconMenuData.Groups.Clear();
                MenuGroupDict.Clear();
                IconMenuViewGroup grp = new IconMenuViewGroup("");
                grp.IconBorderRadius = 20;
                //获取所有菜单组
                foreach (MenuInfo menu in listmenu)
                {
                    if (string.IsNullOrWhiteSpace(menu.ParentID.ToString()) == true)
                    {
                        //添加一级菜单
                        grp.Items.Add(new IconMenuViewItem(menu.MenuID.ToString(), menu.Portrait, menu.MenuName, menu.MenuID.ToString(), ""));

                        #region 添加二级菜单
                        ////添加二级菜单
                        //List<MenuInfo> listsecondMenu = MenuOption.GetSubMenuByUserID(Client.Session["UserId"].ToString(), menu.MenuID.ToString());
                        //if (listsecondMenu.Count > 0)
                        //{
                        //    MenuInfo menuItem = MenuOption.GetMenuByMenuID(menu.MenuID);
                        //    IconMenuViewGroup mvGroupItem = new IconMenuViewGroup(menuItem.MenuName);
                        //    foreach (MenuInfo secondMenu in listsecondMenu)
                        //    {
                        //        mvGroupItem.Items.Add(new IconMenuViewItem(secondMenu.MenuID.ToString(), secondMenu.Portrait, secondMenu.MenuName, secondMenu.MenuID.ToString(), ""));
                        //        if (MenuGroupDict.ContainsKey(menu.MenuID.ToString()) == false)
                        //            MenuGroupDict.Add(menu.MenuID.ToString(), mvGroupItem);
                        //    }
                        //}
                        #endregion
                    }
                }
                this.iconMenuData.Groups.Add(grp);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.OpenDrawer();//打开侧边栏
        }

        private void iconMenuView1_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            MenuItem(e.Item.ID, e.Item.Text);
        }

        /// <summary>
        /// 菜单点击事件方法
        /// </summary>
        /// <param name="MenuID"></param>
        private void MenuItem(string MenuID, string MenuName)
        {
            //if (MenuGroupDict.ContainsKey(MenuID) == true)
            //{
            //    //显示当前菜单的二级菜单
            //    this.iconMenuData.ShowDialogMenu(MenuGroupDict[MenuID]);
            //}
            //else
            //{
            switch (MenuName)
            {
                //创建请假
                case "问卷发起":
                    Show(new InitiatingQuestionnaire(int.Parse(MenuID)), true);
                    //Leave.frmLeaveCreate frmLeaveCreate = new Leave.frmLeaveCreate();
                    ////请假创建界面添加侧滑关闭功能，在Show中将设置moveClose为True
                    //Show(frmLeaveCreate, true);
                    break;
                case "问卷列表":
                    Show(new QuestionnaireList((int)Client.Session["UserId"]), true);
                    break;
                case "在线评测":
                    Show(new QuestionnaireTypeList());
                    break;

            }
            //}
        }
        /// <summary>
        /// Toolbar方法
        /// </summary>
        /// <param name="toolbarItemName"></param>
        private void ProcessToolbarFormName(string toolbarItemName)
        {
            try
            {
                switch (toolbarItemName)
                {
                    case "":
                        this.Close();
                        break;
                    case "My":
                        MyPage my = new MyPage();
                        this.Show(my, (MobileForm sender1, object args) =>
                        {
                            ProcessToolbarFormName(my.toolbarItemName);
                            //UI.Layout.LeftPage lp = this.Drawer as UI.Layout.LeftPage;
                            //lp.getUser();
                        }
                        );
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Toolbar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            ProcessToolbarFormName(e.Name);

        }

        private void button1_Press(object sender, EventArgs e)
        {
            barcodeScanner1.GetBarcode();
        }

        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.error))
                {
                    Show(new QuestionnaireList(Convert.ToInt32(RSACSR.Decrypt(e.Value))), true);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("非有效二维码");
            }
        }
    }
}