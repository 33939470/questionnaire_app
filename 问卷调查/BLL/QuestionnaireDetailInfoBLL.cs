using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 问卷调查.BLL
{
    public class QuestionnaireDetailInfoBLL
    {
        public paper_QuestionnaireEntities context = new paper_QuestionnaireEntities();
        public IQueryable<QuestionnaireDetailInfo> questionnaireDetailInfo;
        public IQueryable<QuestionnaireDetailInfo> GetQuestionUrlInfo(int questionnaireInfoId)
        {
            var QuestionnaireDetailInfo = context.QuestionnaireDetailInfo.Where(t => t.QuestionnaireInfoId==questionnaireInfoId);
            questionnaireDetailInfo = QuestionnaireDetailInfo;
            return QuestionnaireDetailInfo;
        }
    }
}
