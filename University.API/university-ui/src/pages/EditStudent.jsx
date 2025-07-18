import { App, Card, Spin } from "antd";
import { useNavigate, useParams } from "react-router-dom";
import StudentForm from "../components/StudentForm";
import { useEffect, useState } from "react";
import api from "../services/api";

function EditStudent() {
  const { id } = useParams();
  const navigate = useNavigate();
  const [student, setStudent] = useState(null);
  const [loading, setLoading] = useState(true);
  const {message} = App.useApp();

  useEffect(() => {
    const fetchStudent = async () => {
      try {
        const response = await api.get(`/students/${id}`);
        setStudent(response.data.result);
      } catch (err) {
        message.error("Faild to load student");
      } finally {
        setLoading(false);
      }
    };
    fetchStudent();
  }, [id, message]);

  const onSuccess = (values) => {
    console.log(values);
    // message.success("student has been updated");
    navigate("/students");
  };

  const onCancel = () => {
    navigate("/students");
  };

  return (
    <>
      <Card title="Edit Student">
        {loading ? (
          <Spin />
        ) : student ? (
          <StudentForm mode="edit" initialValues={student} onSuccess={onSuccess} onCancel={onCancel} />
        ) : (
          <p> Student not found</p>
        )}
      </Card>
    </>
  );
}

export default EditStudent;
