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
    partial class SingleChoiceControl : Smobiler.Core.Controls.MobileUserControl
    {
        public SingleChoiceControl() : base()
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

        public static string CKID { get; set; } 

        private void SingleChoiceControl_Load(object sender, EventArgs e)
        {
            Answer.Visible = false;
            //CheckID.Visible = false;
            #region 给模板控件命名
            //TypeText.Name += "_" + Number.Text;
            //numberText.Name+= "_" + Number.Text;
            //Number.Name= "number_" + Number.Text;
            //ContentText.Name +=  "_"+ Number.Text;
            //Answer.Name += "_" + Number.Text;
            //OptionA.Name += "_" + Number.Text;
            //OptionB.Name += "_" + Number.Text;
            //OptionC.Name += "_" + Number.Text;
            //OptionD.Name += "_" + Number.Text;
            #endregion
        }

        private void Answer_ButtonPress(object sender, RadioButtonPressEventArgs e)
        {
            if (Answer.CheckedButtons.Length>0)           
                CheckID.Text = Answer.CheckedButton.ID;                       
        }
    }
}