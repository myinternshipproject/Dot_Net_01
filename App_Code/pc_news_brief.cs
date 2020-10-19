using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


/// <summary>
/// Summary description for pc_news_brief
/// </summary>
public class pc_news_brief
{
    string totalNews, body,title,tbody;

    string[,] aData = new string[20, 100];
    pc_datahandler dler = new pc_datahandler();

	public pc_news_brief()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void news_show(Table tbl_info,int num,int subMenu,int weekId,Label lb_message)
    {

        if (subMenu == 0)
        {
            aData = dler.moreColumnAllString("Select a.NewsTitle,a.NewsBrief,a.NewsId from News a where a.WeekId='"+weekId+"' and a.CategoryId in (Select b.CategoryId from NewsCategory b where b.TypeId='" + num + "')", lb_message);
        }
        else
        {
            aData = dler.moreColumnAllString("Select a.NewsTitle,a.NewsBrief,a.NewsId from News a where a.WeekId='"+weekId+"' and a.CategoryId='" + subMenu + "'", lb_message);
        }
        
        body = "";
        for (int i = 0; i < aData.GetLength(0); i++)
        {
            if (aData[i, 0] == null)
            {
                break;
            }
       

        
        body +="<div id='rightnow'>";
           body +="<h3 class='reallynow'>";
           body += "<span><font face='suto'> "+aData[i,0]+" </font> </span>";
                  body +="<br />";
                   body +="</h3>";
                   body += "<p class='youhave'><font face='suto'> " + aData[i, 1] + " </font>";
                     
                      body += "&nbsp;&nbsp;&nbsp;<font face='suto'><a href='detailnews.aspx?NewsId=" + aData[i, 2] + "'>বিস্তারিত</a></font> ";
                      body += "</p>"; 
                     body += "</div>";
        }
        //======= ========= ========== ========== ============

                     //  body += "<div id='rightnow'>";
                     //  body += "<h3 class='reallynow'>";
                    //   body += "<span>Right Now</span>";
                    //   body += "<br />";
                   //    body += "</h3>";
                    //   body += "<p class='youhave'>You have <a href='#'>19 new orders</a>, <a href='#'>12 new users</a> and <a href='#'>5 new reviews</a>, today you made <a href='#'>$1523.63 in sales</a> and a total of <strong>$328.24 profit </strong>";
                    //   body += "</p>";
                    //   body += "</div>";



                       totalNews = body;
                       TableCell tcell = new TableCell();
                       tcell.Text = totalNews;
                       TableRow trow = new TableRow();
                       trow.Cells.Add(tcell);
                       tbl_info.Rows.Add(trow);
              
              
              


    }

    //============ =========== ================= ==========
    public void news_detail_show(Table tbl_info, int num, Label lb_message)
    {

        aData = dler.moreColumnAllString("Select a.NewsTitle,a.NewsDetail,a.NewsBy from News a where a.NewsId='"+num+"'", lb_message);
        body = "";
         
            if (aData[0, 0] != null)
            {
                


            body += "<div id='rightnow'>";
            body += "<h3 class='reallynow'>";
            body += "<span><font face='suto'> " + aData[0, 0] + " </font> </span>";
            body += "<br />";
            body += "</h3>";
            body += "<p class='youhave'><font face='suto'> " +HttpUtility.HtmlDecode(aData[0, 1]) + " </font>";
            body += "</p>";
           // body += "<span><font face='suto'><a href='detailnews.aspx?NewsId=" + aData[i, 2] + "'>বিস্তারিত</a></font> </span>";
            body += "</div>";
        }
        //======= ========= ========== ========== ============

        //  body += "<div id='rightnow'>";
        //  body += "<h3 class='reallynow'>";
        //   body += "<span>Right Now</span>";
        //   body += "<br />";
        //    body += "</h3>";
        //   body += "<p class='youhave'>You have <a href='#'>19 new orders</a>, <a href='#'>12 new users</a> and <a href='#'>5 new reviews</a>, today you made <a href='#'>$1523.63 in sales</a> and a total of <strong>$328.24 profit </strong>";
        //   body += "</p>";
        //   body += "</div>";



        totalNews = body;
        TableCell tcell = new TableCell();
        tcell.Text = totalNews;
        TableRow trow = new TableRow();
        trow.Cells.Add(tcell);
        tbl_info.Rows.Add(trow);





    }


    //================= ================ ===================


}