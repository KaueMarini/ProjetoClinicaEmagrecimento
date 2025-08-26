using PrjCalculadoraWeb.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalculadoraWeb
{
    public partial class index : System.Web.UI.Page
    {
        private static List<Paciente> pacientes = new List<Paciente>();
        protected void Page_Load(object sender, EventArgs e)
        {
            btnDeletar.Enabled = false;
        }
        protected void btLimpar_Click(object sender, EventArgs e)
        {
            Session["paciente"] = null;

            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtDiagnostico.Text = "";

            txtNome.ReadOnly = false;
            txtCPF.ReadOnly = false;
            txtDataNascimento.ReadOnly = false;

            rbFem.Enabled = rbMasc.Enabled = rbNRA.Enabled = true;
            rbMasc.Checked = false;
            rbFem.Checked = false;
            rbNRA.Checked = false;

            btnDeletar.Enabled = false;
        }

        protected void Atualiza(float peso, float altura)
        {
            Paciente p = (Paciente)Session["paciente"];
            if (p != null)
            {
                p.Atualiza(peso, altura);
                mostra(p);
                txtDiagnostico.Text = p.diagnostico();
                return;
            }

        }

        protected void btOk_Click(object sender, EventArgs e)
        {


            char sexo = '?';
            if (rbFem.Checked) sexo = 'F';
            if (rbMasc.Checked) sexo = 'M';

            if(!DateTime.TryParse(txtDataNascimento.Text, out DateTime dataNascimento))
            {
                txtDiagnostico.Text = "Digite uma data valida";
                return;
            }

            float.TryParse(txtPeso.Text, out float peso);
            float.TryParse(txtAltura.Text, out float altura);
            Paciente p = new Paciente(txtNome.Text, sexo, txtCPF.Text, dataNascimento, peso, altura);

            if (txtNome.Text.Length <= 0 || txtCPF.Text.Length <= 0 || txtDataNascimento.Text.Length <= 0 || txtPeso.Text.Length <= 0 || 
                txtAltura.Text.Length <= 0 || (!rbMasc.Checked && !rbFem.Checked && !rbNRA.Checked))
            {
                txtDiagnostico.Text = "Por favor, preencha todos os campos.";
                return;
            }

            if(txtCPF.Text.Length > 12 || txtCPF.Text.Length < 12)
            {
                txtDiagnostico.Text = "O CPF deve contar exatos 12 caracteres, sem pontos e com barra!!";
                return ;
            }
            
            int idade = p.Idade(dataNascimento);
            if(idade < 13)
            {
                txtDiagnostico.Text = "Idade minima 13!!";
                return;
            }
            if (idade > 100)
            {
                txtDiagnostico.Text = "Idade maixma 100!!";
                return;
            }

            if(altura < 1.2 || altura > 2.1)
            {
                txtDiagnostico.Text = "A altura deve ser entre 1.2m e 2 metros!!";
                return;
            }

            if (Session["paciente"] != null)
            {
                Atualiza(peso, altura);
                return;
            }

            txtDiagnostico.Text = p.diagnostico();


            bool ok = true;
            foreach (Paciente paciente in pacientes)
            {
                if(paciente.cpf.Equals(p.cpf))
                {
                    ok = false;
                    break;
                }
            }

            if(ok)
            {
                pacientes.Add(p);
            }
            else
            {
                txtDiagnostico.Text = "Paciente ja cadastrado";
            }

        }

        private void mostra(Paciente p)
        {
            txtAltura.Text = p.altura().ToString();
            txtCPF.Text = p.cpf.ToString();
            txtDataNascimento.Text = p.dataNascimento.ToString("dd/MM/yyyy");
            txtNome.Text = p.nome.ToString();
            txtPeso.Text = p.peso().ToString();
            txtRegistro.Text = p.registro.ToString();
            txtCPF.ReadOnly = txtNome.ReadOnly = txtDataNascimento.ReadOnly = true;


            if(p.sexo == 'F') rbFem.Checked = true;
            else if(p.sexo == 'M') rbMasc.Checked = true;
            else rbNRA.Checked = true;

            rbFem.Enabled = rbMasc.Enabled = rbNRA.Enabled = false;
            
        }

        protected void btnOkBusca_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtRegistro.Text, out int resultado))
            {
                txtDiagnostico.Text = "Registro deve ser um numero";
            }


            foreach(Paciente paciente in pacientes)
            {
                if(paciente.registro.Equals(txtRegistro.Text))
                {
                    Session["paciente"] = paciente;
                    mostra(paciente);
                    btnDeletar.Enabled = true;
                    txtDiagnostico.Text = "Paciente encontrado";

                    return;
                }
            }
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtDiagnostico.Text = "";

            txtNome.ReadOnly = false;
            txtCPF.ReadOnly = false;
            txtDataNascimento.ReadOnly = false;

            rbFem.Enabled = rbMasc.Enabled = rbNRA.Enabled = true;
            rbMasc.Checked = false;
            rbFem.Checked = false;
            rbNRA.Checked = false;
            txtDiagnostico.Text = "Paciente não encontrado";
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Paciente p = (Paciente)Session["paciente"];
            if (p != null)
            {
                pacientes.RemoveAll(pac => pac.cpf == p.cpf);
                Session.Remove("paciente");

                Session["paciente"] = null;

                txtNome.Text = "";
                txtCPF.Text = "";
                txtDataNascimento.Text = "";
                txtPeso.Text = "";
                txtAltura.Text = "";
                txtDiagnostico.Text = "";

                txtNome.ReadOnly = false;
                txtCPF.ReadOnly = false;
                txtDataNascimento.ReadOnly = false;

                rbFem.Enabled = rbMasc.Enabled = rbNRA.Enabled = true;
                rbMasc.Checked = false;
                rbFem.Checked = false;
                rbNRA.Checked = false;

                txtDiagnostico.Text = "Paciente excluido";
            }
            btnDeletar.Enabled=false;
        }
    }
}