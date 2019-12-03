using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireListFolder
{
    partial class QuestionnaireListControl : Smobiler.Core.Controls.MobileUserControl
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
            Smobiler.Core.Controls.RadioButton radioButton3 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton4 = new Smobiler.Core.Controls.RadioButton();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.EditBtn = new Smobiler.Core.Controls.Button();
            this.DeleteBtn = new Smobiler.Core.Controls.Button();
            this.ReleaseBtn = new Smobiler.Core.Controls.Button();
            this.startQuestion = new Smobiler.Core.Controls.Button();
            this.radioGroup1 = new Smobiler.Core.Controls.RadioGroup();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.NumberText = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.Titel = new Smobiler.Core.Controls.Label();
            this.CreateTime = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.Id = new Smobiler.Core.Controls.Label();
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.EditBtn,
            this.DeleteBtn,
            this.ReleaseBtn,
            this.startQuestion,
            this.radioGroup1,
            this.label3,
            this.NumberText});
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 60);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(77, 28);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(42, 24);
            this.EditBtn.Text = "编辑";
            this.EditBtn.Press += new System.EventHandler(this.EditBtn_Press);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(150, 28);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(49, 24);
            this.DeleteBtn.Text = "删除";
            // 
            // ReleaseBtn
            // 
            this.ReleaseBtn.Location = new System.Drawing.Point(10, 28);
            this.ReleaseBtn.Name = "ReleaseBtn";
            this.ReleaseBtn.Size = new System.Drawing.Size(42, 24);
            this.ReleaseBtn.Text = "发布";
            this.ReleaseBtn.Press += new System.EventHandler(this.button1_Press);
            // 
            // startQuestion
            // 
            this.startQuestion.Location = new System.Drawing.Point(77, 26);
            this.startQuestion.Name = "startQuestion";
            this.startQuestion.Size = new System.Drawing.Size(54, 28);
            this.startQuestion.Text = "开始作答";
            this.startQuestion.Press += new System.EventHandler(this.startQuestion_Press);
            // 
            // radioGroup1
            // 
            this.radioGroup1.ButtonHeight = 30;
            radioButton3.ID = "0";
            radioButton3.Text = "匿名";
            radioButton3.Value = null;
            radioButton4.ID = "1";
            radioButton4.Text = "实名";
            radioButton4.Value = null;
            this.radioGroup1.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton3,
            radioButton4});
            this.radioGroup1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioGroup1.Location = new System.Drawing.Point(223, 4);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.radioGroup1.Size = new System.Drawing.Size(68, 50);
            this.radioGroup1.ButtonPress += new Smobiler.Core.Controls.RadioButtonPressEventHandler(this.radioGroup1_ButtonPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(150, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.Text = "调查对象类型:";
            // 
            // NumberText
            // 
            this.NumberText.DisplayMember = "Number";
            this.NumberText.Location = new System.Drawing.Point(21, 4);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(31, 18);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Titel,
            this.CreateTime,
            this.label1,
            this.label2});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            // 
            // Titel
            // 
            this.Titel.DisplayMember = "Name";
            this.Titel.FontSize = 16F;
            this.Titel.Location = new System.Drawing.Point(11, 0);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(148, 33);
            this.Titel.Text = "问卷标题";
            // 
            // CreateTime
            // 
            this.CreateTime.DisplayMember = "CreateTime";
            this.CreateTime.FontSize = 10F;
            this.CreateTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTime.Location = new System.Drawing.Point(201, 9);
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Size = new System.Drawing.Size(88, 24);
            this.CreateTime.Text = "时间";
            // 
            // label1
            // 
            this.label1.FontSize = 12F;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.Text = "创建时间:";
            // 
            // label2
            // 
            this.label2.DisplayMember = "ID";
            this.label2.Location = new System.Drawing.Point(128, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Id
            // 
            this.Id.DisplayMember = "Id";
            this.Id.FontSize = 15F;
            this.Id.Location = new System.Drawing.Point(11, 115);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(40, 27);
            this.Id.Text = "Id";
            // 
            // QuestionnaireListControl
            // 
            this.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.BorderColor = System.Drawing.Color.Gainsboro;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel3,
            this.Id});
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.QuestionnaireListControl_Load);
            this.Name = "QuestionnaireListControl";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Button EditBtn;
        private Smobiler.Core.Controls.Button DeleteBtn;
        private Smobiler.Core.Controls.Button ReleaseBtn;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label Titel;
        private Smobiler.Core.Controls.Label CreateTime;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Button startQuestion;
        private Smobiler.Core.Controls.RadioGroup radioGroup1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label NumberText;
        private Smobiler.Core.Controls.Label Id;
    }
}