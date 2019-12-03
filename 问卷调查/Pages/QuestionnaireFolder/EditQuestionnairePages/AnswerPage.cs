using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;
using 问卷调查.BLL;
using System.Data;
using static 问卷调查.BLL.Enums;

namespace 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages
{
    partial class AnswerPage : Smobiler.Core.Controls.MobileForm
    {
        private static int QIID = 0;
        public AnswerPage(int QIID) : base()
        {
            AnswerPage.QIID = QIID;
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        QuestionnaireDetailInfoBLL questionnaireDetailInfobll = new QuestionnaireDetailInfoBLL();
        ListView TemplateListView_SingleChoice = new ListView();//单选题模块
        ListView TemplateListView_MultipleChoice = new ListView();//多选题模块
        private void AnswerPage_Load(object sender, EventArgs e)
        {
            try
            {
                this.title1.Text = "测试";
                int interval = 30;
                int number = 1;
                #region 绘制页面主体框
                Panel QuestionnairePanel = new Panel();
                QuestionnairePanel.Location = new Point(0, 50);
                QuestionnairePanel.Border = new Border(1, 1, 1, 1);
                QuestionnairePanel.BorderColor = Color.Gray;
                QuestionnairePanel.Height = 470;
                QuestionnairePanel.Width = this.Width;
                QuestionnairePanel.Scrollable = true;
                this.Controls.Add(QuestionnairePanel);
                #endregion
                List<QuestionnaireDetailInfo> questionnaireDetailInfo = questionnaireDetailInfobll.GetQuestionUrlInfo(QIID).ToList();

                int MultipleChoiceBoxLocationY = TemplateListView_SingleChoice.Location.Y + TemplateListView_SingleChoice.Height + interval;
                interval = 30;

                TemplateListView_SingleChoice.Location = new Point(0, 0);
                QuestionnairePanel.Controls.Add(TemplateListView_SingleChoice);//将单选题listview添加到panel中
                TemplateListView_SingleChoice.TemplateControlName = "AnswerSingleChoiceControl";//配置模板
                TemplateListView_SingleChoice.Width = 300;


                DataTable table_SingleChoice = new DataTable();
                table_SingleChoice.Columns.Add("Number", typeof(System.Int32));//标识
                table_SingleChoice.Columns.Add("TypeInfo", typeof(System.String));//题型
                table_SingleChoice.Columns.Add("ContentText", typeof(System.String));//试题内容
                                                                                 
                table_SingleChoice.Columns.Add("OptionA", typeof(System.String));//选项1
                table_SingleChoice.Columns.Add("OptionB", typeof(System.String));//选项2
                table_SingleChoice.Columns.Add("OptionC", typeof(System.String));//选项3
                table_SingleChoice.Columns.Add("OptionD", typeof(System.String));//选项4

                TemplateListView_MultipleChoice.Location = new Point(0, MultipleChoiceBoxLocationY);
                QuestionnairePanel.Controls.Add(TemplateListView_MultipleChoice);//将多选题listview添加到panel中
                TemplateListView_MultipleChoice.TemplateControlName = "AnswerMultipleChoiceControl";//配置模板
                TemplateListView_MultipleChoice.Width = 300;


                DataTable table_MultipleChoice = new DataTable();
                table_MultipleChoice.Columns.Add("Number", typeof(System.Int32));//标识
                table_MultipleChoice.Columns.Add("TypeInfo", typeof(System.String));//题型
                table_MultipleChoice.Columns.Add("ContentText", typeof(System.String));//试题内容                                                                 
                table_MultipleChoice.Columns.Add("OptionA", typeof(System.String));//选项1
                table_MultipleChoice.Columns.Add("OptionB", typeof(System.String));//选项2
                table_MultipleChoice.Columns.Add("OptionC", typeof(System.String));//选项3
                table_MultipleChoice.Columns.Add("OptionD", typeof(System.String));//选项4
                table_MultipleChoice.Columns.Add("OptionE", typeof(System.String));//选项5
                table_MultipleChoice.Columns.Add("OptionF", typeof(System.String));//选项6

                
                List<QuestionnaireDetailInfo> QuestionnaireDetailInfo1 = questionnaireDetailInfo.Where(Q_DetailList => Q_DetailList.probType == (int)Enum_ProbType.单选题).ToList();
                TemplateListView_SingleChoice.Height = TemplateListView_SingleChoice.TemplateControl.Height * QuestionnaireDetailInfo1.Count;
                foreach (QuestionnaireDetailInfo item in QuestionnaireDetailInfo1)
                {

                    table_SingleChoice.Rows.Add(number, "单选题", item.Content, item.OptionA, item.OptionB, item.OptionC, item.OptionD);
                    number++;

                }
                TemplateListView_SingleChoice.Rows.Clear();     //清除数据
                if (table_SingleChoice.Rows.Count > 0)    //绑定数据源
                {
                    TemplateListView_SingleChoice.DataSource = table_SingleChoice;
                    TemplateListView_SingleChoice.DataBind();
                }
                List<QuestionnaireDetailInfo> QuestionnaireDetailInfo2= questionnaireDetailInfo.Where(Q_DetailList => Q_DetailList.probType == (int)Enum_ProbType.多选题).ToList();
                TemplateListView_MultipleChoice.Height = TemplateListView_MultipleChoice.Height * QuestionnaireDetailInfo2.Count;
                foreach (QuestionnaireDetailInfo item in QuestionnaireDetailInfo2)
                {

                    table_MultipleChoice.Rows.Add(number, "多选题", item.Content, item.OptionA, item.OptionB, item.OptionC, item.OptionD, item.OptionE, item.OptionF);
                    number++;

                }
                TemplateListView_MultipleChoice.Rows.Clear();     //清除数据
                if (table_MultipleChoice.Rows.Count > 0)    //绑定数据源
                {
                    TemplateListView_MultipleChoice.DataSource = table_MultipleChoice;
                    TemplateListView_MultipleChoice.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}