using Model;
using Repository;

namespace Service
{
    public class SocioService
    {
        public SociosRepository _sociosRepository = new SociosRepository();

        public List<Socios> listarSocios()
        {
            return _sociosRepository.listarSocios();
        }

        public List<Localidad> CargarComboLocalidades()
        {

            return this._sociosRepository.CargarComboLocalidades();
        }

        public bool guardarSocio(Socios socio, int _accion)
        {
            // Regla de negocio: edad mínima
            //if (alumno.FechaNacimiento > DateTime.Now.AddYears(-5))
            //  return false;

            DateTime fecha = new DateTime(2009, 10, 1); // Año, Mes, Día;
            if (fecha > DateTime.Now.AddYears(-5))
            {
                throw new Exception("El socio debe ser mayor de 18 años");
                //return false;
            }


            // Regla de negocio: Alumno suspendido
            //if (_repo.suspendido(alumno.Dni) ==1)
            //throw new Exception("El usuario esta susoendid ");
            //   return false;
            
            return _sociosRepository.updateSocio(socio, _accion);
        }
    }
}
