﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class entertainment : System.Web.UI.Page
{
    pc_news_brief brief = new pc_news_brief();
    pc_sub_menu menu = new pc_sub_menu();
    pc_onload load = new pc_onload();
    string CatId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CatId = Request.QueryString["CatId"];
        if (!IsPostBack)
        {
            if (CatId == null)
            {
               // brief.news_show(tbl_info, 7,0, lb_message);
            }
            else
            {
              //  brief.news_show(tbl_info, 7,Convert.ToInt32(CatId), lb_message);
            }

            menu.main_menu(tbl_top_menu, 7);
            menu.sub_menu(tbl_sub_menu, 7,1,lb_message);
            load.load_week(DropDownList1, lb_message);
        }

    }
}