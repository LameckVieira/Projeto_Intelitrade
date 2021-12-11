import { render } from '@testing-library/react';
import { Component } from 'react';
import './cadastroFuncionario.css';
import Menu from '../../components/menu/menu'
import Pesquisa from '../../components/pesquisa/pesquisa'

export default class CadastroFuncionario extends Component {
    constructor(props) {
        super(props);
        this.state = {
            cadastroFuncionar: ''

        }

    }
    render() {
        return (
            <div>
                <main className="Quadradao1">
                    <Menu/>
                    <section className="quadradao2">
                        <div className="quadradao3">
                            <Pesquisa/>
                            <div className="vagas">
                                <form className='Vagas-form-c'>
                                    <div className='Vagas-form-input-container'>
                                        <label>Nome</label>
                                        <input placeholder='Nome do funcionário' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>CPF</label>
                                        <input placeholder='CPF do funcionário' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Senha</label>
                                        <input placeholder='Senha do funcionário' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Email</label>
                                        <input placeholder='Email do funcionário' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Telefone</label>
                                        <input placeholder='Telefone do funcionário' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>CodFuncionário</label>
                                        <input placeholder='Código do funcionário' />
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