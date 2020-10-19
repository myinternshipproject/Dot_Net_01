using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for pc_data_valid
/// </summary>
public class pc_data_valid
{
    int conf;
    int[] sdata = new int[31];
    string[] var1 = new string[10];
    string[] var2 = new string[10];
    Random ran = new Random();
    string variData,HtmlCode;

	public pc_data_valid()
	{
		//
		// TODO: Add constructor logic here
		//

        //==========================
        var1[0] = "wsx";
        var1[1] = "qaz";
        var1[2] = "edc";
        var1[3] = "rfv";
        var1[4] = "tgb";
        var1[5] = "yhn";
        var1[6] = "ujm";
        var1[7] = "ikq";
        var1[8] = "olw";
        var1[9] = "asd";

        //===== ============= ================

        var2[0] = "12x";
        var2[1] = "23z";
        var2[2] = "34c";
        var2[3] = "45v";
        var2[4] = "56b";
        var2[5] = "67n";
        var2[6] = "78m";
        var2[7] = "89q";
        var2[8] = "90w";
        var2[9] = "01d";



        //=======================================



	}

    //=========== ====================== ====================
    public int checkEmpty(params string[] mydata)
    {

        conf = 1;
        for (int i = 0; i < mydata.GetLength(0); i++)
        {
            if (mydata[i].Trim() == "")
            {
                conf = 0;
                break;
            }
        }
        return conf;
    }

    //======== ========= ========= ========

    public int[] dataDropCheck(string[] mdata)
    {

        for (int i = 0; i < 30; i++)
        {
            if (mdata[i] == "" || mdata[i] == null)
            {
                sdata[i] = 0;
            }
            else
            {
                sdata[i] = Convert.ToInt32(mdata[i]);
            }
        }
        return sdata;
    }

    //======== =========== ========= ======

    public int checkPhone(string phoneNumber)
    {
        conf = 0;

        if (phoneNumber.Length == 11)
        {
            if (phoneNumber.Substring(0, 2).Contains("01"))
            {
                conf = 1;
            }
            else
            {
                conf = 0;
            }
        }
        else
        {
            conf = 0;
        }
        return conf;
    }

    //========= ========== ========== ======== ========

    public int checkEmail(string email)
    {
        conf = 0;

        if (email.Contains("@") && email.Contains("."))
        {
            conf = 1;
        }
        else
        {
            conf = 0;
        }

        return conf;
    }

    //========= ========= ========== ========== =======

    public int passCheck(string password, string repassword)
    {
        conf = 0;
        if (password.Trim().Equals(repassword.Trim()))
        {
            conf = 1;
        }

        return conf;
    }

    //====== ============ ============= ===================

    public int passLen(string password)
    {
        conf = 0;
        if (password.Length > 5)
        {
            conf = 1;
        }

        return conf;
    }

    //============ ============ ============ ==============

    public string varicode()
    {
        variData = var1[ran.Next(0, 9)] + var2[ran.Next(0, 9)] + ran.Next(1000000, 9999999);

        return variData;

    }

    //========= =========== ===============

    public string repData(string gdata)
    {
        variData = gdata.Replace("'", "''");

        return variData;
    }


    //======================== =============================
    public string repHtml(string gdata)
    {
        HtmlCode = HttpUtility.HtmlDecode(gdata);
        variData = Regex.Replace("<.?>", HtmlCode, String.Empty);
        
        return variData;
    }


    //========== ============== =======================

}