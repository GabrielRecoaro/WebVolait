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
    }
}