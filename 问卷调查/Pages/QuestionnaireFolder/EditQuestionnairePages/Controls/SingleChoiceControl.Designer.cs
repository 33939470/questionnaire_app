using System;
using Smobiler.Core;
namespace 问卷调查.Pages.EditQuestionnairePages.Controls
{
    partial class SingleChoiceControl : Smobiler.Core.Controls.MobileUserControl
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
            Smobiler.Core.Controls.RadioButton radioButton9 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton10 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton11 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton12 = new Smobiler.Core.Controls.RadioButton();
            this.ProbType = new Smobiler.Core.Controls.Label();
            this.numberText = new Smobiler.Core.Controls.Label();
            this.Number = new Smobiler.Core.Controls.Label();
            this.ContentText = new Smobiler.Core.Controls.TextBox();
            this.AnswerInfoPanel = new Smobiler.Core.Controls.Panel();
            this.Answer = new Smobiler.Core.Controls.RadioGroup();
            this.OptionA = new Smobiler.Core.Controls.TextBox();
            this.OptionC = new Smobiler.Core.Controls.TextBox();
            this.OptionD = new Smobiler.Core.Controls.TextBox();
            this.OptionB = new Smobiler.Core.Controls.TextBox();
            this.Option1 = new Smobiler.Core.Controls.Label();
            this.Option2 = new Smobiler.Core.Controls.Label();
            this.Option3 = new Smobiler.Core.Controls.Label();
            this.Option4 = new Smobiler.Core.Controls.Label();
            this.CheckID = new Smobiler.Core.Controls.Label();
            // 
            // ProbType
            // 
            this.ProbType.DisplayMember = "TypeInfo";
            this.ProbType.FontSize = 18F;
            this.ProbType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ProbType.Location = new System.Drawing.Point(31, 5);
            this.ProbType.Name = "ProbType";
            this.ProbType.Size = new System.Drawing.Size(88, 24);
            this.ProbType.Text = "单选题";
            // 
            // numberText
            // 
            this.numberText.FontSize = 14F;
            this.numberText.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.numberText.Location = new System.Drawing.Point(210, 5);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(35, 25);
            this.numberText.Text = "题号:";
            // 
            // Number
            // 
            this.Number.DisplayMember = "Number";
            this.Number.FontSize = 14F;
            this.Number.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Number.Location = new System.Drawing.Point(245, 5);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(36, 24);
            this.Number.Text = "xx";
            // 
            // ContentText
            // 
            this.ContentText.Border = new Smobiler.Core.Controls.Border(1F);
            this.ContentText.BorderColor = System.Drawing.Color.Silver;
            this.ContentText.BorderRadius = 3;
            this.ContentText.DisplayMember = "Content";
            this.ContentText.ForeColor = System.Drawing.Color.Silver;
            this.ContentText.Location = new System.Drawing.Point(31, 37);
            this.ContentText.MaxLength = 240;
            this.ContentText.Name = "ContentText";
            this.ContentText.Size = new System.Drawing.Size(234, 30);
            this.ContentText.Text = "此处填写试题内容";
            this.ContentText.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.ContentText.TouchEnter += new System.EventHandler(this.ContentText_TouchEnter);
            this.ContentText.TouchLeave += new System.EventHandler(this.ContentText_TouchLeave);
            // 
            // AnswerInfoPanel
            // 
            this.AnswerInfoPanel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Answer,
            this.OptionA,
            this.OptionC,
            this.OptionD,
            this.OptionB,
            this.Option1,
            this.Option2,
            this.Option3,
            this.Option4});
            this.AnswerInfoPanel.Location = new System.Drawing.Point(31, 67);
            this.AnswerInfoPanel.Name = "AnswerInfoPanel";
            this.AnswerInfoPanel.Size = new System.Drawing.Size(234, 113);
            // 
            // Answer
            // 
            radioButton9.ID = "A";
            radioButton9.Value = null;
            radioButton10.ID = "B";
            radioButton10.Value = null;
            radioButton11.ID = "C";
            radioButton11.Value = null;
            radioButton12.ID = "D";
            radioButton12.Value = null;
            this.Answer.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton9,
            radioButton10,
            radioButton11,
            radioButton12});
            this.Answer.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Answer.Location = new System.Drawing.Point(0, 6);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(48, 101);
            this.Answer.ButtonPress += new Smobiler.Core.Controls.RadioButtonPressEventHandler(this.Answer_ButtonPress);
            // 
            // OptionA
            // 
            this.OptionA.Border = new Smobiler.Core.Controls.Border(1F);
            this.OptionA.BorderColor = System.Drawing.Color.Silver;
            this.OptionA.BorderRadius = 3;
            this.OptionA.DisplayMember = "OptionA";
            this.OptionA.Location = new System.Drawing.Point(53, 6);
            this.OptionA.Name = "OptionA";
            this.OptionA.Size = new System.Drawing.Size(180, 23);
            // 
            // OptionC
            // 
            this.OptionC.Border = new Smobiler.Core.Controls.Border(1F);
            this.OptionC.BorderColor = System.Drawing.Color.Silver;
            this.OptionC.BorderRadius = 3;
            this.OptionC.DisplayMember = "OptionC";
            this.OptionC.Location = new System.Drawing.Point(53, 58);
            this.OptionC.Name = "OptionC";
            this.OptionC.Size = new System.Drawing.Size(180, 23);
            // 
            // OptionD
            // 
            this.OptionD.Border = new Smobiler.Core.Controls.Border(1F);
            this.OptionD.BorderColor = System.Drawing.Color.Silver;
            this.OptionD.BorderRadius = 3;
            this.OptionD.DisplayMember = "OptionD";
            this.OptionD.Location = new System.Drawing.Point(53, 84);
            this.OptionD.Name = "OptionD";
            this.OptionD.Size = new System.Drawing.Size(180, 23);
            // 
            // OptionB
            // 
            this.OptionB.Border = new Smobiler.Core.Controls.Border(1F);
            this.OptionB.BorderColor = System.Drawing.Color.Silver;
            this.OptionB.BorderRadius = 3;
            this.OptionB.DisplayMember = "OptionB";
            this.OptionB.Location = new System.Drawing.Point(53, 32);
            this.OptionB.Name = "OptionB";
            this.OptionB.Size = new System.Drawing.Size(180, 23);
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(0, 6);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(48, 23);
            this.Option1.Text = "选项1";
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(0, 32);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(48, 23);
            this.Option2.Text = "选项2";
            // 
            // Option3
            // 
            this.Option3.Location = new System.Drawing.Point(0, 58);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(48, 23);
            this.Option3.Text = "选项3";
            // 
            // Option4
            // 
            this.Option4.Location = new System.Drawing.Point(0, 84);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(48, 23);
            this.Option4.Text = "选项4";
            // 
            // CheckID
            // 
            this.CheckID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.CheckID.Location = new System.Drawing.Point(131, 9);
            this.CheckID.Name = "CheckID";
            this.CheckID.Size = new System.Drawing.Size(63, 28);
            // 
            // SingleChoiceControl
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Border = new Smobiler.Core.Controls.Border(1F);
            this.BorderColor = System.Drawing.Color.Silver;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ProbType,
            this.numberText,
            this.Number,
            this.AnswerInfoPanel,
            this.ContentText,
            this.CheckID});
            this.Size = new System.Drawing.Size(300, 200);
            this.Load += new System.EventHandler(this.SingleChoiceControl_Load);
            this.Name = "SingleChoiceControl";

        }
        #endregion

        private Smobiler.Core.Controls.Label ProbType;
        private Smobiler.Core.Controls.Label numberText;
        private Smobiler.Core.Controls.Label Number;
        private Smobiler.Core.Controls.TextBox ContentText;
        private Smobiler.Core.Controls.Panel AnswerInfoPanel;
        private Smobiler.Core.Controls.RadioGroup Answer;
        private Smobiler.Core.Controls.TextBox OptionA;
        private Smobiler.Core.Controls.TextBox OptionC;
        private Smobiler.Core.Controls.TextBox OptionD;
        private Smobiler.Core.Controls.TextBox OptionB;
        private Smobiler.Core.Controls.Label CheckID;
        private Smobiler.Core.Controls.Label Option1;
        private Smobiler.Core.Controls.Label Option2;
        private Smobiler.Core.Controls.Label Option3;
        private Smobiler.Core.Controls.Label Option4;
    }
}