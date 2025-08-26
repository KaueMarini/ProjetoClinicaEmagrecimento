using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrjCalculadoraWeb.Classes;

namespace PrjCalculadoraWeb
{
    public partial class login : System.Web.UI.Page
    {
        private List<Usuario> lista = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime.TryParse("10/10/2000", out DateTime dt);
            lista.Add(new Usuario("Maria", 'F', "123.456.789/01", dt, "Maria", "12345"));
            lista.Add(new Usuario("Chico", 'M', "456.321.789/01", dt, "Chico", "33333"));
            lista.Add(new Usuario("Bento", 'M', "321.654.789/01", dt, "Bento", "55555"));
            lista.Add(new Usuario("Bianca", 'F', "333.456.789/01", dt, "Bianca", "78787"));
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            foreach(Usuario usuario in lista)
            {
                if (usuario.Valida(txtUsuario.Text, txtSenha.Text))
                {
                    Response.Redirect("index.aspx");
                    return;
                }
            }
            lblMsg.Text = "Usuario não cadastrado";
        }
    }
}