import React, { Component, useState, useHistory } from 'react';
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
import axios from 'axios';

export default function Login() {

    const [email, setEmail] = useState("");
    const [senha, setSenha] = useState("");

    
    
    const efetuarLogin = (e) => {
        e.preventDefault();
        axios.post("https://localhost:5001/v1/conta/entrar", {
            email: email,
            senha: senha
        }).then((response) => {
            if (response.status === 200) {
                localStorage.setItem("token", JSON.stringify(response.data.data.token))
                console.log(localStorage.getItem("token"))
            }
        }).catch((error) => {
            console.log(error)
        })
    }

    return (
        <div className="tela-login">
            <Painel>
                <div className="quadradao"> 
                    <h1 className="titulo-painel">Login</h1>
                    <div className="alinhar-inputs">
                        <form  className="quadradao1" onSubmit={efetuarLogin}>
                            <input className="input-painel" placeholder="Email" value={email} onChange={(e) => setEmail(e.target.value)}/>
                            <input className="input-painel" type="password" placeholder="Senha" value={senha} onChange={(e) => setSenha(e.target.value)}/>
                            <button className="btn-login" type="submit"><Link to="/Perfil">Entrar</Link></button>
                        </form>
                    </div>
                    <div className="realizar-cadastro">
                        <p>Não possui conta?<Link to="/Cadastro"> Cadastre-se</Link></p>
                    </div>
                </div>
            </Painel>
        </div>
    )
}

