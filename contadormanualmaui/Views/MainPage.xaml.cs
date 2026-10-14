using contadormanual.Maui.Models;


namespace contadormanualmaui.Views;

public partial class MainPage : ContentPage
{
    private Contador _contador;

    public MainPage()
    {
        InitializeComponent();
        _contador = new Contador();
        BindingContext = _contador;
    }

    private void OnContarButtonClicker(object sender, EventArgs e)
    {
        _contador.Contar();
    }

    private void OnReiniciarButtonClicker(object sender, EventArgs e)
    {
        _contador.Reiniciar();
    }

}