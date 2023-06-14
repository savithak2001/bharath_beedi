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
        String str = "select agent_id,name,date_of_birth,gender,address,phone from agent";
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
        String gender = null;
        if (rdbmale.Checked == true)
        {
            gender = "Male";
        }
        if (rdbfemale.Checked == true)
        {
            gender = "Female";
        }
        String str = "insert into agent(name,date_of_birth,gender,address,phone,password)values('" + txtname.Text + "','" + txtdate.Text + "','" + gender + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtpassword.Text + "')";
        dl.DmlCmd(str);


        String str1 = "insert into registration( phone, password, user_type)values('"+ txtphone.Text +"','"+ txtpassword.Text +"','Agent')";
        dl.DmlCmd(str1);
        fillgrid();
    }
    protected void btnclear_Click1(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtdate.Text = "";
        txtaddress.Text = "";
        txtphone.Text = "";
        txtpassword.Text = "";
        rdbmale.Checked = false;
        rdbfemale.Checked = false;
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
                qstr = "delete from agent where agent_id ='" + lbl.Text + "'";
                DataLayer dl = new DataLayer();
                dl.DmlCmd(qstr);
            }
           
        }
        fillgrid();
    }
}