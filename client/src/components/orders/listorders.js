import { useEffect, useState } from "react";
import { deleteOrder, getOrders } from "../../managers/ordermanager";
import { Button, Table } from "reactstrap";
import { useNavigate } from "react-router-dom";

export const ListOrders = () => {
 const [orders, setOrders] = useState([]);

 const navigate = useNavigate();
 function getData() {
  getOrders().then(setOrders);
 }
 useEffect(() => {
  getData();
 }, []);

 const handleDeleteOrder = (order) => {
  deleteOrder(order).then(() => {
   getData();
  });
 };

 return (
  <>
   <Button
    color="primary"
    onClick={() => {
     navigate("/orders/create");
    }}
   >
    Create Order
   </Button>
   <Table>
    <thead>
     <tr>
      <th>Order Id</th>
      <th>Date Placed</th>
      <th>Number of Pizzas</th>
      <th>Total Cost</th>
      <th></th>
      <th>Actions</th>
     </tr>
    </thead>
    <tbody>
     {orders.map((o) => (
      <tr key={o.id}>
       <td>{o.id}</td>
       <td>{o.timePlaced.split("T")[0]}</td>
       <td>{o.pizzas.length}</td>
       <td>${o.totalOrderCost}</td>
       <td></td>
       <td>
        <Button
         color="primary"
         onClick={() => {
          navigate(`/orders/${o.id}`);
         }}
        >
         Details
        </Button>
        <Button color="danger" onClick={() => handleDeleteOrder(o)}>
         Delete
        </Button>
       </td>
      </tr>
     ))}
    </tbody>
   </Table>
  </>
 );
};
