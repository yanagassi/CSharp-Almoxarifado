using System;
using System.Windows.Forms;

namespace Requisição
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            init();
        }
        
        private static void init()
        {
            conexao conn = new conexao();
            if (conn.conecta())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new usuario());
            }
        }
    }

}
