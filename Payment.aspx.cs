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
        String str = "insert into payment(passbook_id,from_date,to-date,total_beedi_count,amount)values('" + txtpassbook.Text + "','" + txtfrom.Text + "','" + txtto.Text + "','" + txttotal.Text + "','" + txtamount.Text + "')";
        dl.DmlCmd(str);
    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtpassbook.Text = "";
        txtfrom.Text = "";
        txtto.Text = "";
        txttotal.Text = "";
        txtamount.Text = "";
    }
}