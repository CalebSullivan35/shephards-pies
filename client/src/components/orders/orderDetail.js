import { useParams } from "react-router-dom";
import { Button, ListGroup, ListGroupItem, Table } from "reactstrap";
import { getOrderDetails } from "../../managers/ordermanager";
import { useEffect, useState } from "react";
import { deletePizza } from "../../managers/pizzaManager";

export const OrderDetails = () => {
 const [detailedOrder, setDetailedOrder] = useState({});
 const { id } = useParams();
 function getData() {
  getOrderDetails(id).then(setDetailedOrder);
  console.log(detailedOrder);
 }

 const handleDeletePizza = (pizza) => {
  deletePizza(pizza).then(() => getData());
 };

 useEffect(() => {
  getData();
 }, []);
 if (detailedOrder == null) {
  return "";
 }
 return (
  <>
   <h1> Details for Order #{id}</h1>
   <ListGroup>
    <ListGroupItem>Order Number: {detailedOrder.id}</ListGroupItem>
    <ListGroupItem>
     Date Placed: {detailedOrder.timePlaced?.split("T")[0]}
    </ListGroupItem>
    <ListGroupItem>
     Recieving Employee:{" "}
     {detailedOrder?.employeeReciever?.firstName +
      " " +
      detailedOrder?.employeeReciever?.lastName}
    </ListGroupItem>
   </ListGroup>
   <h3>Pizzas For order:</h3>
   <Table>
    <thead>
     <th>Pizza #</th>
     <th>Size</th>
     <th>Toppings</th>
     <th></th>
     <th>Sauce</th>
     <th>Cheese</th>
     <th>Actions</th>
    </thead>
    <tbody>
     {detailedOrder?.pizzas?.map((pizza) => {
      return (
       <tr key={pizza.id}>
        <td>
         <h3>{pizza.id}</h3>
        </td>
        <td>{pizza.sauce.name}</td>
        <td>
         {pizza.pizzaToppings.map((pt) => {
          return <tr>{pt.topping.name}</tr>;
         })}
        </td>

        <td></td>
        <td>{pizza.sauce.name}</td>
        <td>{pizza.cheese.name}</td>
        <td>
         <Button color="danger" onClick={() => handleDeletePizza(pizza)}>
          Delete
         </Button>
        </td>
       </tr>
      );
     })}
     <tr></tr>
    </tbody>
   </Table>
  </>
 );
};
