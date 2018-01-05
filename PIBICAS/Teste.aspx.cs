using PIBICAS.Models;
using PIBICAS.Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIBICAS
{
    public partial class Teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var al = new Aluno();
            al.AlunoUsuario = "Adryano";
            al.AlunoTipoOperacao = "Inclusão";
            al.AlunoTempo = DateTime.Now;
            al.AlunoSituacao = "Ativo";
            al.AlunoRepetir = "Não";
            al.AlunoRastro = "IP";
            al.AlunoNome = "Adryano";
            al.AlunoEscolaridade = "Superior";
            al.AlunoDataNascimento = DateTime.Parse("10/02/2017");
            al.AlunoCPF = "0495359746";
            al.AlunoCelular1 = "98987041068";

            var alDao = new AlunoDAO();
            alDao.InsertOrUpdate(al);

            //var usuDao = new UsuarioDAO();
            //var usu = usuDao.PesquisarPorEmail("escorciomax@gmail.com");
            //var o = usu.UsuarioCPF;

        }
    }
}