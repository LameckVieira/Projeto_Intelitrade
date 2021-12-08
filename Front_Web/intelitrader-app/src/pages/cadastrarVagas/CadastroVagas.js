import { render } from '@testing-library/react';
import { Component } from 'react';
import './cadastroVagas.css';
import Menu from '../../components/menu/menu'

export default class CadastroVagas extends Component {
    constructor(props) {
        super(props);
        this.state = {
            CadastrarVagas: ''

        }

    }
    render() {
        return (
            <div>
                <main className="Quadradao1">
                    <Menu/>
                    <section className="quadradao2">
                        <div className="quadradao3">
                            <div className="topo">
                                <input className="topo1" placeholder='Pesquise por vagas na nossa empresa' />
                                <p className="topo2">
                                    Cadastro de vagas
                                </p>
                            </div>
                            <div className="vagas">
                                <form className='Vagas-form'>
                                    <div className='Vagas-form-input-container'>
                                        <label>Nome</label>
                                        <input placeholder='Informe o nome da Vaga' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Descrição</label>
                                        <input placeholder='Informe a descrição da Vaga' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Quantidade</label>
                                        <input placeholder='Informe o preço do Vagas' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Cargo</label>
                                        <select>
                                            <option disabled >Cargo da Vaga</option>
                                        </select>
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Data</label>
                                        <input placeholder='Informe da Vagas' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Tipo Vagas</label>
                                        <select>
                                            <option disabled >Tipo de Vaga</option>
                                        </select>

                                    </div>

                                    <div className="butao">
                                        <button className="butao">Cadastrar</button>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </section>
                </main >
            </div >
        );

    };
}


