import { useEffect, useState } from "react";
import { Button } from "reactstrap";
import { postOrder } from "../../managers/ordermanager";
import { useNavigate } from "react-router-dom";
import { getAllUsers } from "../../managers/authmanager";

export const CreateOrder = ({ loggedInUser }) => {
 const [delivery, setDelivery] = useState(false);
 const [tableNumber, setTableNumber] = useState(null);
 const [tipAmount, setTipAmount] = useState(0);
 const [users, setUsers] = useState([]);
 const [driver, setDriver] = useState({});
 const navigate = useNavigate();

 const getUserData = async () => {
  getAllUsers().then(setUsers);
 };

 useEffect(() => {
  getUserData();
 }, []);

 const handleDeliveryChecbox = () => {
  setDelivery((prevDelivery) => !prevDelivery);
 };

 const handleTableSelect = (event) => {
  setTableNumber(parseInt(event.target.value));
 };

 const handleTip = (event) => {
  setTipAmount(parseFloat(event.target.value));
 };

 const handleDeliveryDriver = (event) => {
  setDriver(users.find((u) => u.id === parseInt(event.target.value)));
 };

 const handleSubmitButton = () => {
  //if delivery is false set the driver to be null
  let driverId = driver.id;
  if (delivery === false) {
   driverId = null;
  }
  //if delivery is true set the tableId to be null
  let tableNum = tableNumber;
  if (delivery == true) {
   tableNum = 0;
  }
  const newOrder = {
   EmployeeRecieverId: loggedInUser.id,
   DeliveryDriverId: driverId,
   TableId: tableNum,
   TipAmount: tipAmount,
  };

  postOrder(newOrder)
   .then((response) => {
    // Access the ID property of the response
    const orderId = response.id;
    console.log(`New order ID: ${orderId}`);
    navigate(`${orderId}`);
   })
   .catch((error) => {
    console.error("Error posting order:", error);
   });
 };
 return (
  <>
   <h1>Create New Order</h1>
   <div className="newOrderField">
    <div className="deliveryCheckbox">
     <input
      type="checkbox"
      checked={delivery}
      onChange={() => {
       handleDeliveryChecbox();
      }}
     ></input>
     <label> Delievery?</label>
    </div>
    <div className="tipInput">
     <input
      type="number"
      onChange={(e) => {
       handleTip(e);
      }}
     />
     <label>Tip Amount</label>
    </div>
    {delivery == false ? (
     <div>
      <select value={tableNumber} onChange={handleTableSelect}>
       <option value={0}>Select Table #</option>
       <option value={1}>1</option>
       <option value={2}>2</option>
       <option value={3}>3</option>
       <option value={4}>4</option>
       <option value={5}>5</option>
       <option value={6}>6</option>
      </select>
      <label>Select Table Number</label>
     </div>
    ) : (
     <div>
      <select
       name="driverList"
       onChange={handleDeliveryDriver}
       value={driver?.id}
      >
       <option value={0}>Select Delivery Driver</option>
       {users.map((u) => {
        return (
         <option value={u.id}>
          {u.firstName} {u.lastName}
         </option>
        );
       })}
      </select>
      <label>Select Table Number</label>
     </div>
    )}

    <Button onClick={() => handleSubmitButton()}>Go </Button>
   </div>
  </>
 );
};
