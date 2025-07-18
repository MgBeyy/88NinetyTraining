import { useEffect, useState } from "react";
import api from "../services/api";
import { Row, Col, App, Table, Button, Modal } from "antd";
import StudentCard from "../components/StudentCard";
import { Link, useNavigate } from "react-router-dom";

function Students() {
  const [students, setStudents] = useState([]);
  const [loading, setLoading] = useState(true);
  const navigate = useNavigate();
  const {message} = App.useApp();
const [modal, contextHolder] = Modal.useModal();
  useEffect(() => {
    api
      .get("/students")
      .then((res) => {
        setStudents(res.data.result);
      })
      .catch((err) => {
        if (err.response?.status === 401) {
          message.error("Unauthorized, please log in first");
        } else {
          message.error("Faild to load students");
        }
      })
      .finally(() => {
        setLoading(false);
      });
  });

  const handleEdit = (student) => {
    navigate(`/students/${student.id}/edit`);
  };

  const handleDelete = (student) => {
    console.log("modal çağırıldı")
    modal.confirm({
      title: "Are you sure?",
      content: `Do you really want to delete ${student.name}?`,
      okText: "Yes",
      cancelText: "No",
      onOk: async () => {
        try {
          await api.delete(`/students/${student.id}`);
          message.success("Student deleted successfully.");
          navigate("/students");
        } catch (err) {
          message.error("Failed to delete student.");
        }
      },
    });
  };

  const columns = [
    {
      title: "ID",
      dataIndex: "id",
      key: "id",
    },
    {
      title: "NAME",
      dataIndex: "name",
      key: "name",
    },
    {
      title: "EMAIL",
      dataIndex: "email",
      key: "email",
    },
  ];

  return (
    <div>
      {contextHolder}
      <div
        style={{
          display: "flex",
          justifyContent: "space-between",
          alignItems: "center",
          marginBottom: "16px",
        }}
      >
        <h1>Students Table</h1>
        <Button type="primary" size="large">
          <Link to="add">Add Student</Link>
        </Button>
      </div>

      <hr />
      <div>
        <Row gutter={[16, 16]}>
          {students.map((student) => (
            <Col key={student.id} xs={24} sm={12} md={8} lg={6}>
              <StudentCard
                name={student.name}
                email={student.email}
                OnEdit={() => handleEdit(student)}
                OnDelete={() => handleDelete(student)}
              />
            </Col>
          ))}
        </Row>
      </div>

      <hr />
      <Table
        loading={loading}
        columns={columns}
        dataSource={students}
        rowKey="id"
        pagination={{ pageSize: 10 }}
      ></Table>
    </div>
  );
}

export default Students;
