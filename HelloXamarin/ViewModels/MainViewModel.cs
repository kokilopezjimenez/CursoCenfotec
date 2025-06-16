using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloXamarin.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string nombre;
        private string saludo;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Saludo
        {
            get => saludo;
            set
            {
                if (saludo != value)
                {
                    saludo = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand SaludarCommand { get; }

        public MainViewModel()
        {
            SaludarCommand = new Command(Saludar);
        }

        private void Saludar()
        {
            Saludo = $"Hola, {Nombre}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
