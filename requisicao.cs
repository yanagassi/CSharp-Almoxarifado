using Npgsql;
using System;
using System.Windows.Forms;

namespace Requisição
{
    public partial class requisicao : Form
    {
        private static int matricula;
        private static int count =0;
        private static int[] arrayItens = new int[30];
        private static int[] arrayQuants = new int[30];
        public requisicao(int NMatriculas)
        {
            matricula = NMatriculas;
            InitializeComponent();
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
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
                textBox3.Text =  listBox1.SelectedItem.ToString();
                conexao con = new conexao();
                textBox4.Text =  con.consultaS("SELECT * FROM estoque WHERE nome='"+ listBox1.SelectedItem.ToString()+"'", "descricao");
                textBox5.Text =  con.consultaS("SELECT * FROM estoque WHERE nome='" + listBox1.SelectedItem.ToString() + "'", "quantidade") + " unidades";
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
            
            conexao con = new conexao();
       
            if (textBox3.Text != "")
            {
                string retorno = con.consultaS(String.Format("SELECT * FROM estoque WHERE nome='{0}'", textBox3.Text), "id");
                listBox2.Items.Add(textBox3.Text + " | Quantidade: " + textBox1.Text);
                arrayItens[count] = Convert.ToInt32(retorno);
                arrayQuants[count] = Convert.ToInt32(textBox1.Text);
                count++;
            }

            else
            {
                MessageBox.Show("Nenhum item selecionado !");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, id;
            string recebe = "", qauntidades = "";

            for (i = 0; i < Convert.ToUInt32(listBox2.Items.Count.ToString()); i++)
            {
                recebe =  recebe + Convert.ToString(arrayItens[i]) + ";";
                qauntidades = qauntidades + Convert.ToString(arrayQuants[i]) +";" ;
            }

            string observacao = textBox2.Text;
           
            conexao con = new conexao();
            string sql = String.Format("INSERT INTO requisicoes(usuario, items, data, observacao, quantidade) values ({0},'{1}',null,'{2}','{3}')",
            Convert.ToInt32(matricula),
            Convert.ToString(recebe),
            Convert.ToString(observacao),
            Convert.ToString(qauntidades)
            );

            NpgsqlConnection conecta = con.conn();
            NpgsqlCommand cmd = new NpgsqlCommand(sql,conecta);

            cmd.ExecuteNonQuery();
            id = Convert.ToInt32(con.consultaS("SELECT * FROM requisicoes", "id"));
            Finalizar fim = new Finalizar(id);
            fim.Show();
            this.Hide();
            con.conn().Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
