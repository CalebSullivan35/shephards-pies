import { Route, Routes } from "react-router-dom";

import { AuthorizedRoute } from "./auth/AuthorizedRoute";

import Register from "./auth/Register";
import Login from "./auth/Login";
import { ListOrders } from "./orders/listorders";
import { OrderDetails } from "./orders/orderDetail";
import { CreateOrder } from "./orders/createOrder";

export default function ApplicationViews({ loggedInUser, setLoggedInUser }) {
 return (
  <Routes>
   <Route path="/">
    {/* <Route
     index
     element={
      <AuthorizedRoute loggedInUser={loggedInUser}>
       <Home />
      </AuthorizedRoute>
     }
    /> */}
    {/* <Route
     path="userprofiles"
     element={
      <AuthorizedRoute loggedInUser={loggedInUser} roles={["Admin"]}>
       <UserProfileList />
      </AuthorizedRoute>
     }
    /> */}
    {/* <Route
     path="userprofiles/:id"
     element={
      <AuthorizedRoute loggedInUser={loggedInUser} roles={["Admin"]}>
       <UserProfileDetails />
      </AuthorizedRoute>
     }
    /> */}
    <Route
     path="orders"
     element={
      <AuthorizedRoute loggedInUser={loggedInUser}>
       <ListOrders />
      </AuthorizedRoute>
     }
    />
    <Route
     path="orders/create"
     element={
      <AuthorizedRoute loggedInUser={loggedInUser}>
       <CreateOrder />
      </AuthorizedRoute>
     }
    />
    <Route
     path="orders/:id"
     element={
      <AuthorizedRoute loggedInUser={loggedInUser}>
       <OrderDetails />
      </AuthorizedRoute>
     }
    />
    <Route path="login" element={<Login setLoggedInUser={setLoggedInUser} />} />
    <Route
     path="register"
     element={<Register setLoggedInUser={setLoggedInUser} />}
    />
   </Route>
   <Route path="*" element={<p>Whoops, nothing here...</p>} />
  </Routes>
 );
}
