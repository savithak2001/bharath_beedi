﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 23px;
        }
        .style2
        {
            width: 269px;
        }
        .style3
        {
            height: 23px;
            width: 269px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;">
        <tr>
            <td class="style2">
                Passbook Id</td>
            <td>
                <asp:TextBox ID="txtpassbook" runat="server" 
                    ontextchanged="txtpassbook_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtpassbook" ErrorMessage="Passbook Id is compulsory" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Name</td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtname" ErrorMessage="Only characters" ForeColor="Red" 
                    ValidationExpression="[a-z/sA-Z]*"></asp:RegularExpressionValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Date Of Birth</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="txtdate_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txtdate" Format="yyyy-MM-dd">
                </asp:CalendarExtender>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Gender</td>
            <td class="style1">
                <asp:RadioButton ID="rdbmale" runat="server" Text="Male" />
                <asp:RadioButton ID="rdbfemale" runat="server" Text="Female" />
            </td>
            <td class="style1">
            </td>
        </tr>
        <tr>
            <td class="style3">
                Address</td>
            <td class="style1">
                <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine" 
                    MaxLength="450"></asp:TextBox>
            </td>
            <td class="style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Phone</td>
            <td>
                <asp:TextBox ID="txtphone" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtphone" ErrorMessage="Only numbers" ForeColor="Red" 
                    ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Password</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" MaxLength="12"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Password must be within 12 characters" ForeColor="Red" 
                    ControlToValidate="txtpassword"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" onclick="btnsubmit_Click" 
                    Text="Submit" />
                    <asp:Button ID="btnclear" runat="server" onclick="btnclear_Click" 
                    Text="Clear" CausesValidation="False" />
                <asp:Button ID="btndelete" runat="server" Text="Delete" 
                    CausesValidation="False" onclick="btndelete_Click" />
                <asp:Button ID="btnupdate" runat="server" Text="Update" 
                    CausesValidation="False" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
            </td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" GridLines="Vertical" style="margin-left: 52px" Width="409px">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkmail" runat="server" 
                                    CommandArgument='<%# Eval("[employee_id]") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblId" runat="server" Text='<%#Eval("[employee_id]") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    <%--<asp:TemplateField>
                    
                    <ItemTemplate>

                            <asp:Label ID="lblfrmid" runat="server" Text='<%#Eval("[From_id]") %>' Visible="True"></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>--%>


                        <asp:BoundField DataField="passbook_id" HeaderText="Passbook Id" />
                        <asp:BoundField DataField="name" HeaderText="Name" />
                         <asp:BoundField DataField="date_of_birth" HeaderText="Date Of Birth" />
                        <asp:BoundField DataField="gender" HeaderText="Gender" />
                         <asp:BoundField DataField="address" HeaderText="Address" />
                        <asp:BoundField DataField="phone" HeaderText="Phone" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

