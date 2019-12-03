using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages
{
    partial class QuestionnaireTypeList : Smobiler.Core.Controls.MobileForm
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
            this.iconMenuData = new Smobiler.Core.Controls.IconMenuView();
            this.title = new Smobiler.Core.Controls.Label();
            // 
            // iconMenuData
            // 
            this.iconMenuData.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.iconMenuData.BorderColor = System.Drawing.Color.Silver;
            this.iconMenuData.ColumnNum = 2;
            this.iconMenuData.Location = new System.Drawing.Point(0, 47);
            this.iconMenuData.MenuItemHeight = 120;
            this.iconMenuData.Name = "iconMenuData";
            this.iconMenuData.Size = new System.Drawing.Size(300, 453);
            this.iconMenuData.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.SkyBlue;
            this.title.FontSize = 18F;
            this.title.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.title.Name = "title";
            this.title.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.title.Size = new System.Drawing.Size(300, 50);
            this.title.Text = "问卷类型";
            // 
            // QuestionnaireTypeList
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.iconMenuData,
            this.title});
            this.Load += new System.EventHandler(this.QuestionnaireTypeList_Load);
            this.Name = "QuestionnaireTypeList";

        }
        #endregion

        private Smobiler.Core.Controls.IconMenuView iconMenuData;
        private Smobiler.Core.Controls.Label title;
    }
}