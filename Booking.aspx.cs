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
        String str = "insert into booking(passbook_id,date,leaf_requested,tobacco_requested,thread_requested,status,leaff_provided,tobaccoo_provided,threadd_provided)values('" + txtpassbook.Text + "','" + txtdate.Text + "','" + txtleaf.Text + "','" + txttobacco.Text + "','" + txtthread.Text + "','" + txtstatus.Text + "','" + txtleaff.Text + "','" + txttobacco.Text + "','" + txtthreadd.Text + "')";
        dl.DmlCmd(str);
    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtpassbook.Text = "";
        txtdate.Text = "";
        txtleaf.Text = "";
        txttobacco.Text = "";
        txtthread.Text = "";
        txtstatus.Text = "";
        txtleaff.Text = "";
        txttobaccoo.Text = "";
        txtthreadd.Text = "";
    }
}