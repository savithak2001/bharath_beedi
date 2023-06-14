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
        String str = "select details_id,passbook_id,agent_id,date,beedi_counts,sets from beedi_details";
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


    public void filldropdownn()
    {
        String str = "select agent_id,name from agent";
        DataSet ds = new DataSet();
        DataLayer dl = new DataLayer();
        ds = dl.GetDataSet(str);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlagentname.DataSource = ds;
            ddlagentname.DataTextField = "name";
            ddlagentname.DataValueField = "agent_id";
            ddlagentname.DataBind();
            ddlagentname.Items.Insert(0, "-- Select Agent");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();
            filldropdownn();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        DataLayer dl = new DataLayer();
        String str = "insert into beedi_details(passbook_id,agent_id,date,beedi_counts,sets)values('" + txtpassbook.Text + "','" + ddlagentname.SelectedItem.Value   + "','" + txtdate.Text + "','" + txtbeedi.Text + "','" + txtsets.Text + "')";
        dl.DmlCmd(str);
        fillgrid();
    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtpassbook.Text = "";
        ddlagentname.SelectedIndex = 0;
        txtdate.Text = "";
        txtbeedi.Text = "";
        txtsets.Text = "";
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
                qstr = "delete from beedi_details where details_id ='" + lbl.Text + "'";
                DataLayer dl = new DataLayer();
                dl.DmlCmd(qstr);
            }
        }
        fillgrid();
    }
}