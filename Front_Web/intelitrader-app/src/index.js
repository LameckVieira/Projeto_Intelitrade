import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Switch, Route, Routes } from 'react-router-dom';
import reportWebVitals from './reportWebVitals';

//rotas
import Login from './pages/Login'
// import Cadastro from './pages/Cadastro'
// import Cadastro from './pages/cadastrarVagas'
import CadastroVagas from './pages/cadastrarVagas/CadastroVagas';

const routing = (
  <React.StrictMode>
    <Router>
      <Routes>
        <Route path="/" componet={Login} element={<Login />}/>
        {/* <Route path="/Cadastro" componet={Cadastro} element={<Cadastro />}/> */}
        <Route path="/CadastroVagas" componet={CadastroVagas} element={<CadastroVagas />}/>
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
