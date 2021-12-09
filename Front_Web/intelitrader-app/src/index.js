import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Switch, Route, Routes } from 'react-router-dom';
import reportWebVitals from './reportWebVitals';

//rotas
import Login from './pages/Login/login'
import Cadastro from './pages/Cadastro/cadastro'
import VagasFuncionario from './pages/VagasFuncionario/vagasFuncionario';
import Vagas from './pages/Vagas/vagas';
import CadastroVagas from './pages/cadastrarVagas/CadastroVagas';
import CadastroFuncionario from './pages/cadastroFuncionario/cadastrofuncionario';
import Perfil from './pages/Perfil/perfil';

const routing = (
  <React.StrictMode>
    <Router>
      <Routes>
        <Route path="/" component={Login} element={<Login />}/>
        <Route path="/cadastro" component={Cadastro} element={<Cadastro />}/>
        <Route path="/VagasFuncionario" component={VagasFuncionario} element={<VagasFuncionario />}/>
        <Route path="/Vagas" component={Vagas} element={<Vagas />}/>
        <Route path="/CadastroVagas" componet={CadastroVagas} element={<CadastroVagas />}/>
        <Route path="/CadastroFuncionario" componet={CadastroFuncionario} element={<CadastroFuncionario />}/>
        <Route path="/perfil" component={Perfil} element={<Perfil />}/>
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
