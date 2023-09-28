import { List } from "../data/list"
import { Abilities } from "./Abillities";
import { Form } from "./IForm";
import { GameIndex } from "./IGameIndex";
import { Moves } from "./Moves";
import { HeldItem } from "./IHeldItem";
import { Species} from "./ISpecies";
import { Sprites } from "./ISprites";
import { Stat } from "./IStat";

export class Pokemon {
    
    static Abilities: List<Abilities>;
    static BaseExperience: number;
    static Forms: List<Form>;
    static GameIndices: List<GameIndex> | null;
    static Height: number;
    static HeldItems: List<HeldItem> | null;
    static Id: number ;
    static IsDefault: boolean;
    static Encounters: string | null;
    static Moves: List<Moves>;
    static Name: string;
    static Order: number;
    static PastTypes: List<object> | null;
    static Species: Species;
    static Sprites: Sprites;
    static Stats: List<Stat>;
    static Weight: number;
}