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

        public void CadastrarCliente(Cliente cli)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tb_cliente values(@CPF_Cli, @NomeCompleto_Cli, @NomeSocial_Cli, @Email_Cli, @Telefone_Cli)", con.ConectarBD());
            cmd.Parameters.Add("@CPF_Cli", MySqlDbType.VarChar).Value = cli.CPF_Cli;
            cmd.Parameters.Add("@NomeCompleto_Cli", MySqlDbType.VarChar).Value = cli.NomeCompleto_Cli;
            cmd.Parameters.Add("@NomeSocial_Cli", MySqlDbType.VarChar).Value = cli.NomeSocial_Cli;
            cmd.Parameters.Add("@Email_Cli", MySqlDbType.VarChar).Value = cli.Email_Cli;
            cmd.Parameters.Add("@Telefone_Cli", MySqlDbType.VarChar).Value = cli.Telefone_Cli;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Cliente ListarCodCliente(int cod)
        {
            var comando = String.Format("select * from tb_cliente where CPF_Cli = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodCli = cmd.ExecuteReader();
            return ListarCodCli(DadosCodCli).FirstOrDefault();
        }

        public List<Cliente> ListarCodCli(MySqlDataReader dt)
        {
            var AltAl = new List<Cliente>();
            while (dt.Read())
            {
                var AlTemp = new Cliente()
                {
                    CPF_Cli = (dt["CPF_Cli"].ToString()),
                    NomeCompleto_Cli = (dt["NomeCompleto_Cli"].ToString()),
                    NomeSocial_Cli = (dt["NomeSocial_Cli"].ToString()),
                    Email_Cli = (dt["Email_Cli"].ToString()),
                    Telefone_Cli = (dt["Telefone_Cli"].ToString()),

                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Cliente> ListarCliente()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tb_cliente", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCliente(DadosCliente);
        }

        public List<Cliente> ListarTodosCliente(MySqlDataReader dt)
        {
            var TodosCliente = new List<Cliente>();
            while (dt.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    CPF_Cli = (dt["CPF_Cli"].ToString()),
                    NomeCompleto_Cli = (dt["NomeCompleto_Cli"].ToString()),
                    NomeSocial_Cli = (dt["NomeSocial_Cli"].ToString()),
                    Email_Cli = (dt["Email_Cli"].ToString()),
                    Telefone_Cli = (dt["Telefone_Cli"].ToString()),

                };
                TodosCliente.Add(ClienteTemp);
            }
            dt.Close();
            return TodosCliente;

        }
    }
}