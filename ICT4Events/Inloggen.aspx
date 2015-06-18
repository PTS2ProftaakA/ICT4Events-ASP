<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inloggen.aspx.cs" Inherits="ICT4Events.Inloggen" %>
<!DOCTYPE html>
<html>
    <head runat="server">
        <title>Inloggen</title>
    </head>
    <body>
        <form style="text-align: center;" id="formInlog" runat="server">
        <div>
            <span style="color: red;" id="resultMessage" runat="server"></span>
            <br/><br/>
            <input type="text" id="userInput" placeholder="Gebruikersnaam" runat="server" />
            <br/>
            <asp:RequiredFieldValidator ControlToValidate="userInput" ErrorMessage="Gebruikersnaam mag niet leeg zijn" runat="server" />
            <br/><br/>
            <input type="password" id="passInput" placeholder="Wachtwoord" runat="server" />
            <br/>
            <asp:RequiredFieldValidator ControlToValidate="passInput" ErrorMessage="Wachtwoord mag niet leeg zijn" runat="server" />
            <br/><br/>
            <input type="submit" value="Inloggen" />
        </div>
        </form>
    </body>
</html>