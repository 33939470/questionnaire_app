using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireFolder
{
    partial class Questionnaire_Answer : Smobiler.Core.Controls.MobileForm
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
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.SkyBlue;
            this.Title.FontSize = 18F;
            this.Title.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Title.Name = "Title";
            this.Title.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.Title.Size = new System.Drawing.Size(300, 50);
            this.Title.Text = "问卷标题";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 50);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.Size = new System.Drawing.Size(300, 404);
            this.listView1.TemplateControlName = "Questionnaire_Answer_Control";
            // 
            // Questionnaire_Answer
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title,
            this.listView1});
            this.Name = "Questionnaire_Answer";

        }
        #endregion

        private Smobiler.Core.Controls.Label Title;
        private Smobiler.Core.Controls.ListView listView1;
    }
}