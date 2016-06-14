using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    
    class Query
    {

        public  Connection cs;
        public SqlConnection cnn;
        string query;

        public Query() {
           cnn=cs.ligar();
            this.query = null;
        }


        public void insertTarefas(String tarefa) {

            query = "INSERT INTO  ";
           

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

            query = "insert into Utilizador values(" + id + "," + nome + "," + dataNas + "," + dataIns + "," + posto + ")";

            SqlCommand comando = new SqlCommand(query,cnn);

            try
            {
                
                int recordsAffected = comando.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Inserção falhada!");
            }

            


        }

        public bool validaAutenticacao(String id, String pass) {

            query = "select * from Utilizador where nome=" + id;
            SqlCommand comando = new SqlCommand(query, cnn);
            try
            {

                int recordsAffected = comando.ExecuteNonQuery();

                if (recordsAffected != 0)
                {
                    MessageBox.Show("Login com Sucesso");
                    return true;
                }
                else
                {
                    MessageBox.Show("Login falhado!");
                    return false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Login falhado!");
                return false;
            }


        }

      


    


    }
    }

