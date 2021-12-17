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
                                        <input placeholder='Título da vaga' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Descrição</label>
                                        <input placeholder='Descrição da vaga' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Quantidade</label>
                                        <input placeholder='Quantidade de vagas disponíveis' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Nível de experiência da vaga</label>
                                        <select>
                                            <option >Nível da vaga</option>
                                            <option >Pleno</option>
                                            <option >Sênior</option>
                                            <option >Júnior</option>
                                            <option >Estagiário</option>
                                        </select>
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Data</label>
                                        <input placeholder='Data de criação da vaga' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Área de atuação da vaga</label>
                                        <select>
                                            <option >Área da vaga</option>
                                            <option >C#</option>
                                            <option >.NET</option>
                                            <option >JS</option>
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


