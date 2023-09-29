namespace ShephardsPies.Models;

public class Order {
  public int Id { get; set; }
  public int EmployeeRecieverId { get; set; }
  public UserProfile EmployeeReciever { get; set; }
  public int? DeliveryDriverId { get; set; }
  public UserProfile DeliveryDriver { get; set; }
  public DateTime TimePlaced { get; set; }
  public List<PizzaOrder> PizzaOrders { get; set; }
  public double TipAmount { get; set; }
  
  //need to add calculated values for the total ordercost. 
  public double TotalOrderCost {get
  {
      double maxPizzaPrice = PizzaOrders.Max(order => order.Pizza.PizzaTotalCost);
      double totalCost = maxPizzaPrice + TipAmount;
      if (DeliveryDriverId != null)
      {
        //delivery surcharge
        totalCost += 5.00;
      }
      return totalCost;
  }
  }


  
}