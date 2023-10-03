namespace ShephardsPies.Models;

public class Order {
  public int Id { get; set; }
  public int EmployeeRecieverId { get; set; }
  public UserProfile EmployeeReciever { get; set; }
  public int? DeliveryDriverId { get; set; }
  public UserProfile? DeliveryDriver { get; set; }
  public int TableId { get; set; }
  public DateTime TimePlaced { get; set;}
  public List<Pizza>? Pizzas { get; set; }
  public double TipAmount { get; set; }
  
  public double? TotalOrderCost {
  
  get
  {
      double totalCost = 0;
      if (Pizzas != null && Pizzas.Count > 0)
      {
      double maxPizzaPrice = Pizzas.Max(Pizza => Pizza.PizzaTotalCost);
       totalCost += maxPizzaPrice + TipAmount;
      }

      if (DeliveryDriverId != null)
      {
        //delivery surcharge
        totalCost += 5.00;
      }
      return totalCost;
  }

  }


  
}