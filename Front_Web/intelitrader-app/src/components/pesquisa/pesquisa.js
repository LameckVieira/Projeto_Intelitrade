import { Component } from 'react';
import lupa from "../../components/pesquisa/img/lupa.png"

import './pesquisa.css';


export default class pesquisa extends Component {
    constructor(props) {
        super(props);
        this.state = {
            menu: ''

        }

    }
    render() {
        return (
            <div>
                <main>
                    <section className="pesquisa">
                        <div className="topo">
                            <div>
                            {/* <img className="pesquisaimg" src={lupa}></img> */}
                            <input className="topo1" placeholder='Pesquise por vagas na nossa empresa' />
                            </div>
                            
                            <p className="topo2">
                                Cadastro de Funcionário
                            </p>
                        </div>
                    </section>
                </main>
            </div>
        );

    };
}