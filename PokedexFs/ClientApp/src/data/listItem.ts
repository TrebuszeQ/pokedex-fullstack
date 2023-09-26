import { List } from "./list";

export class ListItem<T> {
    private _list: List<T>;
    private _index: number;
    public _value: T;
    
    constructor(list: List<T>, index: number, value: T) {
        this._list = list;
        this._index = index;
        this._value = value;
    }
    
    previous(index: number) : ListItem<T> {
        return this._list.get(index - 1);
    }
    
    next(index: number): ListItem<T> {
        return this._list.get(index + 1);
    }
    
}