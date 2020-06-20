using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoMVCB38.DTO;
using ProjetoMVCB38.BLL;

namespace ProjetoMVCB38.UI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChecarBeneficio_Click(object sender, EventArgs e)
        {
            try
            {
                
                TblClienteB38DTO clientedto = new TblClienteB38DTO();
                TblClienteB38Bll clientebll = new TblClienteB38Bll();

                clientedto._nome_cliente = txtNomeB38.Text;
                clientedto._cpf_cliente = txtCpfB38.Text;
                clientedto._nome_mae = txtNomeMaeB38.Text;

                bool resultado = clientebll.consultarBeneficio(clientedto);

                if (resultado)
                {
                    lblResposta.Style.Add("color", "blue");
                    lblResposta.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                }
                else
                {
                    lblResposta.Style.Add("color", "red");
                    lblResposta.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }

            }catch(Exception ex)
            {
                lblResposta.Style.Add("color","red");
                lblResposta.Text = ex.Message;
            }
        }
    }
}