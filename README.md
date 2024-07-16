# WeatherApp README

### This is a simple weather application that fetches weather data from the OpenWeatherMap API and displays it on the form.

## Requirements

* .NET Framework (any version that supports C# 7.0 or higher)
* Visual Studio (or any other IDE that supports C#)
* Newtonsoft.Json library (can be installed through NuGet Package Manager)

## Building the Project

* Open the WeatherApp solution in Visual Studio.
* Restore NuGet packages (if necessary).
* Build the project (Build -> Build Solution).

## Running the Project

* Make sure you have an API key from OpenWeatherMap (https://openweathermap.org/api).
* Update the apiKey variable in the GetWeatherDataAsync method with your API key.
* Run the project (Debug -> Start Without Debugging).

## How to Use the Application

* Enter the city or location you want to see the weather for in the text box.
* Click the "Search" button.
* The application will fetch the weather data and display it on the form.
* The application will also refresh the current weather by clicking the button beside the label "Refresh Current Weather".

## Additional Notes

* The application currently only fetches weather data for the next 5 days.
* You can customize the application further by adding features such as displaying hourly forecasts, wind speed, and humidity.
