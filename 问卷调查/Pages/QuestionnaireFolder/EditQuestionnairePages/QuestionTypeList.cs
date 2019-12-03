using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;

namespace 问卷调查.Pages.QuestionnaireListFolder
{
    partial class QuestionTypeList : Smobiler.Core.Controls.MobileForm
    {
        int QuestionnaireTypeId = 0;
        public QuestionTypeList(int QuestionnaireTypeIdParam) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            QuestionnaireTypeId = QuestionnaireTypeIdParam;
        }

        private void QuestionnaireTypeList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Press(object sender, EventArgs e)
        {
            if (SingleChoiceCK.Checked == false)
                SingleChoiceCK.Checked = true;
            else
                SingleChoiceCK.Checked = false;
        }

        private void MultipleChoiceBtn_Press(object sender, EventArgs e)
        {
            if (MultipleChoiceCK.Checked == false)
                MultipleChoiceCK.Checked = true;
            else
                MultipleChoiceCK.Checked = false;
        }

        private void CompletionBtn_Press(object sender, EventArgs e)
        {
            if (CompletionCK.Checked == false)
                CompletionCK.Checked = true;
            else
                CompletionCK.Checked = false;
        }

        private void ShortAnswerBtn_Press(object sender, EventArgs e)
        {
            if (ShortAnswerCK.Checked == false)
                ShortAnswerCK.Checked = true;
            else
                ShortAnswerCK.Checked = false;
        }
        /// <summary>
        /// 点击下一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextStep_Press(object sender, EventArgs e)
        {

            #region 数据校验

            //问卷名校验
            if (string.IsNullOrWhiteSpace(QuestionnaireTitle.Text)|| QuestionnaireTitle.Text == "输入问卷名称")
            {
                MessageBox.Show("请输入问卷名称");
                return;
            }
          
            string head = "SingleChoice";
            if (!SingleChoiceCK.Checked && !MultipleChoiceCK.Checked && !CompletionCK.Checked && !ShortAnswerCK.Checked)
            {
                MessageBox.Show("至少选择一种题型");
                return;
            }
            //问题数量文本校验
            Dictionary<string, string> parms = new Dictionary<string, string>();
            if (SingleChoiceCK.Checked&& (string.IsNullOrWhiteSpace(SingleChoiceCount.Text)|| int.Parse(SingleChoiceCount.Text) == 0))
            {
                MessageBox.Show("请输入单选题数量");
                return;
            }
            if (MultipleChoiceCK.Checked && (string.IsNullOrWhiteSpace(MultipleChoiceCount.Text) || int.Parse(MultipleChoiceCount.Text) == 0))
            {
                MessageBox.Show("请输入多选题数量");
                return;
            }
            if (CompletionCK.Checked && (string.IsNullOrWhiteSpace(CompletionCount.Text) || int.Parse(CompletionCount.Text) == 0))
            {
                MessageBox.Show("请输入填空选题数量");
                return;
            }
            if (ShortAnswerCK.Checked && (string.IsNullOrWhiteSpace(ShortAnswerCount.Text) || int.Parse(ShortAnswerCount.Text) == 0))
            {
                MessageBox.Show("请输入简答题数量");
                return;
            }
            #endregion

            #region 添加参数
            parms.Add("QuestionnaireTypeId", QuestionnaireTypeId.ToString());
            parms.Add("QuestionnaireTitle", QuestionnaireTitle.Text);
            parms.Add("SingleChoiceCount", SingleChoiceCount.Text);
            parms.Add("MultipleChoiceCount", MultipleChoiceCount.Text);
            parms.Add("CompletionCount", CompletionCount.Text);
            parms.Add("ShortAnswerCount", ShortAnswerCount.Text);
            parms.Add("head", head);
            #endregion
            Show(new EditQuestionnairePage(parms));
        }

        private void QuestionnaireTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionnaireTitle_TouchEnter(object sender, EventArgs e)
        {
            QuestionnaireTitle.ForeColor = Color.Black;
            if (QuestionnaireTitle.Text=="输入问卷名称")
                QuestionnaireTitle.Text = "";            
        }

        private void QuestionnaireTitle_TouchLeave(object sender, EventArgs e)
        {
            QuestionnaireTitle.ForeColor = Color.LightGray;
        }

        private void QuestionnaireTypeList_Load_1(object sender, EventArgs e)
        {

        }
    }
}