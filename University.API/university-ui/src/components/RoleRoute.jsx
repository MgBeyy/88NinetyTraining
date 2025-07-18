import { Navigate } from "react-router-dom"
import { getUserInfo, isLoggedIn } from "../auth/auth"


const RoleRoute = ({allowedRoles, children}) => {
    if(!isLoggedIn()) return <Navigate to="/login" />;
    const user = getUserInfo();
    if(!user || !allowedRoles.includes(user.role)){
        return <Navigate to="/unauthorized" />
    }
    return children
}

export default RoleRoute;

