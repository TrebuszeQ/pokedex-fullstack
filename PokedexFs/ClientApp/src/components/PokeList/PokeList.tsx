import React, { Component, useState } from 'react';
import { List } from "../../data/list";
import { Pokemon } from "../../pokedataft/Pokemon";
type Status =
    { status: "idle" } |
    { status: "loading" } |
    { status: "success", data: List<Pokemon> } |
    { status: "error", error: Error};

export class PokeList extends Component {
    static : string = PokeList.name;
    
    private _listCache: null | List<Pokemon>;
    constructor(props) {
        super(props);
        const [requestState, setRequestState] = useState<Status>("idle");
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
            const response: Response = await fetch('pokelist');
            const data = await response.json();
            this._listCache = data;

            const [requestState, setRequestState] = useState<Status>({ status: "success", data: data });
        }
        console.log(this._listCache);
    }
    
    PresentList()
    {
        if(this.state != "ready")
        {
        }
    }
    
    
    render() {
        return (
            <div> <h1>lol</h1> </div>
        )
    }
}
