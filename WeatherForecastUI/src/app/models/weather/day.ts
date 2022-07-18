import { Condition } from "./condition"

export interface Day {
    maxtempC: number
    maxtempF: number
    mintempC: number
    mintempF: number
    condition: Condition
  }