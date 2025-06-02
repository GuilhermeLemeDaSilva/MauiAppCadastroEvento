using MauiAppCadastroEvento.Models;

namespace MauiAppCadastroEvento.Views;

public partial class CadastroEvento : ContentPage
{
 public CadastroEvento()
  {
  InitializeComponent();

  dtpck_inicio.MinimumDate = DateTime.Now;
  dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

  dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
  dtpck_termino.MaximumDate = dtpck_inicio.Date.AddDays(4);
    }

 private async void Button_Clicked(object sender, EventArgs e)
  {
        try
        {
            Evento c = new Evento
            {
                Local = local_evento.Text,
                Custo = decimal.Parse(custo_participante.Text),
                Nome = nome_evento.Text,
                Participantes = int.Parse(numero_participantes.Text),
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
            };
            await Navigation.PushAsync(new EventoCadastrado()
            {
                BindingContext = c
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
  }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtpck_termino.MaximumDate = data_selecionada_inicio.AddDays(4);
    }
}