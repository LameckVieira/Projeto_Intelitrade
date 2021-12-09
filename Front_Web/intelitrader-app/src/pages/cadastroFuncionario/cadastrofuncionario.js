import { render } from '@testing-library/react';
import { Component } from 'react';
import './cadastroFuncionario.css';
import Menu from '../../components/menu/menu'
import Pesquisa from '../../components/pesquisa/pesquisa'

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
                            <Pesquisa/>
                            <div className="vagas">
                                <form className='Vagas-form'>
                                    <div className='Vagas-form-input-container'>
                                        <label>Nome</label>
                                        <input placeholder='Informe o nome do Funcionario' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>CPF</label>
                                        <input placeholder='Informe o CPF do Funcionario' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Senha</label>
                                        <input placeholder='Informe a senha do Funcionario' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Email</label>
                                        <input placeholder='Informe o email do Funcionario' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>Telefone</label>
                                        <input placeholder='Informe o telefone do Funcionario' />
                                    </div>
                                    <div className='Vagas-form-input-container'>
                                        <label>CodFuncionario</label>
                                        <input placeholder='Informe o Códico do Funcionario' />
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