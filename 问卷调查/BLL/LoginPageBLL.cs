using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 问卷调查.BLL
{
    class LoginPageBLL
    {
        public string CheckUserInfo(string userName, string passWord, ref bool LoginState,ref int UserID)
        {
            DataTable result = ADO.query("select * from userInfo where  userName='" + userName + "'");
            if (result.Rows.Count > 0)
            {
                if (result.Rows[0]["passWord"].ToString() != passWord)
                {
                    LoginState = false;
                    return "用户名与密码不匹配";
                }
                else
                {
                    UserID = int.Parse(result.Rows[0]["ID"].ToString());
                    return string.Empty;
                }                 
            }
            else
            {
                LoginState = false;
                return "该用户不存在";
            }

        }
    }
}
