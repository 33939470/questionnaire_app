using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages.Controls
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class AnswerSingleChoiceControl : Smobiler.Core.Controls.MobileUserControl
    {
        public AnswerSingleChoiceControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void Answer_ButtonPress(object sender, RadioButtonPressEventArgs e)
        {

        }
    }
}