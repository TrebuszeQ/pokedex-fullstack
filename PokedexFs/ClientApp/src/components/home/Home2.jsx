import React, { Component } from "react";
// css
import "./Home.css";
import "../Globals.css"
// components
import {PokeList} from "../PokeList/PokeList";
// classes

export class Home2 extends Component {
    static displayName = Home2.name;
    static Pokelist = new PokeList();
    constructor (props) {
        super(props);
    }

    
    // from PokeList class
    render() {
        return (
            <div id="homeW" className="relativeItem l9 borderBox">
                <div id="homeB" className="purpleTheme relativeItem l8 borderBox noPadd">
                    <h3>Pokemon Data</h3>
                    <h3>Image</h3>
                    <h3>Pokemons</h3>
                </div>

                <div id="dataW" className="purpleTheme relativeItem l8 borderBox">
                    <h4></h4>
                </div>

                <div id="imageW" className="relativeItem l8 borderBox">
                </div>

                <nav id="pokeListW" className="relativeItem purpleTheme l8 borderBox">
                    {Home2.Pokelist.PresentList()}
                </nav>
            </div>
        );
    }
}