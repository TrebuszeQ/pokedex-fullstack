import React, { Component } from 'react';
import { Navbar } from "./navbar/Navbar";
// css
import "./Globals.css";
import "./Layout.css";

export class Layout extends Component {
    static displayName = Layout.name;
    
    render() {
        return (
            <div id="pageW" className="l10 absoluteItem">
                <Navbar></Navbar>
            </div>
            
        );
    }
}