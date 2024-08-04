<%@ Page Title="Home Page" Language="C#" Async="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormTest._Default" %>

<asp:Content ID="hdCnt" ContentPlaceHolderID="HeadContent" runat="server">
    <include src="~/CssX.html"></include>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>
        <asp:ListBox runat="server" ID="lst" />
        <div class="row">
            <section class="col-md-12" aria-labelledby="gettingStartedTitle">
                <div dir="rtl">
                    <asp:GridView ID="gvEmployee" runat="server" EmptyDataText="No Records Found" AutoGenerateColumns="false" OnRowDataBound="gvEmployee_RowDataBound" CssClass="table">
                        <Columns>
                            <asp:HyperLinkField HeaderText="شناسه کارمندی" DataNavigateUrlFields="EmpID,EmpName,EmpAge"
                                DataNavigateUrlFormatString="NewForm.aspx?EmpID={0}&EmpName={1}&EmpAge={2}"
                                DataTextField="EmpID" Target="_blank" />
                            <asp:HyperLinkField HeaderText="نام کارمند" DataNavigateUrlFields="EmpID,EmpName,EmpAge"
                                DataNavigateUrlFormatString="NewForm.aspx?EmpID={0}&EmpName={1}&EmpAge={2}"
                                DataTextField="EmpName" Target="_blank" />
                            <asp:HyperLinkField HeaderText="سن" DataNavigateUrlFields="EmpID,EmpName,EmpAge"
                                DataNavigateUrlFormatString="NewForm.aspx?EmpID={0}&EmpName={1}&EmpAge={2}"
                                DataTextField="EmpAge" Target="_blank" />
                        </Columns>
                    </asp:GridView>
                </div>
                <asp:Button runat="server" ID="btnTest" Text="click me!" OnClick="btntest_Click" />
                <asp:GridView ID="GridView1" runat="server" EmptyDataText="No Records Found" AutoGenerateColumns="true" CssClass="table">
                </asp:GridView>
            </section>
        </div>
    </main>

</asp:Content>
