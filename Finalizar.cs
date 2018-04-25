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
    public partial class Finalizar : Form
    {
        private static int id;
        public Finalizar(int req)
        {
            if(req != 0)
            {
                id = req;
                InitializeComponent();
                textBox1.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;

                label1.Text = "Nº da Requisição: " + Convert.ToString(id);
                conexao con = new conexao();
                int user = Convert.ToInt32(con.consultaS("SELECT * FROM requisicoes WHERE id=" + id, "usuario"));
                textBox1.Text = con.consultaS("SELECT * FROM funcionarios WHERE id=" + user, "nome");
                textBox3.Text = Convert.ToString(user);
                textBox4.Text = con.consultaS("SELECT * FROM funcionarios WHERE id=" + user, "departamento");

            }
            else
            {
                MessageBox.Show("Erro na requisição, Tente novamente !");
                this.Hide();
                usuario user = new usuario();
                user.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Finalizar_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
