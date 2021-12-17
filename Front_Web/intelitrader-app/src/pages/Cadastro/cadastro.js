import React from 'react';
import {
    BrowserRouter as Router,
    Switch,
    Route,
    useParams,
    Link
  } from "react-router-dom";
import './cadastro.css';
import '../../index.css'

import Painel from '../../components/Painel'

export default function Cadastro() {
    return (
        <div className="tela-cadastro">
            <Painel>
                <h1 className="titulo-painel">Cadastro</h1>
                <div className="alinhar-inputs">
                    <form className="quadradao1">
                        <input className="input-painel" placeholder="Nome" />
                        <input className="input-painel" placeholder="CPF" />
                        <input className="input-painel" placeholder="Telefone" />
                        <input className="input-painel" placeholder="Email" />
                        <input className="input-painel" type="password" placeholder="Senha" />
                        <button className="btn-cadastro"><Link to="/">Cadastre-se</Link></button>
                    </form>
                </div>        
                <div className="realizar-cadastro">
                    <p>Já possui conta?<Link to="/">Login</Link></p>
                </div>
            </Painel>
        </div>
    )
}