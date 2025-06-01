using System.ComponentModel;

namespace MauiAppCadastroEvento.Models;

public class Evento : ContentView
{
 public string Nome { get; set; }
 public DateTime DataInicio { get; set; }
 public DateTime DataTermino { get; set; }
 public int Participantes { get; set; }
 public string Local { get; set; }
 public decimal Custo { get; set; }
 public int Dias
  {
  get => DataTermino.Subtract(DataInicio).Days;
  }
 public double ValorTotal
  {
  get => (double)(Participantes * Custo);
  }
}
