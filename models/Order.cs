using System.ComponentModel.DataAnnotations.Schema;

namespace ShephardsPies.Models;

public class Order {
  public int Id { get; set; }
  public int EmployeeRecieverId { get; set; }
  [ForeignKey("EmployeeRecieverId")]
  public UserProfile EmployeeReciever { get; set; }
  public int? DeliveryDriverId { get; set; }
  [ForeignKey("DeliveryDriverId")]
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
      foreach(Pizza pizza in Pizzas){
          totalCost += pizza.PizzaTotalCost;
      }
      }

      if (DeliveryDriverId != null)
      {
        //delivery surcharge
        totalCost += 5.00;
      }

      totalCost += TipAmount;
      return totalCost;
  }

  }


  
}