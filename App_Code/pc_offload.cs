using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


/// <summary>
/// Summary description for pc_offload
/// </summary>
public class pc_offload
{
	public pc_offload()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void load_Monthtype(DropDownList dd_access)
    {

       
        dd_access.Items.Clear();
        ListItem item0 = new ListItem("", "");
        dd_access.Items.Add(item0);

        

            ListItem item1 = new ListItem("English", "1");
            dd_access.Items.Add(item1);
            ListItem item2 = new ListItem("Bangla", "2");
            dd_access.Items.Add(item2);
            ListItem item3 = new ListItem("Arabic", "3");
            dd_access.Items.Add(item3);

        
    }

    //========= ============ ========= ==========
    //============== ============ ================
    public void load_newStatus(DropDownList dd_access)
    {


        dd_access.Items.Clear();
        ListItem item0 = new ListItem("", "");
        dd_access.Items.Add(item0);



        ListItem item1 = new ListItem("Hot", "1");
        dd_access.Items.Add(item1);
        ListItem item2 = new ListItem("Normal", "2");
        dd_access.Items.Add(item2);
       

    }

    //============== ============ ================
    public void load_viewStatus(DropDownList dd_access)
    {


        dd_access.Items.Clear();
        ListItem item0 = new ListItem("", "");
        dd_access.Items.Add(item0);



        ListItem item1 = new ListItem("Mid", "1");
        dd_access.Items.Add(item1);
        ListItem item2 = new ListItem("Right", "2");
        dd_access.Items.Add(item2);


    }


    //============ ============= ===================
    //====== =========== ============= =============



}