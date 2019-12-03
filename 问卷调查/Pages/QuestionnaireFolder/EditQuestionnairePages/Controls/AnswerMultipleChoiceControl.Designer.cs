using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages.Controls
{
    partial class AnswerMultipleChoiceControl : Smobiler.Core.Controls.MobileUserControl
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
            Smobiler.Core.Controls.RadioButton radioButton25 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton26 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton27 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton28 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton29 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton30 = new Smobiler.Core.Controls.RadioButton();
            this.ProbType = new Smobiler.Core.Controls.Label();
            this.numberText = new Smobiler.Core.Controls.Label();
            this.Number = new Smobiler.Core.Controls.Label();
            this.AnswerInfoPanel = new Smobiler.Core.Controls.Panel();
            this.Answer = new Smobiler.Core.Controls.RadioGroup();
            this.OptionA = new Smobiler.Core.Controls.Label();
            this.OptionB = new Smobiler.Core.Controls.Label();
            this.OptionC = new Smobiler.Core.Controls.Label();
            this.OptionD = new Smobiler.Core.Controls.Label();
            this.OptionE = new Smobiler.Core.Controls.Label();
            this.OptionF = new Smobiler.Core.Controls.Label();
            this.CheckID = new Smobiler.Core.Controls.Label();
            this.ContentText = new Smobiler.Core.Controls.Label();
            // 
            // ProbType
            // 
            this.ProbType.DisplayMember = "TypeInfo";
            this.ProbType.FontSize = 18F;
            this.ProbType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ProbType.Location = new System.Drawing.Point(31, 5);
            this.ProbType.Name = "ProbType";
            this.ProbType.Size = new System.Drawing.Size(70, 24);
            this.ProbType.Text = "多选题";
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
            // AnswerInfoPanel
            // 
            this.AnswerInfoPanel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Answer,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.OptionE,
            this.OptionF});
            this.AnswerInfoPanel.Location = new System.Drawing.Point(32, 70);
            this.AnswerInfoPanel.Name = "AnswerInfoPanel";
            this.AnswerInfoPanel.Size = new System.Drawing.Size(234, 161);
            // 
            // Answer
            // 
            radioButton25.ID = "A";
            radioButton25.Text = "A.";
            radioButton25.Value = null;
            radioButton26.ID = "B";
            radioButton26.Text = "B.";
            radioButton26.Value = null;
            radioButton27.ID = "C";
            radioButton27.Text = "C.";
            radioButton27.Value = null;
            radioButton28.ID = "D";
            radioButton28.Text = "D.";
            radioButton28.Value = null;
            radioButton29.ID = "E";
            radioButton29.Text = "E.";
            radioButton29.Value = null;
            radioButton30.ID = "F";
            radioButton30.Text = "F.";
            radioButton30.Value = null;
            this.Answer.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton25,
            radioButton26,
            radioButton27,
            radioButton28,
            radioButton29,
            radioButton30});
            this.Answer.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Answer.Location = new System.Drawing.Point(0, 6);
            this.Answer.MultiSelect = true;
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(48, 153);
            this.Answer.ButtonPress += new Smobiler.Core.Controls.RadioButtonPressEventHandler(this.Answer_ButtonPress);
            // 
            // OptionA
            // 
            this.OptionA.DisplayMember = "OptionA";
            this.OptionA.Location = new System.Drawing.Point(53, 6);
            this.OptionA.Name = "OptionA";
            this.OptionA.Size = new System.Drawing.Size(180, 23);
            this.OptionA.Text = "label1";
            // 
            // OptionB
            // 
            this.OptionB.DisplayMember = "OptionB";
            this.OptionB.Location = new System.Drawing.Point(53, 32);
            this.OptionB.Name = "OptionB";
            this.OptionB.Size = new System.Drawing.Size(180, 23);
            this.OptionB.Text = "label1";
            // 
            // OptionC
            // 
            this.OptionC.DisplayMember = "OptionC";
            this.OptionC.Location = new System.Drawing.Point(53, 58);
            this.OptionC.Name = "OptionC";
            this.OptionC.Size = new System.Drawing.Size(180, 23);
            this.OptionC.Text = "label1";
            // 
            // OptionD
            // 
            this.OptionD.DisplayMember = "OptionD";
            this.OptionD.Location = new System.Drawing.Point(53, 84);
            this.OptionD.Name = "OptionD";
            this.OptionD.Size = new System.Drawing.Size(180, 23);
            this.OptionD.Text = "label1";
            // 
            // OptionE
            // 
            this.OptionE.DisplayMember = "OptionE";
            this.OptionE.Location = new System.Drawing.Point(53, 110);
            this.OptionE.Name = "OptionE";
            this.OptionE.Size = new System.Drawing.Size(180, 23);
            this.OptionE.Text = "label1";
            // 
            // OptionF
            // 
            this.OptionF.DisplayMember = "OptionF";
            this.OptionF.Location = new System.Drawing.Point(53, 136);
            this.OptionF.Name = "OptionF";
            this.OptionF.Size = new System.Drawing.Size(180, 23);
            this.OptionF.Text = "label1";
            // 
            // CheckID
            // 
            this.CheckID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.CheckID.Location = new System.Drawing.Point(115, 7);
            this.CheckID.Name = "CheckID";
            this.CheckID.Size = new System.Drawing.Size(67, 28);
            // 
            // ContentText
            // 
            this.ContentText.DisplayMember = "ContentText";
            this.ContentText.Location = new System.Drawing.Point(32, 37);
            this.ContentText.Name = "ContentText";
            this.ContentText.Size = new System.Drawing.Size(249, 27);
            this.ContentText.Text = "label1";
            // 
            // AnswerMultipleChoiceControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ProbType,
            this.numberText,
            this.Number,
            this.AnswerInfoPanel,
            this.CheckID,
            this.ContentText});
            this.Size = new System.Drawing.Size(300, 250);
            this.Name = "AnswerMultipleChoiceControl";

        }
        #endregion

        private Smobiler.Core.Controls.Label ProbType;
        private Smobiler.Core.Controls.Label numberText;
        private Smobiler.Core.Controls.Label Number;
        private Smobiler.Core.Controls.Panel AnswerInfoPanel;
        private Smobiler.Core.Controls.RadioGroup Answer;
        private Smobiler.Core.Controls.Label CheckID;
        private Smobiler.Core.Controls.Label OptionA;
        private Smobiler.Core.Controls.Label ContentText;
        private Smobiler.Core.Controls.Label OptionB;
        private Smobiler.Core.Controls.Label OptionC;
        private Smobiler.Core.Controls.Label OptionD;
        private Smobiler.Core.Controls.Label OptionE;
        private Smobiler.Core.Controls.Label OptionF;
    }
}