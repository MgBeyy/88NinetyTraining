import { Layout, Menu } from "antd";
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import Login from "./pages/Login";
import Students from "./pages/Students";
import Grades from "./pages/Grades";
import AddStudent from "./pages/AddStudent";
import EditStudent from "./pages/EditStudent";
import { logout } from "./auth/auth";
import PrivateRoute from "./components/PrivateRoute";
import RoleRoute from "./components/RoleRoute";
const { Header, Content } = Layout;

function App() {
  return (
    <Router>
      <Layout>
        <Header style={{ color: "#FFF" }}>
          <Menu theme="dark" mode="horizontal" defaultSelectedKeys={["login"]}>
            <Menu.Item key="login">
              <Link to="/login">Login</Link>
            </Menu.Item>
            <Menu.Item key="students">
              <Link to="/students">Students</Link>
            </Menu.Item>
            <Menu.Item key="logout" onClick={logout}>
              Logout
            </Menu.Item>
          </Menu>
        </Header>
        <Content style={{ padding: "20px" }}>
          <Routes>
            <Route path="/login" element={<Login />} />
            <Route
              path="/students"
              element={
                <PrivateRoute>
                  <Students />
                </PrivateRoute>
              }
            />
            <Route
              path="/students/add"
              element={
                <PrivateRoute>
                  <AddStudent />
                </PrivateRoute>
              }
            />
            <Route
              path="/students/:id/edit"
              element={
                <PrivateRoute>
                  <EditStudent />
                </PrivateRoute>
              }
            />
            <Route
              path="/grades"
              element={
                <RoleRoute allowedRoles={["Teacher"]}>
                  <Grades />
                </RoleRoute>
              }
            />
            <Route path="/unauthorized" element={<div> Access Denied</div>} />
          </Routes>
        </Content>
      </Layout>
    </Router>
  );
}

export default App;
