using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages
{
    partial class AnswerPage : Smobiler.Core.Controls.MobileForm
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
            this.title1 = new Smobiler.Core.Controls.Title();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(111, 35);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 41);
            // 
            // AnswerPage
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1});
            this.Load += new System.EventHandler(this.AnswerPage_Load);
            this.Name = "AnswerPage";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
    }
}