using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireListFolder.sendQ
{
    partial class SedQuestion : Smobiler.Core.Controls.MobileForm
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
            this.barCodeView1 = new Smobiler.Core.Controls.BarCodeView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // barCodeView1
            // 
            this.barCodeView1.Location = new System.Drawing.Point(27, 217);
            this.barCodeView1.Name = "barCodeView1";
            this.barCodeView1.Size = new System.Drawing.Size(243, 231);
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(0, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.Text = "打开软件扫一扫参与问卷调查";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "返回";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // label2
            // 
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(0, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 35);
            this.label2.Text = "复制下面链接参与问卷调查";
            // 
            // label3
            // 
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(0, 98);
            this.label3.Name = "label3";
            this.label3.Selectable = true;
            this.label3.Size = new System.Drawing.Size(300, 35);
            this.label3.Text = "label3";
            this.label3.Underline = true;
            // 
            // SedQuestion
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.barCodeView1,
            this.label1,
            this.button1,
            this.label2,
            this.label3});
            this.Load += new System.EventHandler(this.SedQuestion_Load);
            this.Name = "SedQuestion";

        }
        #endregion

        private Smobiler.Core.Controls.BarCodeView barCodeView1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
    }
}