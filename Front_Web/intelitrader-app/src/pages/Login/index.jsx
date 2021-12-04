import React from 'react';
import {
    BrowserRouter as Router,
    Switch,
    Route,
    useParams,
    Link
  } from "react-router-dom";
import './login.css';
import '../../index.css'

import Painel from '../../components/Painel'

export default function Login() {
    return (
        <div className="tela-login">
            <Painel>
                <h1 className="titulo-painel">Login</h1>
                <div className="alinhar-inputs">
                    <form>
                        <input className="input-painel" placeholder="Email" />
                        <input className="input-painel" type="password" placeholder="Senha" />
                        <button className="btn-login">Entrar</button>
                    </form>
                </div>
                <div className="realizar-cadastro">
                    <p>Não possui conta?<Link to="/Cadastro"> Cadastre-se</Link></p>
                </div>
            </Painel>
        </div>
    )
}

