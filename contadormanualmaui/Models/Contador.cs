

namespace contadormanualmaui.Models
{
    public class Contador
    {
        public int _conteo;
        public int Conteo => _conteo;

        public Contador()
            {
            _conteo = 0;
            }
        public void Contar()
        {
            _conteo ++;
        }
        public void Reiniciar() 
        {
            _conteo = 0;
        }


    }
}
