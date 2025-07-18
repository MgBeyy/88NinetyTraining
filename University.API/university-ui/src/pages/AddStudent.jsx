import { Card, message } from "antd";
import { useNavigate } from "react-router-dom";
import StudentForm from "../components/StudentForm";

function AddStudent() {
  const navigate = useNavigate();
  const [messageApi, contextHolder] = message.useMessage();

  const onSuccess = (values) => {
    console.log(values);
    messageApi.success("student has been added");
    navigate("/students");
  };

  const onCancel = () => {
    navigate("/students");
  };

  return (
    <>{contextHolder}
    <Card title="Create Student">
      <StudentForm mode="create" onSuccess={onSuccess} onCancel={onCancel} />
    </Card>
    </>
  );
}

export default AddStudent;
