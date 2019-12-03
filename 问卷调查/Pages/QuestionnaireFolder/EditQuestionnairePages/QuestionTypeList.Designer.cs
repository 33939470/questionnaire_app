using System;
using Smobiler.Core;
namespace 问卷调查.Pages.QuestionnaireListFolder
{
    partial class QuestionTypeList : Smobiler.Core.Controls.MobileForm
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
            this.TypeInfo = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.SingleChoiceCK = new Smobiler.Core.Controls.CheckBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.SingleChoiceCount = new Smobiler.Core.Controls.TextBox();
            this.SingleChoiceBtn = new Smobiler.Core.Controls.Button();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.MultipleChoiceCK = new Smobiler.Core.Controls.CheckBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.MultipleChoiceCount = new Smobiler.Core.Controls.TextBox();
            this.MultipleChoiceBtn = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.CompletionCK = new Smobiler.Core.Controls.CheckBox();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.CompletionCount = new Smobiler.Core.Controls.TextBox();
            this.CompletionBtn = new Smobiler.Core.Controls.Button();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.ShortAnswerCK = new Smobiler.Core.Controls.CheckBox();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.ShortAnswerCount = new Smobiler.Core.Controls.TextBox();
            this.ShortAnswerBtn = new Smobiler.Core.Controls.Button();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.NextStep = new Smobiler.Core.Controls.Button();
            this.QuestionnaireName = new Smobiler.Core.Controls.Label();
            this.QuestionnaireTitle = new Smobiler.Core.Controls.TextBox();
            // 
            // TypeInfo
            // 
            this.TypeInfo.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4});
            this.TypeInfo.Location = new System.Drawing.Point(14, 181);
            this.TypeInfo.Name = "TypeInfo";
            this.TypeInfo.Size = new System.Drawing.Size(271, 162);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.SingleChoiceCK,
            this.label1,
            this.SingleChoiceCount,
            this.SingleChoiceBtn});
            this.panel1.Location = new System.Drawing.Point(27, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 25);
            // 
            // SingleChoiceCK
            // 
            this.SingleChoiceCK.Location = new System.Drawing.Point(0, 5);
            this.SingleChoiceCK.Name = "SingleChoiceCK";
            this.SingleChoiceCK.Size = new System.Drawing.Size(15, 15);
            this.SingleChoiceCK.TintColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(113, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.Text = "题数：";
            // 
            // SingleChoiceCount
            // 
            this.SingleChoiceCount.Border = new Smobiler.Core.Controls.Border(1F);
            this.SingleChoiceCount.BorderColor = System.Drawing.Color.Silver;
            this.SingleChoiceCount.BorderRadius = 3;
            this.SingleChoiceCount.FontSize = 16F;
            this.SingleChoiceCount.Location = new System.Drawing.Point(154, 0);
            this.SingleChoiceCount.Name = "SingleChoiceCount";
            this.SingleChoiceCount.Size = new System.Drawing.Size(66, 25);
            this.SingleChoiceCount.Text = "0";
            // 
            // SingleChoiceBtn
            // 
            this.SingleChoiceBtn.BackColor = System.Drawing.Color.Transparent;
            this.SingleChoiceBtn.FontSize = 18F;
            this.SingleChoiceBtn.ForeColor = System.Drawing.Color.Black;
            this.SingleChoiceBtn.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.SingleChoiceBtn.Location = new System.Drawing.Point(17, 0);
            this.SingleChoiceBtn.Name = "SingleChoiceBtn";
            this.SingleChoiceBtn.Size = new System.Drawing.Size(90, 25);
            this.SingleChoiceBtn.Text = "单选题";
            this.SingleChoiceBtn.Press += new System.EventHandler(this.button1_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.MultipleChoiceCK,
            this.label3,
            this.MultipleChoiceCount,
            this.MultipleChoiceBtn});
            this.panel2.Location = new System.Drawing.Point(27, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 25);
            // 
            // MultipleChoiceCK
            // 
            this.MultipleChoiceCK.Location = new System.Drawing.Point(0, 5);
            this.MultipleChoiceCK.Name = "MultipleChoiceCK";
            this.MultipleChoiceCK.Size = new System.Drawing.Size(15, 15);
            this.MultipleChoiceCK.TintColor = System.Drawing.Color.Black;
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(113, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.Text = "题数：";
            // 
            // MultipleChoiceCount
            // 
            this.MultipleChoiceCount.Border = new Smobiler.Core.Controls.Border(1F);
            this.MultipleChoiceCount.BorderColor = System.Drawing.Color.Silver;
            this.MultipleChoiceCount.BorderRadius = 3;
            this.MultipleChoiceCount.FontSize = 16F;
            this.MultipleChoiceCount.Location = new System.Drawing.Point(154, 0);
            this.MultipleChoiceCount.Name = "MultipleChoiceCount";
            this.MultipleChoiceCount.Size = new System.Drawing.Size(65, 25);
            this.MultipleChoiceCount.Text = "0";
            // 
            // MultipleChoiceBtn
            // 
            this.MultipleChoiceBtn.BackColor = System.Drawing.Color.Transparent;
            this.MultipleChoiceBtn.FontSize = 18F;
            this.MultipleChoiceBtn.ForeColor = System.Drawing.Color.Black;
            this.MultipleChoiceBtn.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.MultipleChoiceBtn.Location = new System.Drawing.Point(17, 0);
            this.MultipleChoiceBtn.Name = "MultipleChoiceBtn";
            this.MultipleChoiceBtn.Size = new System.Drawing.Size(90, 25);
            this.MultipleChoiceBtn.Text = "多选题";
            this.MultipleChoiceBtn.Press += new System.EventHandler(this.MultipleChoiceBtn_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.CompletionCK,
            this.label5,
            this.CompletionCount,
            this.CompletionBtn});
            this.panel3.Location = new System.Drawing.Point(27, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 25);
            // 
            // CompletionCK
            // 
            this.CompletionCK.Location = new System.Drawing.Point(0, 5);
            this.CompletionCK.Name = "CompletionCK";
            this.CompletionCK.Size = new System.Drawing.Size(15, 15);
            this.CompletionCK.TintColor = System.Drawing.Color.Black;
            // 
            // label5
            // 
            this.label5.FontSize = 15F;
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label5.Location = new System.Drawing.Point(113, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.Text = "题数：";
            // 
            // CompletionCount
            // 
            this.CompletionCount.Border = new Smobiler.Core.Controls.Border(1F);
            this.CompletionCount.BorderColor = System.Drawing.Color.Silver;
            this.CompletionCount.BorderRadius = 3;
            this.CompletionCount.FontSize = 16F;
            this.CompletionCount.Location = new System.Drawing.Point(154, 0);
            this.CompletionCount.Name = "CompletionCount";
            this.CompletionCount.Size = new System.Drawing.Size(65, 25);
            this.CompletionCount.Text = "0";
            // 
            // CompletionBtn
            // 
            this.CompletionBtn.BackColor = System.Drawing.Color.Transparent;
            this.CompletionBtn.FontSize = 18F;
            this.CompletionBtn.ForeColor = System.Drawing.Color.Black;
            this.CompletionBtn.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.CompletionBtn.Location = new System.Drawing.Point(17, 0);
            this.CompletionBtn.Name = "CompletionBtn";
            this.CompletionBtn.Size = new System.Drawing.Size(90, 25);
            this.CompletionBtn.Text = "填空题";
            this.CompletionBtn.Press += new System.EventHandler(this.CompletionBtn_Press);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ShortAnswerCK,
            this.label7,
            this.ShortAnswerCount,
            this.ShortAnswerBtn});
            this.panel4.Location = new System.Drawing.Point(27, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 25);
            // 
            // ShortAnswerCK
            // 
            this.ShortAnswerCK.Location = new System.Drawing.Point(0, 6);
            this.ShortAnswerCK.Name = "ShortAnswerCK";
            this.ShortAnswerCK.Size = new System.Drawing.Size(15, 15);
            this.ShortAnswerCK.TintColor = System.Drawing.Color.Black;
            // 
            // label7
            // 
            this.label7.FontSize = 15F;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label7.Location = new System.Drawing.Point(113, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 25);
            this.label7.Text = "题数：";
            // 
            // ShortAnswerCount
            // 
            this.ShortAnswerCount.Border = new Smobiler.Core.Controls.Border(1F);
            this.ShortAnswerCount.BorderColor = System.Drawing.Color.Silver;
            this.ShortAnswerCount.BorderRadius = 3;
            this.ShortAnswerCount.FontSize = 16F;
            this.ShortAnswerCount.Location = new System.Drawing.Point(154, 0);
            this.ShortAnswerCount.Name = "ShortAnswerCount";
            this.ShortAnswerCount.Size = new System.Drawing.Size(65, 25);
            this.ShortAnswerCount.Text = "0";
            // 
            // ShortAnswerBtn
            // 
            this.ShortAnswerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShortAnswerBtn.FontSize = 18F;
            this.ShortAnswerBtn.ForeColor = System.Drawing.Color.Black;
            this.ShortAnswerBtn.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.ShortAnswerBtn.Location = new System.Drawing.Point(17, 0);
            this.ShortAnswerBtn.Name = "ShortAnswerBtn";
            this.ShortAnswerBtn.Size = new System.Drawing.Size(90, 25);
            this.ShortAnswerBtn.Text = "简答题";
            this.ShortAnswerBtn.Press += new System.EventHandler(this.ShortAnswerBtn_Press);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.FontSize = 18F;
            this.label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label8.Name = "label8";
            this.label8.SelfAlign = Smobiler.Core.Controls.LayoutSelfAlign.Center;
            this.label8.Size = new System.Drawing.Size(300, 50);
            this.label8.Text = "选择题型";
            // 
            // NextStep
            // 
            this.NextStep.FontSize = 18F;
            this.NextStep.Location = new System.Drawing.Point(37, 451);
            this.NextStep.Name = "NextStep";
            this.NextStep.Size = new System.Drawing.Size(220, 30);
            this.NextStep.Text = "下一步";
            this.NextStep.Press += new System.EventHandler(this.NextStep_Press);
            // 
            // QuestionnaireName
            // 
            this.QuestionnaireName.FontSize = 15F;
            this.QuestionnaireName.Location = new System.Drawing.Point(37, 86);
            this.QuestionnaireName.Name = "QuestionnaireName";
            this.QuestionnaireName.Size = new System.Drawing.Size(59, 29);
            this.QuestionnaireName.Text = "问卷名称";
            // 
            // QuestionnaireTitle
            // 
            this.QuestionnaireTitle.Border = new Smobiler.Core.Controls.Border(1F);
            this.QuestionnaireTitle.BorderColor = System.Drawing.Color.Silver;
            this.QuestionnaireTitle.BorderRadius = 3;
            this.QuestionnaireTitle.FontSize = 15F;
            this.QuestionnaireTitle.ForeColor = System.Drawing.Color.LightGray;
            this.QuestionnaireTitle.Location = new System.Drawing.Point(37, 115);
            this.QuestionnaireTitle.MaxLength = 50;
            this.QuestionnaireTitle.Name = "QuestionnaireTitle";
            this.QuestionnaireTitle.Size = new System.Drawing.Size(220, 29);
            this.QuestionnaireTitle.Text = "输入问卷名称";
            this.QuestionnaireTitle.TextChanged += new System.EventHandler(this.QuestionnaireTitle_TextChanged);
            this.QuestionnaireTitle.TouchEnter += new System.EventHandler(this.QuestionnaireTitle_TouchEnter);
            this.QuestionnaireTitle.TouchLeave += new System.EventHandler(this.QuestionnaireTitle_TouchLeave);
            // 
            // QuestionnaireTypeList
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.TypeInfo,
            this.label8,
            this.NextStep,
            this.QuestionnaireName,
            this.QuestionnaireTitle});
            this.Load += new System.EventHandler(this.QuestionnaireTypeList_Load_1);
            this.Name = "QuestionnaireTypeList";

        }
        #endregion

        private Smobiler.Core.Controls.Panel TypeInfo;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.CheckBox SingleChoiceCK;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox SingleChoiceCount;
        private Smobiler.Core.Controls.Button SingleChoiceBtn;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.CheckBox MultipleChoiceCK;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.TextBox MultipleChoiceCount;
        private Smobiler.Core.Controls.Button MultipleChoiceBtn;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.CheckBox CompletionCK;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.TextBox CompletionCount;
        private Smobiler.Core.Controls.Button CompletionBtn;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.CheckBox ShortAnswerCK;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.TextBox ShortAnswerCount;
        private Smobiler.Core.Controls.Button ShortAnswerBtn;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Button NextStep;
        private Smobiler.Core.Controls.Label QuestionnaireName;
        private Smobiler.Core.Controls.TextBox QuestionnaireTitle;
    }
}