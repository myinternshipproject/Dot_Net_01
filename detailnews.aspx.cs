using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class detailnews : System.Web.UI.Page
{
    int newsID;
    pc_news_brief bnews = new pc_news_brief();
    pc_sub_menu menu = new pc_sub_menu();
    pc_onload load = new pc_onload();
    string CatId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CatId = Request.QueryString["CatId"];
        newsID = Convert.ToInt32(Request.QueryString["NewsId"]);
        menu.main_menu(tbl_top_menu, 1);
        menu.sub_menu(tbl_sub_menu, 1,1,lb_message);
        load.load_week(dd_week, lb_message);
        bnews.news_detail_show(tbl_info, newsID, lb_message);

    }
}