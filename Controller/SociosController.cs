using Model;
using Service;

namespace Controller
{
    public class SociosController
    {
        public SocioService _sociosService = new SocioService();

        public List<Socios> listarSocios()
        {
            return _sociosService.listarSocios();
        }

        public bool guardarSocio(Socios socio, int _accion)
        {
            return _sociosService.guardarSocio(socio, _accion);
        }

        public List<Localidad> CargarComboLocalidades()
        {
            return this._sociosService.CargarComboLocalidades();
        }


    }
}
