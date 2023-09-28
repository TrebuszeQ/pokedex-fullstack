import React, {Component, useState} from 'react';
import { List } from "../../data/list";
import { Pokemon } from "../../pokedataft/Pokemon";
type Status = "idle" | "loading" | "success" | "error";

export class PokeList extends Component {
    static displayName = PokeList.name;
    
    private _listCache: null | List<Pokemon>;
    constructor(props) {
        super(props);
        
        const [enabled, disabled] = useState<Status>("idle");
        // this.state = { pokeList: [], loading: true };
    }
    
    async componentDidMount(): Promise<void> {
        await this.FetchList();
    }

    private async FetchList(): Promise<List<Pokemon>> {
        if(this._listCache != null) {
            return this._listCache;
        }
        else 
        {
            const response = await fetch('pokelist');
            const data = await response.json();
            this._listCache = data;
            // this.setState({ pokeList: data, loading: false });
            
        }
        console.log(this._listCache);
    }
    
    render() {
        return (
            <div> <h1>lol</h1> </div>
        )
    }
}
