import {Component} from "react";
    
export class PokeList extends Component {
    static displayName = PokeList.name;
    _pokeList = null;
    _pokeListRender = null;
    _listCache = null;
    state = {pokeList: null, status: "idle"}
    Status = 
        { status: "idle" } |
        { status: "loading" } |
        { status: "success" } |
        { status: "error" };
    
    constructor(props) {
        super(props);
        this.setState({ pokeList: null, status: this.Status[0] });
    }

    
    // returns list from the cache or tries to fetches it, if error throws error.
    async FetchList() {
        this.state = { pokeList: null, status: this.Status[1] };
        const listCache = this._listCache;
        if(listCache != null) {
            return listCache;
        }
        else if(listCache != null)
        {
            try 
            {
                const response = await fetch('pokelist');
                const data = await response.json();
                this._listCache = data;
                this._pokeList = data;
                this.state = { pokeList: data, status: this.Status[2]};
                this.populatePokeListRender();
            }
            catch (e)
            {
                this.setState({ pokeList: null, status: this.Status[3]});
                throw e(`During fetching of Pokemon list error occured: ${e}.`);
            }
        }
        this.state = { pokeList: null, status: this.Status[0]};
        
    }
    
    
    // populates _pokeListRender
    PopulatePokeListRender()
    {
        if(this._pokeList != null && this._pokeListRender == null)
        {
            for(let i = 0; i < this._pokeList.length; i++)
            {
                this._pokeListRender[0] =
                    <li className="l8 relativeItem borderBox noPadd noMarg">
                        <button type="button" className="noPadd noMarg Button l8 relativeItem">
                            {this._pokeList[i].Name.toUpperCase()}
                        </button>
                    </li>;
            }
        }
    }
    
    
    // returns jsx to render
    PresentList()
    {
        if(this._pokeListRender != null) return this._pokeListRender;
        else if(this._pokeList === null) return <h3>No content to list.</h3>;
        
        else if(this._pokeList != null && this._pokeListRender == null)
        {
            for(let i = 0; i < this._pokeList.length; i++) 
            {
                this._pokeListRender[0] =
                <li className="l8 relativeItem borderBox noPadd noMarg">
                    <button type="button" className="noPadd noMarg Button l8 relativeItem"> 
                        {this._pokeList[i].Name.toUpperCase()} 
                    </button>
                </li>;
            }
        }
    }
}