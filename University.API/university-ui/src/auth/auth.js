import {jwtDecode} from "jwt-decode";

const TOKEN_KEY = 'token';

export const getToken = () => {
    return localStorage.getItem(TOKEN_KEY)
}


export const isLoggedIn = () => {
    const token = getToken();
    if (!token) return false;
    try {
        const decoded = jwtDecode(token);
        const now = Date.now() / 1000;
        return decoded.exp && decoded.exp > now;
    }catch (err){
        return false;
    }
};


export const logout = () => {
    return localStorage.removeItem(TOKEN_KEY);
};



export const getUserInfo = () => {
    const token = getToken();
    if (!token) return null;
    try {
        return jwtDecode(token);
    }catch (err){
        return null;
    }
};