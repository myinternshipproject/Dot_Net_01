using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


/// <summary>
/// Summary description for pc_insert
/// </summary>
public class pc_insert
{
    int sChecker, sChecker2, conf, conf2, clientId, contructorId, userTypeId, accessId;
    pc_datahandler dhandler = new pc_datahandler();
    pc_data_valid dvalid = new pc_data_valid();
    Random ran = new Random();
    string tsql, PicFileName;
    int[] mywork = new int[31];
    int fileSize;
    string[] fdata = new string[20];

	public pc_insert()
	{
		//
		// TODO: Add constructor logic here
		//
        fdata[0] = "qaz";
        fdata[1] = "wsx";
        fdata[2] = "edc";
        fdata[3] = "rfv";
        fdata[4] = "tgb";
        fdata[5] = "yhn";
        fdata[6] = "ujm";
        fdata[7] = "ik1";
        fdata[8] = "qwe";
        fdata[9] = "ert";
        fdata[10] = "tyu";
        fdata[11] = "uio";
        fdata[12] = "asd";
        fdata[13] = "dfg";
        fdata[14] = "ghj";
        fdata[15] = "jkl";
        fdata[16] = "zxc";
        fdata[17] = "cvb";
        fdata[18] = "bnm";
        fdata[19] = "zdr";

        



	}


    //=========== ============ =========================

    public void insert_contact(TextBox tb_address, TextBox tb_phone, TextBox tb_email, TextBox tb_fax, TextBox tb_web,Label lb_message)
    {
        sChecker = dvalid.checkEmpty(tb_address.Text, tb_phone.Text, tb_email.Text);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("insert into Contact (Address,Phone,Email,Fax,Web) values ('" + tb_address.Text.Trim() + "','" + tb_phone.Text.Trim() + "','" + tb_email.Text.Trim() + "','" + tb_fax.Text.Trim() + "','" + tb_web.Text.Trim() +  "')", lb_message);
            if (conf > 0)
            {
                tb_address.Text = "";
                tb_phone.Text = "";
                tb_email.Text = "";
                tb_fax.Text = "";
                tb_web.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }

    //============= ================== ============

    public void insert_news_type(TextBox tb_type,  Label lb_message)
    {
        sChecker = dvalid.checkEmpty(tb_type.Text);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("insert into NewsType (Type) values ('" + tb_type.Text.Trim() + "')", lb_message);
            if (conf > 0)
            {
                tb_type.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }

    //================= ================== ================
    public void insert_news_Category(TextBox tb_category, Label lb_message)
    {
        sChecker = dvalid.checkEmpty(tb_category.Text);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("insert into NewsCategory (Category) values ('" + tb_category.Text+ "')", lb_message);
            if (conf > 0)
            {
                tb_category.Text = "";
               // dd_type.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }


    //=========== ================== =========================
    public void insert_week_Detail(TextBox tb_weekname, Label lb_message)
    {
        sChecker = dvalid.checkEmpty(tb_weekname.Text);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("insert into WeekDetail (WeekName,Date,FrontView,Status) values ('" + tb_weekname.Text.Trim()+"','"+DateTime.Today.ToString("MM/dd/yyyy") + "','0','1')", lb_message);
            if (conf > 0)
            {
                tb_weekname.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }


    //================== ================= =====================

    public void insert_News(DropDownList dd_week,DropDownList dd_category,string newstitle, string newsbrief, string newsDetail,string newsby,DropDownList dd_newsStatus,DropDownList dd_viewStatus,TextBox tb_soft_title, Label lb_message)
    {
        sChecker = dvalid.checkEmpty(dd_week.Text,dd_category.Text,newstitle,newsbrief, newsDetail);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("insert into News (WeekId,CategoryId,NewsTitle,NewsBrief,NewsDetail,NewsBy,Validity,NewsStatus,ViewStatus,title2) values ('" +dd_week.SelectedValue+ "','" +dd_category.SelectedValue + "','"+dvalid.repData(newstitle)+"','"+dvalid.repData(newsbrief)+"','"+dvalid.repData(newsDetail)+"','"+dvalid.repData(newsby)+"','"+dd_week.SelectedValue+"#"+dvalid.repHtml(newstitle)+"','"+dd_newsStatus.SelectedValue+"','"+dd_viewStatus.SelectedValue+"','"+tb_soft_title.Text.Trim()+"')", lb_message);
            if (conf > 0)
            {
               // dd_category.Text = "";
               // dd_week.Text = "";
               // tb_newsbrief.Text = "";
               // tb_newsby.Text = "";
               // tb_newsdetail.Text = "";
               // tb_newstitle.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }
    
    //============= =============== =======================
    //================== ================= =====================


    public void insert_MonthInfo(DropDownList dd_type, TextBox tb_monthNo, TextBox tb_monthName, TextBox tb_monthDays, Label lb_message)
    {
        sChecker = dvalid.checkEmpty(dd_type.Text, tb_monthNo.Text, tb_monthName.Text, tb_monthDays.Text);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("insert into MonthInfo (MonthType,MonthNo,MonthName,Days) values ('" + dd_type.SelectedValue + "','"+tb_monthNo.Text.Trim()+"','"+tb_monthName.Text.Trim()+"','"+tb_monthDays.Text.Trim()+"')", lb_message);
            if (conf > 0)
            {
                tb_monthDays.Text = "";
                tb_monthName.Text = "";
                tb_monthNo.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }
    //============= =============== =======================
    //=================== ================== ===============
    //================== ================= =====================

    public void insert_SQL(TextBox tb_sql,  Label lb_message)
    {
        sChecker = dvalid.checkEmpty(tb_sql.Text);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend(tb_sql.Text.Trim(), lb_message);
            if (conf > 0)
            {
                tb_sql.Text = "";
                 
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }


    //================== ================== ======================
    //========= ================ ================== ==============

    //============= ==================== =====================
    public void insert_large_picture(DropDownList dd_news, FileUpload fu_pic, string fpath, Label lb_message)
    {
        sChecker = dvalid.checkEmpty(dd_news.Text, fpath);
        if (sChecker == 1)
        {
            PicFileName = "large_pic_" + ran.Next(10000, 99999) + "_" + fdata[ran.Next(0, 19)] + "_" + dd_news.SelectedValue + "_d_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_t_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + ".jpg";
            conf = dhandler.dataSend("insert into NewsPic ( NewsId,PicFile ) values ('" + dd_news.SelectedValue + "','" + PicFileName + "')", lb_message);
            if (conf > 0)
            {
                dhandler.picSend(fu_pic, fpath, PicFileName);
                //tb_pictitle.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }



    //============ =============== ================ =======================

    //============= ==================== =====================
    public void insert_small_picture(DropDownList dd_news, FileUpload fu_pic, string fpath, Label lb_message)
    {
        sChecker = dvalid.checkEmpty(dd_news.Text, fpath);
        if (sChecker == 1)
        {
            PicFileName = "small_pic_" + ran.Next(10000, 99999) + "_" + fdata[ran.Next(0, 19)] + "_" + dd_news.SelectedValue + "_d_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_t_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + ".jpg";
            conf = dhandler.dataSend("insert into NewsSmallPic ( NewsId,PicFile ) values ('" + dd_news.SelectedValue + "','" + PicFileName + "')", lb_message);
            if (conf > 0)
            {
                dhandler.picSend(fu_pic, fpath, PicFileName);
                //tb_pictitle.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }

    //=========== ================ =============== ========================

    //================== ================= =====================

    public void insert_update_news(string newstitle, string newsbrief, string newsDetail, string newsby, DropDownList dd_newsStatus, DropDownList dd_viewStatus, DropDownList dd_softtitle, Label lb_message)
    {
        sChecker = dvalid.checkEmpty( newstitle, newsbrief, newsDetail,dd_newsStatus.Text,dd_viewStatus.Text);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("update News set NewsTitle='"+newstitle+"',NewsBrief='"+newsbrief+"',NewsDetail='"+newsDetail+"',NewsBy='"+newsby+"',NewsStatus='"+dd_newsStatus.SelectedValue+"',ViewStatus='"+dd_viewStatus.SelectedValue+"' where newsId='"+dd_softtitle.SelectedValue+"'", lb_message);
            if (conf > 0)
            {
                // dd_category.Text = "";
                // dd_week.Text = "";
                // tb_newsbrief.Text = "";
                // tb_newsby.Text = "";
                // tb_newsdetail.Text = "";
                // tb_newstitle.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }

    //============= =============== =======================

    public void insert_DayInfo( TextBox tb_dayNo, TextBox tb_dayName,  Label lb_message)
    {
        sChecker = dvalid.checkEmpty( tb_dayNo.Text, tb_dayName.Text);
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("insert into DayInfo (DayNo,Day) values ('" +  tb_dayNo.Text.Trim() + "','" + tb_dayName.Text.Trim() + "')", lb_message);
            if (conf > 0)
            {
                tb_dayNo.Text = "";
                tb_dayName.Text = "";
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }
    //============= =============== =======================
    public void insert_newsDelete(DropDownList dd_news, Label lb_message)
    {
        sChecker = dvalid.checkEmpty(dd_news.Text.Trim());
        if (sChecker == 1)
        {
            conf = dhandler.dataSend("Delete from News Where NewsId='"+dd_news.SelectedValue+"'", lb_message);
            if (conf > 0)
            {
                
            }
        }
        else
        {
            lb_message.Text = "Fill the empty field";
        }

    }
    
    //====== ============ ================ ================ ===============

}