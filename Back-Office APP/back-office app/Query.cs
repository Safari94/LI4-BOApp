using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    


    }
    }

