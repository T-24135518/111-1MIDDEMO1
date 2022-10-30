using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q2_Sub : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            /*lb_Msg.Text = "保單號碼：" + Request.Form.Get("tb_Num") + "<br />" +  "通訊種類：" + Request.Form.Get("rbl_Phone") + "<br />" +
               "通訊號碼：" + Request.Form.Get("txt_Phone") + "<br />" + "所在城市：" + Request.Form.Get("dpl_City") + "<br />" +
               "所在區域：" + Request.Form.Get("dpl_Area");*/

            string[] s_text = new string[] { "保單號碼：", "通訊種類：", "通訊號碼：", "所在城市：", "所在區域："};
            string[] s_get = new string[] {"tb_Num", "rbl_Phone", "txt_Phone", "dpl_City", "dpl_Area" };
            for (int x = 0; x < s_get.Length; x++)
            {
                lb_Msg.Text += s_text[x] + Request.Form.Get(s_get[x]) + "<br />";
            }
            
        }
    }
}