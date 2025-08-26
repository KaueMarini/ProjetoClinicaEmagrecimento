using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrjCalculadoraWeb.Classes
{
    public class Paciente : Pessoa
    {
        public String registro { get; private set; }
        public IMC imc{ get; set; }

        private static int contador = 0;

        public String diagnostico()
        {
            return imc.diagnostico();
        }

        public void Atualiza(float peso, float altura)
        {
            imc = new IMC(peso, altura);

        }

        public float peso()
        {
            return imc.peso;
        }

        public float altura()
        {
            return imc.altura;
        }
        public Paciente(String nome, char sexo, String cpf, DateTime dataNascimento, float peso, float altura) : base(nome, sexo, cpf, dataNascimento)
        {
            imc = new IMC(peso, altura);
            registro = (++contador).ToString(); 
        }

    }
}