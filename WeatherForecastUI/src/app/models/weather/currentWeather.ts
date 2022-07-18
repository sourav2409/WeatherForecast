import { CurrentWeather } from "./current"
import { WeatherLocation } from "./location"

export interface CurrentWeatherData {
    currentWeather: CurrentWeather
    weatherLocation: WeatherLocation
    success: boolean
    message: any
    valodationError: any[]
  }