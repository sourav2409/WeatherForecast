import { Component, OnInit } from '@angular/core';
import { Forecast } from './models/weather/forecast';
import { Forecastday } from './models/weather/forecastDay';
import { WeatherForecastData } from './models/weather/weatherForecast';
import { WeatherService } from './services/weather.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
  title = 'WeatherForecastUI';
  weatherForeCastData: WeatherForecastData | undefined;
  forecasts: Forecastday[] = [];
  cityName: string = 'Chelmsford';

  constructor(private weatherService: WeatherService) {
   
  }

  ngOnInit() {
    this.getWeatherForecast(this.cityName);
    this.cityName = '';
  }

  getWeatherForecast(cityName: string): void{
    this.weatherService.getWeatherForecastData(cityName,7)
        .subscribe(
          data=>(
            this.weatherForeCastData = data, 
            this.forecasts = data.forecast.forecastday)
          );
  }

  isDay(): boolean{
    return this.weatherForeCastData?.currentWeather.isDay === 1;
  }

  getLocation() : string{
    return this.weatherForeCastData ? this.weatherForeCastData.weatherLocation.name : ''
  }

  getCurrentTemp(): number{
    return this.weatherForeCastData ? this.weatherForeCastData.currentWeather.tempC : 0;
  }

  onSubmit(): void{
    this.getWeatherForecast(this.cityName);
    this.cityName='';
  }

}
