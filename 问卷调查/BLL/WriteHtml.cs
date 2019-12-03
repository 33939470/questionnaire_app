using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

using 问卷调查.QHtmlWebService;

namespace 问卷调查.BLL
{
    public class WriteHtml
    {
        public static string WriteFile(string id,int userId,out string url)
        {
            string msg = "";
            QHtmlWebServiceSoapClient q = new QHtmlWebServiceSoapClient();
            
            msg=q.Chtml(id,userId,out url);
            return msg;
        }

    }
}

