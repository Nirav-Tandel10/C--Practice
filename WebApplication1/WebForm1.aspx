-<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title></head><body><form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 19px; top: 143px; position: absolute; height: 1px; margin-top: 0px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" style="z-index: 1; left: 629px; top: 110px; position: absolute; width: 138px; height: 29px; margin-top: 0px" />
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="empID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="empID" HeaderText="empID" InsertVisible="False" ReadOnly="True" SortExpression="empID" />
                <asp:BoundField DataField="empName" HeaderText="empName" SortExpression="empName" />
                <asp:BoundField DataField="dateOfJoining" HeaderText="dateOfJoining" SortExpression="dateOfJoining" />
                <asp:BoundField DataField="depID" HeaderText="depID" SortExpression="depID" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                <asp:BoundField DataField="workingPlace" HeaderText="workingPlace" SortExpression="workingPlace" />
                <asp:BoundField DataField="Contacts" HeaderText="Contacts" SortExpression="Contacts" />
            </Columns>
        </asp:GridView>
        <p>
            &nbsp;</p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FullStackConnectionString %>" ProviderName="<%$ ConnectionStrings:FullStackConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [FullStackEmpDetails]"></asp:SqlDataSource>
    </form>
</body>
</html>
