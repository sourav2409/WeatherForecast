import { CurrentWeather } from "./current"
import { Forecast } from "./forecast"
import { WeatherLocation } from "./location"

export interface WeatherForecastData{
    forecast: Forecast
    currentWeather: CurrentWeather
    weatherLocation: WeatherLocation
    success: boolean
    message: any
    valodationError: any[]
}