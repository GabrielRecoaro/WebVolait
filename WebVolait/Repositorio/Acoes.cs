using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebVolait.Repositorio;
using MySql.Data.MySqlClient;
using WebVolait.Models;

namespace WebVolait.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();


        public void CadastrarFuncionario(Funcionario func)
        {

            MySqlCommand cmd = new MySqlCommand("insert into tb_funcionario values(@CPF_Func, @NomeCompleto_Func, @NomeSocial_Func, @Email_Func, @Telefone_Func, @Senha_Func)", con.ConectarBD());
            cmd.Parameters.Add("@CPF_Func", MySqlDbType.VarChar).Value = func.CPF_Func;
            cmd.Parameters.Add("@NomeCompleto_Func", MySqlDbType.VarChar).Value = func.NomeCompleto_Func;
            cmd.Parameters.Add("@NomeSocial_Func", MySqlDbType.VarChar).Value = func.NomeSocial_Func;
            cmd.Parameters.Add("@Email_Func", MySqlDbType.VarChar).Value = func.Email_Func;
            cmd.Parameters.Add("@Telefone_Func", MySqlDbType.VarChar).Value = func.Telefone_Func;
            cmd.Parameters.Add("@Senha_Func", MySqlDbType.VarChar).Value = func.Senha_Func;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Funcionario ListarCodFuncionario(int cod)
        {
            var comando = String.Format("select * from tb_funcionario where CPF_Func = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodFunc(DadosCodFunc).FirstOrDefault();
        }

        public List<Funcionario> ListarCodFunc(MySqlDataReader dt)
        {
            var AltAl = new List<Funcionario>();
            while (dt.Read())
            {
                var AlTemp = new Funcionario()
                {
                    CPF_Func = (dt["CPF_Func"].ToString()),
                    NomeCompleto_Func = (dt["NomeCompleto_Func"].ToString()),
                    NomeSocial_Func = (dt["NomeSocial_Func"].ToString()),
                    Email_Func = (dt["Email_Func"].ToString()),
                    Telefone_Func = (dt["Telefone_Func"].ToString()),
                    Senha_Func = (dt["Senha_Func"].ToString()),

                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tb_funcionario", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {

                    CPF_Func = (dt["CPF_Func"].ToString()),
                    NomeCompleto_Func = (dt["NomeCompleto_Func"].ToString()),
                    NomeSocial_Func = (dt["NomeSocial_Func"].ToString()),
                    Email_Func = (dt["Email_Func"].ToString()),
                    Telefone_Func = (dt["Telefone_Func"].ToString()),
                    Senha_Func = (dt["Senha_Func"].ToString()),

                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }
            dt.Close();
            return TodosFuncionarios;

        }
    }
}