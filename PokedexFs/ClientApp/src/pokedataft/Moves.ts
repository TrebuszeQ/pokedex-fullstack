import { Move } from "./IMove";
import { VersionGroupDetail } from "./Versions/IVersionGroupDetail";

export interface Moves {
    move: Move
    version_group_details: VersionGroupDetail[]
}