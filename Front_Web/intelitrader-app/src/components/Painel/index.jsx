import React from 'react';
import './painel.css';

import LogoIntelitrader from '../../assets/img/logo-intelitrader.png';

export default function Painel(props) {
    return (
        <div className="bg-painel">
            <img src={LogoIntelitrader}/>
            {props.children}
        </div>
    )
}
