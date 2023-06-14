using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    public void fillgrid()
    {
        String str = "select price_id,passbook_id,beedi_counts,price from price_setting";
        DataSet ds = new DataSet();
        DataLayer dl = new DataLayer();
        ds = dl.GetDataSet(str);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataMember = "table";
            GridView1.DataBind();
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();
        }
    }    
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        DataLayer dl = new DataLayer();
        String str = "insert into price_setting(passbook_id,beedi_counts,price)values('" + txtpassbook.Text + "','" + txtbeedi.Text + "','" + txtprice.Text + "')";
        dl.DmlCmd(str);
        fillgrid();
    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtpassbook.Text = "";
        txtbeedi.Text = "";
        txtprice.Text = "";
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox chk = (CheckBox)GridView1.Rows[i].FindControl("chkmail");

            if (chk.Checked)
            {
                Label lbl = (Label)GridView1.Rows[i].FindControl("lblId");

                string qstr;
                qstr = "delete from price_setting where price_id ='" + lbl.Text + "'";
                DataLayer dl = new DataLayer();
                dl.DmlCmd(qstr);
            }
        }
        fillgrid();
    }
}