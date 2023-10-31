import React from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';

import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import HomePage from "./components/HomePage"

function App() {
  return (
      <Router>
          <Routes>
              <Route path='/' element={<HomePage />} />
          </Routes>
      </Router>
  );
}

export default App;
