using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloAuteticacao.Classes
{
    public class NivelDAO
    {

        public string Inserir(string nome)
        {
            //abrindo a conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML
            comando.CommandText = "INSERT INTO Nivel(Nome)Values(@Nome)";
            //Adcionando parâmetros contra SQL Injection
            comando.Parameters.Add(new SqlParameter("@nome", nome));
            //Esta tudo pronto! Vamos Executar o comando.
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Dados Inseridos Com sucesso!";
        }
        public string Atualizar()
        {
            return "Você atualizou";
        }
        public DataTable Pesquisar()
        {

            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML
            comando.CommandText = "select * from Nivel;";

            //DataTable (banco de dados na memória)
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable;
        }
        //sobrecarga de método - mesmo nome
        //overload
        public DataTable PesquisarPorNome(string nome)
        {
                Conexao.MinhaInstancia.Open();
                SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = ("SELECT * from Nivel where Nome=@Nome;");
                comando.Parameters.AddWithValue("@Nome", nome);
                DataTable dataTable = new DataTable();
                SqlDataReader reader = comando.ExecuteReader();
                dataTable.Load(reader);
                Conexao.MinhaInstancia.Close();

                return dataTable;

            }
        
        public string Deletar()
        {
           
            return "Você vai deletar";
        }
    
    
    
    
    }
}
