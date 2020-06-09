﻿using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjetoMVCB38.DAL
{
    public class DALMVC
    {
        private string string_conexao = 
        $"Persist Security info={ConfigurationManager.AppSettings["persistenciaBD"]};" +
        $" server={ConfigurationManager.AppSettings["servidorBD"]}; database={ConfigurationManager.AppSettings["nomeBD"]};" +
        $" user={ConfigurationManager.AppSettings["usuarioBD"]};" +
        $"pwd={ConfigurationManager.AppSettings["senhaBD"]};";
        private MySqlConnection conexao;

        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }catch(MySqlException e)
            {
                throw new Exception($"erro ao conectar no banco de dados {e.Message}");
            }
        }
        public void executarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
            }
            catch (MySqlException e)
            {
                throw new Exception($"erro ao executar comando {e.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}