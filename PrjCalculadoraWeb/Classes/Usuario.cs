using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrjCalculadoraWeb.Classes
{
    public class Usuario : Pessoa
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public bool Valida(String login, String senha)
        {
            return login.Equals(Login) && senha.Equals(Senha);
        }
        public Usuario(String nome, char sexo, String cpf, DateTime dataNascimento, String login, String senha): base(nome, sexo, cpf, dataNascimento)
        {
            this.Login = login;
            this.Senha = senha;
        }


    }
}