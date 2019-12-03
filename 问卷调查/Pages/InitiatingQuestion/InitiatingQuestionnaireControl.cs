using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Drawing;

namespace 问卷调查.Pages.InitiatingQuestion
{
    partial class InitiatingQuestionnaireControl : Smobiler.Core.Controls.MobileUserControl
    {
        public InitiatingQuestionnaireControl() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void InitiatingQuestionnaireControl_Load(object sender, EventArgs e)
        {
           
        }


        private void panel1_Press(object sender, EventArgs e)
        {
            //this.BorderColor = Color.Blue;
            //this.BorderStyle = BorderStyle.Dotted;
           // this.BackColor = Color.Gray;
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            //this.BorderColor = Color.Blue;
            //this.BorderStyle = BorderStyle.Dotted;
            //MessageBox.Show("ds");
        }
    }
}