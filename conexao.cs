using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Requisição
{

    class conexao
    {
        private string DB_NAME = "almoxarifado";
        private string DB_USER = "postgres";
        private string DB_PASS = "kjkszpj98";
        private string DB_LOCAL = "127.0.0.1";

        public Boolean conecta()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server="+ DB_LOCAL+ ";Port=5432;User Id=" + DB_USER  + ";Password=" + DB_PASS + ";Database="+ DB_NAME + ";");
                conn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não conectado, ERROR: " + e);
                return false;
            }
            
        }
        public string consultaS(string dado, string dado2)
        {
            if(conecta())
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=" + DB_LOCAL + ";Port=5432;User Id=" + DB_USER + ";Password=" + DB_PASS + ";Database=" + DB_NAME + ";");
                
                string resultado;
                try
                {
                    conn.Open();
                    int i;
                    NpgsqlCommand cmd = new NpgsqlCommand(dado, conn);
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    resultado = "";
                    while (rd.Read())
                    {
                        for (i = 0; i < rd.FieldCount; i++)
                        {
                            resultado = "" + rd[dado2];
                        }
                    }
                    conn.Close();
                    return resultado;

                }
                catch (Exception e)
                {
                    MessageBox.Show("ERRO NA CONSULTA: " + e);
                    return "";
                }
            }
            else
            {
                MessageBox.Show("Banco de dados desconectado ! ");
                return "";
            }

        }

        public NpgsqlConnection conn()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=" + DB_LOCAL + ";Port=5432;User Id=" + DB_USER + ";Password=" + DB_PASS + ";Database=" + DB_NAME + ";");
            conn.Open();
            return conn;
        }

    }

    
}
