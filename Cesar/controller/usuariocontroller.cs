using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//biblioteca para client mysql
using modelo;//conectar a class modelo 
using TestandoApp;

namespace controller
{
    public class usuariocontroller
    {
        //instanciei o onjeto conexao
        conexao con = new conexao();  
        //criando metodo de cadastrar usuario
        public bool cadastrar(usuariomodelo usuario)//passo o objeto do cadastrar como parametro
        {
            //declaro o resultado da query(consulta)
            bool resultado = false;
            string sql = "insert into usuario(nome,senha) values('" + usuario.nome + "','" + usuario.senha + "')";
            //chamndo minha conexao
            MySqlConnection sqlcon = con.GetConexao();
            sqlcon.Open();//abrindo o banco 
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o sql
                resultado = true;
            cmd.ExecuteNonQuery();//executra sql
            sqlcon.Close();//fecha a conexao
            return resultado;//retorna o valor


            return resultado;//retorno o valor
        }
    }
}
