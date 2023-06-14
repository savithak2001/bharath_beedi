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
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        DataLayer dl = new DataLayer();
        String str = "insert into registration(phone,password,user_type)values('" + txtphone.Text + "','" + txtpassword.Text + "','" + txtuser.Text + "')";
        dl.DmlCmd(str);
    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtphone.Text = "";
        txtpassword.Text = "";
        txtuser.Text = "";
    }
}