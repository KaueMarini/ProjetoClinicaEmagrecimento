using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrjCalculadoraWeb.Classes
{
    public class Pessoa
    {
        public int idade { get ; private set; }
        public string nome { get; private set; }
        public char sexo { get; private set; }
        public string cpf { get; private set; }
        public DateTime dataNascimento { get; private set; }

        public Pessoa(string nome, char sexo, string cpf, DateTime dataNascimento)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
        }

        public int Idade(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;
            if (dataNascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade;
        }
    }

   

}