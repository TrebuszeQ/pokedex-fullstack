import { GenerationI } from "./IGenerationI";
import { GenerationIi } from "./IGenerationIi";
import { GenerationIii } from "./IGenerationIii";
import { GenerationIv } from "./IGenerationIv";
import { GenerationV } from "./IGenerationV";
import { GenerationVi } from "../Pokemon";
import { GenerationVii } from "./IGenerationVii";
import { GenerationViii } from "./IGenerationViii";

export interface Versions {
    "generation-i": GenerationI
    "generation-ii": GenerationIi
    "generation-iii": GenerationIii
    "generation-iv": GenerationIv
    "generation-v": GenerationV
    "generation-vi": GenerationVi
    "generation-vii": GenerationVii
    "generation-viii": GenerationViii
}