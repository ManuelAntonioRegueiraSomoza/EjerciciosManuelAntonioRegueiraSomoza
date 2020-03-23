using System;
using System.Collections.Generic;
using System.Linq;
namespace Tienda.Datos
{
    public class RepositorioUsuarios
    {
        public static List<Usuario> UDatos = new List<Usuario>
         {
              new Usuario(1, "Manuel","Regueira","627193814"),
              new Usuario(2, "Bea","Ayaso","627999999")
         };


        public Usuario ObtenerUser(int idI)
        {
            return UDatos.FirstOrDefault(usuario => usuario.Id == idI);
        }
        public void InsertaUsuario(String nombreU, String apellidoU, String numeroU)
        {
            int nextId = UDatos.Count + 1;
            Usuario userIns = new Usuario(nextId, nombreU, apellidoU, numeroU);
            UDatos.Add(userIns);
        }

        public void ModificarUsuario(int IdU, String nombreUMod, String apellidoUMod, String numeroUMod)
        {
            Usuario uMod = ObtenerUser(IdU);
            uMod.Nombre = nombreUMod;
            uMod.Apellido = apellidoUMod;
            uMod.Numero = numeroUMod;
        }
        public int idPrimerUsuario()
        {
            int idPrimero;
            Usuario uPrimero = UDatos.First();
            idPrimero = uPrimero.Id;
            return idPrimero;
        }

        public Usuario ObtenerUserPorNombre(string nameUser)
        {
            return UDatos.FirstOrDefault(usuario => usuario.Nombre == nameUser);
        }



    }

}