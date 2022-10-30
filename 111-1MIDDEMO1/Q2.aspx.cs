using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q2 : System.Web.UI.Page {
        string[] s_City = new string[2] { "台北市", "新北市" };
        string[,] s_Area = new string[2, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"}
        };

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            { 
                for (int i_ct = 0; i_ct <s_City.Length; i_ct++)
                {
                    ListItem x = new ListItem();
                    x.Text = s_City[i_ct];
                    x.Value = s_City[i_ct];

                    dpl_City.Items.Add(x);
                }
                mt_GenSecondList();
            }
        }

        protected string[,] GetS_Area()
        {
            return s_Area;
        }

        protected void mt_GenSecondList()
        {
            int y = dpl_City.SelectedIndex;
            dpl_Area.Items.Clear();
            for (int i_ct = 0; i_ct < s_Area.GetLength(1); i_ct++)
            {
                ListItem x = new ListItem();
                x.Text = s_Area[y, i_ct];
                x.Value = s_Area[y, i_ct];

                dpl_Area.Items.Add(x);
            }
        }

        protected void dpl_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_GenSecondList();
        }
    }
}