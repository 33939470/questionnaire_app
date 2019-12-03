using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
//using 问卷调查.Pages.QuestionnaireListFolder.EditQuestionnairePages;
using System.Drawing;
using System.Data;
using 问卷调查.Business;
using static 问卷调查.BLL.Enums;

namespace 问卷调查.Pages.QuestionnaireListFolder
{
    partial class EditQuestionnairePage : Smobiler.Core.Controls.MobileForm
    {
        Dictionary<string, string> parameters = null;
        QuestionnaireOption QuesOp = new QuestionnaireOption();
        string parameStr = "";

        int SingleChoiceCount = 0;//单选题数量
        int MultipleChoiceCount = 0;//多选题数量
        int CompletionCount = 0;//填空题数量
        int ShortAnswerCount = 0;//简答题数量
        string QuestionnaireTitle = "";//问卷标题
        int QuestionnaireId = 0;//问卷ID
        string openPageWay = "";//调用该页面的方式 
        int QuestionnaireTypeId = 0;//问卷类型ID
        public EditQuestionnairePage(Dictionary<string, string> parms) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            parameters = parms;
            QuestionnaireTitle = parameters["QuestionnaireTitle"];//问卷名称
            SingleChoiceCount = int.Parse(parameters["SingleChoiceCount"]);//单选题
            MultipleChoiceCount = int.Parse(parameters["MultipleChoiceCount"]);//多选题
            CompletionCount = int.Parse(parameters["CompletionCount"]);//填空题
            ShortAnswerCount = int.Parse(parameters["ShortAnswerCount"]);//简答题      
            QuestionnaireTypeId = int.Parse(parameters["QuestionnaireTypeId"]);//简答题   
            openPageWay = "创建问卷";
        }
        /// <summary>
        /// 重载构造函数让页面可在不同的场景使用
        /// </summary>
        /// <param name="pramStr"></param>
        public EditQuestionnairePage(int QuestionnaireId_parms) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            openPageWay = "编辑问卷";
            QuestionnaireId = QuestionnaireId_parms;
        }

        int number = 1;
        ListView TemplateListView_SingleChoice = new ListView();//单选题模块
        ListView TemplateListView_MultipleChoice = new ListView();//多选题模块

        
        List<QuestionnaireDetailInfo> Q_DetailInfoList = null;//试题信息集合
        List<QuestionnaireDetailInfo> Q_DetailInfoList_SingleChoice=null;//单选题集合
        List<QuestionnaireDetailInfo> Q_DetailInfoList_MultipleChoice = null;//单选题集合
        private void EditQuestionnairePage_Load(object sender, EventArgs e)
        {
            int interval = 30;     
            #region 其它
            //单选题模板
            //SingleChoiceControl SingleChoice = new SingleChoiceControl();
            //SingleChoice.Height = 200;
            //SingleChoice.Width = (this.Width / 2 - 15)*2;
            //SingleChoice.Location = new Point(15,60);

            //SingleChoice.Border = new Border(1, 1, 1, 1);
            //this.Controls.Add(SingleChoice);

            //多选题模板
            //MultipleChoiceControl MultipleChoice = new MultipleChoiceControl();
            //MultipleChoice.Height = 250;
            //MultipleChoice.Width = (this.Width / 2 - 15) * 2;
            //MultipleChoice.Location = new Point(15, 60);

            //MultipleChoice.Border = new Border(1, 1, 1, 1);
            //this.Controls.Add(MultipleChoice);
            #endregion

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

            #region 绘制模板--单选题

            TemplateListView_SingleChoice.Location = new Point(0, 0);
            QuestionnairePanel.Controls.Add(TemplateListView_SingleChoice);//将单选题listview添加到panel中
            TemplateListView_SingleChoice.TemplateControlName = "SingleChoiceControl";//配置模板
            TemplateListView_SingleChoice.Width = 300;
           

            DataTable table_SingleChoice = new DataTable();
            table_SingleChoice.Columns.Add("Number", typeof(System.Int32));//标识
            table_SingleChoice.Columns.Add("TypeInfo", typeof(System.String));//题型
            table_SingleChoice.Columns.Add("Content", typeof(System.String));//试题内容
            //table_SingleChoice.Columns.Add("AnswerID", typeof(System.String));//答案
            table_SingleChoice.Columns.Add("OptionA", typeof(System.String));//选项1
            table_SingleChoice.Columns.Add("OptionB", typeof(System.String));//选项2
            table_SingleChoice.Columns.Add("OptionC", typeof(System.String));//选项3
            table_SingleChoice.Columns.Add("OptionD", typeof(System.String));//选项4
            if (openPageWay=="创建问卷")
            {
                //单选题的总模块高度等于单题模块高度*题数
                TemplateListView_SingleChoice.Height = TemplateListView_SingleChoice.TemplateControl.Height * SingleChoiceCount;
                for (int i = 0; i < SingleChoiceCount; i++)
                {
                    table_SingleChoice.Rows.Add(number, "单选题", "","","","","");
                    number++;
                }
            }
            else
            {             
                Q_DetailInfoList = QuesOp.GetQ_DetailInfoByQuestionnaireID(QuestionnaireId);//问卷试题信息
                Q_DetailInfoList_SingleChoice = Q_DetailInfoList.Where(Q_DetailList => Q_DetailList.probType == (int)Enum_ProbType.单选题).ToList();//问卷单选题信息
                //单选题的总模块高度等于单题模块高度*题数（此处题数值变更）
                TemplateListView_SingleChoice.Height = TemplateListView_SingleChoice.TemplateControl.Height * Q_DetailInfoList_SingleChoice.Count;
                foreach (QuestionnaireDetailInfo item in Q_DetailInfoList_SingleChoice)
                {
                    table_SingleChoice.Rows.Add(number, "单选题",item.Content,item.OptionA,item.OptionB, item.OptionC, item.OptionD);
                    number++;
                }              
            }          

            TemplateListView_SingleChoice.Rows.Clear();     //清除数据
            if (table_SingleChoice.Rows.Count > 0)    //绑定数据源
            {
                TemplateListView_SingleChoice.DataSource = table_SingleChoice;
                TemplateListView_SingleChoice.DataBind();
            }
            #endregion

            #region  绘制模板--多选题
            //获取单选题盒子的末尾高度，从末尾开始绘制多选题,如果没有单选题，则无需添加间隔高度
            if (parameters!=null&&parameters["head"] == "MultipleChoice"|| Q_DetailInfoList_SingleChoice!=null)
                interval = 0;
            int MultipleChoiceBoxLocationY = TemplateListView_SingleChoice.Location.Y + TemplateListView_SingleChoice.Height + interval;
            interval = 30;
            
            TemplateListView_MultipleChoice.Location = new Point(0, MultipleChoiceBoxLocationY);
            QuestionnairePanel.Controls.Add(TemplateListView_MultipleChoice);//将单选题listview添加到panel中
            TemplateListView_MultipleChoice.TemplateControlName = "MultipleChoiceControl";//配置模板
            TemplateListView_MultipleChoice.Width = 300;
           

            DataTable table_MultipleChoice = new DataTable();
            table_MultipleChoice.Columns.Add("Number", typeof(System.Int32));//标识
            table_MultipleChoice.Columns.Add("TypeInfo", typeof(System.String));//题型
            table_MultipleChoice.Columns.Add("Content", typeof(System.String));//试题内容
             //table_MultipleChoice.Columns.Add("AnswerID", typeof(System.String));//答案
            table_MultipleChoice.Columns.Add("OptionA", typeof(System.String));//选项1
            table_MultipleChoice.Columns.Add("OptionB", typeof(System.String));//选项2
            table_MultipleChoice.Columns.Add("OptionC", typeof(System.String));//选项3
            table_MultipleChoice.Columns.Add("OptionD", typeof(System.String));//选项4
            table_MultipleChoice.Columns.Add("OptionE", typeof(System.String));//选项5
            table_MultipleChoice.Columns.Add("OptionF", typeof(System.String));//选项6
            if (openPageWay == "创建问卷")
            {
                //多选题的总模块高度等于单题模块高度*题数
                TemplateListView_MultipleChoice.Height = TemplateListView_MultipleChoice.TemplateControl.Height * MultipleChoiceCount;
                for (int i = 0; i < MultipleChoiceCount; i++)
                {
                    table_MultipleChoice.Rows.Add(number, "多选题", "", "","","","","","");
                    number++;
                }
            }
            else
            {
                Q_DetailInfoList_MultipleChoice = Q_DetailInfoList.Where(Q_DetailList=> Q_DetailList.probType==(int)Enum_ProbType.多选题).ToList();
                //单选题的总模块高度等于单题模块高度*题数（此处题数值变更）
                TemplateListView_MultipleChoice.Height = TemplateListView_MultipleChoice.TemplateControl.Height * Q_DetailInfoList_MultipleChoice.Count;
                foreach (QuestionnaireDetailInfo item in Q_DetailInfoList_MultipleChoice)
                {
                    table_MultipleChoice.Rows.Add(number, "多选题", item.Content, item.OptionA, item.OptionB, item.OptionC, item.OptionD, item.OptionE, item.OptionF);
                    number++;
                }
            }
            TemplateListView_MultipleChoice.Rows.Clear();     //清除数据
            if (table_MultipleChoice.Rows.Count > 0)    //绑定数据源
            {
                TemplateListView_MultipleChoice.DataSource = table_MultipleChoice;
                TemplateListView_MultipleChoice.DataBind();
            }
            #endregion

            #region 绘制结束分割线
            Line line = new Line();
            line.Width = this.Width;
            line.BackColor = Color.Gray;
            line.Location = new Point(0, QuestionnairePanel.Height + Title.Height);
            this.Controls.Add(line);
            #endregion

            #region 绘制保存按钮
            Button nextBtn = new Button();
            nextBtn.Press += nextBtn_Press;
            nextBtn.Width = 200;
            nextBtn.Height = 30;
            nextBtn.Text = "保    存";
            nextBtn.FontSize = 15;
            nextBtn.Visible = true;
            //nextBtn.Location = new Point(this.Width / 2 - nextBtn.Width / 2, line.Location.Y + 20);
            nextBtn.Location = new Point(37, 451);
            this.Controls.Add(nextBtn);
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void singleChoiceControl1_Load(object sender, EventArgs e)
        {

        }
       
        private void nextBtn_Press(object sender, EventArgs e)
        {
            Dictionary<string, object> dataInfo = new Dictionary<string, object>();
            DataTable table_SingleChoice_data = new DataTable();//单选题表格
            DataTable table_MultipleChoice_data = new DataTable();//多选题表格

            #region 填充单选题数据          
            if (SingleChoiceCount>0|| Q_DetailInfoList_SingleChoice!=null)
            {
                int SingleChoiceControlCount = TemplateListView_SingleChoice.Rows.Count;                             
                table_SingleChoice_data.Columns.Add("Number", typeof(System.Int32));//标识
                table_SingleChoice_data.Columns.Add("ProbType", typeof(System.String));//题型
                table_SingleChoice_data.Columns.Add("Content", typeof(System.String));//试题内容
               // table_SingleChoice_data.Columns.Add("Answer", typeof(System.String));//答案
                table_SingleChoice_data.Columns.Add("OptionA", typeof(System.String));//选项A
                table_SingleChoice_data.Columns.Add("OptionB", typeof(System.String));//选项B
                table_SingleChoice_data.Columns.Add("OptionC", typeof(System.String));//选项C
                table_SingleChoice_data.Columns.Add("OptionD", typeof(System.String));//选项D

                for (int i = 0; i < SingleChoiceControlCount; i++)
                {
                    //string NAME = TemplateListView_SingleChoic.Rows[i].Control.Controls[i].Name;
                    MobileControlCollection controls = TemplateListView_SingleChoice.Rows[i].Control.Controls;
                    table_SingleChoice_data.Rows.Add();
                    for (int j = 0; j < controls.Count; j++)
                    {                     
                        if (controls[j].Name == "Number")         
                            table_SingleChoice_data.Rows[i]["Number"] = ((Label)controls[j]).Text;
                        if (controls[j].Name == "ProbType")
                            table_SingleChoice_data.Rows[i]["ProbType"] = ((Label)controls[j]).Text;
                        if (controls[j].Name == "ContentText")
                            table_SingleChoice_data.Rows[i]["Content"] = ((TextBox)controls[j]).Text;
                      
                        if (controls[j].Name == "AnswerInfoPanel")
                        {
                            for (int p = 0; p < ((Panel)controls[j]).Controls.Count; p++)
                            {
                                    //if (((Panel)controls[j]).Controls[p].Name == "Answer")
                                    //    table_SingleChoice_data.Rows[i]["Answer"] =  ((Label)controls["CheckID"]).Text;
                                    
                                if (((Panel)controls[j]).Controls[p].Name == "OptionA")
                                    table_SingleChoice_data.Rows[i]["OptionA"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                                if (((Panel)controls[j]).Controls[p].Name == "OptionB")
                                    table_SingleChoice_data.Rows[i]["OptionB"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                                if (((Panel)controls[j]).Controls[p].Name == "OptionC")
                                    table_SingleChoice_data.Rows[i]["OptionC"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                                if (((Panel)controls[j]).Controls[p].Name == "OptionD")
                                    table_SingleChoice_data.Rows[i]["OptionD"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                            }                           
                        }                 
                    }
                    //if (string.IsNullOrWhiteSpace(table_SingleChoice_data.Rows[i]["Answer"].ToString()))
                    //{
                    //    MessageBox.Show("第" + table_SingleChoice_data.Rows[i]["Number"] + "题没有选择答案");
                    //    return;
                    //}
                    if (string.IsNullOrWhiteSpace(table_SingleChoice_data.Rows[i]["Content"].ToString())|| table_SingleChoice_data.Rows[i]["Content"].ToString()=="此处填写试题内容")
                    {                     
                        MessageBox.Show("第"+ table_SingleChoice_data.Rows[i]["Number"]+"题没有填写内容");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_SingleChoice_data.Rows[i]["OptionA"].ToString()))
                    {
                        MessageBox.Show("第" + table_SingleChoice_data.Rows[i]["Number"] + "题没有填写选项1");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_SingleChoice_data.Rows[i]["OptionB"].ToString()) )
                    {
                        MessageBox.Show("第" + table_SingleChoice_data.Rows[i]["Number"] + "题没有填写选项2");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_SingleChoice_data.Rows[i]["OptionC"].ToString()))
                    {
                        MessageBox.Show("第" + table_SingleChoice_data.Rows[i]["Number"] + "题没有填写选项3");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_SingleChoice_data.Rows[i]["OptionD"].ToString()))
                    {
                        MessageBox.Show("第" + table_SingleChoice_data.Rows[i]["Number"] + "题没有填写选项4");
                        return;
                    }
                }
            }
            #endregion

            #region 填充多选题数据
            if (MultipleChoiceCount>0|| Q_DetailInfoList_MultipleChoice!=null)
            {
                int MultipleChoiceControlCount = TemplateListView_MultipleChoice.Rows.Count;               
                table_MultipleChoice_data.Columns.Add("Number", typeof(System.Int32));//标识
                table_MultipleChoice_data.Columns.Add("ProbType", typeof(System.String));//题型
                table_MultipleChoice_data.Columns.Add("Content", typeof(System.String));//试题内容
               // table_MultipleChoice_data.Columns.Add("Answer", typeof(System.String));//答案
                table_MultipleChoice_data.Columns.Add("OptionA", typeof(System.String));//选项A
                table_MultipleChoice_data.Columns.Add("OptionB", typeof(System.String));//选项B
                table_MultipleChoice_data.Columns.Add("OptionC", typeof(System.String));//选项C
                table_MultipleChoice_data.Columns.Add("OptionD", typeof(System.String));//选项D
                table_MultipleChoice_data.Columns.Add("OptionE", typeof(System.String));//选项E
                table_MultipleChoice_data.Columns.Add("OptionF", typeof(System.String));//选项F

                for (int i = 0; i < MultipleChoiceControlCount; i++)
                {
                    MobileControlCollection controls = TemplateListView_MultipleChoice.Rows[i].Control.Controls;
                    table_MultipleChoice_data.Rows.Add();
                    for (int j = 0; j < controls.Count; j++)
                    {
                        
                        if (controls[j].Name == "Number")
                            table_MultipleChoice_data.Rows[i]["Number"] = ((Label)controls[j]).Text;
                        if (controls[j].Name == "ProbType")
                            table_MultipleChoice_data.Rows[i]["ProbType"] = ((Label)controls[j]).Text;
                        if (controls[j].Name == "ContentText")
                            table_MultipleChoice_data.Rows[i]["Content"] = ((TextBox)controls[j]).Text;
                        if (controls[j].Name == "AnswerInfoPanel")
                        {
                            for (int p = 0; p < ((Panel)controls[j]).Controls.Count; p++)
                            {
                                //if (((Panel)controls[j]).Controls[p].Name == "Answer")
                                //    table_MultipleChoice_data.Rows[i]["Answer"] = ((Label)controls["CheckID"]).Text;
                                
                                if (((Panel)controls[j]).Controls[p].Name == "OptionA")
                                    table_MultipleChoice_data.Rows[i]["OptionA"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                                if (((Panel)controls[j]).Controls[p].Name == "OptionB")
                                    table_MultipleChoice_data.Rows[i]["OptionB"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                                if (((Panel)controls[j]).Controls[p].Name == "OptionC")
                                    table_MultipleChoice_data.Rows[i]["OptionC"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                                if (((Panel)controls[j]).Controls[p].Name == "OptionD")
                                    table_MultipleChoice_data.Rows[i]["OptionD"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                                if (((Panel)controls[j]).Controls[p].Name == "OptionE")
                                    table_MultipleChoice_data.Rows[i]["OptionE"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                                if (((Panel)controls[j]).Controls[p].Name == "OptionF")
                                    table_MultipleChoice_data.Rows[i]["OptionF"] = ((TextBox)((Panel)controls[j]).Controls[p]).Text;
                            }
                        }
                    }
                    //if (string.IsNullOrWhiteSpace(table_MultipleChoice_data.Rows[i]["Answer"].ToString()))
                    //{
                    //    MessageBox.Show("第" + table_MultipleChoice_data.Rows[i]["Number"] + "题没有选择答案");
                    //    return;
                    //}
                    if (string.IsNullOrWhiteSpace(table_MultipleChoice_data.Rows[i]["Content"].ToString()) || table_MultipleChoice_data.Rows[i]["Content"].ToString() == "此处填写试题内容")
                    {
                        MessageBox.Show("第" + table_MultipleChoice_data.Rows[i]["Number"] + "题没有填写内容");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_MultipleChoice_data.Rows[i]["OptionA"].ToString()))
                    {
                        MessageBox.Show("第" + table_MultipleChoice_data.Rows[i]["Number"] + "题没有填写选项1");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_MultipleChoice_data.Rows[i]["OptionB"].ToString()))
                    {
                        MessageBox.Show("第" + table_MultipleChoice_data.Rows[i]["Number"] + "题没有填写选项2");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_MultipleChoice_data.Rows[i]["OptionC"].ToString()))
                    {
                        MessageBox.Show("第" + table_MultipleChoice_data.Rows[i]["Number"] + "题没有填写选项3");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_MultipleChoice_data.Rows[i]["OptionD"].ToString()))
                    {
                        MessageBox.Show("第" + table_MultipleChoice_data.Rows[i]["Number"] + "题没有填写选项4");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_MultipleChoice_data.Rows[i]["OptionE"].ToString()) )
                    {
                        MessageBox.Show("第" + table_MultipleChoice_data.Rows[i]["Number"] + "题没有填写选项5");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(table_MultipleChoice_data.Rows[i]["OptionF"].ToString()))
                    {
                        MessageBox.Show("第" + table_MultipleChoice_data.Rows[i]["Number"] + "题没有填写选项6");
                        return;
                    }
                }               
            }
            #endregion

            dataInfo.Add("QuestionnaireTitle", QuestionnaireTitle);//开始填充单选题表格    
            dataInfo.Add("UserId", Client.Session["UserId"].ToString());//传入UserUD
            dataInfo.Add("SingleChoiceTable", table_SingleChoice_data);//开始填充单选题表格
            dataInfo.Add("MultipleChoiceTable", table_MultipleChoice_data);//开始填充多选题表格
            string result = "";
            if (openPageWay=="创建问卷")
            {
                dataInfo.Add("QuestionnaireTypeId", QuestionnaireTypeId);//开始填充多选题表格
                result = QuesOp.SaveQuestionnaireInfo(dataInfo, Enum_DataOption.Add);
            }
            else
            {
                dataInfo.Add("QuestionnaireId", QuestionnaireId);//开始填充多选题表格
                result = QuesOp.SaveQuestionnaireInfo(dataInfo, Enum_DataOption.Update);
            }
            
            //MessageBox.Show(result);
            if (result=="保存成功")
            {
                Show(new QuestionnaireList((int)Client.Session["UserId"]), true);
            }
        }
    }
}