<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="DatabaseConnect.Customers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" href="TableStyles.css" type="text/css" />
    <style type="text/css">
        .style40
        {
            width: 122px;
        }
        .style43
        {
            height: 27px;
            width: 151px;
        }
        .style44
        {
            height: 29px;
            width: 151px;
        }
        .style45
        {
            width: 151px;
            height: 26px;
        }
        .style47
        {
            height: 27px;
            width: 155px;
        }
        .style48
        {
            height: 29px;
            width: 155px;
        }
        .style49
        {
            width: 155px;
            height: 26px;
        }
        .style50
        {
            height: 28px;
            width: 155px;
        }
        .style51
        {
            height: 28px;
            width: 151px;
        }
        .style52
        {
            width: 47px;
        }
        .style53
        {
            width: 92px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 58%;">
            <tr>
                <td class="style1">
                    <asp:GridView ID="gvCustomers" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
                        BorderStyle="Solid" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
                        GridLines="Vertical" Height="309px" Width="739px">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="cust_id" 
                                DataNavigateUrlFormatString="Customers.aspx?id={0}" Text="Select" />
                            <asp:BoundField DataField="cust_id" HeaderText="Cust. ID" />
                            <asp:BoundField DataField="cust_name" HeaderText="Customer Name" />
                            <asp:BoundField DataField="cust_contact" HeaderText="Customer Contact" />
                            <asp:BoundField DataField="cust_email" HeaderText="Customer Email" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    <asp:Panel ID="Panel1" runat="server" BackColor="Silver" Height="229px" 
        Width="739px">
        <table style="width:99%; height: 118px;">
            <tr>
                <td class="style43">
                    <asp:Label ID="lblCustID" runat="server" Font-Bold="True" Font-Names="calibri" 
                        Font-Size="Small" Text="Customer ID:"></asp:Label>
                </td>
                <td class="style30" colspan="2">
                    <asp:TextBox ID="tbCustID" runat="server" Width="185px"></asp:TextBox>
                </td>
                <td class="style47">
                    <asp:Label ID="lblCustContact" runat="server" Font-Bold="True" 
                        Font-Names="Calibri" Font-Size="Small" Text="Customer Contact:"></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="tbCustContact" runat="server" TabIndex="1" Width="185px" 
                        style="margin-left: 0px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td class="style44">
                    <asp:Label ID="lblCustName" runat="server" Font-Bold="True" 
                        Font-Names="calibri" Font-Size="Small" Text="Customer Name:"></asp:Label>
                </td>
                <td class="style30" colspan="2">
                    <asp:TextBox ID="tbCustName" runat="server" TabIndex="2" Width="185px"></asp:TextBox>
                </td>
                <td class="style48">
                    <asp:Label ID="lblCustEmail" runat="server" Font-Bold="True" 
                        Font-Names="Calibri" Font-Size="Small" Text="Customer Email:"></asp:Label>
                </td>
                <td class="style13">
                    <asp:TextBox ID="tbCustEmail" runat="server" TabIndex="3" Width="185px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td class="style45">
                    <asp:Label ID="lblCustAddy" runat="server" Font-Bold="True" 
                        Font-Names="Calibri" Font-Size="Small" Text="Customer Address:"></asp:Label>
                </td>
                <td class="style30" colspan="2">
                    <asp:TextBox ID="tbCustAddy" runat="server" TabIndex="4" Width="185px"></asp:TextBox>
                </td>
                <td class="style49">
                    <asp:Label ID="lblCustCity" runat="server" Font-Bold="True" 
                        Font-Names="Calibri" Font-Size="Small" Text="Customer City:"></asp:Label>
                </td>
                <td class="style24">
                    <asp:TextBox ID="tbCustCity" runat="server" TabIndex="5" Width="185px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td class="style51">
                    <asp:Label ID="lblCustState" runat="server" Font-Bold="True" 
                        Font-Names="Calibri" Font-Size="Small" Text="Customer State:"></asp:Label>
                </td>
                <td class="style30" colspan="2">
                    <asp:TextBox ID="tbCustState" runat="server" TabIndex="6" Width="185px"></asp:TextBox>
                </td>
                <td class="style50">
                    <asp:Label ID="lblCustZip" runat="server" Font-Bold="True" Font-Names="Calibri" 
                        Font-Size="Small" Text="Customer Zip:"></asp:Label>
                </td>
                <td class="style23">
                    <asp:TextBox ID="tbCustZip" runat="server" TabIndex="7" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style51">
                    <asp:Label ID="lblCustCountry" runat="server" Font-Bold="True" 
                        Font-Names="Calibri" Font-Size="Small" Text="Customer Country:"></asp:Label>
                </td>
                <td class="style30" colspan="2">
                    <asp:TextBox ID="tbCustCountry" runat="server" TabIndex="8" Width="185px"></asp:TextBox>
                </td>
                <td class="style50">
                    &nbsp;</td>
                <td class="style23">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style51">
                    <asp:Button ID="btnCreate" runat="server" Font-Names="Calibri" 
                        onclick="btnCreate_Click" TabIndex="9" Text="Create" Width="77px" />
                </td>
                <td class="style53">
                    <asp:Button ID="btnUpdate" runat="server" Font-Names="Calibri" 
                        onclick="btnUpdate_Click" style="margin-left: 0px" TabIndex="11" Text="Update" 
                        Width="77px" />
                </td>
                <td class="style40">
                    &nbsp;</td>
                <td class="style50">
                    &nbsp;<asp:Button ID="btnDelete" runat="server" Font-Names="Calibri" 
                        onclick="btnDelete_Click" style="margin-left: 0px" TabIndex="12" Text="Delete" 
                        Width="77px" />
                </td>
                <td class="style23">
                    <asp:Button ID="btnClear" runat="server" Font-Names="Calibri" 
                        onclick="btnClear_Click" style="margin-left: 0px" Text="Clear Fields" 
                        Width="77px" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    </form>
</body>
</html>
