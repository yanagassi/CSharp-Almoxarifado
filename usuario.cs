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
        }

        private void NMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Numero de Matricula INVALIDO !!!");
                }
            }
            catch
            {
                MessageBox.Show("Numero de Matricula INVALIDO !!!");
            }
           
        }

        private void usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
