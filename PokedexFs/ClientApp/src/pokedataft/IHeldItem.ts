import { Item } from "./IItem";
import { VersionDetail } from "./Versions/IVersionDetail";

export interface HeldItem {
    item: Item
    version_details: VersionDetail[]
}