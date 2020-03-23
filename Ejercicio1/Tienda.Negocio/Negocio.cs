using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Datos;

public class Negocio
    {

    private RepositorioUsuarios repUsuarios;

    public Negocio()
    {
        repUsuarios= new RepositorioUsuarios();
    }
    public string ObtieneNombreUsuario(int idUser)
        {
            Usuario user = this.repUsuarios.ObtenerUser(idUser);
            return user.Nombre;
        }
        public string ObtieneApellidoUsuario(int idUser)
        {
            Usuario user = this.repUsuarios.ObtenerUser(idUser);
            return user.Apellido;
        }

        public string ObtieneNumeroUsuario(int idUser)
        {

            Usuario user = this.repUsuarios.ObtenerUser(idUser);
            return user.Numero;
        }
        public void InsertarEnRepositorio(string nombre, string apellido, string numero)
    {
        this.repUsuarios.InsertaUsuario(nombre, apellido, numero);
    
    }
        public int BuscarEnRepositorioPorNombre(string nombre)
    {
        Usuario user=this.repUsuarios.ObtenerUserPorNombre(nombre);
        return user.Id;
    }

    }

