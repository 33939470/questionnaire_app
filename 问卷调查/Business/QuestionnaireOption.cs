using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 问卷调查.BLL;
using 问卷调查.Pages.QuestionnaireListFolder;
using static 问卷调查.BLL.Enums;

namespace 问卷调查.Business
{
    /// <summary>
    /// 问卷信息逻辑操作层
    /// </summary>
   public class QuestionnaireOption
    {
        QuestionnaireOptionBLL QuestionnaireBLL = new QuestionnaireOptionBLL();

        /// <summary>
        /// 根据用户ID返回问卷列表
        /// </summary>
        public List<QuestionnaireInfo> GetQuestionnaireListByUserID(int UserID)
        {
            List<QuestionnaireInfo> Questionnaires = QuestionnaireBLL.GetQuestionnaireListByUserID(UserID).ToList();
            return Questionnaires;
        }

        /// <summary>
        ///  通过问卷ID获取问卷试题
        /// </summary>
        /// <param name="QuestionnaireID">类型等级</param>
        /// <returns></returns>
        public List<QuestionnaireDetailInfo> GetQ_DetailInfoByQuestionnaireID(int QuestionnaireID)
        {
            List<QuestionnaireDetailInfo> Q_DetailInfo = QuestionnaireBLL.GetQ_DetailInfoByQuestionnaireID(QuestionnaireID).ToList() ;
            return Q_DetailInfo;
        }

        /// <summary>
        /// 获取问题类型信息
        /// </summary>
        /// <param name="leven">类型等级</param>
        /// <param name="parentTypeId">父类型ID（0代表此级为第一级）</param>
        /// <returns></returns>
        public List<QuestionType> GetQuestionTypeInfoByleven(int leven,int parentTypeId)
        {
            List<QuestionType> QuestionTypeInfo = QuestionnaireBLL.GetQuestionnTypeInfo(leven, parentTypeId).ToList();
            return QuestionTypeInfo;
        }

        /// <summary>
        /// 获取问卷类型信息
        /// </summary>
        /// <param name="leven">类型等级</param>
        /// <param name="parentTypeId">父类型ID（0代表此级为第一级）</param>
        /// <returns></returns>
        public List<QuestionnaireTypeInfo> GetQuestionnaireTypeInfo()
        {
            List<QuestionnaireTypeInfo> questionnaireTypeInfo = QuestionnaireBLL.GetQuestionnaireTypeInfo().ToList();
            return questionnaireTypeInfo;
        }
        /// <summary>
        /// 根据扫描二维码显示对应问卷
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public List<QuestionnaireInfo> GetQuestionnaireListByUserIDBR(int ID)
        {
            List<QuestionnaireInfo> Questionnaires = QuestionnaireBLL.GetQuestionnaireByUserIDBR(ID).ToList();
            return Questionnaires;
        }
        /// <summary>
        /// 保存问卷
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public string SaveQuestionnaireInfo(Dictionary<string, object> dataInfo,Enum_DataOption mode )
        {
            try
            {
                if (mode == Enum_DataOption.Add)
                    QuestionnaireBLL.AddQuestionnaireInfo(dataInfo);
                if (mode == Enum_DataOption.Update)
                    QuestionnaireBLL.SaveQuestionnaireInfo(dataInfo);

                return "保存成功";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }           
        }
    }
}
