using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using 问卷调查.Business;
using 问卷调查.Pages.QuestionnaireListFolder;
using 问卷调查.Pages.QuestionnaireFolder.EditQuestionnairePages;

namespace 问卷调查.Pages
{
    partial class QuestionnaireList : Smobiler.Core.Controls.MobileForm
    {
        static int id = 0;
        public QuestionnaireList(int id) : base()
        {
            QuestionnaireList.id = id;
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        //菜单信息逻辑操作层
        QuestionnaireOption QuestionnaireOption = new QuestionnaireOption();

        private void PaperList_Load(object sender, EventArgs e)
        {
            Client.Session["QId"] = "";
            List<QuestionnaireInfo> Questionnairelist = null;
            if (id==1)
            {
                Questionnairelist = QuestionnaireOption.GetQuestionnaireListByUserID(int.Parse(Client.Session["UserId"].ToString()));
            }
            else
            {
                Questionnairelist = QuestionnaireOption.GetQuestionnaireListByUserIDBR(id);
                Client.Session["QId"] = id;
            }
            
            DataTable table = new DataTable();
            table.Columns.Add("Number", typeof(System.Int32));
            table.Columns.Add("ID", typeof(System.Int32));
            table.Columns.Add("NAME", typeof(System.String));
            table.Columns.Add("CREATETIME", typeof(System.DateTime));//创建时间
            table.Columns.Add("CRETEUSERID", typeof(System.Int32));//创建者ID
            int i = 0;
            foreach (QuestionnaireInfo Questionnaire in Questionnairelist)
            {
                i++;
                table.Rows.Add(i,Questionnaire.ID, Questionnaire.Name,  Questionnaire.CreateTime, Questionnaire.CreateUserId);
            }
          
            QuestionnaireListView.Rows.Clear();     //清除数据
            if (table.Rows.Count > 0)    //绑定数据源
            {
                QuestionnaireListView.DataSource = table;
                QuestionnaireListView.DataBind();
            }
        }

        private void CreatePaperBtn_Press(object sender, EventArgs e)
        {
            //Show(new QuestionTypeList());
            Show(new QuestionnaireTypeList());
        }
    }
}