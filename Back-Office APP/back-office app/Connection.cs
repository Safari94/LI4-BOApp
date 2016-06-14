using System;
using System.Data.SqlClient;
using System.Windows;

namespace WpfApplication1
{
    public partial class Connection
    {
        public SqlConnection cnn;
        public Connection() {

            this.cnn = new SqlConnection();

        }
        // Returna um conexão com o sql Server
        public SqlConnection ligar()
        {
            string connetionString = null;
            
            connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Conexão Aberta ! ");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer ligação! ");
            }
            return cnn;
        }
        // Desliga a conexão com o sqlServer
        private void desligar() {
            cnn.Close();
            MessageBox.Show("Conexão Fechada ! ");
        }
    }
}
