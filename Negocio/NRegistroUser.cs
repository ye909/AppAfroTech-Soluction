using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRegistroUser
    {
      DAL.DRegistroUser dalRegistroUser = new DAL.DRegistroUser();
        public void validarUsuario(Entidade.ERegistroUser usuario)
        {
            dalRegistroUser.validarLoguin(usuario);
        }

    }
}
