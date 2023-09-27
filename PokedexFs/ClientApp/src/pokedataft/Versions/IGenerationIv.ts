import { DiamondPearl } from "./IDiamondPearl";
import { HeartgoldSoulsilver } from "./IHeartGoldSoulsilver";
import { Platinum } from "./IPlatinum";

export interface GenerationIv {
    "diamond-pearl": DiamondPearl
    "heartgold-soulsilver": HeartgoldSoulsilver
    platinum: Platinum
}