using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using ProjetoMVCB38.DAL;
using ProjetoMVCB38.DTO;

namespace ProjetoMVCB38.BLL
{
    public class TblClienteB38Bll
    {
        private DALMVC conexao;

        public Boolean consultarBeneficio(TblClienteB38DTO user)
        {
            conexao = new DALMVC();

            string sql = $@"SELECT * FROM tbl_clienteB38 
              WHERE `nome_cliente`='{user._nome_cliente}'
              AND `cpf_cliente`='{user._cpf_cliente}'
              AND `nome_mae`='{user._nome_mae}'";

            DataTable resultado = conexao.executarConsulta(sql);

            return resultado.Rows.Count == 1;
        }
    }
}