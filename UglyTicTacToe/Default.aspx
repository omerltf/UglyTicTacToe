<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UglyTicTacToe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/CSS/StyleSheet.css" rel="Stylesheet" type="text/css" />
    <title>Tic Tac Toe</title>
</head>
<body>
    <header>
        <h1>Welcome to my UGLY Tic Tac Toeeeee</h1>
    </header>
    <form id="form1" runat="server">
        <br />
        <asp:Label CssClass="Warning" ID="Warning" Text="Proceed at your own peril (photosensitivity warning)" runat="server" />
        <asp:Button CssClass="WarningButton" ID="WarningButton" Text="Proceed" OnClick="WarningButton_Click" runat="server" />

        <asp:Panel CssClass="ButtonPanel" ID="ButtonPanel" Visible="false" runat="server">
            <asp:Button CssClass="Button" ID="One" OnClick="Button_Click" Text=" " runat="server" CommandArgument="0,0" />
            <asp:Button CssClass="Button" ID="Two" OnClick="Button_Click" Text=" " runat="server" CommandArgument="0,1" />
            <asp:Button CssClass="Button" ID="Three" OnClick="Button_Click" Text=" " runat="server" CommandArgument="0,2" />
            <br />
            <asp:Button CssClass="Button" ID="Four" OnClick="Button_Click" Text=" " runat="server" CommandArgument="1,0" />
            <asp:Button CssClass="Button" ID="Five" OnClick="Button_Click" Text=" " runat="server" CommandArgument="1,1" />
            <asp:Button CssClass="Button" ID="Six" OnClick="Button_Click" Text=" " runat="server" CommandArgument="1,2" />
            <br />
            <asp:Button CssClass="Button" ID="Seven" OnClick="Button_Click" Text=" " runat="server" CommandArgument="2,0" />
            <asp:Button CssClass="Button" ID="Eight" OnClick="Button_Click" Text=" " runat="server" CommandArgument="2,1" />
            <asp:Button CssClass="Button" ID="Nine" OnClick="Button_Click" Text=" " runat="server" CommandArgument="2,2" />
        </asp:Panel>
        <div>
            <asp:Label CssClass="WinNotification" ID="WinNotificationX" Visible="false" Text="User X Wins" runat="server" />
            <asp:Label CssClass="WinNotification" ID="WinNotificationO" Visible="false" Text="User O Wins" runat="server" />
            <asp:Label CssClass="WinNotification" ID="TieNotification" Visible="false" Text="Game Ended in a Tie" runat="server" />
            <br />
            <br />
            <asp:Image CssClass="CssImageConfetti" ID="Confetti" ImageUrl="~\CSS\giphy.gif" Visible="false" runat="server"  />
            <asp:Image CssClass="CssImageConfetti" Height="500" Width="500" ID="TTT" ImageUrl="~\CSS\ttt.gif" Visible="false" runat="server"  />

        </div>
        <div>
            <asp:Button CssClass="NewGameButton" ID="NewGameButton" Visible="false" Text="New Game" OnClick="NewGameButton_Click" runat="server" />
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Image CssClass="CssImage" ImageUrl="~\CSS\giphy_css.gif" runat="server" />
        <asp:Image CssClass="CssImage" ImageUrl="~\CSS\upvote.gif" runat="server" />

    </form>
</body>
</html>
