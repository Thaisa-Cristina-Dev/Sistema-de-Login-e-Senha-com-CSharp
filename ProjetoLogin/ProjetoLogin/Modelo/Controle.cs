using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.verificarLogin(login, senha);
            if (LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {

            LoginDaoComandos LoginDao = new LoginDaoComandos();
            this.mensagem = LoginDao.cadastrar(email, senha, confSenha);
            if (LoginDao.tem) // a mensagem que vai vir de sucesso
            {
                this.tem = true;
            }

            return mensagem;
        }

    }
}
