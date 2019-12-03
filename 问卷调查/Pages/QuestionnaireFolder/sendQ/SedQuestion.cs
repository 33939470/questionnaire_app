using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 问卷调查.BLL;

namespace 问卷调查.Pages.QuestionnaireListFolder.sendQ
{
    partial class SedQuestion : Smobiler.Core.Controls.MobileForm
    {
        static int id = 0;
        static string str = "";
        public SedQuestion(int id,string str) : base()
        {
            sendQ.SedQuestion.id = id;
            sendQ.SedQuestion.str = str;
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void SedQuestion_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(SedQuestion.id.ToString());
            string id= RSACSR.Encryption(SedQuestion.id.ToString());
            label3.Text = sendQ.SedQuestion.str;
            
            this.barCodeView1.Value = id;
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}