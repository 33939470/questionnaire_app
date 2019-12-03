using System;
using Smobiler.Core;
namespace 问卷调查.Pages.InitiatingQuestion
{
    partial class InitiatingQuestionnaireControl : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.Transparent;
            this.label1.DisplayMember = "MenuName";
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(45, 78);
            this.label1.Name = "label1";
            this.label1.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.Text = "label1";
            // 
            // imageButton1
            // 
            this.imageButton1.Border = new Smobiler.Core.Controls.Border(1F);
            this.imageButton1.BorderColor = System.Drawing.Color.LightGray;
            this.imageButton1.BorderRadius = 10;
            this.imageButton1.DisplayMember = "Portrait";
            this.imageButton1.Location = new System.Drawing.Point(9, 10);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "调查";
            this.imageButton1.Size = new System.Drawing.Size(130, 88);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // InitiatingQuestionnaireControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.imageButton1});
            this.Size = new System.Drawing.Size(150, 110);
            this.Load += new System.EventHandler(this.InitiatingQuestionnaireControl_Load);
            this.Name = "InitiatingQuestionnaireControl";

        }
        #endregion
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
    }
}