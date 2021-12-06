import { render } from '@testing-library/react';
import { Component } from 'react';
import logo from "../../pages/cadastrarVagas/img/g12.png"
import perfil from "../../pages/cadastrarVagas/img/perfil.jfif"
import notificações from "../../pages/cadastrarVagas/img/Vector.svg"
import curriculo from "../../pages/cadastrarVagas/img/description_black_24dp 1.svg"
import config from "../../pages/cadastrarVagas/img/settings_black_24dp 1.png"
import ajuda from "../../pages/cadastrarVagas/img/Vector.png"
import sair from "../../pages/cadastrarVagas/img/Vector (1).png"
import expand from "../../pages/cadastrarVagas/img/expand_more_black_24dp 8.png"
import './cadastroFuncionario.css';
// import Menu from '../../components/menu'

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
                    <section className="menu">
                        <div className="menu1">
                            <div className="logoempresa">
                                <img className="foto_empresa" src={logo}></img>
                            </div>
                            <div className="perfil">
                                <img className="perfilimg" src={perfil}></img>
                            </div>
                            <div className="informacao">
                                <p> Lameck Vieira Barbosa</p>
                                <p>Email</p>
                            </div>
                            <div className="linkedin">
                                <div className="linke">
                                    <a className="link">Seu Linkedin</a>

                                </div>
                            </div>
                            <div className="quadradao">
                                <div className="quadradinho">
                                    <img src={notificações}></img>
                                    <p>Notificações</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="quadradinho">
                                    <img src={curriculo}></img>
                                    <p>Meu Currículo</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="quadradinho">
                                    <img src={config}></img>
                                    <p>Configurações</p>
                                    <img src={expand}></img>
                                </div>
                                <div className="quadradinho">
                                    <img src={ajuda}></img>
                                    <p>Central de ajuda</p>
                                    <img src={expand}></img>
                                </div>
                            </div>
                            <div className="sair">
                                <div className="sair1">
                                    <img src={sair}></img>
                                    <p>Sair</p>
                                </div>
                            </div>
                        </div>
                    </section>
                    <section className="quadradao2">
                        <div className="quadradao3">
                            <div className="topo">
                                <input className="topo1" placeholder='Pesquise por vagas na nossa empresa' />
                                <p className="topo2">
                                    Cadastro de Funcionario
                                </p>
                            </div>
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