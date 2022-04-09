<%@ Page Title="Robert Johnson's Asp.Net Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspNetCalc2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- Robert Johnson's Calculator Web App --%>
    <%--CIT 243--%>

    <main class="center">
        <div class="container">
            <div class="container calcWrap">
                <div class="row">
                    <asp:TextBox ID="calcDisplay" runat="server" CssClass="form-control output"></asp:TextBox>
                    <asp:Button ID="clearBtn" runat="server" Text="C" class="btn btn-danger" OnClick="ClearBtn_Click" />
                </div>

                <div class="row">
                    <asp:Button ID="oneBtn" runat="server" Text="1" class="btn btn-default " OnClick="OneBtn_Click" />
                    <asp:Button ID="twoBtn" runat="server" Text="2" class="btn btn-default " OnClick="TwoBtn_Click" />
                    <asp:Button ID="threeBtn" runat="server" Text="3" class="btn btn-default " OnClick="ThreeBtn_Click" />
                    <asp:Button ID="plusBtn" runat="server" Text="+" class="btn btn-default btn-operator " OnClick="PlusBtn_Click" />
                </div>
                <div class="row">
                    <asp:Button ID="fourBtn" runat="server" Text="4" class="btn btn-default " OnClick="FourBtn_Click" />
                    <asp:Button ID="fiveBtn" runat="server" Text="5" class="btn btn-default " OnClick="FiveBtn_Click" />
                    <asp:Button ID="sixBtn" runat="server" Text="6" class="btn btn-default " OnClick="SixBtn_Click" />
                    <asp:Button ID="minusBtn" runat="server" Text="-" class="btn btn-default btn-operator " OnClick="MinusBtn_Click" />
                </div>
                <div class="row">
                    <asp:Button ID="sevenBtn" runat="server" Text="7" class="btn btn-default " OnClick="SevenBtn_Click" />
                    <asp:Button ID="eightBtn" runat="server" Text="8" class="btn btn-default " OnClick="EightBtn_Click" />
                    <asp:Button ID="nineBtn" runat="server" Text="9" class="btn btn-default " OnClick="NineBtn_Click" />
                    <asp:Button ID="timesBtn" runat="server" Text="x" class="btn btn-default btn-operator " OnClick="TimesBtn_Click" />
                </div>
                <div class="row">
                    <asp:Button ID="zeroBtn" runat="server" Text="0" class="btn btn-default " OnClick="ZeroBtn_Click" />
                    <asp:Button ID="dotBtn" runat="server" Text="." class="btn btn-default" OnClick="DotBtn_Click" />
                    <asp:Button ID="eqBtn" runat="server" Text="=" class="btn btn-default btn-operator " OnClick="EqBtn_Click" />
                    <asp:Button ID="divideBtn" runat="server" Text="/" class="btn btn-default btn-operator " OnClick="DivideBtn_Click" />
                </div>
            </div>
        </div>
        <asp:Label ID="errorAlert" runat="server" Text=""></asp:Label>
    </main>

</asp:Content>
