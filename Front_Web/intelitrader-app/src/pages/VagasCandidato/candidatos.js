import { render } from '@testing-library/react';
import { Component } from 'react';
import logo from "../../assets/img/g12.png"
import perfil from "../../assets/img/account_circle_black_24dp.png"
import notificações from "../../assets/img/Vector.svg"
import curriculo from "../../assets/img/description_black_24dp 1.png"
import config from "../../assets/img/settings_black_24dp 1.png"
import ajuda from "../../assets/img/Vector.png"
import sair from "../../assets/img/Vector (1).png"
import expand from "../../assets/img/expand_more_black_24dp 8.png"
import './candidatos.css';
// import Menu from '../../components/menu'

export default function VagasCandidato(){
    return(
    <>    
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
                <div className="fundo">
                    <section className="vaga1">
                        <div className="titulovaga1">
                            <h1 className="nomevaga1">Desenvolvedor C#</h1>
                        </div>
                    </section>
                    <section className="vaga2">
                        <div className="titulovaga2">
                            <h1 className="nomevaga2">Desenvolvedor React Native</h1>
                        </div>
                    </section>
                    <section className="vaga3">
                        <div className="titulovaga3">
                        <h1 className="nomevaga3">Desenvolvedor Python</h1>
                        </div>
                    </section>
                </div>
            </main>
        </div>
    </>
    )
}
     