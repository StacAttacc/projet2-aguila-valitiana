import React, { useState } from 'react';
import { Button, Col, Container, Form, FormGroup, Input, Label, Row } from 'reactstrap';
import FileUpload from './FileUpload';
import { JournalEntry } from '../models/media';
import http from '../service/http';
import { create } from 'domain';
import { AxiosResponse } from 'axios';
import { createLog } from '../service/mediaService';

const HomePage = () => {
    const [title, setTitle] = useState<string>("");
    const [date, setDate] = useState<Date>({} as Date);
    const [description, setDescription] = useState<string>("");

    const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        const log: JournalEntry = {
            title: title,
            date: date,
            description: description
        }
        createLog(log).then((res) => {
            console.log(res)
        })

    }
    
        
    return (
        <Container fluid className="m-2">
            <h2>Client Name</h2>

            <Form onSubmit={handleSubmit}>
                <Row>
                    <Col>
                        <FormGroup>
                            <Label for="title">Title</Label>
                            <Input type="text" id="title" value={title} onChange={(e) => setTitle(e.target.value)} />
                        </FormGroup>
                    </Col>
                    <Col>
                        <FormGroup>
                            <Label for="date">Date</Label>
                            <Input type="date" id="date" onChange={(e) => setDate(new Date(e.target.value))} placeholder="date placeholder" />
                        </FormGroup>
                    </Col>
                </Row>
                <Row>
                    <Col>
                        <FormGroup>
                            <Label for="description">Description</Label>
                            <Input type="textarea" id="description" value={description} onChange={(e) => setDescription(e.target.value)} />
                        </FormGroup>
                    </Col>
                  
                </Row>
                <Button color="primary" type="submit">Save</Button>
            </Form>
        </Container>
    );
}

export default HomePage;