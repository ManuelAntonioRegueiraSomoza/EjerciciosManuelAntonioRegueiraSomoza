using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.Datos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Numero { get; set; }

        public Usuario(int idUser, string nombreUser, string apellidoUser, string numUser)
        {
            Id = idUser;
            Nombre = nombreUser;
            Apellido = apellidoUser;
            Numero = numUser;

        }

    }
}
