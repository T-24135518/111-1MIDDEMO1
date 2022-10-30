using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q1 : System.Web.UI.Page {
        string[] s_IdSet = new string[3] { "A123456789", "P123456789", "YD321" };

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void tb_Account_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < s_IdSet.Length; i++)
            {
                if (tb_Account.Text == s_IdSet[i])
                {
                    lb_Type.Text = "複診";
                    break;
                }
                else
                {
                    lb_Type.Text = "初診";
                }
            }
            btn_Submit.Visible = ((tb_Account.Text != "") ? true : false);
            pl_Msg.Visible = false;
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            pl_Msg.Visible = true;
            lb_Msg.Text = lb_Type.Text + "<br />" + tb_Account.Text + "先生/小姐，已完成掛號。";
            if (tb_Email.Text != "")
            {
                lb_Msg.Text += "已寄送信箱" + tb_Email.Text + "<br />";
            }
        }
    }
}