import { isLoggedIn } from "../auth/auth";
import { Navigate } from "react-router-dom";

const PrivateRoute = ({ children }) => {
  return isLoggedIn() ? children : <Navigate to="/login" />;
};

export default PrivateRoute;