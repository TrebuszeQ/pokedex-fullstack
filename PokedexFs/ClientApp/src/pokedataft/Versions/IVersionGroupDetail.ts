import { MoveLearnMethod } from "../IMoveLearnMethod";
import { VersionGroup } from "./IVersionGroup";

export interface VersionGroupDetail {
    level_learned_at: number
    move_learn_method: MoveLearnMethod
    version_group: VersionGroup
}