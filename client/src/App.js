import { useEffect, useState } from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";
import { Spinner } from "reactstrap";
import NavBar from "../Components/navbar";
import ApplicationViews from "./Components/ApplicationViews";
import { tryGetLoggedInUser } from "./managers/authmanager";

function App() {
 const [loggedInUser, setLoggedInUser] = useState();

 useEffect(() => {
  // user will be null if not authenticated
  tryGetLoggedInUser().then((user) => {
   setLoggedInUser(user);
  });
 }, []);

 // wait to get a definite logged-in state before rendering
 if (loggedInUser === undefined) {
  return <Spinner />;
 }

 return (
  <>
   <NavBar loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
   <ApplicationViews
    loggedInUser={loggedInUser}
    setLoggedInUser={setLoggedInUser}
   />
  </>
 );
}

export default App;