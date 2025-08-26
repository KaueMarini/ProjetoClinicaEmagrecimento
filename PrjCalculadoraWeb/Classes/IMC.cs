using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrjCalculadoraWeb.Classes
{
    public class IMC
    {
        public float peso { get; set; }
        public float altura { get; set; }

        public IMC(float peso, float altura)
        {
            if (altura == 0)
            {
                throw new ArgumentException("Altura não pode ser zero");
            }
            this.peso = peso;
            this.altura = altura;
        }

        public string diagnostico()
        {
            float valor = imc();
            if (valor < 18.5) return "Peso Baixo";
            if (valor < 24.9) return "Peso Normal";
            if (valor < 29.9) return "Sobrepeso!";
            if (valor < 34.9) return "Obesidade (Grau I)";
            if (valor < 39.9) return "Obesidade (Grau II)";
            return "Obesidade (Grau III)";
        }
        private float imc()
        {
            return peso/ (altura * altura);
        }
    }
}