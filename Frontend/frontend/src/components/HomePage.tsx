import React from 'react';
import { Col, Container, Row } from 'reactstrap';
import FileUpload from './FileUpload';

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
            <FileUpload />
        </Container>
    );
}

export default HomePage;