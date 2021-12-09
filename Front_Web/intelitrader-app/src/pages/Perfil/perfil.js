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
                                <div className="dados">
                                    <p>Dados pessoais</p>
                                </div>

                            </div>
                        </div>
                    </section>
                </main>
            </div >
        );

    };
}