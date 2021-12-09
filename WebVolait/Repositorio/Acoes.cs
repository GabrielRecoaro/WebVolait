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

        public void CadastrarAtendimento(Atendimento atend)
        {
            string data_sistema = Convert.ToDateTime(atend.DataHora_Atend).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tb_atendimento values(@Cod_Atend, @Desc_Atend, @DataHora_Atend, @NomeCliente_Atend, @Cod_Func)", con.ConectarBD());
            cmd.Parameters.Add("@Cod_Atend", MySqlDbType.VarChar).Value = atend.Cod_Atend;
            cmd.Parameters.Add("@Desc_Atend", MySqlDbType.VarChar).Value = atend.Desc_Atend;
            cmd.Parameters.Add("@DataHora_Atend", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@NomeCliente_Atend", MySqlDbType.VarChar).Value = atend.NomeCliente_Atend;
            cmd.Parameters.Add("@Cod_Func", MySqlDbType.VarChar).Value = atend.Cod_Func;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Atendimento ListarCodAtendimento(int cod)
        {
            var comando = String.Format("select * from tb_atendimento where Cod_Atend = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodAtend = cmd.ExecuteReader();
            return ListarCodAtend(DadosCodAtend).FirstOrDefault();
        }

        public List<Atendimento> ListarCodAtend(MySqlDataReader dt)
        {
            var AltAl = new List<Atendimento>();
            while (dt.Read())
            {
                var AlTemp = new Atendimento()
                {
                    Cod_Atend = ushort.Parse(dt["Cod_Atend"].ToString()),
                    Desc_Atend = (dt["Desc_Atend"].ToString()),
                    DataHora_Atend = DateTime.Parse(dt["DataHora_Atend"].ToString()),
                    NomeCliente_Atend = (dt["NomeCliente_Atend"].ToString()),
                    Cod_Func = ushort.Parse(dt["Cod_Func"].ToString()),
                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Atendimento> ListarAtendimento()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tb_atendimento", con.ConectarBD());
            var DadosAtendimento = cmd.ExecuteReader();
            return ListarTodosAtendimento(DadosAtendimento);
        }

        public List<Atendimento> ListarTodosAtendimento(MySqlDataReader dt)
        {
            var TodosAtendimento = new List<Atendimento>();
            while (dt.Read())
            {
                var AtendimentoTemp = new Atendimento()
                {
                    Cod_Atend = ushort.Parse(dt["Cod_Atend"].ToString()),
                    Desc_Atend = (dt["Desc_Atend"].ToString()),
                    DataHora_Atend = DateTime.Parse(dt["DataHora_Atend"].ToString()),
                    NomeCliente_Atend = (dt["NomeCliente_Atend"].ToString()),
                    Cod_Func = ushort.Parse(dt["Cod_Func"].ToString()),

                };
                TodosAtendimento.Add(AtendimentoTemp);
            }
            dt.Close();
            return TodosAtendimento;

        }
    }
}