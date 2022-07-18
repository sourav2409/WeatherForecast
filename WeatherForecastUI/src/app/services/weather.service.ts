import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HandleError, HandleErrorService } from '../handle-error.service';
import { CurrentWeatherData } from '../models/weather/currentWeather';
import { WeatherForecastData } from '../models/weather/weatherForecast';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {

  private handleError: HandleError;
  
  constructor(private http: HttpClient,
    errorHandler: HandleErrorService) {
      this.handleError = errorHandler.createHandleError('WeatherService');
     }

  getCurrentWeatherData(cityName: string): Observable<CurrentWeatherData>{
    return this.http.get<CurrentWeatherData>(environment.weatherApiBaseUrl+'currentWeather',{
      params: new HttpParams()
              .set('city', cityName)
    });
  }

  getWeatherForecastData(cityName: string, forHowManyDays: number): Observable<WeatherForecastData>{
    const options =  { params: new HttpParams()
                                  .set('city', cityName)
                                  .set('days',forHowManyDays)};

    return this.http.get<WeatherForecastData>(environment.weatherApiBaseUrl+'forecast', options)
           .pipe(
            catchError(this.handleError<WeatherForecastData>('getWeatherForecastData'))
           );
  }
}
