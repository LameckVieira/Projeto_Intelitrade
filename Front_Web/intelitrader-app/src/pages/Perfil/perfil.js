import { Component } from 'react';
import lupa from '../../components/pesquisa/img/lupa.png'
import expand from "../../pages/cadastrarVagas/img/expand_more_black_24dp 8.png"
import Menu from '../../components/menu/menu'
import './perfil.css';

export default class perfil extends Component {
    constructor(props) {
        super(props);
        this.state = {
            perfil: ''

        }

    }
    render() {
        return (
            <div>
                <main className="Quadradao1">
                    <Menu />
                    <section className="quadradao2">
                        <div className="quadradao3">
                            <div className="topo">
                                <input className="topo1" placeholder='Pesquise por vagas na nossa empresa' />
                                <p className="topo2">
                                    Meu Perfil
                                </p>
                            </div>
                            <div className="progresso">
                                <div className="progresso2">
                                    <h1 className="meuprogresso">Meu progresso</h1>
                                </div>
                                <div className="progresso2">
                                <h1 className="meuprogresso">Minhas Vagas</h1>
                                </div>
                            </div>
                            <div className="meudados">
                                <div className="dados2">
                                    <p className="dados1">Dados pessoais</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="dados3">
                                    <p className="dados1">Objetivos</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="dados4">
                                    <p className="dados1">Resumo profissional</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="dados5">
                                    <p className="dados1">Formação acadêmica e complementar</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="dados6">
                                    <p className="dados1">Idiomas</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="dados7">
                                    <p className="dados1">Histórico profissional</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="dados8">
                                    <p className="dados1">Informações complementares</p>
                                    <img src={expand}></img>
                                </div>

                            </div>
                        </div>
                    </section>
                </main>
            </div >
        );

    };
}