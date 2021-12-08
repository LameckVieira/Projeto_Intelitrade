import { render } from '@testing-library/react';
import { Component } from 'react';
import lupa from '../../components/pesquisa/img/lupa.png'
import expand from "../../pages/cadastrarVagas/img/expand_more_black_24dp 8.png"
import Menu from '../../components/menu/menu'
import './candidatos.css';

export default class VagasCandidato extends Component {
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
                                    Cadastro de Funcionario
                                </p>
                            </div>
                            <div className="vagas">
                                <div className='Vagas-div'>
                                    <div className="quadradinhovaga">
                                        <div className="qualquercoisa">
                                            <p>Densencolvedor C#</p>
                                            <img src={expand}></img>
                                        </div>
                                        <div className="cargo">
                                            <p>Senior</p>
                                        </div>
                                        <div className="descricao">
                                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley <br></br> Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley</p>
                                        </div>
                                        <div className="butao12">
                                            <div className="alinha">
                                                <button className="butao123">Editar</button>
                                                <button className="butao123">Excluir</button>
                                            </div>
                                                <p>Quantidade:</p>
                                            <div className="final">
                                                <p>08/12/2021</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div className="quadradinhovaga">
                                        <div className="qualquercoisa">
                                            <p>Densencolvedor C#</p>
                                            <img src={expand}></img>
                                        </div>
                                        <div className="cargo">
                                            <p>Senior</p>
                                        </div>
                                        <div className="descricao">
                                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley <br></br> Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley</p>
                                        </div>
                                        <div className="butao12">
                                            <div className="alinha">
                                                <button className="butao123">Editar</button>
                                                <button className="butao123">Excluir</button>
                                            </div>
                                                <p>Quantidade:</p>
                                            <div className="final">
                                                <p>08/12/2021</p>
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