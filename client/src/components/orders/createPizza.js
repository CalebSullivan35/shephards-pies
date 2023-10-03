import { useEffect, useState } from "react";
import { Button } from "reactstrap";
import {
 getCheeses,
 getSauces,
 getSizes,
 getToppings,
} from "../../managers/optionManager";
import {
 assignTopping,
 postPizza,
 unassignTopping,
} from "../../managers/pizzaManager";
import { useParams } from "react-router-dom";

export const CreatePizzaForNewOrder = () => {
 const { id } = useParams();
 console.log(id);
 //first we need to get all the toppings,sauce,cheese,pizzasizes and store those in state.
 const [cheeseList, setCheeseList] = useState([]);
 const [toppingList, setToppingList] = useState([]);
 const [sauceList, setSauceList] = useState([]);
 const [sizeList, setSizeList] = useState([]);
 const [newPizza, setNewPizza] = useState({
  CheeseId: null,
  SauceId: null,
  PizzaSizeId: null,
  OrderId: id,
 });
 const [pizzaId, setPizzaId] = useState(null);
 const [newTopping, setNewTopping] = useState({});
 function getData() {
  getCheeses().then(setCheeseList);
  getToppings().then(setToppingList);
  getSauces().then(setSauceList);
  getSizes().then(setSizeList);
 }

 useEffect(() => {
  getData();
 }, []);

 //use effect to update newpizza order Id when the userId Is added
 useEffect(() => {
  setNewPizza((prevState) => ({ ...prevState, OrderId: id }));
 }, [id]);

 const handleCheeseChange = (event) => {
  const selectedCheeseId = parseInt(event.target.value);
  setNewPizza((prevState) => ({ ...prevState, CheeseId: selectedCheeseId }));
 };
 const handleSauceChange = (event) => {
  const selectedSauceId = parseInt(event.target.value);
  setNewPizza((prevState) => ({ ...prevState, SauceId: selectedSauceId }));
 };
 const handleSizeChange = (event) => {
  const selectedSizeId = parseInt(event.target.value);
  setNewPizza((prevState) => ({ ...prevState, PizzaSizeId: selectedSizeId }));
 };

 //handle add Toppings button. This button will post the new pizza object, and update the pizzaId with the new pizzaId from the response of the fetch.

 const handleAddToppingsButton = () => {
  postPizza(newPizza).then((res) => setPizzaId(res.id));
 };

 const handleToppingCheckbox = (e, topping) => {
  const { checked } = e.target;
  const promise = checked
   ? assignTopping(pizzaId, topping.id)
   : unassignTopping(pizzaId, topping.id);
 };

 //first create a pizza w/o toppings with submit pizza button
 // then add so it creates toppings with the selected toppings
 //display updated info in a table.

 return (
  <>
   <div>
    <h2>Create Pizzas</h2>
    <h4>Select Cheese</h4>
    <div>
     <select
      name="cheeselist"
      onChange={handleCheeseChange}
      value={newPizza.CheeseId || ""}
     >
      <option value="">Select Cheese</option>
      {cheeseList.map((c) => (
       <option key={c.id} value={c.id}>
        {c.name}
       </option>
      ))}
     </select>
    </div>
    <div>
     <h4>Select Sauce</h4>
     <div>
      <select
       name="saucelist"
       onChange={handleSauceChange}
       value={newPizza.SauceId || ""}
      >
       <option value="">Select Sauce</option>
       {sauceList.map((s) => (
        <option key={s.id} value={s.id}>
         {s.name}
        </option>
       ))}
      </select>
     </div>
    </div>
    <div>
     <h4>Select Size</h4>
     <div>
      <select
       name="sizelist"
       onChange={handleSizeChange}
       value={newPizza.PizzaSizeId || ""}
      >
       <option value="">Select Size</option>
       {sizeList.map((s) => (
        <option key={s.id} value={s.id}>
         {s.name}
        </option>
       ))}
      </select>
     </div>
     <Button
      onClick={() => {
       handleAddToppingsButton();
      }}
     >
      {" "}
      Add Toppings!
     </Button>

     {pizzaId != null ? (
      <div>
       <h4>Select Toppings</h4>
       <div className="toppingsContainer">
        {toppingList.map((topping) => (
         <div key={topping.id}>
          <input
           type="checkbox"
           onChange={(e) => {
            handleToppingCheckbox(e, topping);
           }}
          />
          <label className="toppingLabel">{topping.name}</label>
         </div>
        ))}
       </div>
       <Button
        onClick={() => {
         setPizzaId(null);
        }}
       >
        Submit Pizza!
       </Button>
      </div>
     ) : (
      ""
     )}
    </div>
   </div>
  </>
 );
};
