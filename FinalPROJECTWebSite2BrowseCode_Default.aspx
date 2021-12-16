<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
        <div style ="padding:20px">
            <table class="nav-justified">
                <tr>
                    <td colspan="4" style="font-size: xx-large; font-weight: bold; color: #000000; background-color: #339933">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Students Data </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 167px">&nbsp;</td>
                    <td style="width: 445px">&nbsp;</td>
                    <td style="width: 113px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 167px">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="ID" Width="100px"></asp:Label>
                    </td>
                    <td style="width: 445px">
                        <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button4" runat="server" BackColor="#999999" BorderColor="Black" Font-Bold="True" ForeColor="#003300" Text="Search" Width="100px" OnClick="Button4_Click" />
                    </td>
                    <td style="width: 113px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 167px">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Firstname" Width="100px"></asp:Label>
                    </td>
                    <td style="width: 445px">
                        <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="200px"></asp:TextBox>
                    </td>
                    <td style="width: 113px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 167px">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Lastname" Width="100px"></asp:Label>
                    </td>
                    <td style="width: 445px">
                        <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="200px"></asp:TextBox>
                    </td>
                    <td style="width: 113px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 167px">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="Quizscore" Width="100px"></asp:Label>
                    </td>
                    <td style="width: 445px">
                        <asp:TextBox ID="TextBox4" runat="server" Height="16px"></asp:TextBox>
                    </td>
                    <td style="width: 113px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 167px">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" Text="Remarks" Width="100px"></asp:Label>
                    </td>
                    <td style="width: 445px">
                        <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="200px"></asp:TextBox>
                    </td>
                    <td style="width: 113px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 167px">&nbsp;</td>
                    <td style="width: 445px">&nbsp;</td>
                    <td style="width: 113px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 167px">&nbsp;</td>
                    <td style="width: 445px">
                        <asp:Button ID="Button1" runat="server" BackColor="#999999" BorderColor="Black" Font-Bold="True" ForeColor="#003300" Text="Insert" Width="100px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" BackColor="#999999" BorderColor="Black" Font-Bold="True" ForeColor="#003300" Text="Update" Width="100px" OnClick="Button2_Click" OnClientClick ="return confirm('Are you sure to Update?');"/>
&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" BackColor="#999999" BorderColor="Black" Font-Bold="True" ForeColor="#003300" Text="Delete" Width="100px" OnClick="Button3_Click" OnClientClick ="return confirm ('Are you sure to delete?');" />
                    </td>
                    <td style="width: 113px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="GridView1" runat="server" ForeColor="#003300" Width="785px">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
    </div>
</asp:Content>
