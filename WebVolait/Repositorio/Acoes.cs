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
        public void CadastrarHospedagem(Hospedagem hosp)
        {

            MySqlCommand cmd = new MySqlCommand("insert into tb_hospedagem values(@Cod_Hosp, @Nome_Hosp, @CNPJ_Hosp, @NumDiarias_Hosp, @Cod_TipoHosp)", con.ConectarBD());
            cmd.Parameters.Add("@Cod_Hosp", MySqlDbType.VarChar).Value = hosp.Cod_Hosp;
            cmd.Parameters.Add("@Nome_Hosp", MySqlDbType.VarChar).Value = hosp.Nome_Hosp;
            cmd.Parameters.Add("@CNPJ_Hosp", MySqlDbType.VarChar).Value = hosp.CNPJ_Hosp;
            cmd.Parameters.Add("@NumDiarias_Hosp", MySqlDbType.VarChar).Value = hosp.NumDiarias_Hosp;
            cmd.Parameters.Add("@Cod_TipoHosp", MySqlDbType.VarChar).Value = hosp.Cod_TipoHosp;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Hospedagem ListarCodHospedagem(int cod)
        {
            var comando = String.Format("select * from tb_hospedagem where Cod_Hosp = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodHosp = cmd.ExecuteReader();
            return ListarCodHosp(DadosCodHosp).FirstOrDefault();
        }

        public List<Hospedagem> ListarCodHosp(MySqlDataReader dt)
        {
            var AltAl = new List<Hospedagem>();
            while (dt.Read())
            {
                var AlTemp = new Hospedagem()
                {
                    Cod_Hosp = ushort.Parse(dt["Cod_Hosp"].ToString()),
                    Nome_Hosp = (dt["Nome_Hosp"].ToString()),
                    CNPJ_Hosp = (dt["CNPJ_Hosp"].ToString()),
                    NumDiarias_Hosp = ushort.Parse(dt["NumDiarias_Hosp"].ToString()),
                    Cod_TipoHosp = ushort.Parse(dt["Cod_TipoHosp"].ToString()),


                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Hospedagem> ListarHospedagem()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tb_hospedagem", con.ConectarBD());
            var DadosHospedagem = cmd.ExecuteReader();
            return ListarTodosHospedagem(DadosHospedagem);
        }

        public List<Hospedagem> ListarTodosHospedagem(MySqlDataReader dt)
        {
            //ficar atento com plural

            var TodosHospedagens = new List<Hospedagem>();
            while (dt.Read())
            {
                var HospedagemTemp = new Hospedagem()
                {
                    Cod_Hosp = ushort.Parse(dt["Cod_Hosp"].ToString()),
                    Nome_Hosp = (dt["Nome_Hosp"].ToString()),
                    CNPJ_Hosp = (dt["CNPJ_Hosp"].ToString()),
                    NumDiarias_Hosp = ushort.Parse(dt["NumDiarias_Hosp"].ToString()),
                    Cod_TipoHosp = ushort.Parse(dt["Cod_TipoHosp"].ToString()),

                };
                TodosHospedagens.Add(HospedagemTemp);
            }
            dt.Close();
            return TodosHospedagens;

        }

        public void CadastrarPacote(Pacote pac)
        {

            MySqlCommand cmd = new MySqlCommand("insert into tb_pacote values(@fCod_Pacote, @Nome_Pacote, @Desc_Pacote, @Destino_Pacote, @Valor_Pacote)", con.ConectarBD());
            cmd.Parameters.Add("@Cod_Pacote", MySqlDbType.VarChar).Value = pac.Cod_Pacote;
            cmd.Parameters.Add("@Nome_Pacote", MySqlDbType.VarChar).Value = pac.Nome_Pacote;
            cmd.Parameters.Add("@Desc_Pacote", MySqlDbType.VarChar).Value = pac.Desc_Pacote;
            cmd.Parameters.Add("@Destino_Pacote", MySqlDbType.VarChar).Value = pac.Destino_Pacote;
            cmd.Parameters.Add("@Valor_Pacote", MySqlDbType.VarChar).Value = pac.Valor_Pacote;
          
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Pacote ListarCodPacote(int cod)
        {
            var comando = String.Format("select * from vw_pacote where Cod_Pacote = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodPac = cmd.ExecuteReader();
            return ListarCodPac(DadosCodPac).FirstOrDefault();
        }

        public List<Pacote> ListarCodPac(MySqlDataReader dt)
        {
            var AltAl = new List<Pacote>();
            while (dt.Read())
            {
                var AlTemp = new Pacote()
                {
                    Cod_Pacote = ushort.Parse(dt["Cod_Pacote"].ToString()),
                    Nome_Pacote = (dt["Nome_Pacote"].ToString()),
                    Desc_Pacote = (dt["Desc_Pacote"].ToString()),
                    Destino_Pacote = (dt["Destino_Pacote"].ToString()),
                    Valor_Pacote = (dt["Valor_Pacote"].ToString()),
                   

                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Pacote> ListarPacote()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from vw_pacote", con.ConectarBD());
            var DadosPacote = cmd.ExecuteReader();
            return ListarTodosPacote(DadosPacote);
        }

        public List<Pacote> ListarTodosPacote(MySqlDataReader dt)
        {
            var TodosPacotes = new List<Pacote>();
            while (dt.Read())
            {
                var PacoteTemp = new Pacote()
                {
                    Cod_Pacote = ushort.Parse(dt["Cod_Pacote"].ToString()),
                    Nome_Pacote = (dt["Nome_Pacote"].ToString()),
                    Desc_Pacote = (dt["Desc_Pacote"].ToString()),
                    Destino_Pacote = (dt["Destino_Pacote"].ToString()),
                    Valor_Pacote = (dt["Valor_Pacote"].ToString()),
                   

                };
                TodosPacotes.Add(PacoteTemp);
            }
            dt.Close();
            return TodosPacotes;

        }

        public void CadastrarPasseio(Passeio pass)
        {

            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(@Cod_Passeio, @Empresa_Passeio, @CNPJ_Passeio, @Nome_Passeio, @Duracao_Passeio)", con.ConectarBD());
            cmd.Parameters.Add("@Cod_Passeio", MySqlDbType.VarChar).Value = pass.Cod_Passeio;
            cmd.Parameters.Add("@Empresa_Passeio", MySqlDbType.VarChar).Value = pass.Empresa_Passeio;
            cmd.Parameters.Add("@CNPJ_Passeio", MySqlDbType.VarChar).Value = pass.CNPJ_Passeio;
            cmd.Parameters.Add("@Nome_Passeio", MySqlDbType.VarChar).Value = pass.Nome_Passeio;
            cmd.Parameters.Add("@Desc_Passeio", MySqlDbType.VarChar).Value = pass.Desc_Passeio;
            cmd.Parameters.Add("@Duracao_Passeio", MySqlDbType.VarChar).Value = pass.Duracao_Passeio;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Passeio ListarCodPasseio(int cod)
        {
            var comando = String.Format("select * from tb_passeio where Cod_Passeio = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodPass = cmd.ExecuteReader();
            return ListarCodPass(DadosCodPass).FirstOrDefault();
        }

        public List<Passeio> ListarCodPass(MySqlDataReader dt)
        {
            var AltAl = new List<Passeio>();
            while (dt.Read())
            {
                var AlTemp = new Passeio()
                {
                    Cod_Passeio = ushort.Parse(dt["Cod_Passeio"].ToString()),
                    Empresa_Passeio = (dt["Empresa_Passeio"].ToString()),
                    CNPJ_Passeio = (dt["CNPJ_Passeio"].ToString()),
                    Nome_Passeio = (dt["Nome_Passeio"].ToString()),
                    Desc_Passeio = (dt["Desc_Passeio"].ToString()),
                    Duracao_Passeio = (dt["Duracao_Passeio"].ToString()),

                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Passeio> ListarPasseio()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tb_passeio", con.ConectarBD());
            var DadosPasseio = cmd.ExecuteReader();
            return ListarTodosPasseio(DadosPasseio);
        }

        public List<Passeio> ListarTodosPasseio(MySqlDataReader dt)
        {
            var TodosPasseios = new List<Passeio>();
            while (dt.Read())
            {
                var PasseioTemp = new Passeio()
                {
                    Cod_Passeio = ushort.Parse(dt["Cod_Passeio"].ToString()),
                    Empresa_Passeio = (dt["Empresa_Passeio"].ToString()),
                    CNPJ_Passeio = (dt["CNPJ_Passeio"].ToString()),
                    Nome_Passeio = (dt["Nome_Passeio"].ToString()),
                    Desc_Passeio = (dt["Desc_Passeio"].ToString()),
                    Duracao_Passeio = (dt["Duracao_Passeio"].ToString()),

                };
                TodosPasseios.Add(PasseioTemp);
            }
            dt.Close();
            return TodosPasseios;

        }

        public void CadastrarTransporte(Transporte transp)
        {

            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(@Cod_Transp, @Empresa_Transp, @CNPJ_Transp, @Duracao_Transp, @Cod_TipoTransp)", con.ConectarBD());
            cmd.Parameters.Add("@Cod_Transp", MySqlDbType.VarChar).Value = transp.Cod_Transp;
            cmd.Parameters.Add("@Empresa_Transp", MySqlDbType.VarChar).Value = transp.Empresa_Transp;
            cmd.Parameters.Add("@CNPJ_Transp", MySqlDbType.VarChar).Value = transp.CNPJ_Transp;
            cmd.Parameters.Add("@Duracao_Transp", MySqlDbType.VarChar).Value = transp.Duracao_Transp;
            cmd.Parameters.Add("@Cod_TipoTransp", MySqlDbType.VarChar).Value = transp.Cod_TipoTransp;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Transporte ListarCodTransporte(int cod)
        {
            var comando = String.Format("select * from tb_transporte where Cod_Transp = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodTransp = cmd.ExecuteReader();
            return ListarCodTransp(DadosCodTransp).FirstOrDefault();
        }

        public List<Transporte> ListarCodTransp(MySqlDataReader dt)
        {
            var AltAl = new List<Transporte>();
            while (dt.Read())
            {
                var AlTemp = new Transporte()
                {
                    Cod_Transp = ushort.Parse(dt["Cod_Transp"].ToString()),
                    Empresa_Transp = (dt["Empresa_Transp"].ToString()),
                    CNPJ_Transp = (dt["CNPJ_Transp"].ToString()),
                    Duracao_Transp = (dt["Duracao_Transp"].ToString()),
                    Cod_TipoTransp = ushort.Parse(dt["Cod_TipoTransp"].ToString()),
                    
                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Transporte> ListarTransporte()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tb_transporte", con.ConectarBD());
            var DadosTransporte = cmd.ExecuteReader();
            return ListarTodosTransporte(DadosTransporte);
        }

        public List<Transporte> ListarTodosTransporte(MySqlDataReader dt)
        {
            var TodosTransportes = new List<Transporte>();
            while (dt.Read())
            {
                var TransporteTemp = new Transporte()
                {
                    Cod_Transp = ushort.Parse(dt["Cod_Transp"].ToString()),
                    Empresa_Transp = (dt["Empresa_Transp"].ToString()),
                    CNPJ_Transp = (dt["CNPJ_Transp"].ToString()),
                    Duracao_Transp = (dt["Duracao_Transp"].ToString()),
                    Cod_TipoTransp = ushort.Parse(dt["Cod_TipoTransp"].ToString()),
                    

                };
                TodosTransportes.Add(TransporteTemp);
            }
            dt.Close();
            return TodosTransportes;

        }

        public void CadastrarVenda(Venda vend)
        {
            //ATENTO COM AS CHAR E VARCHAR
            string data_sistema = Convert.ToDateTime(vend.Data_Venda).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tb_venda values(@NotaFiscal, @Data_Venda, @CPF_Func, @CPF_Cli, @Cod_TipoPagto, @Valor_Venda)", con.ConectarBD());
            cmd.Parameters.Add("@NotaFiscal", MySqlDbType.VarChar).Value = vend.NotaFiscal;
            cmd.Parameters.Add("@Data_Venda", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@CPF_Func", MySqlDbType.VarChar).Value = vend.CPF_Func;
            cmd.Parameters.Add("@CPF_Cli", MySqlDbType.VarChar).Value = vend.CPF_Cli;
            cmd.Parameters.Add("@Cod_TipoPagto", MySqlDbType.VarChar).Value = vend.Cod_TipoPagto;
            cmd.Parameters.Add("@Valor_Venda", MySqlDbType.VarChar).Value = vend.Valor_Venda;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Venda ListarCodVenda(int cod)
        {
            var comando = String.Format("select * from vw_venda where NotaFiscal = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodVend = cmd.ExecuteReader();
            return ListarCodVend(DadosCodVend).FirstOrDefault();
        }

        public List<Venda> ListarCodVend(MySqlDataReader dt)
        {
            var AltAl = new List<Venda>();
            while (dt.Read())
            {
                var AlTemp = new Venda()
                {
                    NotaFiscal = (dt["NotaFiscal"].ToString()),
                    Data_Venda = DateTime.Parse(dt["Data_Venda"].ToString()),
                    CPF_Func = (dt["CPF_Func"].ToString()),
                    CPF_Cli = (dt["CPF_Cli"].ToString()),
                    Cod_TipoPagto = int.Parse(dt["Cod_TipoPagto"].ToString()),
                    Valor_Venda = decimal.Parse(dt["Cod_TipoPagto"].ToString()),

                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Venda> ListarVenda()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from vw_venda", con.ConectarBD());
            var DadosVenda = cmd.ExecuteReader();
            return ListarTodosVenda(DadosVenda);
        }

        public List<Venda> ListarTodosVenda(MySqlDataReader dt)
        {
            var TodosVendas = new List<Venda>();
            while (dt.Read())
            {
                var VendaTemp = new Venda()
                {
                    NotaFiscal = (dt["NotaFiscal"].ToString()),
                    Data_Venda = DateTime.Parse(dt["Data_Venda"].ToString()),
                    CPF_Func = (dt["CPF_Func"].ToString()),
                    CPF_Cli = (dt["CPF_Cli"].ToString()),
                    Cod_TipoPagto = int.Parse(dt["Cod_TipoPagto"].ToString()),
                    Valor_Venda = decimal.Parse(dt["Cod_TipoPagto"].ToString()),

                };
                TodosVendas.Add(VendaTemp);
            }
            dt.Close();
            return TodosVendas;

        }

    }
}