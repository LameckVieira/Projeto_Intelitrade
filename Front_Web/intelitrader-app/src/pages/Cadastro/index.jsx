import React from 'react';
import './cadastro.css';
import '../../index.css'

import Painel from '../../components/Painel'

export default function Cadastro() {
    return (
        <div className="tela-cadastro">
            <Painel>
                <h1 className="titulo-painel">Cadastro</h1>
                <div className="alinhar-inputs">
                    <form>
                        <input className="input-painel" placeholder="Nome" />
                        <input className="input-painel" placeholder="CPF" />
                        <input className="input-painel" placeholder="Telefone" />
                        <input className="input-painel" placeholder="Email" />
                        <input className="input-painel" placeholder="Senha" />
                        <button className="btn-cadastro">Cadastre-se!</button>
                    </form>
                </div>
                <div className="realizar-cadastro">
                    <p>Já possui conta?<a> Login</a></p>
                </div>
            </Painel>
        </div>
    )
}