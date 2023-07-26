using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using controller;

namespace TestandoApp
{
    public partial class FormCliente : Form
    {
        public FormCliente() //Construtor
        {
            InitializeComponent(); //Constroi tudo que tem no formulario
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome " + txtnome.Text);
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Seja bem-vindo(a)");
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            //chamo a instancia do modelo usuario
            usuariomodelo usmodelo = new usuariomodelo();
            //populo os atributos modelo
            usmodelo.nome = txtnome.Text;
            usmodelo.senha = txtsenha.Text; 
            usuariocontroller uscontroller = new usuariocontroller();
            if(uscontroller.cadastrar(usmodelo) == true)
            {
                MessageBox.Show("Usuario cadstrado" + txtnome.Text);
            }
            else
            {
                MessageBox.Show("Usuario não cadstrado");
            }
     
            //Chamando a instancia do objeto
            conexao conectar = new conexao();
            if (conectar.GetConexao() == null )
            {
                MessageBox.Show("Erro na conexão!");
            }
            else
            {
                MessageBox.Show("Teste com o BD realizado com sucesso!!!");
            }
        }
    }
}
