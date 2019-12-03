using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 问卷调查.Pages.QuestionnaireListFolder.sendQ;
using 问卷调查.BLL;
using 问卷调查.Business;
using 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages;

namespace 问卷调查.Pages.QuestionnaireListFolder
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class QuestionnaireListControl : Smobiler.Core.Controls.MobileUserControl
    {
        public QuestionnaireListControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        QuestionUrlListOption questionUrlListOption = new QuestionUrlListOption();
        List<QuestionUrl> questionUrlList = new List<QuestionUrl>();
        private void button1_Press(object sender, EventArgs e)
        {
            var id= label2.Text;
            var number= this.NumberText.Text;
            string url = "";
            
            //匿名0，实名1
            bool AnonymousRealname = false;
            try
            {
                for (int i = 0; i < ((Panel)this.Controls[1]).Controls.Count; i++)
                {
                    if (((Panel)this.Controls[1]).Controls[i].Name == "radioGroup1_" + number)
                    {
                        var a = (RadioGroup)((Panel)this.Controls[1]).Controls[i];
                        //MessageBox.Show();
                        AnonymousRealname = a.CheckedButton.ID == "1" ? true : false;
                        break;
                    }
                }
                //var btn= radioGroup1.CheckedButton.Checked;
                string msg = WriteHtml.WriteFile(id, int.Parse(Client.Session["UserId"].ToString()), out url);
                if (msg == "")
                {
                    this.Form.Show(new SedQuestion(Convert.ToInt32(id), url), true);
                }
                else
                {
                    this.Form.Show(new SedQuestion(Convert.ToInt32(id), msg), true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("用户类型为必选项");
            }
            //if (radioGroup1.Buttons[0].Checked|| radioGroup1.Buttons[1].Checked)
            //{
            //    switch (radioGroup1.Buttons[0].Checked)
            //    {
            //        case true:
            //            AnonymousRealname = false;
            //            break;
            //        case false:
            //            AnonymousRealname = true;
            //            break;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("用户类型为必选项");
            //    return;
            //}
            //if (radioGroup1.CheckedButton.ID=="1")
            //{

            //}
            //else
            //{

            //}
            
        }

        private void QuestionnaireListControl_Load(object sender, EventArgs e)
        {
            this.Height = 100;
            Id.Visible = false;
            if (Client.Session["QId"] != null && Client.Session["QId"].ToString() != "")
            {
                startQuestion.Visible = true;
                ReleaseBtn.Visible = false;
                EditBtn.Visible = false;
                DeleteBtn.Visible = false;
                label3.Visible = false;
                radioGroup1.Visible = false;
            }
            else
            {
                ReleaseBtn.Visible = true;
                EditBtn.Visible = true;
                DeleteBtn.Visible = true;
                startQuestion.Visible = false;
                label3.Visible = true;
                radioGroup1.Visible = true;
            }

            if (!string.IsNullOrWhiteSpace(NumberText.Text))
            {
                this.Name += "_" + NumberText.Text;
                this.radioGroup1.Name += "_" + NumberText.Text;
            }
            
        }

        private void radioGroup1_ButtonPress(object sender, RadioButtonPressEventArgs e)
        {
           
        }

        private void startQuestion_Press(object sender, EventArgs e)
        {
            this.Form.Show(new AnswerPage(Convert.ToInt32(label2.Text)),true);
        }

        private void EditBtn_Press(object sender, EventArgs e)
        {
            this.Form.Show(new EditQuestionnairePage(int.Parse(Id.Text)));
        }
    }
}