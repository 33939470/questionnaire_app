using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static 问卷调查.BLL.Enums;

namespace 问卷调查.BLL
{
    /// <summary>
    /// 问卷信息操作数据层
    /// </summary>
    public class QuestionnaireOptionBLL
    {
        public paper_QuestionnaireEntities context = new paper_QuestionnaireEntities();
        public IQueryable<QuestionnaireInfo> entitiesQuestionnaireInfo;//问卷信息表
        public IQueryable<QuestionType> entitiesQuestionTypeInfo;//问题类型表
        public IQueryable<QuestionnaireTypeInfo> entitiesQuestionnaireTypeInfo;//问卷类型表
        public IQueryable<QuestionnaireDetailInfo> entitiesQuestionnaireDetailInfo;//问题详细信息表
        /// <summary>
        /// 根据用户ID返回问卷列表对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        public IQueryable<QuestionnaireInfo> GetQuestionnaireListByUserID(int UserID)
        {
            var QuestionnaireInfo = context.QuestionnaireInfo.Where<QuestionnaireInfo>(Questionnaire => Questionnaire.CreateUserId == UserID);
            entitiesQuestionnaireInfo = QuestionnaireInfo;
            return entitiesQuestionnaireInfo;
        }

        #region 保存问卷
        /// <summary>
        /// 添加问卷
        /// </summary>
        /// <param name="ID">用户ID</param>
        public void AddQuestionnaireInfo(Dictionary<string, object> dataInfo)
        {
            string paperName = dataInfo["QuestionnaireTitle"].ToString();//问卷名
            int userId = int.Parse(dataInfo["UserId"].ToString());//用户ID
            QuestionnaireInfo QInfo = new QuestionnaireInfo();
            QuestionnaireDetailInfo QDetailInfo = new QuestionnaireDetailInfo();
            int QInfoId = 0;
            //添加问卷主表信息
            QInfo.Name = paperName;
            // QInfo.PaperType = int.Parse(Enum.Parse(typeof(Enums.Enum_ProbType),item["ProbType"].ToString()).ToString());
            QInfo.PaperType = (int)dataInfo["QuestionnaireTypeId"];//问卷类型
            QInfo.CreateUserId = userId;
            QInfo.PaperCount = 50;
            QInfo.State = 0;//启用
            QInfo.CreateTime = DateTime.Now;
             context.QuestionnaireInfo.Add(QInfo);
            context.SaveChanges();
            context.Entry(QInfo);
           // QInfoId = QInfo.id

            foreach (DataRow item in ((DataTable)dataInfo["SingleChoiceTable"]).Rows)//添加单选题到试题详细表
            {
                QDetailInfo.PaperType = QInfo.PaperType;
                QDetailInfo.probType = (int)Enum_ProbType.单选题;
                QDetailInfo.number= (int)item["Number"];
                QDetailInfo.State = 0;
                QDetailInfo.QuestionnaireInfoId = QInfo.ID;
                QDetailInfo.Content = item["Content"].ToString();
               // QDetailInfo.Answer= item["Answer"].ToString();
                QDetailInfo.OptionA= item["OptionA"].ToString();
                QDetailInfo.OptionB = item["OptionB"].ToString();
                QDetailInfo.OptionC = item["OptionC"].ToString();
                QDetailInfo.OptionD = item["OptionD"].ToString();
                context.QuestionnaireDetailInfo.Add(QDetailInfo);
               
            }
            context.SaveChanges();
            foreach (DataRow item in ((DataTable)dataInfo["MultipleChoiceTable"]).Rows)//添加多选题到试题详细表
            {
                QDetailInfo.PaperType = (int)dataInfo["QuestionnaireTypeId"];//问卷类型
                QDetailInfo.probType = (int)Enum_ProbType.多选题;
                QDetailInfo.number = (int)item["Number"];
                QDetailInfo.State = 0;
                QDetailInfo.QuestionnaireInfoId = QInfo.ID;
                QDetailInfo.Content = item["Content"].ToString();
               // QDetailInfo.Answer = item["Answer"].ToString();
                QDetailInfo.OptionA = item["OptionA"].ToString();
                QDetailInfo.OptionB = item["OptionB"].ToString();
                QDetailInfo.OptionC = item["OptionC"].ToString();
                QDetailInfo.OptionD = item["OptionD"].ToString();
                QDetailInfo.OptionE = item["OptionE"].ToString();
                QDetailInfo.OptionF = item["OptionF"].ToString();
                context.QuestionnaireDetailInfo.Add(QDetailInfo);             
            }
            context.SaveChanges();
        }


        public void SaveQuestionnaireInfo(Dictionary<string, object> dataInfo)
        {
            string paperName = dataInfo["QuestionnaireTitle"].ToString();//问卷名
            int userId = int.Parse(dataInfo["UserId"].ToString());//用户ID
            int QuestionnaireId = int.Parse(dataInfo["QuestionnaireId"].ToString());//问卷ID
            //QuestionnaireInfo QInfo = new QuestionnaireInfo();
            QuestionnaireDetailInfo QDetailInfo = new QuestionnaireDetailInfo();
                       
            foreach (DataRow item in ((DataTable)dataInfo["SingleChoiceTable"]).Rows)//添加单选题到试题详细表
            {
                int number = (int)item["Number"];
                //QDetailInfo = context.QuestionnaireDetailInfo.Single(Q_DetailInfo => Q_DetailInfo.QuestionnaireInfoId == QuestionnaireId && Q_DetailInfo.number == (int)item["Number"]);
               QDetailInfo = context.QuestionnaireDetailInfo.Single(Q_DetailInfo => Q_DetailInfo.QuestionnaireInfoId == QuestionnaireId&&Q_DetailInfo.number == number);

                QDetailInfo.PaperType = (int)Enum_PaperType.investigation;
                QDetailInfo.probType = (int)Enum_ProbType.单选题;
                QDetailInfo.number = (int)item["Number"];
                QDetailInfo.State = 0;
                QDetailInfo.QuestionnaireInfoId = QuestionnaireId;
                QDetailInfo.Content = item["Content"].ToString();
                // QDetailInfo.Answer= item["Answer"].ToString();
                QDetailInfo.OptionA = item["OptionA"].ToString();
                QDetailInfo.OptionB = item["OptionB"].ToString();
                QDetailInfo.OptionC = item["OptionC"].ToString();
                QDetailInfo.OptionD = item["OptionD"].ToString();
            }
             context.Entry(QDetailInfo);
            context.SaveChanges();
            foreach (DataRow item in ((DataTable)dataInfo["MultipleChoiceTable"]).Rows)//添加多选题到试题详细表
            {
                int number = (int)item["Number"];
                QDetailInfo = context.QuestionnaireDetailInfo.Single(Q_DetailInfo => Q_DetailInfo.QuestionnaireInfoId == QuestionnaireId && Q_DetailInfo.number == number);
                QDetailInfo.PaperType = (int)Enum_PaperType.investigation;
                QDetailInfo.probType = (int)Enum_ProbType.多选题;
                QDetailInfo.number = (int)item["Number"];
                QDetailInfo.State = 0;
                QDetailInfo.QuestionnaireInfoId = QuestionnaireId;
                QDetailInfo.Content = item["Content"].ToString();
                // QDetailInfo.Answer = item["Answer"].ToString();
                QDetailInfo.OptionA = item["OptionA"].ToString();
                QDetailInfo.OptionB = item["OptionB"].ToString();
                QDetailInfo.OptionC = item["OptionC"].ToString();
                QDetailInfo.OptionD = item["OptionD"].ToString();
                QDetailInfo.OptionE = item["OptionE"].ToString();
                QDetailInfo.OptionF = item["OptionF"].ToString();
            }
            context.Entry(QDetailInfo);
            context.SaveChanges();
        }
        #endregion


        /// <summary>
        /// 通过问卷ID获取问卷试题
        /// </summary>
        /// <param name="ID">用户ID</param>
        public IQueryable<QuestionnaireDetailInfo> GetQ_DetailInfoByQuestionnaireID(int QuestionnaireID )
        {
            //var QuestionType = context.QuestionType;
            entitiesQuestionnaireDetailInfo = context.QuestionnaireDetailInfo.Where(DetailInfo => DetailInfo.ID== QuestionnaireID);
            return entitiesQuestionnaireDetailInfo;
        }

        /// <summary>
        /// 获取问卷类型
        /// </summary>
        /// <param name="ID">用户ID</param>
        public IQueryable<QuestionnaireTypeInfo> GetQuestionnaireTypeInfo()
        {
            entitiesQuestionnaireTypeInfo = context.QuestionnaireTypeInfo;
            return entitiesQuestionnaireTypeInfo;
           
        }


        /// <summary>
        /// 获取问题类型
        /// </summary>
        /// <param name="ID">用户ID</param>
        public IQueryable<QuestionType> GetQuestionnTypeInfo(int leven, int parentTypeId)
        {
            var QuestionType = context.QuestionType;
            entitiesQuestionTypeInfo = QuestionType.Where(Q_Type => Q_Type.leven == leven && Q_Type.parentTypeId == parentTypeId);
            return entitiesQuestionTypeInfo;
        }
        // <summary>
        /// 根据扫描二维码获取ID返回问卷列表对象
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IQueryable<QuestionnaireInfo> GetQuestionnaireByUserIDBR(int ID)
        {
            var QuestionnaireInfo = context.QuestionnaireInfo.Where<QuestionnaireInfo>(Questionnaire => Questionnaire.ID == ID);
            entitiesQuestionnaireInfo = QuestionnaireInfo;
            return entitiesQuestionnaireInfo;
        }
    }
}
