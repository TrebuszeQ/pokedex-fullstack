import { ListItem } from "./listItem";

export class List<T> {
    private readonly items: Array<ListItem<T>>;
    
    constructor() {
        this.items = [];
    }
    
    size(): number {
        return this.items.length;
    }
    
    add(value: T): void {
        this.items.push(new ListItem<T>(this, this.size(), value));
    }
    
    get(index: number): ListItem<T> {
        return this.items[index];
    }
}