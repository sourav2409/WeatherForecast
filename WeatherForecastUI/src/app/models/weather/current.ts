import { Condition } from "./condition"

export interface CurrentWeather {
    tempC: number
    isDay: number
    feelslikeC: number
    condition: Condition
  }