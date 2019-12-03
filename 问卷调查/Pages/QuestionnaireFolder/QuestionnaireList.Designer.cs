using System;
using Smobiler.Core;
namespace 问卷调查.Pages
{
    partial class QuestionnaireList : Smobiler.Core.Controls.MobileForm
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
            this.CreatePaperBtn = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.QuestionnaireListView = new Smobiler.Core.Controls.ListView();
            // 
            // CreatePaperBtn
            // 
            this.CreatePaperBtn.FontSize = 18F;
            this.CreatePaperBtn.Location = new System.Drawing.Point(61, 466);
            this.CreatePaperBtn.Name = "CreatePaperBtn";
            this.CreatePaperBtn.Size = new System.Drawing.Size(182, 32);
            this.CreatePaperBtn.Text = "创建问卷";
            this.CreatePaperBtn.Press += new System.EventHandler(this.CreatePaperBtn_Press);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.FontSize = 18F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.Text = "问卷列表";
            // 
            // QuestionnaireListView
            // 
            this.QuestionnaireListView.BackColor = System.Drawing.Color.AliceBlue;
            this.QuestionnaireListView.Border = new Smobiler.Core.Controls.Border(0F, 2F, 0F, 2F);
            this.QuestionnaireListView.BorderColor = System.Drawing.Color.Gainsboro;
            this.QuestionnaireListView.Location = new System.Drawing.Point(0, 70);
            this.QuestionnaireListView.Name = "QuestionnaireListView";
            this.QuestionnaireListView.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.QuestionnaireListView.PageSizeTextSize = 11F;
            this.QuestionnaireListView.ShowSplitLine = true;
            this.QuestionnaireListView.Size = new System.Drawing.Size(300, 390);
            this.QuestionnaireListView.TemplateControlName = "QuestionnaireListControl";
            // 
            // PaperList
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.CreatePaperBtn,
            this.label1,
            this.QuestionnaireListView});
            this.Load += new System.EventHandler(this.PaperList_Load);
            this.Name = "PaperList";

        }
        #endregion

        private Smobiler.Core.Controls.Button CreatePaperBtn;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ListView QuestionnaireListView;
    }
}