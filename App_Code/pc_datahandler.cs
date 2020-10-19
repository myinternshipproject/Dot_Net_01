using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


/// <summary>
/// Summary description for pc_datahandler
/// </summary>
public class pc_datahandler
{
    // public string conString = "Data Source=192.168.3.162;Initial Catalog=EcotechEcNew;User Id=ecoit;Password=ecodbo";
    public string conString = "Data Source=sv38.dbsqlserver.com,8888;Initial Catalog=ProtidinerChitro;User Id=pro_eco;Password=pro#eco@555";
    // public string conString = "Data Source=sv38.dbsqlserver.com,8888;Initial Catalog=EcotechECnew;User Id=newEC;Password=new#EC@555";
    public SqlConnection sqlcon;
    public SqlCommand scomd;
    public SqlDataReader reader;

    int adataInt, validData, rowCounter, conf, picConf;
    double adataDouble;
    DateTime adataDate;


    string adataString;

	public pc_datahandler()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int dataChecker(string sql)
    {
        validData = 0;
        try
        {
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            if (reader.HasRows)
            {
                validData = 1;
            }
            else
            {
                validData = 0;
            }
            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            validData = 0;
        }
        catch (Exception ew)
        {
            validData = 0;
        }
        return validData;

    }

    //========= =========== ======== ==================== ==================
    //============ ============== String Loader ============== =============

    public string stringLoader(string sql, Label lb_message)
    {
        adataString = "";
        try
        {
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            if (reader.Read())
            {
                adataString = Convert.ToString(reader.GetValue(0));
            }

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.Text = sqlex1.Message;

        }
        catch (Exception ew)
        {
            lb_message.Text = ew.Message;

        }
        return adataString;

    }

    //========= =========== ======== ==================== ==================
    //============ ============== Int Loader ============== ===========

    public int intLoader(string sql, Label lb_message)
    {
        adataInt = 0;
        try
        {
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    adataInt = Convert.ToInt32(reader.GetValue(0));
                }
                else
                {
                    adataInt = 0;
                }
            }

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.Text = sqlex1.Message;
            adataInt = 0;

        }
        catch (Exception ew)
        {
            lb_message.Text = ew.Message;
            adataInt = 0;

        }

        return adataInt;

    }

    //========= =========== ======== ==================== ==================
    //============ ============== Int Loader ============== ===========

    public double doubleLoader(string sql, Label lb_message)
    {
        adataDouble = 0;
        try
        {
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            if (reader.Read())
            {
                adataDouble = Convert.ToDouble(reader.GetValue(0));
            }

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.Text = sqlex1.Message;

        }
        catch (Exception ew)
        {
            lb_message.Text = ew.Message;

        }
        return adataDouble;

    }

    //========= =========== ======== ==================== ==================
    //============ ============== Int Loader ============== ===========

    public DateTime dateLoader(string sql, Label lb_message)
    {
        adataDate = new DateTime(1, 1, 1900);
        try
        {
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            if (reader.Read())
            {
                adataDate = Convert.ToDateTime(reader.GetValue(0));
            }

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.Text = sqlex1.Message;

        }
        catch (Exception ew)
        {
            lb_message.Text = ew.Message;

        }
        return adataDate;

    }

    //======= =========== ============= ============= ===============
    // ======== ========== ============ ======== ======== ===========

    public int dataSend(string sql, Label l1)
    {
        try
        {
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            conf = scomd.ExecuteNonQuery();
            if (conf >= 1)
            {
                if (l1.ForeColor == Color.Green)
                {
                    l1.ForeColor = Color.Blue;
                }
                else
                {
                    l1.ForeColor = Color.Green;
                }

                l1.Text = "Command Execute Successfully";

            }
            else
            {
                l1.ForeColor = Color.Red;
                l1.Text = "Data Error";
            }
            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            if (sqlex1.Number == 2627)
            {
                l1.ForeColor = Color.Red;
                l1.Text = "This Data Already Exists. " + sqlex1.Message;
                conf = 0;
            }
            else
            {
                l1.ForeColor = Color.Red;
                l1.Text = "Data Base Connection Problem. " + sqlex1.Message;
                conf = 0;
            }
        }
        catch (Exception ew)
        {
            l1.ForeColor = Color.Red;
            l1.Text = "Connection Error. " + ew.Message;
            conf = 0;
        }

        return conf;
    }

    //========================= ======= ========= ====== =========
    //=========== =========== =========== ============ ==========

    //========== ========== ===================
    public string[,] moreColumnAllString(string sql, Label lb_message)
    {
        string[,] moreColumn = new string[5000, 100];
        try
        {

            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            rowCounter = 0;
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    for (int p = 0; p < reader.FieldCount; p++)
                    {
                        if (!reader.IsDBNull(p))
                        {
                            if (reader.GetDataTypeName(p).Equals("date"))
                            {
                                moreColumn[rowCounter, p] = Convert.ToDateTime(reader.GetValue(p)).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                moreColumn[rowCounter, p] = Convert.ToString(reader.GetValue(p));
                            }
                        }
                        else
                        {
                            moreColumn[rowCounter, p] = " ";
                        }
                    }
                }
                else
                {
                    moreColumn[rowCounter, 0] = " ";
                }
                rowCounter++;
            }

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = "Data Base Connection Problem :" + sqlex1.Message;
        }
        catch (Exception ew)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = " Server Connection Error : " + ew.Message;
        }

        return moreColumn;
    }

    //========== ========== ===================
    public string[,] moreColumnStringDate(string sql, Label lb_message)
    {
        string[,] moreColumn = new string[5000, 100];
        try
        {

            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            rowCounter = 0;
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    for (int p = 0; p < reader.FieldCount; p++)
                    {
                        if (!reader.IsDBNull(p))
                        {
                            if (reader.GetDataTypeName(p).Equals("date"))
                            {
                                moreColumn[rowCounter, p] = Convert.ToDateTime(reader.GetValue(p)).ToString("MM/dd/yyyy");
                            }
                            else
                            {
                                moreColumn[rowCounter, p] = Convert.ToString(reader.GetValue(p));
                            }
                        }
                        else
                        {
                            moreColumn[rowCounter, p] = " ";
                        }
                    }
                }
                else
                {
                    moreColumn[rowCounter, 0] = " ";
                }
                rowCounter++;
            }

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = "Data Base Connection Problem :" + sqlex1.Message;
        }
        catch (Exception ew)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = " Server Connection Error : " + ew.Message;
        }

        return moreColumn;
    }

    //======== ========== ========= ======= ========== ========= ===========
    //======== ========== ========= ========= ============ ====== ==========

    public string[] oneColumnAllString(string sql, Label lb_message)
    {
        string[] oneColumn = new string[5000];
        try
        {
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            rowCounter = 0;

            while (reader.Read())
            {

                if (!reader.IsDBNull(0))
                {
                    if (reader.GetDataTypeName(0).Equals("date"))
                    {
                        oneColumn[rowCounter] = Convert.ToDateTime(reader.GetValue(0)).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        oneColumn[rowCounter] = Convert.ToString(reader.GetValue(0));
                    }

                }
                else
                {
                    oneColumn[rowCounter] = " ";
                }
                rowCounter++;
            }

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = "Data Base Connection Problem :" + sqlex1.Message;
        }
        catch (Exception ew)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = " Server Connection Error : " + ew.Message;
        }

        return oneColumn;
    }



    //========= ============ ========== =========== ========= ========
    //======= ======== ===== ========= ========= ====== ==============

    public string[] oneColumnStringDate(string sql, Label lb_message)
    {
        string[] oneColumn = new string[5000];
        try
        {
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            rowCounter = 0;

            while (reader.Read())
            {

                if (!reader.IsDBNull(0))
                {
                    if (reader.GetDataTypeName(0).Equals("date"))
                    {
                        oneColumn[rowCounter] = Convert.ToDateTime(reader.GetValue(0)).ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        oneColumn[rowCounter] = Convert.ToString(reader.GetValue(0));
                    }

                }
                else
                {
                    oneColumn[rowCounter] = " ";
                }
                rowCounter++;
            }

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = "Data Base Connection Problem :" + sqlex1.Message;
        }
        catch (Exception ew)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = " Server Connection Error : " + ew.Message;
        }

        return oneColumn;
    }

    //======== ========== ========== ========== =========== =========
    //========= ========== ========== ========== ========= ==========

    public int picSend(FileUpload fupload, string filePath, string fileName)
    {
        picConf = 0;
        try
        {
            string fullUploadPath = Path.Combine(filePath, fileName);
            fupload.PostedFile.SaveAs(fullUploadPath);
            picConf = 1;
        }
        catch (Exception ew)
        {
            picConf = 0;
        }
        return picConf;
    }

    //========== ============ ============= ============ =============
    //======================= ========================== =============

    //========== ========== ===================
    public string[] AllColumnName (string sql, Label lb_message)
    {
        string[] mColumn = new string[100];
        try
        {

            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            scomd = new SqlCommand(sql, sqlcon);
            reader = scomd.ExecuteReader();
            
                    for (int p = 0; p < reader.FieldCount; p++)
                    {
                        mColumn[p] = reader.GetName(p);
                    }
                

            sqlcon.Close();
        }
        catch (SqlException sqlex1)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = "Data Base Connection Problem :" + sqlex1.Message;
        }
        catch (Exception ew)
        {
            lb_message.ForeColor = Color.Red;
            lb_message.Text = " Server Connection Error : " + ew.Message;
        }

        return mColumn;
    }



    //======================= ====================== ===================
    //============== ================= ========================= =======

}