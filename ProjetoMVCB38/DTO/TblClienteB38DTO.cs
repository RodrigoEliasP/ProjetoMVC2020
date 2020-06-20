using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVCB38.DTO
{
    public class TblClienteB38DTO
    {
        private int id_cliente, tp_usuario;
        private string nome_cliente, sobrenome_cliente, email_cliente, senha_cliente, cpf_cliente, nome_mae;

        public int _id_cliente { get => id_cliente; set => id_cliente = value; }
        public int _tp_usuario { get => tp_usuario; set => tp_usuario = value; }
        public string _email_cliente { get => email_cliente; set => email_cliente = value; }
        public string _senha_cliente { get => senha_cliente; set => senha_cliente = value; }
        public string _nome_mae { get => nome_mae; set => nome_mae = value; }

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
        public string _sobrenome_cliente {
            get
            {
                return sobrenome_cliente;
            }
            set
            {
                if (value != string.Empty)
                {
                    sobrenome_cliente = value;
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
                return cpf_cliente;
            }
            set
            {
                if(value != string.Empty && value.Length == 11)
                {
                    cpf_cliente = value;
                }
                else
                {
                    throw new Exception("CPF está errado");
                }
            }
        }
    }
}