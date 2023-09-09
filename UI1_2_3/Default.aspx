<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI1_2_3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Temperature Conversion Application</h1>
        </section>

        <br />
        <br />

        <div>
            <p>Enter temperature in Celsius: <asp:TextBox ID="celsius" runat="server" Width="277px"></asp:TextBox> 
            <asp:Button ID="SubmitCelsius" runat="server" Text="Celsius to Fahrenheit" OnClick="btnSubmit_CelsuiusToFahrenheit_Click"/> </p>
            <p>Output temperature in Fahrenheit: <asp:TextBox ID="TextBox1" runat="server" Width="277px"></asp:TextBox></p>
            
            <br>
            <br />
            
            <p>Enter temperature in Fahrenheit: <asp:TextBox ID="fahrenheit" runat="server" Width="274px"></asp:TextBox>
            <asp:Button ID="SubmitFahrenheit" runat="server" Text="Fahrenheit to Celsius" OnClick="btnSubmit_FahrenheitToCelsius_Click"/> </p>
            <p>Output temperature in Celsius: <asp:TextBox ID="TextBox2" runat="server" Width="277px"></asp:TextBox></p>
            
        </div>

        <br />
        <br />

        <div>
            <p>Enter Inpute string of numbers: <asp:TextBox ID="inputstring" runat="server" Width="277px"></asp:TextBox>
            <asp:Button ID="sortnumbers" runat="server" Text="Sort Numbers" OnClick="btnSubmit_SortNumbers_Click"/></p>
            <p>Output sorted string of numbers: <asp:TextBox ID="outputstring" runat="server" Width="277px"></asp:TextBox></p>
            
        </div>
    </main>

</asp:Content>
