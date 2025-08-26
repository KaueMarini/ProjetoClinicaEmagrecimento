<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PrjCalculadoraWeb.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="border:solid">
            <tr>
                <td colspan="4" style="text-align:center" width ="800px";>
                    <h1> Clinica de Emagrecimento </h1>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbNome" runat="server" Text="Nome" width ="50px"/>
                </td>
                <td>
                <asp:TextBox ID="txtNome" runat="server"/>
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="lblRegistro" runat="server" Text="Registro"/>
                            </td>
                            <td>
                                <asp:TextBox ID="txtRegistro" runat="server" Width="50px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnOkBusca" runat="server" Text="Busca" OnClick="btnOkBusca_Click"/>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbCpf" runat="server" Text="CPF:" width ="50px"/>
                </td>
                <td>
                <asp:TextBox ID="txtCPF" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbDataNascimento" runat="server" Text="Data Nascimento:" width ="50px"/>
                </td>
                <td>
                <asp:TextBox ID="txtDataNascimento" runat="server"/>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lbSexo" runat="server" Text="Sexo:" width ="50px" />
                    <asp:RadioButton ID="rbMasc" runat="server" text="Masc" GroupName="gSexo" />
                    <asp:RadioButton ID="rbFem" runat="server" text="Fem" GroupName="gSexo"/>
                    <asp:RadioButton ID="rbNRA" runat="server" text="NRA" GroupName="gSexo"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbPeso" runat="server" Text="Peso:" width ="50px"/>
                </td>
                <td>
                <asp:TextBox ID="txtPeso" runat="server"/>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lbAltura" runat="server" Text="Altura:" width ="50px"/>
                </td>
                <td>
                <asp:TextBox ID="txtAltura" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btOk" runat="server" Text="Ok" Width="30%" OnClick="btOk_Click" />
                    <asp:Button ID="btLimpar" runat="server" Text="Limpar" Width="30%" onClick="btLimpar_Click" style="text-align"/>
                    <asp:Button ID="btnDeletar" runat="server" Text="Deletar" Width="30%" OnClick="btnDeletar_Click"/>
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtDiagnostico" runat="server" Width="100%" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
