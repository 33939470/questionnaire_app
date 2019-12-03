using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 问卷调查.BLL
{
    public static class Enums
    {
        #region 问卷类型
        /// <summary>
        /// 问卷类型
        /// </summary>
        public enum Enum_PaperType
        {
            /// <summary>
            /// 调查
            /// </summary>
            investigation = 1,

            /// <summary>
            /// 考试
            /// </summary>
            Examination = 2,

            /// <summary>
            /// 投票
            /// </summary>
            vote = 3,


            /// <summary>
            /// 表单
            /// </summary>
            form = 4,

            /// <summary>
            /// 360度评估
            /// </summary>
            Assessment360 = 5,

            /// <summary>
            /// 评测
            /// </summary>
            evaluating = 5,

        }
        #endregion

        #region 问题类型
        /// <summary>
        /// 问题类型
        /// </summary>
        public enum Enum_ProbType
        {
            /// <summary>
            /// 单选题
            /// </summary>
            单选题 = 1,

            /// <summary>
            /// 多选题
            /// </summary>
            多选题 = 2,

            /// <summary>
            /// 填空题
            /// </summary>
            填空题 = 3,

            /// <summary>
            /// 简答题
            /// </summary>
            简答题 = 4

        }
        #endregion

        #region 数据操作模式
        /// <summary>
        /// 数据操作模式
        /// </summary>
        public enum Enum_DataOption
        {
            Add=1,
            Update=2,
            Delete=3,
        }
        #endregion 
    }
}
