import { Component } from 'react';
import {
    BrowserRouter as Router,
    Switch,
    Route,
    useParams,
    Link
} from "react-router-dom";
import logo from "../../pages/cadastrarVagas/img/g12.png"
import perfil from "../../assets/img/perfil.jpg"
import notificações from "../../pages/cadastrarVagas/img/Vector.svg"
import curriculo from "../../pages/cadastrarVagas/img/description_black_24dp 1.svg"
import config from "../../pages/cadastrarVagas/img/settings_black_24dp 1.png"
import ajuda from "../../pages/cadastrarVagas/img/Vector.png"
import sair from "../../pages/cadastrarVagas/img/Vector (1).png"
import expand from "../../pages/cadastrarVagas/img/expand_more_black_24dp 8.png"
import './menu.css';


export default class Menu extends Component {
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
                    <section className="menu">
                        <div className="menu1">
                            <div className="logoempresa">
                                <img className="foto_empresa" src={logo}></img>
                            </div>
                            <div className="perfil">
                                <img className="perfilimg" src={perfil}></img>
                            </div>
                            <div className="informacao">
                                <p><Link to="/Perfil">Lameck Vieira Barbosa</Link></p>
                                <p>lameck@gmail.com</p>
                            </div>
                            <div className="linkedin">
                                <div className="linke">
                                    <a className="link">Seu Linkedin</a>

                                </div>
                            </div>
                            <div className="quadradao">
                                <div className="quadradinho">
                                    <img src={notificações}></img>
                                    <p><Link to="/VagasCandidatos">Notificações</Link></p>
                                    <img src={expand}></img>
                                </div>
                                <div className="quadradinho">
                                    <img src={curriculo}></img>
                                    <p><Link to="/VagasFuncionario">Meu Currículo</Link></p>
                                    <img src={expand}></img>
                                </div>
                                <div className="quadradinho">
                                    <img src={config}></img>
                                    <p><Link to="/CadastroVagas">Configurações</Link></p>
                                    <img src={expand}></img>
                                </div>
                                <div className="quadradinho">
                                    <img src={ajuda}></img>
                                    <p><Link to="/CadastroFuncionario">Central de ajuda</Link></p>
                                    <img src={expand}></img>
                                </div>
                            </div>
                            <div className="sair">
                                <div className="sair1">
                                    <img src={sair}></img>
                                    <p><Link to="/">Sair</Link></p>
                                </div>
                            </div>
                        </div>
                    </section>
                </main>
            </div>
        );

    };
}