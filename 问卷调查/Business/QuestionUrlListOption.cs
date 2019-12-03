using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 问卷调查.BLL;

namespace 问卷调查.Business
{
    class QuestionUrlListOption
    {
        QuestionUrlBLL QuestionUrlBLL = new QuestionUrlBLL();

        /// <summary>
        /// 返回生成url信息
        /// </summary>
        public List<QuestionUrl> GetQuestionUrl(int Qid,int UserID)
        {
            List<QuestionUrl> Questionnaires = QuestionUrlBLL.GetQuestionUrlInfo(Qid,UserID).ToList();
            return Questionnaires;
        }
    }
}
