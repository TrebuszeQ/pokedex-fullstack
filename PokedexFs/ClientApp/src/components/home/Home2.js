import React, { Component } from "react";
// css
import "./Home.css";
import "../Globals.css";
export class Home2 extends Component {
    static displayName = Home2.name;
    // constructor () {
    //     super();
    // }
    
    render() {
        return (
            <div id="homeW" className="relativeItem l9 borderBox">
                <div id="homeB" className="purpleTheme relativeItem l8 borderBox">

                </div>
                
                <div id="dataW" className="purpleTheme relativeItem l8 borderBox">
                </div>
                
                <div id="imageW" className="relativeItem l8 borderBox">
                </div>
                
                <nav id="pokeMenuW" className="relativeItem purpleTheme l8 borderBox">
                </nav>
            </div>
        );
    }
}