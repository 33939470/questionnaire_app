using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireFolder
{
    partial class Questionnaire_Answer_Control : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Content = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.Option1 = new Smobiler.Core.Controls.Label();
            this.Option2 = new Smobiler.Core.Controls.Label();
            this.Option4 = new Smobiler.Core.Controls.Label();
            this.Option3 = new Smobiler.Core.Controls.Label();
            this.Option5 = new Smobiler.Core.Controls.Label();
            this.Option6 = new Smobiler.Core.Controls.Label();
            // 
            // Content
            // 
            this.Content.DisplayMember = "Content";
            this.Content.FontSize = 16F;
            this.Content.Location = new System.Drawing.Point(50, 10);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(195, 35);
            this.Content.Text = "试题内容";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Option1,
            this.Option2,
            this.Option4,
            this.Option3,
            this.Option5,
            this.Option6});
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 210);
            // 
            // Option1
            // 
            this.Option1.DisplayMember = "OptionA";
            this.Option1.FontSize = 16F;
            this.Option1.Location = new System.Drawing.Point(50, 0);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(195, 35);
            this.Option1.Text = "Option1";
            // 
            // Option2
            // 
            this.Option2.DisplayMember = "OptionB";
            this.Option2.FontSize = 16F;
            this.Option2.Location = new System.Drawing.Point(50, 35);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(195, 35);
            this.Option2.Text = "Option2";
            // 
            // Option4
            // 
            this.Option4.DisplayMember = "OptionC";
            this.Option4.FontSize = 16F;
            this.Option4.Location = new System.Drawing.Point(50, 105);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(195, 35);
            this.Option4.Text = "Option4";
            // 
            // Option3
            // 
            this.Option3.DisplayMember = "OptionC";
            this.Option3.FontSize = 16F;
            this.Option3.Location = new System.Drawing.Point(50, 70);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(195, 35);
            this.Option3.Text = "Option3";
            // 
            // Option5
            // 
            this.Option5.FontSize = 16F;
            this.Option5.Location = new System.Drawing.Point(50, 140);
            this.Option5.Name = "Option5";
            this.Option5.Size = new System.Drawing.Size(195, 35);
            this.Option5.Text = "Option5";
            // 
            // Option6
            // 
            this.Option6.FontSize = 16F;
            this.Option6.Location = new System.Drawing.Point(50, 175);
            this.Option6.Name = "Option6";
            this.Option6.Size = new System.Drawing.Size(195, 35);
            this.Option6.Text = "Option6";
            // 
            // Questionnaire_Answer_Control
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Content,
            this.panel1});
            this.Size = new System.Drawing.Size(300, 265);
            this.Name = "Questionnaire_Answer_Control";

        }
        #endregion

        private Smobiler.Core.Controls.Label Content;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label Option1;
        private Smobiler.Core.Controls.Label Option2;
        private Smobiler.Core.Controls.Label Option4;
        private Smobiler.Core.Controls.Label Option3;
        private Smobiler.Core.Controls.Label Option5;
        private Smobiler.Core.Controls.Label Option6;
    }
}