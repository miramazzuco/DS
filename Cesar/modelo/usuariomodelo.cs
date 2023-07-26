using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class usuariomodelo
    {
        //atribudos no bd
        public int id_usuario;
        public string nome;
        public string senha;

        //construtor da classe modelo usuario
        public usuariomodelo() {
            nome = null;
            senha = null;

        }
    }
}
