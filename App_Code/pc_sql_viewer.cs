using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for pc_sql_viewer
/// </summary>
public class pc_sql_viewer
{
    string tBody, TotalBody, tclass;
    string[] spHead = new string[25];
    string[,] spBody = new string[1000, 25];
    int ProjectId,rCounter;
    pc_datahandler dhandler = new pc_datahandler();
   // bfl_grid_view gview = new bfl_grid_view();

	public pc_sql_viewer()
	{
		//
		// TODO: Add constructor logic here
		//
	}



    public string viewTable(string[] head, string[,] body)
    {
        tBody = "<table id='table1'>";
        tBody += "<tr><th> SL </th>";
        rCounter = 0;
        for (int i = 0; i <100; i++)
        {
            if (head[i] == null || head[i] == "" || head[i]==" ")
            {
                break;
            }
            rCounter++;
            tBody += "<th>" + head[i] + "</th>";
            
        }

        tBody += " </tr>";

        for (int j = 0; j < body.GetLength(0); j++)
        {
            if (body[j, 0] == null)
            {
                break;
            }
            tclass = "odd";
            if (j % 2 == 0)
            {
                tclass = "odd";
            }
            else
            {
                tclass = "even";
            }

            tBody += "<tr class='" + tclass + "'><td>" + (j + 1) + "</td>";
            for (int k = 0; k < rCounter; k++)
            {
                
                    tBody += "<td>" + body[j, k] + "</td>";
                
            }
            tBody += "</tr>";
        }
        tBody += "</table>";

        return tBody;
    }

    //================= ==================== ========
    public string viewTable2(string[] head, string[,] body,int column)
    {
        tBody = "<table id='table1'>";
        tBody += "<tr><th> SL </th>";
        rCounter = 0;
        for (int i = 0; i < column; i++)
        {
            if (head[i] == null || head[i] == "" || head[i] == " ")
            {
                break;
            }
            rCounter++;
            tBody += "<th>" + head[i] + "</th>";

        }

        tBody += " </tr>";

        for (int j = 0; j < body.GetLength(0); j++)
        {
            if (body[j, 0] == null)
            {
                break;
            }
            tclass = "odd";
            if (j % 2 == 0)
            {
                tclass = "odd";
            }
            else
            {
                tclass = "even";
            }

            tBody += "<tr class='" + tclass + "'><td>" + (j + 1) + "</td>";
            for (int k = 0; k < column; k++)
            {

                tBody += "<td>" + body[j, k] + "</td>";

            }
            tBody += "</tr>";
        }
        tBody += "</table>";

        return tBody;
    }

    //============== =========== ==========
   //======== ========== =================
    public void view_sqlTable(Table tbl_view,string SQL, Label lb_message)
    {
        spHead = dhandler.AllColumnName(SQL, lb_message); 
        spBody = dhandler.moreColumnAllString(SQL, lb_message);
        TotalBody = viewTable(spHead, spBody );
        //==== ======== ======== =======
        TableCell tcell = new TableCell();
        tcell.Text = TotalBody;
        TableRow trow = new TableRow();
        trow.Cells.Add(tcell);
        tbl_view.Rows.Add(trow);

    }
   //============= =========================

    public void view_sqlTableDef(Table tbl_view, string TabName, Label lb_message)
    {
        spHead = new string[] { "Table Name", "Column Name" , "Data Type" };
        spBody = dhandler.moreColumnAllString("Select table_name,column_name,data_type from INFORMATION_SCHEMA.Columns where TABLE_NAME='" + TabName + "'", lb_message);
        TotalBody = viewTable2(spHead, spBody,3);
        //==== ======== ======== =======
        TableCell tcell = new TableCell();
        tcell.Text = TotalBody;
        TableRow trow = new TableRow();
        trow.Cells.Add(tcell);
        tbl_view.Rows.Add(trow);

    }

  //==========================================


}