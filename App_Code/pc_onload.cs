using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


/// <summary>
/// Summary description for pc_onload
/// </summary>
public class pc_onload
{

    string[,] moredata = new string[1000, 37];
    string[] mdata = new string[15];
    int conf, conf2;
    string ActPubNumber,HtmlCode,PlanText,NewsTitle,NewsBrief,NewsDetail,NewsBy;
    pc_datahandler eh = new pc_datahandler();
    public pc_onload()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    //============ ============ =================
    public string[,] viewUserLogin(TextBox tb_username, TextBox tb_password, Label lb_message)
    {
        
        moredata = eh.moreColumnStringDate("Select UserSL,UserId,Password,Status from UserInfo where UserId='" + tb_username.Text.Trim() + "'", lb_message);
        if (moredata[0, 0] != null && moredata[0, 0].Trim() != "")
        {
            if (moredata[0, 2].Equals(tb_password.Text.Trim()))
            {
                if (moredata[0, 3].Equals("1"))
                {
                    moredata[0, 4] = "1";
                }
                else
                {
                    lb_message.Text = "sorry, your Account is locked";
                    moredata[0, 4] = "0";
                }

            }
            else
            {
                lb_message.Text = "sorry, your password is NOT correct";
                moredata[0,4] = "0";
            }
        }
        else
        {
            lb_message.Text = "sorry, you are NOT our valid user";
            moredata[0,4] = "0";
        }


        return moredata;
    }
    //=========== ============== =============== ==============

    public void load_type(DropDownList dd_access, Label lb_message)
    {

        moredata = eh.moreColumnAllString("Select TypeId,Type from NewsType", lb_message);
        dd_access.Items.Clear();
        ListItem item0 = new ListItem("", "");
        dd_access.Items.Add(item0);

        for (int i = 0; i < moredata.GetLength(0); i++)
        {
            if (moredata[i, 0] == null)
            {
                break;
            }

            ListItem item1 = new ListItem(moredata[i, 1], moredata[i, 0]);

            dd_access.Items.Add(item1);

        }
    }

    //========================
    public void load_category(DropDownList dd_access, Label lb_message)
    {

        moredata = eh.moreColumnAllString("Select CategoryId,Category from NewsCategory", lb_message);
        dd_access.Items.Clear();
        ListItem item0 = new ListItem("", "");
        dd_access.Items.Add(item0);

        for (int i = 0; i < moredata.GetLength(0); i++)
        {
            if (moredata[i, 0] == null)
            {
                break;
            }

            ListItem item1 = new ListItem(moredata[i, 1], moredata[i, 0]);

            dd_access.Items.Add(item1);

        }
    }


    //======================== 
    public void load_week(DropDownList dd_access, Label lb_message)
    {

        moredata = eh.moreColumnAllString("Select WeekId,WeekName,Status from WeekDetail", lb_message);
        dd_access.Items.Clear();
        ListItem item0 = new ListItem("", "");
        dd_access.Items.Add(item0);

        for (int i = 0; i < moredata.GetLength(0); i++)
        {
            if (moredata[i, 0] == null)
            {
                break;
            }

         //   if (moredata[i, 2] == "1")
          //  {
               // conf = i;
           // }
            ListItem item1 = new ListItem(moredata[i, 1], moredata[i, 0]);

            dd_access.Items.Add(item1);

        }
    }

    //======== ==================== ==========================
    //======================== 
    public string[,] load_act_week(Label lb_message)
    {

        moredata = eh.moreColumnAllString("Select WeekId,WeekName from WeekDetail where Status=1", lb_message);
         
        return moredata;

    }
    //=== ========== ======= =============== ==================
    public void loadTableName(DropDownList dd_table, Label lb_message)
    {

        moredata = eh.moreColumnAllString("Select a.name from Sysobjects a where a.type='U'", lb_message);
        dd_table.Items.Clear();
        ListItem item0 = new ListItem("", "");
        dd_table.Items.Add(item0);

        for (int i = 0; i < moredata.GetLength(0); i++)
        {
            if (moredata[i, 0] == null)
            {
                break;
            }

            ListItem item1 = new ListItem(moredata[i, 0], moredata[i, 0]);

            dd_table.Items.Add(item1);

        }
    }

    //================ ================= ==========================

    //========================
    public void load_title(DropDownList dd_category,DropDownList dd_week,DropDownList dd_access, Label lb_message)
    {

        moredata = eh.moreColumnAllString("Select a.NewsId,a.Title2 from News a where a.WeekId='"+dd_week.SelectedValue+"' and a.CategoryId='"+dd_category.SelectedValue+"'", lb_message);
        dd_access.Items.Clear();
        
        ListItem item0 = new ListItem("", "");
        dd_access.Items.Add(item0);

        for (int i = 0; i < moredata.GetLength(0); i++)
        {
            if (moredata[i, 0] == null)
            {
                break;
            }

           // HtmlCode = HttpUtility.HtmlDecode(moredata[i, 1]);
         //   PlanText = Regex.Replace(HtmlCode,"<.*?>",String.Empty);
            ListItem item1 = new ListItem(moredata[i, 1], moredata[i, 0]);

            dd_access.Items.Add(item1);

        }
    }


    //======= ========== ================ ========================

    public string[,] load_news(DropDownList dd_softtitle,DropDownList dd_newsStatus,DropDownList dd_viewStatus, Label lb_message)
    {
        moredata = eh.moreColumnAllString("Select a.NewsTitle,a.NewsBrief,a.NewsDetail,a.NewsBy,a.NewsStatus,a.ViewStatus from News a where a.NewsId='"+dd_softtitle.SelectedValue+"'", lb_message);

        NewsTitle =HttpUtility.HtmlDecode(moredata[0, 0]);
        NewsBrief = HttpUtility.HtmlDecode(moredata[0, 1]);
        NewsDetail = HttpUtility.HtmlDecode(moredata[0, 2]);
        NewsBy = HttpUtility.HtmlDecode(moredata[0, 3]);

        moredata[0, 0] = NewsTitle;
        moredata[0, 1] = NewsBrief;
        moredata[0, 2] = NewsDetail;
        moredata[0, 3] = NewsBy;

        if (moredata[0, 3] == "1")
        {
           // dd_newsStatus.Items.FindByValue("1").Selected = true;
            //dd_newsStatus.SelectedItem.Value = "1";
            dd_newsStatus.SelectedItem.Text = "Hot";
            dd_newsStatus.SelectedItem.Value = "1";
        }
        else
        {
            //dd_newsStatus.Items.FindByValue("2").Selected = true;
           // dd_newsStatus.Items.FindByValue("2");
           // dd_newsStatus.SelectedItem.Value = "2";
            dd_newsStatus.SelectedItem.Text = "Normal";
            dd_newsStatus.SelectedItem.Value = "2";
        }


        if (moredata[0, 4] == "1")
        {

       //     dd_viewStatus.Items.FindByValue("1").Selected = true;
           // dd_viewStatus.Items.FindByValue("1");
            dd_viewStatus.SelectedItem.Text = "Mid";
            dd_viewStatus.SelectedItem.Value = "1";
       }
       else
       {
      //      dd_viewStatus.Items.FindByValue("2").Selected = true;
            //dd_viewStatus.Items.FindByValue("2");
            dd_viewStatus.SelectedItem.Text = "Right";
            dd_viewStatus.SelectedItem.Value = "2";
       }

        return moredata;
    }


    //=========== ============ ====================== ============

}