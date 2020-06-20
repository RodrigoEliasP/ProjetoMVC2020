using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVCB38.DTO
{
    public class TblClienteB38DTO
    {
        private long id_cliente, tp_usuario, cpf_cliente;
        private string nome_cliente, sobrenome_cliente, email_cliente, senha_cliente, nome_mae;

        public long _id_cliente { get => id_cliente; set => id_cliente = value; }
        public long _tp_usuario { get => tp_usuario; set => tp_usuario = value; }
        public string _email_cliente { get => email_cliente; set => email_cliente = value; }
        public string _senha_cliente { get => senha_cliente; set => senha_cliente = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }


        public string _nome_cliente {
            get {
                return nome_cliente;
            }
            set {
                if (value != string.Empty)
                {
                    nome_cliente = value;
                }
                else
                {
                    throw new Exception("Insira seu nome completo");
                }
            }
        }
        public string _cpf_cliente {
            get
            {
                return cpf_cliente.ToString();
            }
            set
            {
                if(value != string.Empty)
                {
                    try
                    {
                        cpf_cliente = Int64.Parse(value);
                    }
                    catch (FormatException)
                    {
                        throw new Exception("O campo cpf deve ser somente números");
                    }
                }
                else
                {
                    throw new Exception("Insira seu cpf");
                }
            }
        }
        public string _nome_mae
        {
            get
            {
                return nome_mae;
            }
            set
            {
                if (value != string.Empty)
                {
                    nome_mae = value;
                }
                else
                {
                    throw new Exception("Insira o nome da sua mãe");
                }
            }
        }
    }
}