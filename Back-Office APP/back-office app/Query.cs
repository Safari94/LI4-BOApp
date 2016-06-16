using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows;

namespace WpfApplication1
{

    class Query
    {

        public Connection cs;
        public SqlConnection cnn;
        string query;

        public Query() {
            this.cs = new Connection();
            this.cnn=cs.ligar();
            this.query = null;
        }



        public void inserePostos(int a, String b)
        {
            query = "use LI4_f; INSERT INTO Posto (idPosto,descricao) values(" + a + "," + "'"+b+"'" + ");";

            SqlCommand comando = new SqlCommand(query, cnn);

            try
            {

                int recordsAffected = comando.ExecuteNonQuery();
                cs.desligar();
            }
            catch (SqlException z){
            
                MessageBox.Show("Inserção falhada!");
            }
        }

        public void inserePontoInteresse(int id, float latitude, float longitude, String a, String b, String c)
        {
            query = "use LI4_f; Insert into Pontos_Interesse values(" + id + "," + latitude + "," + longitude + "," +
                "'" + a + "'" + "," + "'" + b + "'" + "," + "'" + c + "'" + ");";

            SqlCommand comando = new SqlCommand(query, cnn);

            try
            {

                int recordsAffected = comando.ExecuteNonQuery();
                cs.desligar();
            }
            catch (SqlException z)
            {

                MessageBox.Show("Inserção falhada!");
            }
        }

        public void insertEstado(int id, String estado)
        {

            query = "use LI4_f; INSERT INTO Estado(idEstado,descricao) values (" + id + "," + "'" + estado + "'" + ")";

            SqlCommand comando = new SqlCommand(query, cnn);

            try
            {

                int recordsAffected = comando.ExecuteNonQuery();
                cs.desligar();
            }
            catch (SqlException)
            {

                MessageBox.Show("Inserção falhada!");
            }

        }

        public void insereMissao(int id, String relatorio,String voz, int utilizador, int estado){
            
            query = "use LI4_f; INSERT INTO Estado(idEstado,descricao) values (" + id + "," + "'" + relatorio + "'" + "," +
                "'" + voz + "'" + "," + utilizador + "," + estado +")" ;

            SqlCommand comando = new SqlCommand(query, cnn);

            try
            {

                int recordsAffected = comando.ExecuteNonQuery();
                cs.desligar();
            }
            catch (SqlException)
            {

                MessageBox.Show("Inserção falhada!");
            }
        }

        public void insereMissao(int id, int utilizador, int estado)
        {
            query = "use LI4_f; INSERT INTO Missao(idMissao,Utilizador_idUtilizador,Estado_idEstado) values (" + id + "," + utilizador + "," + estado + ")";

            SqlCommand comando = new SqlCommand(query, cnn);

            try
            {

                int recordsAffected = comando.ExecuteNonQuery();
                cs.desligar();
            }
            catch (SqlException)
            {

                MessageBox.Show("Inserção falhada!");
            }
        }

        public void insertMissaoHasTarefa(int idM, int idT, int idPI)
        {
            query = "use LI4_f; INSERT INTO Missao_has_Tarefa values (" + idM + "," + idT + "," + idPI + ")";

            SqlCommand comando = new SqlCommand(query, cnn);

            try
            {

                int recordsAffected = comando.ExecuteNonQuery();
                cs.desligar();
            }
            catch (SqlException)
            {

                MessageBox.Show("Inserção falhada!");
            }

        }

        public void insertTarefas(int id,String tarefa) {

            query = "use LI4_f; INSERT INTO Tarefa(idTarefa,descricao) values ("+ id + "," + "'" + tarefa+"'" + ")";

            SqlCommand comando = new SqlCommand(query, cnn);

            try
            {

                int recordsAffected = comando.ExecuteNonQuery();
                cs.desligar();
            }
            catch (SqlException)
            {

                MessageBox.Show("Inserção falhada!");
            }

        }

        public void showOperacionais() {

            query= "Select * From operacionais";
            
                
    using (SqlCommand myCommand = new SqlCommand(query, cnn))
            {
                
                using (SqlDataReader reader = myCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["columnName"].ToString());
                    }
                }
            }
        }

        public void insereMissao(int operacional, String nomeMissao, IList tarefas, IList pInteresse) {


        }

        public void insereUtilizador(int id, String nome, String dataNas, String dataIns, int posto) {

            query = 
                "using LI4_f; insert into Utilizador values(" + id + "," + "'" + nome + "'" + "," + "'" + dataNas +"'" +
                "," + "'"+ dataIns+ "'" + "," + posto + ")";

            SqlCommand comando = new SqlCommand(query,cnn);

            try
            {
                
                int recordsAffected = comando.ExecuteNonQuery();
                cs.desligar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Inserção falhada!");
            }
        }

        
      



    


    }
    }

