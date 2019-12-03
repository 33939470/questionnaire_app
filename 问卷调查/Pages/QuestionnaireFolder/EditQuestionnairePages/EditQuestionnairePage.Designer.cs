using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireListFolder
{
    partial class EditQuestionnairePage : Smobiler.Core.Controls.MobileForm
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
            this.Title = new Smobiler.Core.Controls.Label();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.SkyBlue;
            this.Title.FontSize = 18F;
            this.Title.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Title.Name = "Title";
            this.Title.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.Title.Size = new System.Drawing.Size(300, 50);
            this.Title.Text = "问题编辑";
            // 
            // EditQuestionnairePage
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title});
            this.Load += new System.EventHandler(this.EditQuestionnairePage_Load);
            this.Name = "EditQuestionnairePage";

        }
        #endregion

        private Smobiler.Core.Controls.Label Title;
    }
}