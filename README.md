# Sistema de Clínica de Emagrecimento (Trabalho Prático)

Este projeto é um sistema web simples para a gestão de pacientes numa clínica de emagrecimento, desenvolvido como trabalho prático para a disciplina de Sistemas Operacionais. A aplicação foi construída utilizando a plataforma ASP.NET Web Forms e a linguagem C#.

## Funcionalidades Principais

O sistema permite realizar operações básicas de gestão de pacientes, calculando o seu Índice de Massa Corporal (IMC) e fornecendo um diagnóstico.

* **Autenticação de Utilizador:** Acesso ao sistema através de uma tela de login com utilizadores e senhas pré-definidos no código.
* **Registo de Pacientes:** Permite adicionar novos pacientes ao sistema, incluindo nome, CPF, data de nascimento, sexo, peso e altura.
* **Cálculo de IMC:** Ao registar ou atualizar um paciente, o sistema calcula automaticamente o IMC e apresenta um diagnóstico.
* **Busca e Atualização:** É possível procurar por um paciente através do seu número de registo único para visualizar, atualizar o seu peso e altura ou eliminar o seu registo.
* **Validações de Dados:** O sistema inclui várias regras de negócio, como validação de idade (mínimo de 13 anos), altura e formato do CPF.

**Observação:** Os dados dos pacientes são armazenados numa lista em memória, o que significa que são perdidos sempre que a aplicação é reiniciada.

## Tecnologias Utilizadas

* **Backend:** C#
* **Framework:** ASP.NET Web Forms
* **Frontend:** HTML, CSS
* **IDE:** Microsoft Visual Studio

