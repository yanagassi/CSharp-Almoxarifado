using Npgsql;
using System;
using System.Windows.Forms;

namespace Requisição
{
    public partial class requisicao : Form
    {
        private static int matricula;

        public requisicao(int NMatriculas)
        {
            matricula = NMatriculas;
            InitializeComponent();
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);
        }

        private void requisição_Load(object sender, EventArgs e)
        {
            conexao con = new conexao();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM estoque", con.conn());
            NpgsqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
               listBox1.Items.Add(rd["nome"]);   
            }
            con.conn().Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                label1.Text = "Nome: " + listBox1.SelectedItem.ToString();
                conexao con = new conexao();
                label2.Text = "Descrição: " + con.consultaS("SELECT * FROM estoque WHERE nome='"+ listBox1.SelectedItem.ToString()+"'", "descricao");
                label3.Text = "Quantidade disponivel: " + con.consultaS("SELECT * FROM estoque WHERE nome='" + listBox1.SelectedItem.ToString() + "'", "quantidade") + " unidades";
                textBox1.Text = "1";
            } 
        }

        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //listar();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Nome: ")
                listBox2.Items.Add(label1.Text.Substring(6) + " | Quantidade: " + textBox1.Text);
            else
                MessageBox.Show("Nenhum item selecionado !" );
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            string Valor, strLine ="";

            for (i=0; i < Convert.ToUInt32(listBox2.Items.Count.ToString());i++)
            {
                 Valor = listBox2.Items[i].ToString();
                 strLine =  Valor + ";  " +strLine;
            }
            string observacao = textBox2.Text;
            // matricula;
        }
    }
}
