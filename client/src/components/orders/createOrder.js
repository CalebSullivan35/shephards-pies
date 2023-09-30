import { useState } from "react";

export const CreateOrder = () => {
 //first we need to get all the toppings,sauce,cheese,pizzasizes and store those in state.
 const [cheeseList, setCheeseList] = useState([]);
 const [toppingList, setToppingList] = useState([]);
 const [sauceList, setSauceList] = useState([]);
 const [sizeList, setSizeList] = useState([]);

 return (
  <>
   <h1>Create Order Page</h1>
   <div>
    <label></label>
    <input></input>
   </div>
   <button>Add Pizza</button>
  </>
 );
};
