import { Button, Form, Input, message } from "antd";
import { useEffect } from "react";
import api from "../services/api";

const StudentForm = ({
  mode = "create",
  initialValues = {},
  onSuccess,
  onCancel,
}) => {
  const [form] = Form.useForm();
  const [messageApi, contextHolder] = message.useMessage();

  useEffect(() => {
    if (mode === "edit") {
      form.setFieldValue(initialValues);
    }
  }, [mode, initialValues, form]);

  const handleSubmit = async (values) => {
    try {
      if (mode === "create") {
        await api.post("/students", values);
        messageApi.success("Student created successfully!");
      } else {
        await api.put(`/students/${initialValues.id}`, values);
        messageApi.success("Student updated successfully!");
      }
      form.resetFields();
      onSuccess();
    } catch (err) {
      messageApi.error("Operation failed. Please try again.");
    }
  };
    return (
      <>
        {contextHolder}
        <Form
          form={form}
          layout="vertical"
          onFinish={handleSubmit}
          initialValues={initialValues}
        >
          <Form.Item
            label="Name"
            name="name"
            rules={[{ required: true, message: "Please enter name" }]}
          >
            <Input placeholder="Name" />
          </Form.Item>
          <Form.Item
            label="Email"
            name="email"
            rules={[
              { required: true, message: "Please enter email" },
              { type: "email", message: "Please enter a valid email" },
            ]}
          >
            <Input placeholder="Email Address" />
          </Form.Item>
          <Form.Item>
            <Button type="primery" htmlType="submit">
              {mode === "create" ? "Create" : "Update"}
            </Button>
            <Button
              style={{ marginLeft: 8 }}
              onClick={() => {
                form.resetFields();
                if (onCancel) onCancel();
              }}
            >
              Cancel
            </Button>
          </Form.Item>
        </Form>
      </>
    );

};

export default StudentForm;
