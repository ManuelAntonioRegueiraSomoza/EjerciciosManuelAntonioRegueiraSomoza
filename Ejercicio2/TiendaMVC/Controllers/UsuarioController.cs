using System.Web.Mvc;
using TiendaMVC.VistasModelo;

namespace TiendaMVC.Controllers
{
    public class UsuarioController : Controller
    {

       private TiendaMVC.Negocio.Negocio nego;

        public UsuarioController()
        {
            nego = new TiendaMVC.Negocio.Negocio();

        }
       

        public ActionResult Mostrar(int id)
        {    
            
            VistaModeloMostarUsuario usuarioVM = new VistaModeloMostarUsuario
            {
                Id = id,
                Nombre = nego.ObtieneNombreUsuario(id),
                Apellido = nego.ObtieneApellidoUsuario(id),
                Numero = nego.ObtieneNumeroUsuario(id)
            };
            return View(usuarioVM);
        }
        
        public ActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insertar(VistaModeloInsertarUsuario usuarioNuevo)
        {
            int idUser;
            nego.InsertarEnRepositorio(usuarioNuevo.Nombre, usuarioNuevo.Apellido, usuarioNuevo.Numero);
            idUser=nego.BuscarEnRepositorioPorNombre(usuarioNuevo.Nombre);
            
            return RedirectToAction("Mostrar", new { id = idUser});
        }

        public ActionResult Buscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Buscar(VistaModeloBuscar usuarioNuevo)
        {
            int idUser;
            idUser=nego.BuscarEnRepositorioPorNombre(usuarioNuevo.Nombre);

            return RedirectToAction("Mostrar", new { id = idUser });
        }
    }
}