<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Protidiner Chitro</title>
<link rel="stylesheet" type="text/css" href="css/theme.css" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
 
<!--[if IE]>
<link rel="stylesheet" type="text/css" href="css/ie-sucks.css" />
<![endif]-->

<style>
@font-face {
    font-family: suto;
    src: url(font/kalpurush.ttf);
}
</style>


</head>

<body>
	<div id="container">
    	
        <div id="header2"> <form runat="server"> <asp:DropDownList ID="dd_week" Font-Names="suto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dd_week_SelectedIndexChanged"></asp:DropDownList></form>  </div>
         <asp:Table ID="tbl_top_menu" Width="100%" runat="server"></asp:Table>




        <asp:Table ID="tbl_sub_menu" runat="server"></asp:Table>


        <div id="wrapper">
            <div id="content">


                <asp:Table ID="tbl_info" runat="server"></asp:Table>











                <asp:Label ID="lb_message" runat="server" Text=" "></asp:Label>
              
              <div id="infowrap">
              
              
              
                  
                     
              </div>
            </div>
            <div id="sidebar">
  				 
                 
                 
          </div>
      </div>
        <div id="footer">
        <div id="credits">
   		Powered by <a href="http://www.ecotechitbd.com">Ecotech IT Ltd.</a>
        </div>
        
        
        <br />

        </div>
</div>
</body>
</html>
