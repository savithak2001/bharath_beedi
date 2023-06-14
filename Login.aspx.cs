using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        DataLayer dl = new DataLayer();
        DataSet ds = new DataSet();
        string str = "Select * from registration where phone = '" + txtphone.Text + "' and password = '" + txtpassword.Text + "'";
        ds = dl.GetDataSet(str);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["phone"] = txtphone.Text;
            if (ds.Tables[0].Rows[0]["user_type"].ToString() == "Agent")
            {
                Response.Redirect("Agent.aspx");
            }
            else
            {
                Response.Redirect("Employee.aspx");
            }
          
        }
        else
        { 
            Response.Write("<script language='javascript'> alert ('invalid login') </script>");
        }
    }
}