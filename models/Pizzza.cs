using System.Drawing;

namespace ShephardsPies.Models;
public class Pizza {
  public int Id { get; set; }
  public int CheeseId { get; set; }
  public Cheese Cheese { get; set; }
  public int SauceId { get; set; }
  public Sauce Sauce { get; set; }
  public int PizzaSizeId { get; set; }
  public PizzaSize PizzaSize{ get; set; }
  //list of pizza toppings
  public List<PizzaTopping> PizzaToppings { get; set; }
  //add calculated property to get the cost of the pizza. Get it from all the pizzatoppings with this pizza as well as the pizza size. 
public double PizzaTotalCost {

  get {
      return (PizzaToppings.Count() * 0.50) + PizzaSize.Cost;
  }
}

 }