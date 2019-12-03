using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 问卷调查.Business;
using 问卷调查.Pages.QuestionnaireListFolder;

namespace 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages
{
    partial class QuestionnaireTypeList : Smobiler.Core.Controls.MobileForm
    {
        public QuestionnaireTypeList() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void QuestionnaireTypeList_Load(object sender, EventArgs e)
        {
            //获取菜单
            MenuGroup();
        }
        QuestionnaireOption questionnaireOption = new QuestionnaireOption();
        /// <summary>
        ///获取菜单
        /// </summary>
        private void MenuGroup()
        {
            try
            {
                List<QuestionnaireTypeInfo> questionnaireOptionList = questionnaireOption.GetQuestionnaireTypeInfo();
                this.iconMenuData.Groups.Clear();
                // MenuGroupDict.Clear();
                IconMenuViewGroup grp = new IconMenuViewGroup("");
                grp.IconBorderRadius = 20;
                //获取所有菜单组
                foreach (QuestionnaireTypeInfo item in questionnaireOptionList)
                {
                    //添加一级菜单
                    grp.Items.Add(new IconMenuViewItem(item.ID.ToString(), item.portrait, item.Name, item.ID.ToString(), ""));
                }
                this.iconMenuData.Groups.Add(grp);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void iconMenuView1_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            Show(new QuestionTypeList(int.Parse(e.Item.ID)));
        }
    }
}