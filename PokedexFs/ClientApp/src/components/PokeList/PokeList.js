import {Component} from "react";

export class PokeList extends Component {
    static displayName = PokeList.name;

    _listCache = null;
    constructor(props) {
        super(props);
        this.state = { pokeList: [], loading: true };
    }

    async FetchList() {
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