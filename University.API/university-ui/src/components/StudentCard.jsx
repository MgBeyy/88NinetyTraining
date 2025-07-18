import { Card, Typography, Button } from "antd";
const { Title, Text } = Typography;

const StudentCard = (props) => {
  return (
    <Card
      style={{ width: 300, marginBottom: 16 }}
      hoverable
      actions={[
        <Button type="primary" onClick={props.OnEdit}>
          Edit
        </Button>,
        <Button danger onClick={props.OnDelete}>
          Delete
        </Button>,
      ]}
    >
      <Title level={4}>{props.name}</Title>
      <Text type="secondary">{props.email}</Text>
    </Card>
  );
};

export default StudentCard;
