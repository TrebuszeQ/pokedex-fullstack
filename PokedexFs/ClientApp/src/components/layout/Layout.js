import React, { Component } from 'react';
// components
import { Navbar} from "../navbar/Navbar";
import { Container } from 'reactstrap';

// css
import "../Globals.css"
import "./Layout.css";


export class Layout extends Component {
    static displayName = Layout.name;
    
    render() {
        return (
            <div id="pageW" className="l10 absoluteItem">
                <Navbar></Navbar>
                <Container tag="main">
                    {this.props.children}
                </Container>
            </div>
            
        );
    }
}