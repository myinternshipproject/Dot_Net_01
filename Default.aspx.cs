using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    pc_news_brief brief = new pc_news_brief();
    pc_sub_menu menu = new pc_sub_menu();
    pc_onload load = new pc_onload();
    string CatId,WeekId,WeekName;
    string [,] aWeek = new string [2,10];

    protected void Page_Load(object sender, EventArgs e)
    {
        CatId = Request.QueryString["CatId"];
        if (!IsPostBack)
        {
            aWeek = load.load_act_week(lb_message);
            WeekId = aWeek[0, 0];
            WeekName = aWeek[0, 1];

            if (CatId == null)
            {
                brief.news_show(tbl_info, 1,0,Convert.ToInt32(WeekId), lb_message);
            }
            else
            {
                brief.news_show(tbl_info, 1, Convert.ToInt32(CatId), Convert.ToInt32(WeekId), lb_message);
            }
           // brief.news_show(tbl_info,1,lb_message);
            menu.main_menu(tbl_top_menu, 1);
            menu.sub_menu(tbl_sub_menu, 1,1,lb_message);
            load.load_week(dd_week, lb_message);
            dd_week.Text = Convert.ToString(WeekName);

        }

    }

    //==============
    protected void dd_week_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["PubNumber"] = dd_week.SelectedItem.Text;
        Session["PubId"] = dd_week.SelectedValue;
    }

    //=========== =================
}