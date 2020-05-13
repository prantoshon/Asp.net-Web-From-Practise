<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Serach.aspx.cs" Inherits="Registration.Serach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .form-control-borderless {
    border: none;
}

.form-control-borderless:hover, .form-control-borderless:active, .form-control-borderless:focus {
    border: none;
    outline: none;
    box-shadow: none;
}


    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        
<div class="container">
    <br/>
	<div class="row justify-content-center">
                        <div class="col-12 col-md-10 col-lg-8">
                          <%--  <form class="card card-sm">--%>
                                <div class="card-body row no-gutters align-items-center">
                                    <div class="col-auto">
                                        <i class="fas fa-search h4 text-body"></i>
                                    </div>
                                    <!--end of col-->
                                    <div class="col">
                                      <asp:TextBox ID="TextBox1" placeholder="Search  By Department Name " class="form-control form-control-lg form-control-borderless" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                                    </div>
                                    <!--end of col-->
                                    <div class="col-auto">
                                    <%--   <asp:Button ID="Button1" class="btn btn-lg btn-success" runat="server" Text="Button" OnClick="Button1_Click" />--%>
                                    </div>
                                    <!--end of col-->
                                </div>
                           <%-- </form>--%>
                        </div>
                        <!--end of col-->
                    </div>
</div>
    </div>

        <asp:Panel ID="Panel1" runat="server">
            <!-- Search form -->

            <center>
            <div style="width:650px; height: 450px; overflow: scroll">
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">

                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />

            </asp:GridView>

                </div>
                </center>
        </asp:Panel>
    </form>
</body>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</html>
