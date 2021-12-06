import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Switch, Route, Routes } from 'react-router-dom';
import reportWebVitals from './reportWebVitals';

//rotas
import Login from './pages/Login/login'
import Cadastro from './pages/Cadastro/cadastro'
import VagasCandidato from './pages/VagasCandidato/candidatos';

const routing = (
  <React.StrictMode>
    <Router>
      <Routes>
        <Route path="/" component={Login} element={<Login />}/>
        <Route path="/cadastro" component={Cadastro} element={<Cadastro />}/>
        <Route path="/vagascandidatos" component={VagasCandidato} element={<VagasCandidato />}/>
      </Routes>
    </Router>
  </React.StrictMode >
)

ReactDOM.render(
  routing,
  document.getElementById('root')
);


// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
