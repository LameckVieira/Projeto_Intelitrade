import { render } from '@testing-library/react';
import { Component } from 'react';
import lupa from '../../components/pesquisa/img/lupa.png'
import expand from "../../pages/cadastrarVagas/img/expand_more_black_24dp 8.png"
import Menu from '../../components/menu/menu'
import './vagasFuncionario.css';

export default class Vagas extends Component {
    constructor(props) {
        super(props);
        this.state = {
            menu: ''

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
                                    Vagas Funcionário
                                </p>
                            </div>
                            <div className="vagas">
                                <div className='Vagas-div'>
                                    <div className="quadradinhovaga">
                                        <div className="qualquercoisa">
                                            <p>Desenvolvedor C#</p>
                                            <img className="expand" src={expand}></img>
                                        </div>
                                        <div className="cargo">
                                            <p>Pleno</p>
                                        </div>
                                        <div className="descricao">
                                            <p>VAMOOOO!!</p>
                                        </div>
                                        <div className="butao12">
                                            <div className="alinha">
                                                <button className="butao123"> Editar </button>
                                                <button className="butao123"> Excluir </button>
                                                <p className="alinhap">Quantidade:</p>
                                                <p className="alinha2p">5</p>
                                            </div>
                                            <div className="final">
                                                <p>16/12/2021</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div className="quadradinhovaga">
                                        <div className="qualquercoisa">
                                            <p>Desenvolvedor .NET</p>
                                            <img className="expand" src={expand}></img>
                                        </div>
                                        <div className="cargo">
                                            <p>Sênior</p>
                                        </div>
                                        <div className="descricao">
                                            <p>Venha trabalhar aqui</p>
                                        </div>
                                        <div className="butao12">
                                            <div className="alinha">
                                                <button className="butao123"> Editar </button>
                                                <button className="butao123"> Excluir </button>
                                                <p className="alinhap">Quantidade:</p>
                                                <p className="alinha2p">5</p>
                                            </div>
                                            <div className="final">
                                                <p>17/12/2021</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </main>
            </div >
        );

    };
}