using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


/// <summary>
/// Summary description for pc_sub_menu
/// </summary>
public class pc_sub_menu
{
    string tmenu,smenu;

    string[,] aData = new string[20, 100];
    pc_datahandler dler = new pc_datahandler();

	public pc_sub_menu()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public void main_menu(Table tbl_info , int index )
    {

       tmenu = "<div id='header'>";
             
       tmenu += "<h2 id='tid'>cÖwZw`‡bi wPÎ</h2>";
       tmenu += "<h6 id='tid2'>  Av‡cvlnxb I Av‡jvwKZ mvßvwnK  </h6>";
      // tmenu += "<select><option></option> </select>";
      
        tmenu +="<div id='topmenu'>";

        if (index == 1)
        {
            tmenu += "<ul>";
            tmenu += "<li id='bli' class='current'><a href='Default.aspx'>msev`</a></li>";
            tmenu += "<li class='bli2'><a href='politics.aspx'>ivRbxwZ</a></li>";
            tmenu += "<li class='bli2'><a href='culture.aspx'>ms¯‹„wZ</a></li>";
            tmenu += "<li class='bli2'><a href='literature.aspx'>mvwnZ¨</a></li>";
            tmenu += "<li class='bli2'><a href='article.aspx'>cÖwZ‡e`b</a></li>";
            tmenu += "<li class='bli2'><a href='sport.aspx'>‡Ljvayjv</a></li>";
            tmenu += "<li class='bli2'><a href='entertainment.aspx'>we‡bv`b</a></li>";
            tmenu += "</ul>";
        }
        else if (index == 2)
        {
            tmenu += "<ul>";
            tmenu += "<li id='bli'><a href='Default.aspx'>msev`</a></li>";
            tmenu += "<li class='bli2' class='current'><a href='politics.aspx'>ivRbxwZ</a></li>";
            tmenu += "<li class='bli2'><a href='culture.aspx'>ms¯‹„wZ</a></li>";
            tmenu += "<li class='bli2'><a href='literature.aspx'>mvwnZ¨</a></li>";
            tmenu += "<li class='bli2'><a href='article.aspx'>cÖwZ‡e`b</a></li>";
            tmenu += "<li class='bli2'><a href='sport.aspx'>‡Ljvayjv</a></li>";
            tmenu += "<li class='bli2'><a href='entertainment.aspx'>we‡bv`b</a></li>";
            tmenu += "</ul>";
        }
        else if (index == 3)
        {
            tmenu += "<ul>";
            tmenu += "<li id='bli'><a href='Default.aspx'>msev`</a></li>";
            tmenu += "<li class='bli2'><a href='politics.aspx'>ivRbxwZ</a></li>";
            tmenu += "<li class='bli2' class='current'><a href='culture.aspx'>ms¯‹„wZ</a></li>";
            tmenu += "<li class='bli2'><a href='literature.aspx'>mvwnZ¨</a></li>";
            tmenu += "<li class='bli2'><a href='article.aspx'>cÖwZ‡e`b</a></li>";
            tmenu += "<li class='bli2'><a href='sport.aspx'>‡Ljvayjv</a></li>";
            tmenu += "<li class='bli2'><a href='entertainment.aspx'>we‡bv`b</a></li>";
            tmenu += "</ul>";
        }
        else if (index == 4)
        {
            tmenu += "<ul>";
            tmenu += "<li id='bli'><a href='Default.aspx'>msev`</a></li>";
            tmenu += "<li class='bli2'><a href='politics.aspx'>ivRbxwZ</a></li>";
            tmenu += "<li class='bli2'><a href='culture.aspx'>ms¯‹„wZ</a></li>";
            tmenu += "<li class='bli2'  class='current'><a href='literature.aspx'>mvwnZ¨</a></li>";
            tmenu += "<li class='bli2'><a href='article.aspx'>cÖwZ‡e`b</a></li>";
            tmenu += "<li class='bli2'><a href='sport.aspx'>‡Ljvayjv</a></li>";
            tmenu += "<li class='bli2'><a href='entertainment.aspx'>we‡bv`b</a></li>";
            tmenu += "</ul>";
        }
        else if (index == 5)
        {
            tmenu += "<ul>";
            tmenu += "<li id='bli'><a href='Default.aspx'>msev`</a></li>";
            tmenu += "<li class='bli2'><a href='politics.aspx'>ivRbxwZ</a></li>";
            tmenu += "<li class='bli2'><a href='culture.aspx'>ms¯‹„wZ</a></li>";
            tmenu += "<li class='bli2'><a href='literature.aspx'>mvwnZ¨</a></li>";
            tmenu += "<li class='bli2' class='current'><a href='article.aspx'>cÖwZ‡e`b</a></li>";
            tmenu += "<li class='bli2'><a href='sport.aspx'>‡Ljvayjv</a></li>";
            tmenu += "<li class='bli2'><a href='entertainment.aspx'>we‡bv`b</a></li>";
            tmenu += "</ul>";
        }
        else if (index == 6)
        {
            tmenu += "<ul>";
            tmenu += "<li id='bli'><a href='Default.aspx'>msev`</a></li>";
            tmenu += "<li class='bli2'><a href='politics.aspx'>ivRbxwZ</a></li>";
            tmenu += "<li class='bli2'><a href='culture.aspx'>ms¯‹„wZ</a></li>";
            tmenu += "<li class='bli2'><a href='literature.aspx'>mvwnZ¨</a></li>";
            tmenu += "<li class='bli2'><a href='article.aspx'>cÖwZ‡e`b</a></li>";
            tmenu += "<li class='bli2' class='current'><a href='sport.aspx'>‡Ljvayjv</a></li>";
            tmenu += "<li class='bli2'><a href='entertainment.aspx'>we‡bv`b</a></li>";
            tmenu += "</ul>";
        }
        else if (index == 7)
        {
            tmenu += "<ul>";
            tmenu += "<li id='bli'><a href='Default.aspx'>msev`</a></li>";
            tmenu += "<li class='bli2'><a href='politics.aspx'>ivRbxwZ</a></li>";
            tmenu += "<li class='bli2'><a href='culture.aspx'>ms¯‹„wZ</a></li>";
            tmenu += "<li class='bli2'><a href='literature.aspx'>mvwnZ¨</a></li>";
            tmenu += "<li class='bli2'><a href='article.aspx'>cÖwZ‡e`b</a></li>";
            tmenu += "<li class='bli2'><a href='sport.aspx'>‡Ljvayjv</a></li>";
            tmenu += "<li class='bli2' class='current'><a href='entertainment.aspx'>we‡bv`b</a></li>";
            tmenu += "</ul>";
        }

        tmenu += "</div>";
        tmenu += "</div>";

        tbl_info.BorderWidth = 0;
        

        TableCell tcell = new TableCell();
        tcell.VerticalAlign = VerticalAlign.Top;
        tcell.BorderWidth = 0;
        tcell.Text = tmenu;
        TableRow trow = new TableRow();
        trow.Cells.Add(tcell);
        tbl_info.Rows.Add(trow);

    }

    //========== =========== ============== ===================

    public void sub_menu(Table tbl_info, int index,int number,Label lb_message)
    {
        tmenu = "";
        tmenu += "<div id='top-panel'>";
            tmenu +="<div id='panel'>";

            aData = dler.moreColumnAllString("Select a.CategoryId,a.Category from NewsCategory a where a.CategoryId in (Select distinct b.CategoryId from News b where b.WeekId='"+number+"') and a.TypeId='"+index+"'", lb_message);
       

            
                tmenu += "<ul>";
              //  tmenu += "<li><a href='#' class='report'><font face='suto'>evsjv‡`k </font></a></li>";
              //  tmenu += "<li><a href='#' class='report_seo'><font face='suto'>Avš—©RvwZK </font></a></li>";
                // tmenu +="<li><a href='#' class='search'>Search</a></li>";
                // tmenu +="<li><a href='#' class='feed'>RSS Feed</a></li>";
        //======= ================ ============ ===========

                for (int i = 0; i < 50; i++)
                {
                    if (aData[i, 0] == null)
                    {
                        break;
                    }


                   

                    //==============


                    if (index == 1)
                    {
                        tmenu += "<li><a href='Default.aspx?CatId=" + aData[i, 0] + "' class='report'><font face='suto'>" + aData[i, 1] + "</font></a></li>";
                    }
                    else if (index == 2)
                    {
                        tmenu += "<li><a href='politics.aspx?CatId=" + aData[i, 0] + "' class='report'><font face='suto'>" + aData[i, 1] + "</font></a></li>";
                    }
                    else if (index == 4)
                    {
                        tmenu += "<li><a href='culture.aspx?CatId=" + aData[i, 0] + "' class='report'><font face='suto'>" + aData[i, 1] + "</font></a></li>";
                    }
                    else if (index == 3)
                    {
                        tmenu += "<li><a href='literature.aspx?CatId=" + aData[i, 0] + "' class='report'><font face='suto'>" + aData[i, 1] + "</font></a></li>";
                    }
                    else if (index == 5)
                    {
                        tmenu += "<li><a href='article.aspx?CatId=" + aData[i, 0] + "' class='report'><font face='suto'>" + aData[i, 1] + "</font></a></li>";
                    }
                    else if (index == 6)
                    {
                        tmenu += "<li><a href='sport.aspx?CatId=" + aData[i, 0] + "' class='report'><font face='suto'>" + aData[i, 1] + "</font></a></li>";
                    }
                    else if (index == 7)
                    {
                        tmenu += "<li><a href='entertainment.aspx?CatId=" + aData[i, 0] + "' class='report'><font face='suto'>" + aData[i, 1] + "</font></a></li>";
                    }
                    

                }


        //==     ================= ==================
                tmenu += "</ul>";
             

            
           
            

            
            
                 
     tmenu +="</div>";
     tmenu +="</div>";


       //========== =========== =====================
          

        tbl_info.BorderWidth = 0;
        

        TableCell tcell = new TableCell();
        tcell.VerticalAlign = VerticalAlign.Top;
        tcell.BorderWidth = 0;
        tcell.Text = tmenu;
        TableRow trow = new TableRow();
        trow.Cells.Add(tcell);
        tbl_info.Rows.Add(trow);
       //================ ===========================

    }


    //======= ======================= ========================
    public void CP_main_menu(Table tbl_info, int index)
    {

        tmenu = "<div id='header'>";

        tmenu += "<h2 id='tid'>cÖwZw`‡bi wPÎ</h2>";
        tmenu += "<h6 id='tid2'>Av‡cvlnxb I Av‡jvwKZ mvßvwnK </h6>";
        // tmenu += "<select><option></option> </select>";

        tmenu += "<div id='topmenu'>";

        if (index == 1)
        {
            tmenu += "<ul>";
            tmenu += "<li><a href='weekdetail.aspx'> Pub. Num </a></li>";
           // tmenu += "<li><a href='newstype.aspx'> News Type  </a></li>";
            tmenu += "<li><a href='newscategory.aspx'> News Cate.  </a></li>";
            tmenu += "<li><a href='news.aspx'> News   </a></li>";
            tmenu += "<li><a href='smallnewspic.aspx'> Pic (Small)  </a></li>";
            tmenu += "<li><a href='newspic.aspx'>  Pic (Large)  </a></li>";
            tmenu += "<li><a href='editnews.aspx'> News (edit)  </a></li>";
            tmenu += "<li><a href='contact.aspx'> Contact  </a></li>";
            tmenu += "<li><a href='monthinfo.aspx'> Month Info  </a></li>";
            tmenu += "<li><a href='dayinfo.aspx'> Day Info  </a></li>";
            tmenu += "<li><a href='userinfo.aspx'> User  </a></li>";
            tmenu += "<li><a href='logout.aspx'> Logout  </a></li>";
            tmenu += "<li><a href='datastatus.aspx'> Data Status  </a></li>";
            tmenu += "<li><a href='Delete_news.aspx'> Delete News  </a></li>";
            tmenu += "</ul>";
        }
        else 
        {
            tmenu += "<br/><br/><ul>";
            tmenu += "<li> </li>";
            tmenu += "<li> </li>";
            tmenu += "<li> </li>";
            tmenu += "<li> </li>";
            tmenu += "<li> </li>";
            tmenu += "<li> </li>";
            tmenu += "<li> </li>";
            tmenu += "</ul>";
        }

        tmenu += "</div>";
        tmenu += "</div>";

        tbl_info.BorderWidth = 0;


        TableCell tcell = new TableCell();
        tcell.VerticalAlign = VerticalAlign.Top;
        tcell.BorderWidth = 0;
        tcell.Text = tmenu;
        TableRow trow = new TableRow();
        trow.Cells.Add(tcell);
        tbl_info.Rows.Add(trow);

    }

    //========== =========== ============== ===================
    //================== ====================== ==============

    //============== ================ =========================

}