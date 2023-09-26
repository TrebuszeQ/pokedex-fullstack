import React, { Component } from 'react';
// components
import { Navbar } from "./navbar/Navbar";
import {Home2} from "./home/Home2";
// css
import "./Globals.css";
import "./Layout.css";


export class Layout extends Component {
    static displayName = Layout.name;
    
    render() {
        return (
            <div id="pageW" className="l10 absoluteItem">
                <Navbar></Navbar>
                <Home2></Home2>
            </div>
            
        );
    }
}