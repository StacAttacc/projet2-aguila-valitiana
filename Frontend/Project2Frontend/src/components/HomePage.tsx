import React from 'react';
import { Col, Container, Row } from 'reactstrap';

function HomePage() {
  return (
      <Container fluid className="m-2">
          <h2>Client Name</h2>
          <Row>
              <Col>.col</Col>
              <Col>.col</Col>
              <Col>.col</Col>
              <Col>.col</Col>
          </Row>

      </Container>
  );
}

export default HomePage;