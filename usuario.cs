using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisição
{
    public partial class usuario : Form
    {
      
        conexao con = new conexao();
        public usuario()
        {
            
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void NMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    int NMatriculas = Convert.ToInt32(NMatricula.Text);
                    if (con.consultaS("SELECT * FROM funcionarios WHERE id=" + NMatriculas, "nome") != null)
                    {
                        usuario us = new usuario();
                        this.Hide();
                        requisicao req = new requisicao(NMatriculas);
                        req.Show();
                    }
                    else
                    {
                        NMatricula.Text = "";
                        MessageBox.Show("Numero de Matricula INVALIDO !!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Numero de Matricula INVALIDO !!!");
                }

            }
            else
            {
                MessageBox.Show("Insira o Nº de matricula e clique em ' > '");
            }
           
        }

        private void usuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                conexao con = new conexao();
                int id = Convert.ToInt32(NMatricula.Text);
                textBox1.Text =  con.consultaS("SELECT * FROM funcionarios WHERE id=" + id, "nome");
                textBox2.Text =  con.consultaS("SELECT * FROM funcionarios WHERE id=" + id, "departamento");
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Numero de matricula não encontrado !");
                }
                

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
