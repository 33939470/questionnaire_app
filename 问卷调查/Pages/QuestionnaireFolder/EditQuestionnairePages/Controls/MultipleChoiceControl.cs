using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;

namespace 问卷调查.Pages.EditQuestionnairePages.Controls
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class MultipleChoiceControl : Smobiler.Core.Controls.MobileUserControl
    {
        public MultipleChoiceControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContentText_TouchEnter(object sender, EventArgs e)
        {
            if (ContentText.BackColor != Color.Black)
            {
                ContentText.Height = 65;
                this.Height += 35;
                AnswerInfoPanel.Location = new Point(AnswerInfoPanel.Location.X, AnswerInfoPanel.Location.Y + 35);
                ContentText.ForeColor = Color.Black;
                if (ContentText.Text == "此处填写试题内容")
                    ContentText.Text = "";
            }
        }

        private void ContentText_TouchLeave(object sender, EventArgs e)
        {
            AnswerInfoPanel.Location = new Point(AnswerInfoPanel.Location.X, AnswerInfoPanel.Location.Y - 35);
            ContentText.Height = 30;
            this.Height -= 35;
            ContentText.ForeColor = Color.Silver;
            if (ContentText.Text == "")
                ContentText.Text = "此处填写试题内容";
        }

        private void MultipleChoiceControl_Load(object sender, EventArgs e)
        {
            Answer.Visible = false;
            #region 给模板控件命名
            //NameText.Name += "_" + number.Text;
            //numberText.Name += "_" + number.Text;
            //number.Name = "number_" + number.Text;
            //ContentText.Name += "_" + number.Text;
            //Answer.Name += "_" + number.Text;
            //OptionA.Name += "_" + number.Text;
            //OptionB.Name += "_" + number.Text;
            //OptionC.Name += "_" + number.Text;
            //OptionD.Name += "_" + number.Text;
            //OptionE.Name += "_" + number.Text;
            //OptionF.Name += "_" + number.Text;
            #endregion
        }

        private void Answer_ButtonPress(object sender, RadioButtonPressEventArgs e)
        {
            //if (Answer.CheckedButtons.Length > 0)
            //{
            //    if (CheckID.Text.Contains(Answer.CheckedButton.ID))
            //        CheckID.Text = CheckID.Text.Replace(Answer.CheckedButton.ID+",","");
            //    else
            //        CheckID.Text += Answer.CheckedButton.ID + ",";
            //}
            CheckID.Text = "";
            foreach (var CheckedButton in Answer.CheckedButtons)
            {
                CheckID.Text=  CheckedButton.ID + CheckID.Text ;
            }
                
        }
    }
}