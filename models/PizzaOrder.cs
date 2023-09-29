namespace ShephardsPies.Models;

public class PizzaOrder {
  public int Id { get; set; }
  public int PizzaId { get; set; }
  public Pizza Pizza { get; set; }
  public int OrderId { get; set; }
}