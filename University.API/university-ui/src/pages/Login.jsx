import { Button, Form, Input, message } from "antd";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import api from "../services/api";


function Login() {
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate(); 
  const handleLogin = async (values) => {
    try{
      setLoading(true);
      const res = await api.post("/auth/login", values) 
      localStorage.setItem('token', res.data.result);
      navigate("/students");
    } catch (err){
      message.error("Invalid Username or password")
    }finally{
      setLoading(false);
    }
  };


  return (
    <Form
      name="login"
      onFinish={handleLogin}
      layout="vertical"
      style={{ maxWidth: 400, margin: "auto", marginTop: 100 }}
    >
      <Form.Item label="Email" name="email" rules={[{ required: true }]}>
        <Input />
      </Form.Item>
      <Form.Item label="Password" name="password" rules={[{ required: true }]}>
        <Input.Password />
      </Form.Item>
      <Form.Item>
        <Button loading={loading} type="primary" htmlType="submit" block>
          Login
        </Button>
      </Form.Item>
    </Form>
  );
}

export default Login;
