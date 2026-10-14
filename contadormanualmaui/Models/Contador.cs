using System.Collections.Specialized;
using System.ComponentModel;

namespace contadormanual.Maui.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int _conteo;
        private int _incremento;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }

        public int Incremento
        {
            get => _incremento;
            set
            {
                if (_incremento != value)
                {
                    _incremento = value;
                    OnPropertyChanged(nameof(Incremento));
                }
            }
        }
        public Contador()
        {
            Conteo = 0;
            _incremento = 1;
        }
        public void Contar()
        {
            Conteo = Conteo + _incremento;
        }

        public void Reiniciar()
        {
            Conteo = 0;
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}