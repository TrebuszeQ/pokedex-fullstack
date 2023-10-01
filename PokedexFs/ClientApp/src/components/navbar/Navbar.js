import React, { Component } from 'react';
// css
import "./NavbarW.css";
import "../Globals.css";
export class Navbar extends Component {
    static displayName = Navbar.name;
    
    constructor(props) {
        super(props);
        Navbar.init();
    }
    
    static navButtons = [];
    
    static init() {
        Navbar.populateNavButtons();
    }

    static populateNavButtons() {
        const buttonClass = "Button l9 relativeItem purpleTheme";
        let navButtons2 = [];
        for (let i = 0; i < 5; i++) {
            let buttonId = `button${i}`;
            navButtons2[i] = 
                <button key={buttonId} type="button" id={buttonId} className={buttonClass}>
                    {buttonId.toUpperCase()}
                </button>;
        }
        Navbar.navButtons = Object.freeze(navButtons2);
    }

    render() {
        return (
            <nav id="navW" className="relativeItem l9">
                {Navbar.navButtons};
            </nav>
        );
    }
}
