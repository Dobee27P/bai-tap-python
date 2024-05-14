<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherData.aspx.cs" Inherits="WeatherMonitoring.WeatherData" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weather Data</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        table {
            width: 100%;
            border-collapse: collapse;
        }
        th, td {
            padding: 8px 12px;
            border: 1px solid #ddd;
        }
        th {
            background-color: #f4f4f4;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Weather Monitoring</h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id">
                <Columns>
                    <asp:BoundField DataField="timestamp" HeaderText="Timestamp" />
                    <asp:BoundField DataField="temperature" HeaderText="Temperature" />
                    <asp:BoundField DataField="humidity" HeaderText="Humidity" />
                    <asp:BoundField DataField="pressure" HeaderText="Pressure" />
                    <asp:BoundField DataField="wind_speed" HeaderText="Wind Speed" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
