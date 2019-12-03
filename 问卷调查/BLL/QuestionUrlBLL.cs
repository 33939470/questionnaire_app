using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 问卷调查.BLL
{
    public class QuestionUrlBLL
    {
        public paper_QuestionnaireEntities context = new paper_QuestionnaireEntities();
        public IQueryable<QuestionUrl> entitiesQuestionUrlInfo;
        public IQueryable<QuestionUrl> GetQuestionUrlInfo(int Qid,int UserID)
        {
            var QuestionUrlInfo = context.QuestionUrl.Where(t => t.Qid == Qid&&t.UserId==UserID);
            entitiesQuestionUrlInfo = QuestionUrlInfo;
            return entitiesQuestionUrlInfo;
        }
    }
}
