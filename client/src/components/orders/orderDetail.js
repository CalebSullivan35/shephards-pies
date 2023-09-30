import { useParams } from "react-router-dom";
import { ListGroup, ListGroupItem, Table } from "reactstrap";
import { getOrderDetails } from "../../managers/ordermanager";
import { useEffect, useState } from "react";

export const OrderDetails = () => {
 const [detailedOrder, setDetailedOrder] = useState({});
 const { id } = useParams();
 function getData() {
  getOrderDetails(id).then(setDetailedOrder);
  console.log(detailedOrder);
 }

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
       </tr>
      );
     })}
     <tr></tr>
    </tbody>
   </Table>
  </>
 );
};
