import {List} from "../data/list";
import {Pokemon} from "./Pokemon";
import {Component} from "react";

export class PokeList extends ( List<Pokemon> && Component ){
    static displayName = PokeList.name;
    
    private _listCache: null | List<Pokemon>;
    constructor() {
        super();
        this.state = { pokeList: [], loading: true };
    }
    
    private async FetchList() {
        if(this._listCache != null) {
            return this._listCache;
        }
        else 
        {
            const response = await fetch('pokelist');
            const data = await response.json();
            this.setState({ pokeList: data, loading: false });
        }
    }
}