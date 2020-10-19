using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pc_month_info
/// </summary>
public class pc_month_info
{

    int [] BmonthInfo = new int [12];
    int [] AmonthInfo = new int[12];

    int sMonDayRemain;
	public pc_month_info()
	{
		//
		// TODO: Add constructor logic here
		//

        BmonthInfo[0] = 30;
        BmonthInfo[1] = 31;
        BmonthInfo[2] = 30;
        BmonthInfo[3] = 29;
        BmonthInfo[4] = 30;
        BmonthInfo[5] = 31;
        BmonthInfo[6] = 30;
        BmonthInfo[7] = 30;
        BmonthInfo[8] = 31;
        BmonthInfo[9] = 30;
        BmonthInfo[10] = 31;
        BmonthInfo[11] = 30;
         


	}

    //========== ======== =============
    public void BanglaMonth(int sMonth,int sDay, int NoDays)
    {
        //======== ============ ====================
        sMonDayRemain = BmonthInfo[sMonth - 1];

        //=========== =================== ============
    }

}